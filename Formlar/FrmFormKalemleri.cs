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
    public partial class FrmFormKalemleri : Form
    {
        public FrmFormKalemleri()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void BtnAra_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(TxtFaturaId.Text);
            var degerler = (from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           }).Where (x=>x.FATURAID==id);
            gridControl1.DataSource = degerler.ToList();
        }

        private void FrmFormKalemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
