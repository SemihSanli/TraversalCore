using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Kısmını Boş Bırakamazsınız ....!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçimi Yapınız ....!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("En Az 50 Karakter Girişi Yapmalısınız ....!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("1500 Karakter Sınırını Aştınız ....!");
        }
    }
}
