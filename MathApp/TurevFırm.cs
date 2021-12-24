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
    public partial class TurevFırm : Form
    {
        public TurevFırm()
        {
            InitializeComponent();
        }

        private void TurevCiz_Click(object sender, EventArgs e)
        {
            turevciz(0.01);
        }
        private void turevciz(double OrneklmeAraligi)
        {
            // y= (f(x)+h-f(x))/h h sıfıea yaklaşıyor
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[0].Name = "y=x^3+x^2+3";
            Chart1.Series.Add("y'");
            Chart1.Series[1].ChartType = SeriesChartType.Spline;
            Chart1.Series.Add("y''");
            Chart1.Series[2].ChartType = SeriesChartType.Spline;
            Chart1.Series.Add("(f'(x)=sinx / x)");
            Chart1.Series[3].ChartType = SeriesChartType.Spline;
            //Bu örneğim mesela y =x^2 nin türevi
            double y;
            double y1;
            double y2 = 0;
            double y3 = 0;
            double h = 0.00001;
            for (double x = -10; x <= 10; x += OrneklmeAraligi)
            {
                y = Math.Pow(x, 3) + Math.Pow(x, 2) + 3;
                //y'
                y1 = ((Math.Pow(x + h, 3) + Math.Pow(x + h, 2) + 3) - (y)) / h;
                //y''
                y2 = ((((Math.Pow(x + h + h, 3) + Math.Pow(x + h + h, 2) + 3) - (Math.Pow(x + h, 3) + Math.Pow(x + h, 2) + 3)) / h) - y1) / h;

                y3 = ((Math.Sin(x+h) / x + h) - (Math.Sin(x) / x)) / h;

                Chart1.Series[0].Points.AddXY(x, y);
                Chart1.Series[1].Points.AddXY(x, y1);
                Chart1.Series[2].Points.AddXY(x, y2);
                //    chartBirinciDerece.Series[0].Points.AddXY(x, y3);

            }

        }
    }
}
