using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Urun : ITable
    {
        public int Id { get; set; }

        public string Ad { get; set; }
        public string Icindekiler { get; set; }

        public double Fiyat { get; set; }

        public string ResimYolu { get; set; }

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }
    }
}
