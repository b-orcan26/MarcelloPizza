using Business.Interfaces;
using DAL.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UrunManager : Manager<Urun> , IUrunService
    {
        private readonly IUrunRepository urunRepository;
        public UrunManager(IUrunRepository repository):base(repository)
        {
            urunRepository = repository;
        }

        public async Task<List<Urun>> AllUrunWithKategori()
        {
            return await urunRepository.AllUrunWithKategori();
        }

        public async Task<List<Urun>> GetUrunsByKategoriId(int id)
        {
            return await urunRepository.GetUrunsByKategoriId(id);
        }
    }
}
