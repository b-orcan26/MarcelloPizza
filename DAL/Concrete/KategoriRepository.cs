using DAL.EFCoreContext;
using DAL.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Concrete
{
    public class KategoriRepository : Repository<Kategori> , IKategoriRepository
    {
        public KategoriRepository(MyDbContext _db) : base(_db)
        {

        }
    }
}
