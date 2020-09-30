using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UrunAddValidator : AbstractValidator<UrunAddDTO>
    {
        public UrunAddValidator()
        {
            RuleFor(i => i.Ad).MaximumLength(120).WithMessage("Ad alanı 120 karakterden fazla olamaz");
            RuleFor(i => i.Ad).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(i => i.Icindekiler).MaximumLength(220).WithMessage("Içindekiler alanı 220 karakterden fazla olamaz");
            RuleFor(i => i.Icindekiler).NotNull().WithMessage("İçindekiler alanı boş geçilemez");
            RuleFor(i => i.KategoriId).NotNull().WithMessage("Kategori alanı boş geçilemez");
            RuleFor(i => i.Fiyat).NotNull().WithMessage("Fiyat alanı boş geçilemez");
        }
    }
}
