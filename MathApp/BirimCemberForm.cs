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
    public partial class BirimCemberForm : Form
    {
        public BirimCemberForm()
        {
            InitializeComponent();
        }

        private void BirimCemberCız_Click(object sender, EventArgs e)
        {
            BirimCemberCiz(0.01);
        }

        private void BirimCemberForm_Load(object sender, EventArgs e)
        {

        }
        private void BirimCemberCiz(double OrneklmeAraligi)
        {
            Chart1.Series.Add("Negatif");
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[1].ChartType = SeriesChartType.Spline;
            //Bu örneğim mesela x2+y2=1
            double y;
            for (double x = -1; x <= 1; x += OrneklmeAraligi)
            {

                y = (Math.Sqrt(1 - Math.Pow(x, 2)));
                Chart1.Series[0].Points.AddXY(x, y);
                Chart1.Series[1].Points.AddXY(x, -y);
            }

        }
    }
}
