using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UrunListDTO
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Icindekiler { get; set; }

        public double Fiyat { get; set; }

        public string ResimYolu { get; set; }

        public Kategori Kategori { get; set; }

    }
}
