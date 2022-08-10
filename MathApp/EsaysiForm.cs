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
            Ciz(0.01);
        }
        private void EsayisiTurev(double OrneklmeAraligi)
        {
          
           
        }
        private void Ciz(double OrneklmeAraligi)
        {
            Chart1.Series[0].Points.Clear();
            Chart1.Series[0].ChartType = SeriesChartType.Spline;
            Chart1.Series[0].Name = "e=y=(1+(1/x))^x";

            Chart1.Series.Add("y'");
            Chart1.Series[1].Name = "y'()";
            Chart1.Series[1].Points.Clear();
            Chart1.Series[1].ChartType = SeriesChartType.Spline;

            Chart1.Series.Add("e^x türevi");
            Chart1.Series[2].Name = "y2=e^x=> y2' =e^x";
            Chart1.Series[2].Points.Clear();
            Chart1.Series[2].ChartType = SeriesChartType.Spline;

            Chart1.Series.Add("ln(x) = x= e^y");
            Chart1.Series[3].Name = "ln(x) = x= e^y)";
            Chart1.Series[3].Points.Clear();
            Chart1.Series[3].ChartType = SeriesChartType.Spline;

            Chart1.Series.Add("ln'(x) = 1/x");
            Chart1.Series[4].Name = "ln'(x) = 1/x";
            Chart1.Series[4].Points.Clear();
            Chart1.Series[4].ChartType = SeriesChartType.Spline;


            double h = 0.00001;
            double y = 0;
            double y1;
            double y2;
            double y3;
            /*
            // x sonsuza giderken  e sayısının bulunması 
            for (double x = 0; x <= 10; x += OrneklmeAraligi)
            {
                y = Math.Pow((1 + (1 / x)), x);

                Chart1.Series[0].Points.AddXY(x, y);

            }
           
            // e sayısının türevi  0 eşit oluyor ÇÜnkü e sayısı sabit sayı
            for (double x = 0; x <= 10; x += OrneklmeAraligi)
            {
                y1 = (Math.Pow((1 + (1 / (x + h))), x + h) - Math.Pow((1 + (1 / x)), x)) / h; 
                Chart1.Series[1].Points.AddXY(x, y1);
            }
           */
            
           //e^x türevü e^x oluyor
           for (double x = 0; x <= 10; x += 1)
           {
               y2 = (Math.Pow((Math.E), x + h) - Math.Pow( Math.E,x)) / h;
                if (x != 0)
                {
                    double y5 = 1 / x;
                  //  Chart1.Series[2].Points.AddXY(x, y5);
                }
                Chart1.Series[4].Points.AddXY(y2, x);
            }
          /*
           for (double x = 0; x <= 3; x += OrneklmeAraligi)
           {
               y3 = Math.Pow((Math.E), x);
               Chart1.Series[3].Points.AddXY(y3, x);
           }
            */
            //  MessageBox.Show(y.ToString());

        }
    }
}
