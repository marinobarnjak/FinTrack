using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace FinTrack.Models
{
    public class Statistika
    {
        public string KategorijaNaziv { get; set; }
        public decimal UkupanIznos { get; set; }
        public float Postotak { get; set; }
    }
}
