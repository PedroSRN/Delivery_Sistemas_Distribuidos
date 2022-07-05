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
                
	   }
    }
}
