using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloClientes
{
    public class ValidadorCliente : AbstractValidator<Clientes>
    {
       public ValidadorCliente ()
	   {
            RuleFor(x => x.Nome)
               .Matches(new Regex(@"^([^0-9]*)$"))
               .NotEmpty()
               .MinimumLength(3);

            RuleFor(x => x.Telefone)
              .NotEmpty()
              .Matches(new Regex(@"\d{4,5}\-\d{4}"));

            RuleFor(x => x.CPF)
                .NotEmpty()
                 .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"));

            RuleFor(x => x.Endereco)
               .NotEmpty()
               .MinimumLength(3);



        }
    }
}
