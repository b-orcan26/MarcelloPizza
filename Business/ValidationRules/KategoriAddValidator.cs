using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class KategoriAddValidator : AbstractValidator<KategoriAddDTO>
    {
        public KategoriAddValidator()
        {
            RuleFor(i => i.Ad).MaximumLength(100).WithMessage("Kategori adı 100 karakterden fazla olamaz");
            RuleFor(i => i.Ad).NotNull().WithMessage("Kategori adı alanı boş geçilemez");
        }
    }
}
