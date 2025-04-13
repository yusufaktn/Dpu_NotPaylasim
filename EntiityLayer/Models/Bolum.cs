using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiityLayer.Models
{
    public sealed class Bolum
    {
        public Guid ID { get; set; }
        public string BolumAd { get; set; }
        public Guid FakulteID { get; set; } 
        public Fakulte Fakulte { get; set; } 
        public ICollection<Ders> Dersler { get; set; } 
    }
}
