using DAL.EFCoreContext;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete
{
    public class HakkimizdaRepository
    {
        private readonly MyDbContext _context;
        private DbSet<Hakkimizda> Table;
        public HakkimizdaRepository(MyDbContext context)
        {
            _context = context;
            Table = _context.Set<Hakkimizda>();
        }

        public Hakkimizda GetHakkimizda()
        {
            return Table.FirstOrDefault();
        }

        public void Update(Hakkimizda h)
        {
            var hakkimizda = Table.FirstOrDefault();
            hakkimizda.Baslik = h.Baslik;
            hakkimizda.Aciklama1 = h.Aciklama1;
            hakkimizda.Aciklama2 = h.Aciklama2;
            Table.Update(hakkimizda);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }



    }
}
