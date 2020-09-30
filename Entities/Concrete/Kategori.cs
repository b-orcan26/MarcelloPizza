using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kategori : ITable
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Aciklama { get; set; }

        public string Logo { get; set; }

        public virtual List<Urun> Uruns { get; set; }
    }
}
