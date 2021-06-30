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
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               MÜŞTERİ=x.TBLCARI.AD + x.TBLCARI.SOYAD ,

                               PERSONEL =x.TBLPERSONEL.AD+ x.TBLPERSONEL.SOYAD,
                               x.URUNSERINO,
                               x.GELISTARIH,
                               x.CIKISTARIH
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
