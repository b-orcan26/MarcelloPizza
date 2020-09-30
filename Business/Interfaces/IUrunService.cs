using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUrunService : IService<Urun>
    {
        Task<List<Urun>> GetUrunsByKategoriId(int id);
        Task<List<Urun>> AllUrunWithKategori();
    }
}
