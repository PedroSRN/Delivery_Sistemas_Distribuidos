using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloFuncionario
{
    public class MapeadorFuncionario : MapeadorBase<Funcionario>
    {
        public override void ConfigurarParametros(Funcionario funcionario, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", funcionario.Id);
            comando.Parameters.AddWithValue("NOME", funcionario.Nome);
            comando.Parameters.AddWithValue("CARGO", funcionario.Cargo);
            comando.Parameters.AddWithValue("CPF", funcionario.CPF);
            comando.Parameters.AddWithValue("SALARIO", funcionario.Salario);
            comando.Parameters.AddWithValue("DATANASCIMENTO", funcionario.DataNascimento);
        }

        public override Funcionario ConverterRegistro(SqlDataReader leitorFuncionario)
        {
            var id = Convert.ToInt32(leitorFuncionario["ID"]);
            var nome = Convert.ToString(leitorFuncionario["NOME"]);
            var cargo = Convert.ToString(leitorFuncionario["CARGO"]);
            var cpf = Convert.ToString(leitorFuncionario["CPF"]);
            var salario = Convert.ToDouble(leitorFuncionario["SALARIO"]);
            var dataNascimento = Convert.ToDateTime(leitorFuncionario["DATANASCIMENTO"]);

            Funcionario funcionario = new Funcionario();
            funcionario.Id = id;
            funcionario.Nome = nome;
            funcionario.Cargo = cargo;
            funcionario.CPF = cpf;
            funcionario.Salario = salario;
            funcionario.DataNascimento = dataNascimento;

            return funcionario;
        }
    }
}
