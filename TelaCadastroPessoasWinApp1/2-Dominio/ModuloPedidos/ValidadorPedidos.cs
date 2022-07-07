using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloPedidos
{
    public class ValidadorPedidos : AbstractValidator<Pedidos>
    {
        public ValidadorPedidos()
        {
            RuleFor(x => x.Cliente.Nome)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.Cliente.Endereco)
               .NotEmpty()
               .NotNull(); 

            RuleFor(x => x.Funcionario)
               .NotEmpty()
               .NotNull();

            RuleFor(x => x.Produtos)
               .NotEmpty()
               .NotNull();

            RuleFor(x => x.Observacao)
               .Matches(new Regex(@"^([^0-9]*)$"))
               .NotEmpty();
               
        }
    }
}
