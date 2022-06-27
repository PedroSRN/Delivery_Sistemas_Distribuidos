using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloCliente
{
    public class MapeadorCliente : MapeadorBase<Clientes>
    {
        public override void ConfigurarParametros(Clientes clientes, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", clientes.Id);
            comando.Parameters.AddWithValue("NOME", clientes.Nome);
            comando.Parameters.AddWithValue("TELEFONE", clientes.Telefone);
            comando.Parameters.AddWithValue("CPF", clientes.CPF);
            comando.Parameters.AddWithValue("ENDERECO", clientes.Endereco);
        }

        public override Clientes ConverterRegistro(SqlDataReader leitorCliente)
        {
            var id = Convert.ToInt32(leitorCliente["ID"]);
            var nome = Convert.ToString(leitorCliente["NOME"]);
            var telefone = Convert.ToString(leitorCliente["TELEFONE"]);
            var cpf = Convert.ToString(leitorCliente["CPF"]);
            var endereco = Convert.ToString(leitorCliente["ENDERECO"]);

            Clientes clientes = new Clientes();
            clientes.Id = id;
            clientes.Nome = nome;
            clientes.Telefone = telefone;
            clientes.CPF = cpf;
            clientes.Endereco = endereco;

            return clientes;
        }
    }
}
