using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUrunRepository : IRepository<Urun>
    {
        Task<List<Urun>> GetUrunsByKategoriId(int id);
        Task<List<Urun>> AllUrunWithKategori();
    }
}
