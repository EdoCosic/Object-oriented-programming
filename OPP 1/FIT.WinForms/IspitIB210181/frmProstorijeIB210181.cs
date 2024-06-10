using FIT.Data.IspitIB210181;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IspitIB210181
{
    public partial class frmProstorijeIB210181 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        List<ProstorijeIB210181> prostorije;
        public frmProstorijeIB210181()
        {
            InitializeComponent();
        }

        private void frmProstorijeIB210181_Load(object sender, EventArgs e)
        {
            dgvProstorije.AutoGenerateColumns = false;

            UcitajProstorije();
        }

        private void UcitajProstorije()
        {
            prostorije = db.ProstorijeIB210181.ToList();

            if (prostorije != null)
            {

                var SveNastave = db.NastavaIB210181.ToList();

                for (int i = 0; i < prostorije.Count(); i++)
                {
                    prostorije[i].Broj = SveNastave.Where(x => x.ProstorijaId == prostorije[i].Id).Count();
                }

                dgvProstorije.DataSource = null;
                dgvProstorije.DataSource = prostorije;
            }
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            frmNovaProstorijaIB210181 frmNova = new frmNovaProstorijaIB210181();
            if (frmNova.ShowDialog() == DialogResult.OK)
            {
                UcitajProstorije();
            }
        }

        private void dgvProstorije_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaProstorija = prostorije[e.RowIndex];

            if (e.ColumnIndex != 5 || e.ColumnIndex != 6)
            {
                frmNovaProstorijaIB210181 frmNova = new frmNovaProstorijaIB210181(odabranaProstorija);
                if (frmNova.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }

            }
        }

        private void dgvProstorije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabranaProstorija = prostorije[e.RowIndex];

            if (e.ColumnIndex==5)
            {
                frmNastavaIB210181 frmNastava = new frmNastavaIB210181(odabranaProstorija);
                if (frmNastava.ShowDialog() == DialogResult.OK)
                {
                    UcitajProstorije();
                }               
            }
            else if (e.ColumnIndex==6)
            {
                frmPrisustvoIB210181 frmPrisustvo = new frmPrisustvoIB210181(odabranaProstorija);
                frmPrisustvo.ShowDialog();
            }
        }
    }
}
