using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NicePageRestaurant.Controllers
{
    [Authorize]
    public class UrunController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUrunService urunService;
        private readonly IKategoriService kategoriService;
        public UrunController(IMapper _mapper , IUrunService _urunService , IKategoriService _kategoriService)
        {
            mapper = _mapper;
            urunService = _urunService;
            kategoriService = _kategoriService;
        }

        public async Task<IActionResult> Index()
        {
            var liste = mapper.Map<List<UrunListDTO>>(await urunService.AllUrunWithKategori());
            return View(liste);
        }

        public async Task<IActionResult> UrunEkle()
        {
            var kategoriler = await kategoriService.All();
            ViewBag.Kategoriler = new SelectList(kategoriler, "Id", "Ad");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UrunEkle(UrunAddDTO model)
        {
            if (ModelState.IsValid)
            {
                var urun = mapper.Map<Urun>(model);
                await urunService.Add(urun);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UrunSil(int id)
        {
            await urunService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UrunDuzenle(int id)
        {
            var urun = await urunService.GetById(id);
            var kategoriler = await kategoriService.All();
            ViewBag.Kategoriler = new SelectList(kategoriler, "Id", "Ad");
            return View(mapper.Map<UrunGuncelleDTO>(urun));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UrunDuzenle(UrunGuncelleDTO model , IFormFile Resim)
        {
            if (ModelState.IsValid)
            {
                var urun = mapper.Map<Urun>(model);
                if (Resim != null)
                {

                    var baseImagePath= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/");
                    if (urun.ResimYolu != null)
                    {
                        var oldImagePath = Path.Combine(baseImagePath, urun.ResimYolu);

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                  
                    var uzanti = Path.GetExtension(Resim.FileName);
                    var resimAdi = Guid.NewGuid() + uzanti;
                    var imagePath = Path.Combine(baseImagePath, resimAdi);
                    using var stream = new FileStream(imagePath, FileMode.Create);
                    await Resim.CopyToAsync(stream);
                    urun.ResimYolu = resimAdi;
                }                
                await urunService.Update(urun);
                return RedirectToAction("Index");
            }
            var kategoriler = await kategoriService.All();
            ViewBag.Kategoriler = new SelectList(kategoriler, "Id", "Ad");
            return View(model);
        }


    }
}
