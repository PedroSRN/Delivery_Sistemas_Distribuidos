using Delivery.WinApp1._2_Dominio.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloPedidos
{
    public class Pedidos : EntidadeBase<Pedidos>
    {
        public Pedidos(Clientes cliente, Produtos produtos, Funcionario funcionario, string observacao):this()
        {
            Cliente = cliente;
            Produtos = produtos;
            Funcionario = funcionario;
            Observacao = observacao;
      
        }

        public Pedidos()
        {

        }

        public Clientes Cliente { get; set; }
        public Produtos Produtos { get; set; }
        public Funcionario Funcionario { get; set; }
        public string Observacao { get; set; }


        public override void Atualizar(Pedidos pedido)
        {
            Cliente = pedido.Cliente;
            Produtos = pedido.Produtos;
            Funcionario = pedido.Funcionario;
            Observacao = pedido.Observacao;
        }

       
        public void ConfigurarCliente(Clientes cliente)
        {
            if (cliente == null)
                return;
            Cliente = cliente;
        }

        public void ConfigurarProduto(Produtos produto)
        {
            if (produto == null)
                return;
            Produtos = produto;
        }

        public void ConfigurarFuncionario(Funcionario funcionario)
        {
            if (funcionario == null)
                return;
            Funcionario = funcionario;
        }

        public override string ToString()
        {
            return Cliente.Nome;
        }
    }
}
