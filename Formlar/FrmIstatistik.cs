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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            labelControl1.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORI.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            labelControl7.Text = "10";
            labelControl19.Text = (from x in db.TBLURUN orderby x.STOK descending select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN orderby x.STOK ascending select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN orderby x.SATISFIYAT descending select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN orderby x.SATISFIYAT ascending select x.AD).FirstOrDefault();
            labelControl25.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            labelControl21.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl23.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl37.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
        }
    }
}
