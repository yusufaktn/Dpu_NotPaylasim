using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiityLayer.Models
{
    public sealed class Fakulte
    {
        public Guid ID { get; set; }
        public string FakülteAd { get; set; }
        public Guid UniversiteID { get; set; }
        public Universite Universite { get; set; } 
        public ICollection<Bolum> Bolumler { get; set; } 

    }
}
