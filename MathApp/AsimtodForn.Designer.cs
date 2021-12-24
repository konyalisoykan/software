
namespace MathApp
{
    partial class AsimtodForn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AsimtodCiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(14, 14);
            this.Chart1.Margin = new System.Windows.Forms.Padding(5);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "y=ax+b";
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(625, 522);
            this.Chart1.TabIndex = 1;
            this.Chart1.Text = "chart1";
            // 
            // AsimtodCiz
            // 
            this.AsimtodCiz.Location = new System.Drawing.Point(647, 30);
            this.AsimtodCiz.Name = "AsimtodCiz";
            this.AsimtodCiz.Size = new System.Drawing.Size(75, 80);
            this.AsimtodCiz.TabIndex = 2;
            this.AsimtodCiz.Text = "Çiz";
            this.AsimtodCiz.UseVisualStyleBackColor = true;
            this.AsimtodCiz.Click += new System.EventHandler(this.AsimtodCiz_Click);
            // 
            // AsimtodForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 591);
            this.Controls.Add(this.AsimtodCiz);
            this.Controls.Add(this.Chart1);
            this.Name = "AsimtodForn";
            this.Text = "AsimtodForn";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button AsimtodCiz;
    }
}