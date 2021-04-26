using AracKiralamaOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyon.Formlar
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
            
            
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            pnlMusteriEkle.Show();
            pnlMusteriEkle.Location = new Point(pnlMusteriEkle.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnMusteriListe_Click(object sender, EventArgs e)
        {
            pnlMusteriListe.Show();
            pnlMusteriListe.Location = new Point(pnlMusteriListe.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnKurumEkle_Click(object sender, EventArgs e)
        {
            pnlKurumEkle.Show();
            pnlKurumEkle.Location = new Point(pnlKurumEkle.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnKurumListe_Click(object sender, EventArgs e)
        {
            pnlKurumListe.Show();
            pnlKurumListe.Location = new Point(pnlKurumListe.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            pnlAracEkle.Show();
            pnlAracEkle.Location = new Point(pnlAracEkle.Location.X - 0, 40);
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnAracListe_Click(object sender, EventArgs e)
        {
            pnlAracListe.Show();
            pnlAracListe.Location = new Point(pnlAracListe.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnSozlesme_Click(object sender, EventArgs e)
        {
            pnlSozlesme.Show();
            pnlSozlesme.Location = new Point(pnlSozlesme.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();

        }

        private void btnGeriIade_Click(object sender, EventArgs e)
        {
            pnlGeriIade.Show();
            pnlGeriIade.Location = new Point(pnlGeriIade.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnHasarKayit_Click(object sender, EventArgs e)
        {
            pnlHasarKaydi.Show();
            pnlHasarKaydi.Location = new Point(pnlHasarKaydi.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSatislar.Hide();
            pnlSozlesme.Hide();
        }

        private void btnSatislar_Click(object sender, EventArgs e)
        {
            pnlSatislar.Show();
            pnlSatislar.Location = new Point(pnlSatislar.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlPersonelKayit.Hide();
            pnlSozlesme.Hide();
        }

        private void btnPersonelKayit_Click(object sender, EventArgs e)
        {
            pnlPersonelKayit.Show();
            pnlSatislar.Hide();
            pnlPersonelKayit.Location = new Point(pnlPersonelKayit.Location.X - 0, 40);
            pnlAracEkle.Hide();
            pnlAracListe.Hide();
            pnlGeriIade.Hide();
            pnlHasarKaydi.Hide();
            pnlKurumEkle.Hide();
            pnlKurumListe.Hide();
            pnlMusteriEkle.Hide();
            pnlMusteriListe.Hide();
            pnlSozlesme.Hide();

            

        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            AracKiralama db = new AracKiralama();

            Kullanici kullanici = new Kullanici();
            kullanici.kullaniciAdi = txtPersonelKullaniciAdi.Text;
            kullanici.sifre = txtPersonelSifre.Text;
            kullanici.ad = txtPersonelAd.Text;
            kullanici.soyad = txtPersonelSoyad.Text;
            kullanici.tc = txtPersonelTc.Text;
            kullanici.telefon = txtPersonelTelefon.Text;
            kullanici.yetki = RdbYonetici.Checked;

            db.Kullanici.Add(kullanici);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKurumKaydet_Click(object sender, EventArgs e)
        {
            AracKiralama db = new AracKiralama();

            Kurumsal kurumsal = new Kurumsal();

            kurumsal.kurumİsmi = txtKurumAd.Text;
            kurumsal.kurumAdres = txtKurumAdres.Text;
            kurumsal.kurumTelefon = txtKurumTelefon.Text;
            kurumsal.kurumEmail = txtKurumEmail.Text;
            kurumsal.vergiNo = txtVergiNo.Text;
            kurumsal.muhattap = txtMuhattap.Text;
            kurumsal.muhattapTelefon = txtMuhattapTelefon.Text;

            db.Kurumsal.Add(kurumsal);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlAracListe_Paint(object sender, PaintEventArgs e)
        {
            AracKiralama db = new AracKiralama();

            var liste = db.Arac.Select(x => new {

                x.plaka,
                x.marka,
                x.seri,
                x.model,
                x.vites,
                x.renk,
                x.km,
                x.yakit,
                x.kaskoDurumu
            }).ToList();

            dtgrAracListe.DataSource = liste;
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            AracKiralama db = new AracKiralama();

            Arac arac = new Arac();
            arac.plaka = txtAracPlaka.Text;
            arac.marka = txtAracMarka.Text;
            arac.seri = txtAracSeri.Text;
            arac.model = txtAracModel.Text;
            arac.vites = txtAracVites.Text;
            arac.renk = txtAracRenk.Text;
            arac.km = txtAracKm.Text;
            arac.yakit = txtAracYakit.Text;
            arac.kaskoDurumu = txtAracKaskoDurumu.Text;
            db.Arac.Add(arac);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlKurumListe_Paint(object sender, PaintEventArgs e)
        {
            AracKiralama db = new AracKiralama();

            var liste = db.Kurumsal.Select(x => new {

                x.kurumİsmi,
                x.kurumAdres,
                x.kurumTelefon,
                x.kurumEmail,
                x.vergiNo,
                x.muhattap,
                x.muhattapTelefon,
            }).ToList();

            dtgrKurumListe.DataSource = liste;
        }

        private void pnlMusteriListe_Paint(object sender, PaintEventArgs e)
        {
            AracKiralama db = new AracKiralama();

            var liste = db.Musteri.Select(x => new {

                x.tc,
                x.ad,
                x.soyad,
                x.telefon,
                x.adres,
                x.email,
                x.ehliyetSeriNo,
                x.ehliyetAlisTarihi
            }).ToList();

            DtgrMusteriListe.DataSource = liste;
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            AracKiralama db = new AracKiralama();

            Musteri musteri = new Musteri();
            musteri.tc = txtMusteriTc.Text;
            musteri.ad = txtMusteriAd.Text;
            musteri.soyad = txtMusteriSoyad.Text;
            musteri.telefon = txtMusteriTelefon.Text;
            musteri.adres = txtMusteriAdres.Text;
            musteri.email = txtMusteriEmail.Text;
            musteri.ehliyetSeriNo = txtMusteriEhliyetSeriNo.Text;
            musteri.ehliyetAlisTarihi = dtpMusteriEhliyetAlisTarih.Value;
            db.Musteri.Add(musteri);
            db.SaveChanges();

            MessageBox.Show("Bilgileriniz Kayıt Edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
