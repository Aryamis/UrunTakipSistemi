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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities1 db = new DbTeknikServisEntities1();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();

            gridControl5.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                          x.SOYAD,x.IL
                                       }).ToList();
            gridControl3.DataSource = db.urunkategori().ToList();

            DateTime bugun = DateTime.Today;

            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID) where (x.TARIH == bugun)
                         select new
                         {
                             x.BASLIK,
                             x.ICERIK
                         });
            gridControl7.DataSource = deger.ToList();

           string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;

           
            konu1 = db.TBLILETISIM.First(x => x.ID == 1).KONU;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            Lblmeaj1.Text = ad1 + " / " + "Konu : " + konu1;

            konu2 = db.TBLILETISIM.First(x => x.ID == 2).KONU;
            ad2 = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            LblMesaj2.Text = ad2+ " / " + "Konu : " +konu2  ;

            konu3 = db.TBLILETISIM.First(x => x.ID == 3).KONU;
            ad3 = db.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            LblMesaj3.Text = ad3 + " / " + "Konu : " + konu3;

            konu4 = db.TBLILETISIM.First(x => x.ID == 4).KONU;
            ad4 = db.TBLILETISIM.First(x => x.ID == 4).ADSOYAD;
            LblMesaj4.Text = ad4 + " / " + "Konu : " + konu4;

            konu5 = db.TBLILETISIM.First(x => x.ID == 5).KONU;
            ad5= db.TBLILETISIM.First(x => x.ID == 5).ADSOYAD;
            LblMesaj5.Text = ad5 + " / " + "Konu : " + konu5;

     /*       string konu, ad;
            DevExpress.XtraEditors.LabelControl[] label = new DevExpress.XtraEditors.LabelControl[10];
            for (int i=0; i < 10; i++)
            {
                
            }
            label ={ Lblmeaj1,LblMesaj2,LblMesaj3,LblMesaj4,LblMesaj5,LblMesaj6,LblMesaj7,LblMesaj8,LblMesaj9,LblMesaj10};
            for (int i=0; i<10; i++)
            {
                if (db.TBLILETISIM.First(x => x.ID==i+1)!=null)
                    {
                    konu = db.TBLILETISIM.First(x => x.ID == i + 1).KONU;
                    ad = db.TBLILETISIM.First(x => x.ID == i + 1).ADSOYAD;

                    label[i].Text = ad + " / " + "Konu : " + konu;
                }
               
            }
     */
        }
    }
}
