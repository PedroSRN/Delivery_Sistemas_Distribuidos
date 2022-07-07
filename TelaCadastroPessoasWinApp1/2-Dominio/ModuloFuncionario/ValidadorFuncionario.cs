using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloFuncionario
{
    public class ValidadorFuncionario : AbstractValidator<Funcionario>
    {
        public ValidadorFuncionario()
        {
            RuleFor(x => x.Nome)
              .Matches(new Regex(@"^([^0-9]*)$"))
              .NotEmpty()
              .MinimumLength(3);

            RuleFor(x => x.Cargo)
              .Matches(new Regex(@"^([^0-9]*)$"))
              .NotEmpty()
              .MinimumLength(3);

            RuleFor(x => x.CPF)
              .NotEmpty()
              .Matches(new Regex(@"[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"));

            RuleFor(x => x.Salario)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(x => x.DataNascimento)
                .LessThan(x => DateTime.Now.AddYears(-18)) // O FUNCIONARIO DEVE TER NO MINIMO 18 ANOS
                .NotNull()
                .NotEmpty();

        }
    }
}
