using Delivery.WinApp1._2_Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public Funcionario(string nome, string cargo, string cpf, double salario, DateTime dataNascimento):this()
        {
            Nome = nome;
            Cargo = cargo;
            CPF = cpf;
            Salario = salario;
            DataNascimento = dataNascimento;
            
        }
        public Funcionario()
        {

        }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void Atualizar(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Cargo = funcionario.Cargo;
            CPF = funcionario.CPF;
            Salario = funcionario.Salario;
            DataNascimento = funcionario.DataNascimento;
        }

        public override bool Equals(object? obj)
        {
            return obj is Funcionario funcionario &&
                   Id == funcionario.Id &&
                   Nome == funcionario.Nome &&
                   Cargo == funcionario.Cargo &&
                   CPF == funcionario.CPF &&
                   Salario == funcionario.Salario &&
                   DataNascimento == funcionario.DataNascimento;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Cargo, CPF, Salario, DataNascimento);
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
