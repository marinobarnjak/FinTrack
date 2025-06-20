using DBLayer;
using FinTrack.Models;
using FinTrack.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrack
{
    public partial class FrmPregledUnosa : Form
    {
        
        public FrmPregledUnosa()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmPregledUnosa_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration(
                    "PI2425_mbarnjak23_DB",
                    "PI2425_mbarnjak23_User",
                    "L(if;@Q@"
                );



            dgvUnosi.DataSource = UnosRepository.GetUnosi();
            dgvUnosi.Columns["Id"].Visible = false;
            dgvUnosi.Columns["KategorijaId"].Visible = false;

        }

        private void dgvUnosi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvUnosi.SelectedRows.Count > 0)
            {
                var unos = dgvUnosi.SelectedRows[0].DataBoundItem as Models.Unos; 
                                                                                  
                if (unos != null) 
                {
                    var result = MessageBox.Show($"Jeste li sigurni da želite obrisati unos '{unos.Opis}'?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        UnosRepository.DeleteUnos(unos.Id);
                        dgvUnosi.DataSource = UnosRepository.GetUnosi(); 
                    }
                }
                else
                {
                    MessageBox.Show("Molimo odaberite unos za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string pojam = txtPretraga.Text.Trim();// uklanja praznine s početka i kraja unosa

            if (string.IsNullOrWhiteSpace(pojam))// provjerava je li unos prazan ili sadrži samo praznine
            {
                dgvUnosi.DataSource = UnosRepository.GetUnosi(); 
            }
            else
            {
                dgvUnosi.DataSource = UnosRepository.SearchUnosi(pojam); 
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
           if(dgvUnosi.SelectedRows.Count > 0) //provjerava ako je redak odabran
            {                       //uzimamo prvi odabrani redak
                var unos = dgvUnosi.SelectedRows[0].DataBoundItem as Models.Unos; // pretvara odabrani redak u objekt Unos
                if (unos != null)                                                   //databounditem predstavlja objekt koji je vezan uz redak, as models.unos pretvara ga u objekt Unos
                {
                    FrmUnos frmUnos = new FrmUnos(unos); //kreiramo novi form FrmUnos i prosljeđujemo mu odabrani unos
                    frmUnos.ShowDialog(); 
                    dgvUnosi.DataSource = UnosRepository.GetUnosi(); // osvježavamo podatke u DataGridView nakon uređivanja
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite unos za uređivanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            var frmStatistika = new FrmStatistika();
            frmStatistika.ShowDialog(); 
        }
    }
}
