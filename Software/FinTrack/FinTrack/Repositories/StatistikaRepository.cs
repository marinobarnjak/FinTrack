using FinTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using DBLayer;
using FinTrack.Repositories;

namespace FinTrack.Repositories
{
        public static class StatistikaRepository
        {
            public static List<Statistika> IzracunajStatistiku(List<Unos> unosi)
            {
                var statistika = new List<Statistika>();

                var ukupniIznos = unosi.Sum(u => u.Iznos);

                var grupe = unosi.GroupBy(u => u.Kategorija.Naziv);

                foreach (var grupa in grupe)
                {
                    var ukupniIznosKategorije = grupa.Sum(u => u.Iznos);
                    statistika.Add(new Statistika 
                    {
                        KategorijaNaziv = grupa.Key,
                        UkupanIznos = ukupniIznosKategorije,
                        Postotak = (float)(ukupniIznosKategorije / ukupniIznos * 100)
                    });
                }

                return statistika;
            }     
        }
}
