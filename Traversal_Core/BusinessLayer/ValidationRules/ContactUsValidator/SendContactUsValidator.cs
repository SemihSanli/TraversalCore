﻿using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUsValidator
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDTO>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail Alanı Boş Geçilemez");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanı Boş Geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Alanı Boş Geçilemez");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj Alanı Boş Geçilemez");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("En Az 5 Karakterlik Veri Girişi Yapmalısınız");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En Fazla 100 Karakterlik Veri Girişi Yapmalısınız");
            RuleFor(x => x.Mail).MinimumLength(5).WithMessage("En Az 5 Karakterlik Veri Girişi Yapmalısınız");
            RuleFor(x => x.Mail).MaximumLength(100).WithMessage("En Fazla 100 Karakterlik Veri Girişi Yapmalısınız");
        }
    }
}
