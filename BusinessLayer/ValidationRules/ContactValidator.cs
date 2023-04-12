using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactUserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Konu Adını boş geçemezsiniz.");
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz.");
            RuleFor(x => x.ContactSubject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.ContactUserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter giriniz");
            RuleFor(x => x.ContactSubject).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter giriniz");
        }
    }
}
