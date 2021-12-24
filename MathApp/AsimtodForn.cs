using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathApp
{
    public partial class AsimtodForn : Form
    {
        public AsimtodForn()
        {
            InitializeComponent();
        }

        private void AsimtodCiz_Click(object sender, EventArgs e)
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[0].Name = "y=(2*x^2+8)/(x^2-16)";
            Chart1.Series.Add("x<-4");
            Chart1.Series.Add("x>-4");
            Chart1.Series[1].ChartType = SeriesChartType.Spline;
            Chart1.Series[2].ChartType = SeriesChartType.Spline;
            double y;
            double OrneklmeAraligi = 1;
            for (double x = -10; x < 10; x += OrneklmeAraligi)
            {
                if (x < 4 && x > -4)
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    Chart1.Series[0].Points.AddXY(x, y);
                }
                if (x < -4)
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    Chart1.Series[1].Points.AddXY(x, y);
                }
                if (x > 4)
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    Chart1.Series[2].Points.AddXY(x, y);
                }
            }
        }
    }
}
