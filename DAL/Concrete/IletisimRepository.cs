using DAL.EFCoreContext;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Concrete
{
    public class IletisimRepository
    {
        private readonly MyDbContext _context;
        private DbSet<Iletisim> Table;
        public IletisimRepository(MyDbContext context)
        {
            _context = context;
            Table = _context.Set<Iletisim>();
        }

        public Iletisim GetIletisim()
        {
            return Table.FirstOrDefault();
        }

        public void Update(Iletisim i)
        {
            var iletisim = Table.FirstOrDefault();
            iletisim.Adres = i.Adres;
            iletisim.CalismaSaatleri = i.CalismaSaatleri;
            iletisim.Telefon = i.Telefon;
            Table.Update(iletisim);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
