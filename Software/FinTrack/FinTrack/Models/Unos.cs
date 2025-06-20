using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTrack.Models
{
    public class Unos
    {
        public int Id { get; set; }
        public string Vrsta { get; set; } // Prihod/Rashod
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public decimal Iznos { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
    }
    
}
