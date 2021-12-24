
namespace MathApp
{
    partial class EsaysiForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EsayisiHesapla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(14, 31);
            this.Chart1.Margin = new System.Windows.Forms.Padding(5);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "x^2+y^2=1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(625, 522);
            this.Chart1.TabIndex = 3;
            this.Chart1.Text = "chart1";
            // 
            // EsayisiHesapla
            // 
            this.EsayisiHesapla.Location = new System.Drawing.Point(669, 31);
            this.EsayisiHesapla.Name = "EsayisiHesapla";
            this.EsayisiHesapla.Size = new System.Drawing.Size(75, 80);
            this.EsayisiHesapla.TabIndex = 4;
            this.EsayisiHesapla.Text = "Çiz";
            this.EsayisiHesapla.UseVisualStyleBackColor = true;
            this.EsayisiHesapla.Click += new System.EventHandler(this.EsayisiHesapla_Click);
            // 
            // EsaysiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 590);
            this.Controls.Add(this.EsayisiHesapla);
            this.Controls.Add(this.Chart1);
            this.Name = "EsaysiForm";
            this.Text = "EsaysiForm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button EsayisiHesapla;
    }
}