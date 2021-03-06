using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestOdev.Entity;
using Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace TestOdev
{
    public partial class Form1 : Form
    {
        private readonly TestEntities db = new TestEntities();
        decimal StokMiktar = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            //startDate ve endDate DateTime türüne çevrildi.
            DateTime startDate = DateTime.Parse("01-01-2000"), endDate = DateTime.Now;

            //Filtreleme yapmak için Başlangıç ve Bitiş tarihinin boş olup olmadığının kontrolü yapıldı. Ve textbox içine girilen veriler değişkenlere atandı.
            if (BaslangicTarihiArama.Text != "" && BitisTarihiArama.Text!="")
            {
                startDate = Convert.ToDateTime(BaslangicTarihiArama.Text);
                endDate = Convert.ToDateTime(BitisTarihiArama.Text);
            }
            //Tarih formatı veritabanına uyarlandı.
            int sDate = Convert.ToInt32((startDate).ToOADate());
            int eDate = Convert.ToInt32((endDate).ToOADate());
            int SiraNo = 1;

            //Listeye sürekli aynı verilerin eklenmesi engellendi.
            Liste.Rows.Clear();
            int satir = 0;

            //Veritabanından verilerin DataGridView'e eklenebilmesi için gerekli olan Linq sorgusu yazıldı  
            var lst = (from s in db.STI
                       where s.Birim == "ADET"
                       where s.MalKodu.Contains(MalKoduArama.Text)
                       where (s.Tarih >= sDate && s.Tarih <= eDate)
                       select new
                       {
                           id = s.ID,
                           IslemTur = s.IslemTur,
                           EvrakNo = s.EvrakNo,
                           Tarih = s.Tarih,
                           MalKodu = s.MalKodu,
                           Miktar = s.Miktar,
                           Fiyat = s.Fiyat,
                           Tutar = s.Tutar,
                           Birim = s.Birim
                       }).OrderBy(x => x.Tarih).ToList();

            //DataGridView'e veriler eklendi.
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[satir].Cells[0].Value = k.id;
                Liste.Rows[satir].Cells[1].Value = SiraNo;
                if (k.IslemTur == 0)
                {
                    Liste.Rows[satir].Cells[2].Value = "Giris";
                }
                else
                {
                    Liste.Rows[satir].Cells[2].Value = "Cikis";
                }
                Liste.Rows[satir].Cells[3].Value = k.EvrakNo;
                int iString = k.Tarih;
                Liste.Rows[satir].Cells[4].Value = DateTime.FromOADate(k.Tarih).ToString("yyyy-MM-dd");

                if (k.IslemTur == 0)
                {
                    Liste.Rows[satir].Cells[5].Value = k.Miktar;
                    Liste.Rows[satir].Cells[6].Value = 0;
                }
                else
                {
                    Liste.Rows[satir].Cells[6].Value = k.Miktar;
                    Liste.Rows[satir].Cells[5].Value = 0;
                }
                if (k.IslemTur == 0)
                {
                    StokMiktar = StokMiktar + k.Miktar;
                    Liste.Rows[satir].Cells[7].Value = StokMiktar;
                }
                else
                {
                    StokMiktar = StokMiktar - k.Miktar;
                    Liste.Rows[satir].Cells[7].Value = StokMiktar;
                }
                satir++;                
                SiraNo++;
            }
            Liste.AllowUserToAddRows = true;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.Sort(this.Liste.Columns[1], ListSortDirection.Ascending);            
        }

        //Listeleme fonksiyonunu çağırdım.
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        //Verileri Excel tablosuna aktarmak için bütün verileri seçme işlemi yapıyor.
        private void copyAlltoClipboard()
        {
            Liste.SelectAll();
            DataObject dataObj = Liste.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        //Verileri Excel tablosuna aktarıyor.
        private void BtnListToExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Range CR = (Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        //Verileri pdf dosyasına çeviriyor().
        private void BtnListToPdf_Click(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = false;            
            PdfPTable pdfTable = new PdfPTable(Liste.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Pdf'e sütun ekliyor.
            foreach (DataGridViewColumn column in Liste.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Pdf'e satır ekliyor.
            foreach (DataGridViewRow row in Liste.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    try
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                    catch { }
                }
            }

            //Oluşturulan Pdf dosyasını C'nin içinde 'PDFs' klasörünün içine kaydeder.
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "DataGridViewExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}
