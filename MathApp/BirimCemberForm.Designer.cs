
namespace MathApp
{
    partial class BirimCemberForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BirimCemberCız = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart1.Legends.Add(legend3);
            this.Chart1.Location = new System.Drawing.Point(23, 27);
            this.Chart1.Margin = new System.Windows.Forms.Padding(5);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "x^2+y^2=1";
            this.Chart1.Series.Add(series3);
            this.Chart1.Size = new System.Drawing.Size(625, 522);
            this.Chart1.TabIndex = 2;
            this.Chart1.Text = "chart1";
            // 
            // BirimCemberCız
            // 
            this.BirimCemberCız.Location = new System.Drawing.Point(670, 27);
            this.BirimCemberCız.Name = "BirimCemberCız";
            this.BirimCemberCız.Size = new System.Drawing.Size(75, 80);
            this.BirimCemberCız.TabIndex = 3;
            this.BirimCemberCız.Text = "Çiz";
            this.BirimCemberCız.UseVisualStyleBackColor = true;
            this.BirimCemberCız.Click += new System.EventHandler(this.BirimCemberCız_Click);
            // 
            // BirimCemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 563);
            this.Controls.Add(this.BirimCemberCız);
            this.Controls.Add(this.Chart1);
            this.Name = "BirimCemberForm";
            this.Text = "BirimCemberForm";
            this.Load += new System.EventHandler(this.BirimCemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.Button BirimCemberCız;
    }
}