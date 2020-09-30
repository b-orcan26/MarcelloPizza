using DAL.EFCoreContext;
using DAL.Interfaces;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class UrunRepository : Repository<Urun>, IUrunRepository
    {
        public UrunRepository(MyDbContext _db) : base(_db)
        {

        }

        public async Task<List<Urun>> GetUrunsByKategoriId(int id)
        {
            var liste = db.Uruns.ToList();           
            return await db.Uruns.Where(i => i.KategoriId == id).ToListAsync();
        }

        public async Task<List<Urun>> AllUrunWithKategori()
        {
            return await db.Uruns.Include(i => i.Kategori).ToListAsync();
        }

    }
}
