using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloProdutos
{
    public class ValidadorProdutos : AbstractValidator<Produtos>
    {
        public ValidadorProdutos()
        {
            RuleFor(x => x.Nome)
              .Matches(new Regex(@"^([^0-9]*)$"))
              .NotEmpty()
              .MinimumLength(3);

            RuleFor(x => x.Preco)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(x => x.Quantiade)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(x => x.TipoDoProdutor)
                .NotEmpty()
                .NotNull();
                





        }
    }
}
