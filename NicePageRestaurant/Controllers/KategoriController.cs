using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NicePageRestaurant.Controllers
{
    [Authorize]
    public class KategoriController : Controller
    {
        private readonly IKategoriService kategoriService;
        private readonly IMapper mapper;
        public KategoriController(IKategoriService _kategoriService , IMapper _mapper)
        {
            kategoriService = _kategoriService;
            mapper = _mapper;
        }
        public async Task<IActionResult> Index()
        {
            var list = await kategoriService.All();
            return View(list);
        }


        public IActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KategoriEkle(KategoriAddDTO model , IFormFile Logo)
        {
            if (ModelState.IsValid)
            {
                var kategori = mapper.Map<Kategori>(model);

                if (Logo != null)
                {
                    var uzanti = Path.GetExtension(Logo.FileName);
                    var resimAd = Guid.NewGuid() + uzanti;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/logo/" + resimAd);
                    using var stream = new FileStream(path, FileMode.Create);
                    await Logo.CopyToAsync(stream);
                    kategori.Logo = resimAd;
                }

                await kategoriService.Add(kategori);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> KategoriDuzenle(int id)
        {
            var kategori = await kategoriService.GetById(id);
            return View(kategori);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KategoriDuzenle(Kategori k , IFormFile Logo)
        {
            if (ModelState.IsValid)
            {
                if (Logo != null)
                {
                    string fileDirectory = Path.Combine(
                      Directory.GetCurrentDirectory(), "wwwroot/logo/");

                    string fullPath = fileDirectory + k.Logo;

                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.File.Delete(fullPath);                        
                    }
                    var uzanti = Path.GetExtension(Logo.FileName);
                    var fileName = Guid.NewGuid() + uzanti;

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/logo/" + fileName);
                    using var stream = new FileStream(path, FileMode.Create);
                    await Logo.CopyToAsync(stream);
                    k.Logo = fileName;
                }
                await kategoriService.Update(k);
                return RedirectToAction("Index");
            }
            return View(k);
        }

    }
}
