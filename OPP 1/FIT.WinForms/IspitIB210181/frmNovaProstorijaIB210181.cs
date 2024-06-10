using FIT.Data;
using FIT.Data.IspitIB210181;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
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
    public partial class frmNovaProstorijaIB210181 : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private ProstorijeIB210181 odabranaProstorija;

        public frmNovaProstorijaIB210181()
        {
            InitializeComponent();
        }

        public frmNovaProstorijaIB210181(ProstorijeIB210181 odabranaProstorija)
        {
            InitializeComponent();
            this.odabranaProstorija = odabranaProstorija;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;
                var oznaka = txtOznaka.Text;
                var kapacitet = int.Parse(txtKapacitet.Text);
                var logo = Ekstenzije.ToByteArray(pbLogo.Image);

                if (odabranaProstorija == null)
                {
                    var novaProstorija = new ProstorijeIB210181()
                    {

                        Naziv = naziv,
                        Oznaka = oznaka,
                        Kapacitet = kapacitet,
                        Logo = logo

                    };

                    db.ProstorijeIB210181.Add(novaProstorija);
                }
                else 
                {
                    odabranaProstorija.Oznaka = oznaka;
                    odabranaProstorija.Kapacitet = kapacitet;
                    odabranaProstorija.Naziv = naziv;
                    odabranaProstorija.Logo = logo;

                    db.Entry(odabranaProstorija).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                
                }
               
                db.SaveChanges();

                DialogResult = DialogResult.OK;
            }
        }

        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbLogo, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtKapacitet, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtOznaka, err, Kljucevi.ReqiredValue);
        }

        private void pbLogo_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaProstorijaIB210181_Load(object sender, EventArgs e)
        {
            UcitajInfo();
        }

        private void UcitajInfo()
        {

            if (odabranaProstorija!=null)
            {
                txtKapacitet.Text = odabranaProstorija.Kapacitet.ToString();
                txtNaziv.Text = odabranaProstorija.Naziv;
                txtOznaka.Text = odabranaProstorija.Oznaka;
                pbLogo.Image = odabranaProstorija.Logo.ToImage();
            }
        }
    }
}
