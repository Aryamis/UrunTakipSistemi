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
    public partial class FrmYeniDepartman : Form
    {
        public FrmYeniDepartman()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();
            if (TxtDepartmanAd.Text.Length <= 50 && TxtDepartmanAd.Text != "null" )
            {
                t.AD = TxtDepartmanAd.Text;
                t.ACIKLAMA = TxtDepartmanAd.Text;

                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show(" Yeni Departman Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
