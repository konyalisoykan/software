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

      
     

       
      
       

      
        private void denklemÇizimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dereceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirinciDereceForm _form = new BirinciDereceForm();
            
            _form.Show();



        }

        private void dereceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            İkinciDereceForm _form = new İkinciDereceForm();

            _form.Show();
        }

      
   
        private void asimtodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsimtodForn _form = new AsimtodForn();

            _form.Show();
        }

        private void birimÇemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BirimCemberForm _form = new BirimCemberForm();

            _form.Show();
        }

        private void sinüsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SinusForm _form = new SinusForm();

            _form.Show();
        }

        private void türevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurevFırm _form = new TurevFırm();
            _form.Show();
        }

        private void inyegraşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IntegralForm _form = new IntegralForm();
            _form.Show();
        }

        private void eSayisiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            EsaysiForm _form = new EsaysiForm();
            _form.Show();
        }
    }
}
