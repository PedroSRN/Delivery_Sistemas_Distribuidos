﻿using Delivery.WinApp1._2_Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloFuncionario
{
    public class Funcionario : EntidadeBase<Funcionario>
    {
        public Funcionario(string nome, string cargo, string cpf, decimal salario, DateTime dataNascimento):this()
        {
            Nome = nome;
            Cargo = cargo;
            Cpf = cpf;
            Salario = salario;
            DataNascimento = dataNascimento;
            
        }
        public Funcionario()
        {

        }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Cpf { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void Atualizar(Funcionario funcionario)
        {
           Nome = funcionario.Nome;
           Cargo = funcionario.Cargo;
           Cpf = funcionario.Cpf;
           Salario = funcionario.Salario;
           DataNascimento = funcionario.DataNascimento;
        }
    }
}