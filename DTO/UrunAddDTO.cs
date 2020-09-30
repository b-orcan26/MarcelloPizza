using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UrunAddDTO
    {
        public string Ad { get; set; }
        public string Icindekiler { get; set; }

        public double Fiyat { get; set; }

        public string ResimYolu { get; set; }

        public int KategoriId { get; set; }
    }
}
