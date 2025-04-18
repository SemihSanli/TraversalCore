using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen başlığı boş geçmeyin");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen En Az 5 karakter girişi yapın ");
            RuleFor(x => x.Subject).MinimumLength(20).WithMessage("Lütfen En Az 20 karakter girişi yapın ");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen En Fazla 50 karakter girişi yapın ");
            RuleFor(x => x.Subject).MaximumLength(500).WithMessage("Lütfen En Fazla 500 karakter girişi yapın ");
        }
    }
}
