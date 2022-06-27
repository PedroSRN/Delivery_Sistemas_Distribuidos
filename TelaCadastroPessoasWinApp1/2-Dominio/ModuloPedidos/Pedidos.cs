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
        public Pedidos(Clientes cliente, Produtos produtos, Funcionario funcionario, string obsetvacao):this()
        {
            Cliente = cliente;
            Produtos = produtos;
            Funcionario = funcionario;
            Observacao = obsetvacao;
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
    }
   
}
