using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirebaseEditor
{

    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "",
            BasePath = "https://evliyalar-ansiklopedisi-default-rtdb.europe-west1.firebasedatabase.app/"

        };

        IFirebaseClient client;
        private void Connection()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
                MessageBox.Show("Bağlantı sağlandı.");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection();
            
        }
        internal class Evliya
        {
           
            public string Ad { get; set; }
            public string DT { get; set; }
            public string OT { get; set; }
            public string Sehir { get; set; }
            public string Ilce { get; set; }
            public string Mevki { get; set; }
            public string Bilgi { get; set; }
         
        }
        internal class Detay
        {
            public string Hayati { get; set; }
            public string Harita { get; set; }
        }
        SetResponse response = null;
        SetResponse responseDetay = null;
        Evliya result = null;
        Detay DetayResult = null;
        public async void EvliyaOzetiKaydet()
        {
            var evliya = new Evliya()
            {
                Ad = Ad.Text,
                DT = Dtarihi.Text,
                OT = Ot.Text,
                Sehir = Sehir.Text,
                Ilce = Ilce.Text,
                Mevki = Mevki.Text,
                Bilgi = Bilgi.Text
              
            };

            response = await client.SetAsync("Evliyalar/"+Id.Text+  "/", evliya);
            result = response.ResultAs<Evliya>();

            if (result.Ad != null)
                MessageBox.Show("Evliya Kaydedildi");
            else
                MessageBox.Show("Evliya kaydedilemedi.");
        }
        public async void EvliyaDetayKaydet()
        {
            var detay = new Detay()
            {
                Hayati = Detayrichbox.Text,
                Harita = HaritaTextbox.Text,
            };

            responseDetay = await client.SetAsync("Detaylar/" + Id.Text , detay);
            DetayResult = responseDetay.ResultAs<Detay>();

            if (DetayResult.Harita != null)
                MessageBox.Show("Detay Kaydedildi");
            else
                MessageBox.Show("Detay kaydedilemedi.");
        }
        internal async void  HaritaGuncelle()
        {
            var detay = new Detay()
            {
             
                Harita = HaritaTextbox.Text,
            };
            var response = await client.UpdateAsync("Detaylar/" + Id.Text.ToString(), detay);
            DetayResult = response.ResultAs<Detay>();

            if (DetayResult.Harita != null)
                MessageBox.Show("Harita güncellendi");
            else
                MessageBox.Show("Harita güncellenenmedi");

           
        }
        internal async Task<bool> DetayGuncelle()
        {
            try
            {
                var detay = new Detay()
                {
                    Hayati = Detayrichbox.Text,
                    Harita = HaritaTextbox.Text,
                };
                var response = await client.SetAsync("Detaylar/" + Id.Text.ToString(), detay);
                DetayResult = response.ResultAs<Detay>();

                if (DetayResult.Hayati != null)
                    MessageBox.Show("Hayatı güncellendi");
                else
                    MessageBox.Show("Hayatı güncellenenmedi");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return true;

        }
        private void YeniKayit_Click(object sender, EventArgs e)
        {
            EvliyaOzetiKaydet();
            EvliyaDetayKaydet();
        }

        private void Dtarihi_TextChanged(object sender, EventArgs e)
        {

        }

        private void HaritaGuncelle_Click(object sender, EventArgs e)
        {
            HaritaGuncelle();
        }

        private void DetayGuncelle_Click(object sender, EventArgs e)
        {
            DetayGuncelle();
           
        }
    }
}
