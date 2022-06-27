using Delivery.WinApp1._2_Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloClientes
{
    public class Clientes : EntidadeBase<Clientes>
    {
        public Clientes(string nome, string telefone, string cpf, string endereco):this()
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Endereco = endereco;
        }
        public Clientes()
        {

        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }

        public override void Atualizar(Clientes cliente)
        {
           Nome = cliente.Nome;
           Telefone = cliente.Telefone;
           CPF = cliente.CPF;
           Endereco = cliente.Endereco;
        }
    }
}
