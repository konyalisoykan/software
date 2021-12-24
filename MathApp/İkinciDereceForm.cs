using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathApp
{
    public partial class İkinciDereceForm : Form
    {
        public İkinciDereceForm()
        {
            InitializeComponent();
        }


        private void Ciz()
        {
            txtA.Text = trackBar1.Value.ToString();
            txtB.Text = trackBar2.Value.ToString();
            txtC.Text = trackBar3.Value.ToString();
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            double C = Convert.ToDouble(txtC.Text);

            İkinciDerecedenCiz(A, B, C,0.1, -10, 10);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Ciz();
        }


        

        private void İkinciDereceForm_Load(object sender, EventArgs e)
        {
            Ciz();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            Ciz();
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            Ciz();
        }
       
        private void İkinciDerecedenCiz(double KatsayıA, double KatsayıB, double SabitDegerC, double OrneklmeAraligi, double YatayBaslangicNoktasi, double YatayBitisNoktasi)
        {
            chart1.Series[0].Points.Clear();
            double y = 0;
            //Bu örneğim mesela y = Ax2 x + Bx +c grafiği çizdirecek
            for (double x = YatayBaslangicNoktasi; x < YatayBitisNoktasi; x += OrneklmeAraligi)
            {
                y = KatsayıA * x * x + KatsayıB * x + SabitDegerC;
                chart1.Series[0].Points.AddXY(x, y);

            }

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Ciz();
        }
    }
}
