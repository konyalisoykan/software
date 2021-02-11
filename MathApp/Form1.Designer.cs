
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
            System.Windows.Forms.Button BirimCemberButtın;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartBirinciDerece = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBirinciDerecedenCiz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt2B = new System.Windows.Forms.TextBox();
            this.txt2A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2C = new System.Windows.Forms.TextBox();
            this.btnIkinciDerecedenCiz = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Tyrev = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Integral = new System.Windows.Forms.Button();
            BirimCemberButtın = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).BeginInit();
            this.SuspendLayout();
            // 
            // BirimCemberButtın
            // 
            BirimCemberButtın.Location = new System.Drawing.Point(860, 348);
            BirimCemberButtın.Name = "BirimCemberButtın";
            BirimCemberButtın.Size = new System.Drawing.Size(281, 106);
            BirimCemberButtın.TabIndex = 29;
            BirimCemberButtın.Text = "BirimCemberCiz";
            BirimCemberButtın.UseVisualStyleBackColor = true;
            BirimCemberButtın.Click += new System.EventHandler(this.BirimCemberButtın_Click);
            // 
            // chartBirinciDerece
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBirinciDerece.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBirinciDerece.Legends.Add(legend1);
            this.chartBirinciDerece.Location = new System.Drawing.Point(26, 26);
            this.chartBirinciDerece.Margin = new System.Windows.Forms.Padding(6);
            this.chartBirinciDerece.Name = "chartBirinciDerece";
            this.chartBirinciDerece.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBirinciDerece.Series.Add(series1);
            this.chartBirinciDerece.Size = new System.Drawing.Size(764, 626);
            this.chartBirinciDerece.TabIndex = 0;
            this.chartBirinciDerece.Text = "chart1";
            // 
            // btnBirinciDerecedenCiz
            // 
            this.btnBirinciDerecedenCiz.Location = new System.Drawing.Point(1442, 91);
            this.btnBirinciDerecedenCiz.Margin = new System.Windows.Forms.Padding(6);
            this.btnBirinciDerecedenCiz.Name = "btnBirinciDerecedenCiz";
            this.btnBirinciDerecedenCiz.Size = new System.Drawing.Size(161, 49);
            this.btnBirinciDerecedenCiz.TabIndex = 15;
            this.btnBirinciDerecedenCiz.Text = "Grafik Çiz";
            this.btnBirinciDerecedenCiz.UseVisualStyleBackColor = true;
            this.btnBirinciDerecedenCiz.Click += new System.EventHandler(this.btnBirinciDerecedenCiz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1006, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "x  +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(805, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "y = ";
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtB.Location = new System.Drawing.Point(1078, 80);
            this.txtB.Margin = new System.Windows.Forms.Padding(6);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(81, 60);
            this.txtB.TabIndex = 12;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtA.Location = new System.Drawing.Point(837, 75);
            this.txtA.Margin = new System.Windows.Forms.Padding(6);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(137, 60);
            this.txtA.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "x^2  +";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "y = ";
            // 
            // txt2B
            // 
            this.txt2B.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2B.Location = new System.Drawing.Point(1092, 213);
            this.txt2B.Margin = new System.Windows.Forms.Padding(6);
            this.txt2B.Name = "txt2B";
            this.txt2B.Size = new System.Drawing.Size(81, 60);
            this.txt2B.TabIndex = 23;
            // 
            // txt2A
            // 
            this.txt2A.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2A.Location = new System.Drawing.Point(884, 213);
            this.txt2A.Margin = new System.Windows.Forms.Padding(6);
            this.txt2A.Name = "txt2A";
            this.txt2A.Size = new System.Drawing.Size(81, 60);
            this.txt2A.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1222, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "x  +";
            // 
            // txt2C
            // 
            this.txt2C.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt2C.Location = new System.Drawing.Point(1290, 213);
            this.txt2C.Margin = new System.Windows.Forms.Padding(6);
            this.txt2C.Name = "txt2C";
            this.txt2C.Size = new System.Drawing.Size(81, 60);
            this.txt2C.TabIndex = 26;
            // 
            // btnIkinciDerecedenCiz
            // 
            this.btnIkinciDerecedenCiz.Location = new System.Drawing.Point(1459, 189);
            this.btnIkinciDerecedenCiz.Margin = new System.Windows.Forms.Padding(6);
            this.btnIkinciDerecedenCiz.Name = "btnIkinciDerecedenCiz";
            this.btnIkinciDerecedenCiz.Size = new System.Drawing.Size(161, 49);
            this.btnIkinciDerecedenCiz.TabIndex = 28;
            this.btnIkinciDerecedenCiz.Text = "Grafik Çiz";
            this.btnIkinciDerecedenCiz.UseVisualStyleBackColor = true;
            this.btnIkinciDerecedenCiz.Click += new System.EventHandler(this.btnIkinciDerecedenCiz_Click);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(1192, 358);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(281, 106);
            this.Sin.TabIndex = 30;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.Sin_Click);
            // 
            // Tyrev
            // 
            this.Tyrev.Location = new System.Drawing.Point(878, 488);
            this.Tyrev.Name = "Tyrev";
            this.Tyrev.Size = new System.Drawing.Size(281, 106);
            this.Tyrev.TabIndex = 31;
            this.Tyrev.Text = "Tyrev";
            this.Tyrev.UseVisualStyleBackColor = true;
            this.Tyrev.Click += new System.EventHandler(this.Tyrev_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1459, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 32;
            this.button1.Text = "Asimtod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Integral
            // 
            this.Integral.Location = new System.Drawing.Point(1245, 488);
            this.Integral.Name = "Integral";
            this.Integral.Size = new System.Drawing.Size(281, 106);
            this.Integral.TabIndex = 33;
            this.Integral.Text = "Integral";
            this.Integral.UseVisualStyleBackColor = true;
            this.Integral.Click += new System.EventHandler(this.Integral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1725, 852);
            this.Controls.Add(this.Integral);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tyrev);
            this.Controls.Add(this.Sin);
            this.Controls.Add(BirimCemberButtın);
            this.Controls.Add(this.btnIkinciDerecedenCiz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt2C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt2B);
            this.Controls.Add(this.txt2A);
            this.Controls.Add(this.btnBirinciDerecedenCiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.chartBirinciDerece);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Denklem Grafiği Çizme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBirinciDerece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartBirinciDerece;
        private System.Windows.Forms.Button btnBirinciDerecedenCiz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt2B;
        private System.Windows.Forms.TextBox txt2A;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2C;
        private System.Windows.Forms.Button btnIkinciDerecedenCiz;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Tyrev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Integral;
    }
}