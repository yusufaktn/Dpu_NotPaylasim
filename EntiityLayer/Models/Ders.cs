﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntiityLayer.Models
{
    public sealed class Ders
    {
        public Guid DersID { get; set; }
        public string DersAd { get; set; }       
        public string Donem { get; set; }
        public Guid BolümID { get; set; }
        public Bolum Bolum { get; set; }
        public ICollection<DersNotu> DersNotlar { get; set; }
        public ICollection<OgretmenDersler> OgretmenDersleriAtanan { get; set; } 

    }
}
