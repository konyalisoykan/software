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
    public partial class SinusForm : Form
    {
        public SinusForm()
        {
            InitializeComponent();
        }

        private void SinusCiz_Click(object sender, EventArgs e)
        {
            SinCiz(Math.PI / 8);
        }
        private void SinCiz(double OrneklmeAraligi)
        {

            Chart1.Series[0].Points.Clear();
           
            Chart1.Series[0].ChartType = SeriesChartType.Spline;

            //Bu örneğim mesela y = Asin(x+c/b)
            double y;
            for (double x = -2 * Math.PI; x <= 2 * Math.PI; x += OrneklmeAraligi)
            {
                // y= asin(b(x-(c/b))
                // a büyüklük  genlik 
                // b frekans
                // c faz açısı kayma 
                double a = 2;
                double b = 4;
                double c = Math.PI / 2;
                y = a * (Math.Sin(b * (x - (c / b))));
                Chart1.Series[0].Points.AddXY(x, y);

            }

        }
    }
}
