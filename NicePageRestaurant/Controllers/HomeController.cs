using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using AutoMapper;
using Business.Concrete;
using Business.Interfaces;
using DAL.EFCoreContext;
using DTO;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NicePageRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUrunService urunService;
        private readonly IKategoriService kategoriService;
        private readonly IMapper mapper;
        private HakkimizdaManager hakkimizdaService;
        private IletisimManager iletisimService;

        public HomeController(IUrunService _urunService , IMapper _mapper , IKategoriService _kategoriService)
        {
            urunService = _urunService;
            mapper = _mapper;
            kategoriService = _kategoriService;
            hakkimizdaService = new HakkimizdaManager(new MyDbContext());
            iletisimService = new IletisimManager(new MyDbContext());
        }


        public async Task<IActionResult> Index()
        {
            
            var kategoriList = await kategoriService.All();
            var dtoList = mapper.Map<List<KategoriListDTO>>(kategoriList);
            return View(dtoList);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UrunAddDTO model,IFormFile Resim)
        {
            if (ModelState.IsValid)
            {
                var urun = mapper.Map<Urun>(model);

                if (Resim != null)
                {
                    string uzanti = Path.GetExtension(Resim.FileName);
                    string resimAd = Guid.NewGuid() + uzanti;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + resimAd);
                    using var stream = new FileStream(path, FileMode.Create);
                    await Resim.CopyToAsync(stream);
                    urun.ResimYolu = resimAd;
                }                
                await urunService.Add(urun);
                return RedirectToAction("Urunler");
            }
            return View(model);
        }
        
        public async Task<IActionResult> Urunler(int? id)
        {
            List<UrunListDTO> liste = mapper.Map<List<UrunListDTO>>(await urunService.AllUrunWithKategori());
            ViewBag.Kategoriler = await kategoriService.All();
            ViewBag.KategoriId = id;
            return View(liste);
        }

        public IActionResult Hakkimizda()
        {
            var hakkimizda = hakkimizdaService.GetHakkimizda();
            return View(hakkimizda);
        }

        public IActionResult Iletisim()
        {
            var iletisim = iletisimService.GetIletisim();
            return View(iletisim);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
