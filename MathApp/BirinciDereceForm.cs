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
    public partial class BirinciDereceForm : Form
    {
        public BirinciDereceForm()
        {
            InitializeComponent();
        }

        private void BirinciDereceForm_Load(object sender, EventArgs e)
        {
            Ciz();
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
        private void BirinciDerecedenCiz(double KatsayıA, double SabitDegerB, double OrneklmeAraligi, double YatayBaslangicNoktasi, double YatayBitisNoktasi)
        {
            chartBirinciDerece.Series[0].Points.Clear();
            double y = 0;
            //Bu örneğim mesela y = A x + B grafiği çizdirecek
            for (double x = YatayBaslangicNoktasi; x < YatayBitisNoktasi; x += OrneklmeAraligi)
            {
                y = KatsayıA * x + SabitDegerB;
                chartBirinciDerece.Series[0].Points.AddXY(x, y);

            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Ciz();
        }
        private void Ciz()
        {
            txtA.Text = trackBar1.Value.ToString();
            txtB.Text = trackBar2.Value.ToString();
            double A = Convert.ToDouble(txtA.Text);
            double B = Convert.ToDouble(txtB.Text);
            BirinciDerecedenCiz(A, B, 0.1, -10, 10);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Ciz();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            Ciz();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Ciz();
        }
    }
}
