using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }

        private void btnBirinciDerecedenCiz_Click(object sender, EventArgs e)
        {
            chartBirinciDerece.Series[0].Points.Clear();

            double A = 0; // xin katsayısı 

            double B = 0; // sabit değer

            try
            {
                A = double.Parse(txtA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş...  A = 0 kabul edildi");

                A = 0;
            }

            try
            {
                B = double.Parse(txtB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş...  B = 0 kabul edildi");

                B = 0;
            }
            BirinciDerecedenCiz(A, B, 0.1, -5, 5);
          
        }

        private void btnIkinciDerecedenCiz_Click(object sender, EventArgs e)
        {
          

            int A = 0; // x^2 in katsayısı 
            int B = 0; // xin katsayısı 
            int C = 0;  // sabit değer
            try
            {
                A = int.Parse(txt2A.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş...  A = 0 kabul edildi");
                A = 0;
            }

            try
            {
                B = int.Parse(txt2B.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş...  B = 0 kabul edildi");
                B = 0;
            }

            try
            {
                C = int.Parse(txt2C.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş... C = 0 kabul edildi");
                C = 0;
            }

            double y = 0;
            İkinciDerecedenCiz(A, B, C, 0.1, -5, 5);
            /*
            //Bu örneğim mesela y = A x ^ 2 + B * x + C grafiği çizdirecek
            for (double x = -10; x < 10;)
            {
                y = A * x*x + B * x + C;
                chartIkinciDerece.Series[0].Points.AddXY(x, y);
                x += 0.1;
            }
            */
        }

        private void chartIkinciDerece_Click(object sender, EventArgs e)
        {

        }
       
        private void BirinciDerecedenCiz(double KatsayıA, double SabitDegerB,double OrneklmeAraligi,double YatayBaslangicNoktasi,double YatayBitisNoktasi)
        {
            chartBirinciDerece.Series[0].Points.Clear();
            double y = 0;
            //Bu örneğim mesela y = A x + B grafiği çizdirecek
            for (double x = YatayBaslangicNoktasi; x < YatayBitisNoktasi;x+= OrneklmeAraligi)
            {
                y = KatsayıA * x + SabitDegerB;
                chartBirinciDerece.Series[0].Points.AddXY(x, y);
               
            }

        }

        private void İkinciDerecedenCiz(double KatsayıA, double KatsayıB, double SabitDegerC, double OrneklmeAraligi, double YatayBaslangicNoktasi, double YatayBitisNoktasi)
        {
            chartBirinciDerece.Series[0].Points.Clear();
            double y = 0;
            //Bu örneğim mesela y = Ax2 x + Bx +c grafiği çizdirecek
            for (double x = YatayBaslangicNoktasi; x < YatayBitisNoktasi; x += OrneklmeAraligi)
            {
                y = KatsayıA * x*x + KatsayıB*x+SabitDegerC;
                chartBirinciDerece.Series[0].Points.AddXY(x, y);

            }

        }

        private void BirimCemberCiz(double OrneklmeAraligi)
        {
            chartBirinciDerece.Series.Add("Negatif");
            chartBirinciDerece.Series[0].Points.Clear();
            chartBirinciDerece.Series[0].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series[1].ChartType = SeriesChartType.Spline;
            //Bu örneğim mesela x2+y2=1
            double y;
            for (double x = -1; x <= 1; x += OrneklmeAraligi)
            {

                y = (Math.Sqrt(1 - Math.Pow(x, 2)));
                chartBirinciDerece.Series[0].Points.AddXY(x, y);
              chartBirinciDerece.Series[1].Points.AddXY(x, -y);
            }

        }
        private void SinCiz(double OrneklmeAraligi)
        {
            
            chartBirinciDerece.Series[0].Points.Clear();
            chartBirinciDerece.Series[0].ChartType = SeriesChartType.Spline;
           
            //Bu örneğim mesela y = Asin(x+c/b)
            double y;
            for (double x = -2* Math.PI;  x <=2*Math.PI; x += OrneklmeAraligi)
            {
                // y= asin(b(x-(c/b))
                // a büyüklük  genlik 
                // b frekans
                // c faz açısı kayma 
                double a = 2;
                double b = 4;
                double c= Math.PI/2;
                y = a*(Math.Sin(b*(x-(c/b))));
                chartBirinciDerece.Series[0].Points.AddXY(x, y);
               
            }

        }
        private void turevciz(double OrneklmeAraligi)
        {
           // y= (f(x)+h-f(x))/h h sıfıea yaklaşıyor
            chartBirinciDerece.Series[0].Points.Clear();
            chartBirinciDerece.Series[0].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series[0].Name = "y=x^3+x^2+3";
            chartBirinciDerece.Series.Add("y'");
            chartBirinciDerece.Series[1].ChartType = SeriesChartType.Spline;
             chartBirinciDerece.Series.Add("y''");
            chartBirinciDerece.Series[2].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series.Add("(f'(x)=sinx / x)");
            chartBirinciDerece.Series[3].ChartType = SeriesChartType.Spline;
            //Bu örneğim mesela y =x^2 nin türevi
            double y;
            double y1;
            double y2 = 0;
            double y3 = 0;
            double h = 0.00001;
            for (double x =-10; x <=10; x += OrneklmeAraligi)
            {
                y = Math.Pow(x, 3) + Math.Pow(x, 2) + 3;
                //y'
                y1= ((Math.Pow(x+h, 3) + Math.Pow(x+h, 2) + 3)- (y))/ h;
                //y''
                y2 = ((((Math.Pow(x + h+h, 3) + Math.Pow(x + h+h, 2) + 3) - (Math.Pow(x+h, 3) + Math.Pow(x+h, 2) + 3)) / h)-y1)/h;

                y3 = ((Math.Sin(x) / x + h) - (Math.Sin(x) / x)) / h;

                chartBirinciDerece.Series[0].Points.AddXY(x, y);
                chartBirinciDerece.Series[1].Points.AddXY(x, y1);
                chartBirinciDerece.Series[2].Points.AddXY(x, y2);
            //    chartBirinciDerece.Series[0].Points.AddXY(x, y3);

            }

        }
        private void BirimCemberButtın_Click(object sender, EventArgs e)
        {
            BirimCemberCiz(0.01);
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            SinCiz(Math.PI/8);
        }

        private void Tyrev_Click(object sender, EventArgs e)
        {
            turevciz(0.01);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartBirinciDerece.Series[0].Points.Clear();
            chartBirinciDerece.Series[0].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series[0].Name = "y=x^3+x^2+3";
            chartBirinciDerece.Series.Add("x<-4");
            chartBirinciDerece.Series.Add("x>-4");
            chartBirinciDerece.Series[1].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series[2].ChartType = SeriesChartType.Spline;
            double y;
            double OrneklmeAraligi = 1;
            for (double x = -10; x < 10; x += OrneklmeAraligi)
            {
                if (x < 4 && x > -4)
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    chartBirinciDerece.Series[0].Points.AddXY(x, y);
                }
                if (x < -4 )
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    chartBirinciDerece.Series[1].Points.AddXY(x, y);
                }
                if (x > 4)
                {

                    y = (2 * Math.Pow(x, 2) - 8) / (Math.Pow(x, 2) - 16);
                    chartBirinciDerece.Series[2].Points.AddXY(x, y);
                }
            }
        }

        private void Integral_Click(object sender, EventArgs e)
        {
            chartBirinciDerece.Series[0].Points.Clear();
            chartBirinciDerece.Series[0].ChartType = SeriesChartType.Spline;
            chartBirinciDerece.Series[0].Name = "y=x";
            chartBirinciDerece.Series.Add("y=Sf(x)");

            chartBirinciDerece.Series[1].ChartType = SeriesChartType.Spline;

            double y;
            double y1=0;
            double OrneklmeAraligi = 0.01;
            for (double x = 0; x <=20; x += OrneklmeAraligi)
            {
                y = x;
                chartBirinciDerece.Series[0].Points.AddXY(x, y);
                y1 += y * OrneklmeAraligi;
                chartBirinciDerece.Series[1].Points.AddXY(x, y1);
            }
        }
    }
}
