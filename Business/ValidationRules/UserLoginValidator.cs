using DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules
{
    public class UserLoginValidator : AbstractValidator<UserLoginDTO>
    {

        public UserLoginValidator()
        {
            RuleFor(i => i.Username).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(i => i.Password).NotEmpty().WithMessage("Parola alanı boş geçilemez");
        }
    }
}
