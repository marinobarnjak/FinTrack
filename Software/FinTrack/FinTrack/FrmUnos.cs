using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using FinTrack.Repositories;
using FinTrack.Models;

namespace FinTrack
{
    public partial class FrmUnos : Form
    {

        public FrmUnos()
        {
            InitializeComponent();
        }

        private Unos trenutniUnos; // Trenutni unos koji se uređuje ili unosi novi
        public FrmUnos(Unos u)
        { // Konstruktor koji prima trenutni unos za uređivanje
            InitializeComponent();
            trenutniUnos = u; // Postavlja trenutni unos na uneseni objekt
        }

        private void FrmUnos_Load(object sender, EventArgs e)
        {
            
                DB.SetConfiguration(
                    "PI2425_mbarnjak23_DB",        
                    "PI2425_mbarnjak23_User",
                    "L(if;@Q@"
                );
            
            cboKategorija.DataSource = KategorijaRepository.GetKategorije();
            cboKategorija.DisplayMember = "Naziv";  
            cboKategorija.ValueMember = "Id";

            if(trenutniUnos != null)
            {
                dtpDatum.Value = trenutniUnos.Datum;
                txtOpis.Text = trenutniUnos.Opis;
                txtIznos.Text = trenutniUnos.Iznos.ToString();
                cboKategorija.SelectedValue = trenutniUnos.KategorijaId;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPregledUnosa_Click(object sender, EventArgs e)
        {
            FrmPregledUnosa pregled = new FrmPregledUnosa();   
            pregled.ShowDialog();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            if (trenutniUnos == null)
            {
                var unos = new Unos
                {
                    Vrsta = txtVrsta.Text,
                    Opis = txtOpis.Text,
                    Iznos = decimal.Parse(txtIznos.Text),
                    KategorijaId = (int)cboKategorija.SelectedValue,
                    Datum = dtpDatum.Value
                };

                UnosRepository.InsertUnos(unos);
                MessageBox.Show("Unos spremljen.");
            }
            else
            {
                trenutniUnos.Vrsta = txtVrsta.Text;
                trenutniUnos.Opis = txtOpis.Text;
                trenutniUnos.Iznos = decimal.Parse(txtIznos.Text);
                trenutniUnos.KategorijaId = (int)cboKategorija.SelectedValue;
                trenutniUnos.Datum = dtpDatum.Value;
                UnosRepository.UpdateUnos(trenutniUnos);
                MessageBox.Show("Unos ažuriran.");
            }
        }
    }
}
