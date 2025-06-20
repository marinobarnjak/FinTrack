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
using FinTrack.Models;

namespace FinTrack
{
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
                cboMjesec.Items.Add(i);
            cboMjesec.SelectedIndex = DateTime.Now.Month - 1; 

            for (int godina = 2020; godina <= DateTime.Now.Year; godina++)
                cboGodina.Items.Add(godina);
            cboGodina.SelectedItem = DateTime.Now.Year;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (cboMjesec.SelectedIndex == -1 || cboGodina.SelectedIndex == -1)
            {
                MessageBox.Show("Molimo odaberite mjesec i godinu.");
                return;
            }

            int mjesec = (int)cboMjesec.SelectedItem;   
            int godina = (int)cboGodina.SelectedItem;   

            var unosi = UnosRepository.GetUnosiByMonthByYear(mjesec, godina);
            var statistika = StatistikaRepository.IzracunajStatistiku(unosi);

            dgvStatistika.DataSource = statistika;
            dgvStatistika.Columns["KategorijaNaziv"].HeaderText = "Kategorija";
            dgvStatistika.Columns["UkupanIznos"].HeaderText = "Ukupan Iznos";
            dgvStatistika.Columns["Postotak"].HeaderText = "Postotak (%)";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
