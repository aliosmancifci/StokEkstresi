namespace TestOdev
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvrakNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CikisMiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslangicTarihiArama = new System.Windows.Forms.TextBox();
            this.BitisTarihiArama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnListToExcel = new System.Windows.Forms.Button();
            this.BtnListToPdf = new System.Windows.Forms.Button();
            this.MalKoduArama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SiraNo,
            this.IslemTur,
            this.EvrakNo,
            this.Tarih,
            this.GirisMiktar,
            this.CikisMiktar,
            this.Miktar});
            this.Liste.Location = new System.Drawing.Point(3, 138);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(809, 324);
            this.Liste.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // SiraNo
            // 
            this.SiraNo.HeaderText = "SiraNo";
            this.SiraNo.Name = "SiraNo";
            // 
            // IslemTur
            // 
            this.IslemTur.HeaderText = "IslemTur";
            this.IslemTur.Name = "IslemTur";
            // 
            // EvrakNo
            // 
            this.EvrakNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EvrakNo.HeaderText = "EvrakNo";
            this.EvrakNo.Name = "EvrakNo";
            // 
            // Tarih
            // 
            dataGridViewCellStyle3.Format = "d";
            this.Tarih.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GirisMiktar
            // 
            this.GirisMiktar.HeaderText = "GirisMiktar";
            this.GirisMiktar.Name = "GirisMiktar";
            // 
            // CikisMiktar
            // 
            this.CikisMiktar.HeaderText = "CikisMiktar";
            this.CikisMiktar.Name = "CikisMiktar";
            // 
            // Miktar
            // 
            this.Miktar.HeaderText = "StokMiktar";
            this.Miktar.Name = "Miktar";
            // 
            // BaslangicTarihiArama
            // 
            this.BaslangicTarihiArama.Location = new System.Drawing.Point(141, 44);
            this.BaslangicTarihiArama.Name = "BaslangicTarihiArama";
            this.BaslangicTarihiArama.Size = new System.Drawing.Size(100, 20);
            this.BaslangicTarihiArama.TabIndex = 2;
            // 
            // BitisTarihiArama
            // 
            this.BitisTarihiArama.Location = new System.Drawing.Point(271, 44);
            this.BitisTarihiArama.Name = "BitisTarihiArama";
            this.BitisTarihiArama.Size = new System.Drawing.Size(100, 20);
            this.BitisTarihiArama.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mal Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnListToExcel
            // 
            this.BtnListToExcel.Location = new System.Drawing.Point(141, 89);
            this.BtnListToExcel.Name = "BtnListToExcel";
            this.BtnListToExcel.Size = new System.Drawing.Size(100, 23);
            this.BtnListToExcel.TabIndex = 5;
            this.BtnListToExcel.Text = "Excel e Gonder";
            this.BtnListToExcel.UseVisualStyleBackColor = true;
            this.BtnListToExcel.Click += new System.EventHandler(this.BtnListToExcel_Click);
            // 
            // BtnListToPdf
            // 
            this.BtnListToPdf.Location = new System.Drawing.Point(271, 89);
            this.BtnListToPdf.Name = "BtnListToPdf";
            this.BtnListToPdf.Size = new System.Drawing.Size(100, 23);
            this.BtnListToPdf.TabIndex = 6;
            this.BtnListToPdf.Text = "Pdf e Gonder";
            this.BtnListToPdf.UseVisualStyleBackColor = true;
            this.BtnListToPdf.Click += new System.EventHandler(this.BtnListToPdf_Click);
            // 
            // MalKoduArama
            // 
            this.MalKoduArama.Location = new System.Drawing.Point(12, 44);
            this.MalKoduArama.Name = "MalKoduArama";
            this.MalKoduArama.Size = new System.Drawing.Size(100, 20);
            this.MalKoduArama.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 459);
            this.Controls.Add(this.BtnListToPdf);
            this.Controls.Add(this.BtnListToExcel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MalKoduArama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BitisTarihiArama);
            this.Controls.Add(this.BaslangicTarihiArama);
            this.Controls.Add(this.Liste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.TextBox BaslangicTarihiArama;
        private System.Windows.Forms.TextBox BitisTarihiArama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnListToExcel;
        private System.Windows.Forms.Button BtnListToPdf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvrakNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CikisMiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.TextBox MalKoduArama;
    }
}

