using AutoMapper;
using DTO;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NicePageRestaurant.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<UrunAddDTO, Urun>();
            CreateMap<Urun, UrunAddDTO>();

            CreateMap<Kategori, KategoriAddDTO>();
            CreateMap<KategoriAddDTO, Kategori>();

            CreateMap<UrunListDTO, Urun>();
            CreateMap<Urun, UrunListDTO>();

            CreateMap<UrunGuncelleDTO, Urun>();
            CreateMap<Urun, UrunGuncelleDTO>();

            CreateMap<Kategori, KategoriListDTO>();
            CreateMap<KategoriListDTO, Kategori>();
        }
    }
}
