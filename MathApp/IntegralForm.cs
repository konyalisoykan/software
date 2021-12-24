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
    public partial class IntegralForm : Form
    {
        public IntegralForm()
        {
            InitializeComponent();
        }

        private void IntegralCiz_Click(object sender, EventArgs e)
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[0].Name = "y=x";
            Chart1.Series.Add("y=Sf(x)");

            Chart1.Series[1].ChartType = SeriesChartType.Spline;

            double y;
            double y1 = 0;
            double OrneklmeAraligi = 0.01;
            for (double x = 0; x <= 20; x += OrneklmeAraligi)
            {
                y = x;
                Chart1.Series[0].Points.AddXY(x, y);
                //Dikdörtgemner toplanıyot
                y1 += y * OrneklmeAraligi;
                Chart1.Series[1].Points.AddXY(x, y1);
            }

        }
    }
}
