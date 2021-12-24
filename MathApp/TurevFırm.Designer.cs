
namespace MathApp
{
    partial class TurevFırm
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
            this.button1 = new System.Windows.Forms.Button();
            this.TurevCiz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart1.Legends.Add(legend2);
            this.Chart1.Location = new System.Drawing.Point(3, 14);
            this.Chart1.Margin = new System.Windows.Forms.Padding(5);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "x^2+y^2=1";
            this.Chart1.Series.Add(series2);
            this.Chart1.Size = new System.Drawing.Size(625, 522);
            this.Chart1.TabIndex = 3;
            this.Chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TurevCiz
            // 
            this.TurevCiz.Location = new System.Drawing.Point(685, 22);
            this.TurevCiz.Name = "TurevCiz";
            this.TurevCiz.Size = new System.Drawing.Size(75, 80);
            this.TurevCiz.TabIndex = 5;
            this.TurevCiz.Text = "Çiz";
            this.TurevCiz.UseVisualStyleBackColor = true;
            this.TurevCiz.Click += new System.EventHandler(this.TurevCiz_Click);
            // 
            // TurevFırm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 590);
            this.Controls.Add(this.TurevCiz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Chart1);
            this.Name = "TurevFırm";
            this.Text = "TurevFırm";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TurevCiz;
    }
}