using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit13_EditValueChanged(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI cari = new TBLCARI();
            cari.AD = TxtCariAd.Text;
            cari.SOYAD = TxtCariSoyad.Text;
            cari.IL = TxtCariIl.Text;
            cari.ILCE = TxtCariIlce.Text;
            db.TBLCARI.Add(cari);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Sisteme Başarılı Bir Şekilde Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
