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
    public partial class FrmArizaliUrunDetaylistesi : Form
    {
        public FrmArizaliUrunDetaylistesi()
        {
            InitializeComponent();
        }

        private void FrmArizaliUrunDetaylistesi_Load(object sender, EventArgs e)
        {
            DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERINO,
                                          x.ACIKLAMA,
                                          x.TARIHH

                                      }).ToList();
        }
    }
}
