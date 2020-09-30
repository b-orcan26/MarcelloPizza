using Business.Interfaces;
using DAL.Interfaces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KategoriManager : Manager<Kategori> , IKategoriService
    {
        public KategoriManager(IKategoriRepository repository) : base(repository)
        {

        }
    }
}
