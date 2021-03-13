
namespace FirebaseEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button HaritaGuncelle;
            System.Windows.Forms.Button DetayGuncelle;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.Ot = new System.Windows.Forms.TextBox();
            this.Bilgi = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Detayrichbox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.YeniKayit = new System.Windows.Forms.Button();
            this.Dtarihi = new System.Windows.Forms.TextBox();
            this.Sehir = new System.Windows.Forms.TextBox();
            this.Ilce = new System.Windows.Forms.TextBox();
            this.HaritaTextbox = new System.Windows.Forms.TextBox();
            HaritaGuncelle = new System.Windows.Forms.Button();
            DetayGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HaritaGuncelle
            // 
            HaritaGuncelle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HaritaGuncelle.Location = new System.Drawing.Point(738, 632);
            HaritaGuncelle.Name = "HaritaGuncelle";
            HaritaGuncelle.Size = new System.Drawing.Size(381, 73);
            HaritaGuncelle.TabIndex = 20;
            HaritaGuncelle.Text = "Hatiya Güncelle";
            HaritaGuncelle.UseVisualStyleBackColor = true;
            HaritaGuncelle.Click += new System.EventHandler(this.HaritaGuncelle_Click);
            // 
            // DetayGuncelle
            // 
            DetayGuncelle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            DetayGuncelle.Location = new System.Drawing.Point(1095, 640);
            DetayGuncelle.Name = "DetayGuncelle";
            DetayGuncelle.Size = new System.Drawing.Size(381, 73);
            DetayGuncelle.TabIndex = 21;
            DetayGuncelle.Text = "Detay Güncelle";
            DetayGuncelle.UseVisualStyleBackColor = true;
            DetayGuncelle.Click += new System.EventHandler(this.DetayGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "DT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "OT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 62);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 62);
            this.label5.TabIndex = 4;
            this.label5.Text = "İlçe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 62);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bilgi";
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ad.Location = new System.Drawing.Point(209, 23);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(667, 57);
            this.Ad.TabIndex = 6;
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ot.Location = new System.Drawing.Point(209, 159);
            this.Ot.Name = "Ot";
            this.Ot.Size = new System.Drawing.Size(667, 57);
            this.Ot.TabIndex = 8;
            // 
            // Bilgi
            // 
            this.Bilgi.Location = new System.Drawing.Point(211, 367);
            this.Bilgi.Name = "Bilgi";
            this.Bilgi.Size = new System.Drawing.Size(648, 168);
            this.Bilgi.TabIndex = 12;
            this.Bilgi.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 535);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 62);
            this.label7.TabIndex = 13;
            this.label7.Text = "Harita";
            // 
            // Detayrichbox
            // 
            this.Detayrichbox.Location = new System.Drawing.Point(919, 65);
            this.Detayrichbox.Name = "Detayrichbox";
            this.Detayrichbox.Size = new System.Drawing.Size(534, 449);
            this.Detayrichbox.TabIndex = 15;
            this.Detayrichbox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(932, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 62);
            this.label8.TabIndex = 16;
            this.label8.Text = "Detay";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(211, 640);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(206, 57);
            this.Id.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(25, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 62);
            this.label9.TabIndex = 18;
            this.label9.Text = "Id";
            // 
            // YeniKayit
            // 
            this.YeniKayit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YeniKayit.Location = new System.Drawing.Point(451, 632);
            this.YeniKayit.Name = "YeniKayit";
            this.YeniKayit.Size = new System.Drawing.Size(269, 73);
            this.YeniKayit.TabIndex = 19;
            this.YeniKayit.Text = "Yeni Kayıt";
            this.YeniKayit.UseVisualStyleBackColor = true;
            this.YeniKayit.Click += new System.EventHandler(this.YeniKayit_Click);
            // 
            // Dtarihi
            // 
            this.Dtarihi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dtarihi.Location = new System.Drawing.Point(211, 86);
            this.Dtarihi.Name = "Dtarihi";
            this.Dtarihi.Size = new System.Drawing.Size(667, 57);
            this.Dtarihi.TabIndex = 22;
            // 
            // Sehir
            // 
            this.Sehir.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sehir.Location = new System.Drawing.Point(217, 222);
            this.Sehir.Name = "Sehir";
            this.Sehir.Size = new System.Drawing.Size(667, 57);
            this.Sehir.TabIndex = 23;
            // 
            // Ilce
            // 
            this.Ilce.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ilce.Location = new System.Drawing.Point(211, 295);
            this.Ilce.Name = "Ilce";
            this.Ilce.Size = new System.Drawing.Size(667, 57);
            this.Ilce.TabIndex = 24;
            // 
            // HaritaTextbox
            // 
            this.HaritaTextbox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HaritaTextbox.Location = new System.Drawing.Point(217, 553);
            this.HaritaTextbox.Name = "HaritaTextbox";
            this.HaritaTextbox.Size = new System.Drawing.Size(1242, 57);
            this.HaritaTextbox.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 722);
            this.Controls.Add(this.HaritaTextbox);
            this.Controls.Add(this.Ilce);
            this.Controls.Add(this.Sehir);
            this.Controls.Add(this.Dtarihi);
            this.Controls.Add(DetayGuncelle);
            this.Controls.Add(HaritaGuncelle);
            this.Controls.Add(this.YeniKayit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Detayrichbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bilgi);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.TextBox Ot;
        private System.Windows.Forms.RichTextBox Bilgi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Detayrichbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button YeniKayit;
        private System.Windows.Forms.TextBox Dtarihi;
        private System.Windows.Forms.TextBox Sehir;
        private System.Windows.Forms.TextBox Ilce;
        private System.Windows.Forms.TextBox HaritaTextbox;
    }
}

