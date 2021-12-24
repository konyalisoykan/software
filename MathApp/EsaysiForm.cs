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
    public partial class EsaysiForm : Form
    {
        public EsaysiForm()
        {
            InitializeComponent();
        }

        private void EsayisiHesapla_Click(object sender, EventArgs e)
        {
            BirimCemberCiz(1);
        }
        private void BirimCemberCiz(double OrneklmeAraligi)
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[0].Name = "y=(1+(1/x))^x";
           
            double y=0;
            for (double x = 0; x <= 10000; x += OrneklmeAraligi)
            {
                y = Math.Pow((1 + (1 / x)), x);

                Chart1.Series[0].Points.AddXY(x, y);
              
            }
            MessageBox.Show(y.ToString());

        }
    }
}
