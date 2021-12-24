
namespace MathApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.denklemÇizimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dereceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dereceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asimtodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimÇemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trigonometriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinüsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turevİntegralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inyegraşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.sabirHesabıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eSayisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.denklemÇizimiToolStripMenuItem,
            this.trigonometriToolStripMenuItem,
            this.turevİntegralToolStripMenuItem,
            this.sabirHesabıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1378, 33);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // denklemÇizimiToolStripMenuItem
            // 
            this.denklemÇizimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dereceToolStripMenuItem,
            this.dereceToolStripMenuItem1,
            this.asimtodToolStripMenuItem,
            this.birimÇemberToolStripMenuItem});
            this.denklemÇizimiToolStripMenuItem.Name = "denklemÇizimiToolStripMenuItem";
            this.denklemÇizimiToolStripMenuItem.Size = new System.Drawing.Size(145, 29);
            this.denklemÇizimiToolStripMenuItem.Text = "DenklemÇizimi";
            this.denklemÇizimiToolStripMenuItem.Click += new System.EventHandler(this.denklemÇizimiToolStripMenuItem_Click);
            // 
            // dereceToolStripMenuItem
            // 
            this.dereceToolStripMenuItem.Name = "dereceToolStripMenuItem";
            this.dereceToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.dereceToolStripMenuItem.Text = "1. Derece";
            this.dereceToolStripMenuItem.Click += new System.EventHandler(this.dereceToolStripMenuItem_Click);
            // 
            // dereceToolStripMenuItem1
            // 
            this.dereceToolStripMenuItem1.Name = "dereceToolStripMenuItem1";
            this.dereceToolStripMenuItem1.Size = new System.Drawing.Size(221, 34);
            this.dereceToolStripMenuItem1.Text = "2.Derece";
            this.dereceToolStripMenuItem1.Click += new System.EventHandler(this.dereceToolStripMenuItem1_Click);
            // 
            // asimtodToolStripMenuItem
            // 
            this.asimtodToolStripMenuItem.Name = "asimtodToolStripMenuItem";
            this.asimtodToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.asimtodToolStripMenuItem.Text = "Asimtod";
            this.asimtodToolStripMenuItem.Click += new System.EventHandler(this.asimtodToolStripMenuItem_Click);
            // 
            // birimÇemberToolStripMenuItem
            // 
            this.birimÇemberToolStripMenuItem.Name = "birimÇemberToolStripMenuItem";
            this.birimÇemberToolStripMenuItem.Size = new System.Drawing.Size(221, 34);
            this.birimÇemberToolStripMenuItem.Text = "Birim Çember";
            this.birimÇemberToolStripMenuItem.Click += new System.EventHandler(this.birimÇemberToolStripMenuItem_Click);
            // 
            // trigonometriToolStripMenuItem
            // 
            this.trigonometriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinüsToolStripMenuItem});
            this.trigonometriToolStripMenuItem.Name = "trigonometriToolStripMenuItem";
            this.trigonometriToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.trigonometriToolStripMenuItem.Text = "Trigonometri";
            // 
            // sinüsToolStripMenuItem
            // 
            this.sinüsToolStripMenuItem.Name = "sinüsToolStripMenuItem";
            this.sinüsToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.sinüsToolStripMenuItem.Text = "Sinüs";
            this.sinüsToolStripMenuItem.Click += new System.EventHandler(this.sinüsToolStripMenuItem_Click);
            // 
            // turevİntegralToolStripMenuItem
            // 
            this.turevİntegralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.türevToolStripMenuItem,
            this.inyegraşToolStripMenuItem});
            this.turevİntegralToolStripMenuItem.Name = "turevİntegralToolStripMenuItem";
            this.turevİntegralToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.turevİntegralToolStripMenuItem.Text = "Turev/İntegral";
            // 
            // türevToolStripMenuItem
            // 
            this.türevToolStripMenuItem.Name = "türevToolStripMenuItem";
            this.türevToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.türevToolStripMenuItem.Text = "Türev";
            this.türevToolStripMenuItem.Click += new System.EventHandler(this.türevToolStripMenuItem_Click);
            // 
            // inyegraşToolStripMenuItem
            // 
            this.inyegraşToolStripMenuItem.Name = "inyegraşToolStripMenuItem";
            this.inyegraşToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.inyegraşToolStripMenuItem.Text = "İntegral";
            this.inyegraşToolStripMenuItem.Click += new System.EventHandler(this.inyegraşToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 33);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 579);
            this.splitter1.TabIndex = 35;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 33);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 579);
            this.splitter2.TabIndex = 36;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(6, 33);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 579);
            this.splitter3.TabIndex = 37;
            this.splitter3.TabStop = false;
            // 
            // sabirHesabıToolStripMenuItem
            // 
            this.sabirHesabıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eSayisiToolStripMenuItem});
            this.sabirHesabıToolStripMenuItem.Name = "sabirHesabıToolStripMenuItem";
            this.sabirHesabıToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.sabirHesabıToolStripMenuItem.Text = "SabirHesabı";
            // 
            // eSayisiToolStripMenuItem
            // 
            this.eSayisiToolStripMenuItem.Name = "eSayisiToolStripMenuItem";
            this.eSayisiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eSayisiToolStripMenuItem.Text = "ESayisi";
            this.eSayisiToolStripMenuItem.Click += new System.EventHandler(this.eSayisiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 612);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Denklem Grafiği Çizme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem denklemÇizimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dereceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dereceToolStripMenuItem1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.ToolStripMenuItem asimtodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimÇemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trigonometriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinüsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turevİntegralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inyegraşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sabirHesabıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eSayisiToolStripMenuItem;
    }
}