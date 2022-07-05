using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._2_Dominio.ModuloPedidos;
using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Data.SqlClient;


namespace Delivery.WinApp1._3_Infra.ModuloPedidos
{
    public class MapeadorPedidos : MapeadorBase<Pedidos>
    {
        public override void ConfigurarParametros(Pedidos novoPedido, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", novoPedido.Id);
            comando.Parameters.AddWithValue("OBSERVACAO", novoPedido.Observacao);

            comando.Parameters.AddWithValue("CLIENTE_ID", novoPedido.Cliente.Id);
            comando.Parameters.AddWithValue("PRODUTOS_ID", novoPedido.Produtos.Id);
            comando.Parameters.AddWithValue("FUNCIONARIO_ID", novoPedido.Funcionario.Id);

        }

        public override Pedidos ConverterRegistro(SqlDataReader leitorPedidos)
        {
            var id = Convert.ToInt32(leitorPedidos["ID"]);
            var observacao = Convert.ToString(leitorPedidos["OBSERVACAO"]);

            var idCliente = Convert.ToInt32(leitorPedidos["ID_CLIENTE"]);
            var nomeCliente = Convert.ToString(leitorPedidos["NOME_CLIENTE"]);
            var enderecoCliente = Convert.ToString(leitorPedidos["ENDERECO_CLIENTE"]);

            var idProduto = Convert.ToInt32(leitorPedidos["ID_PRODUTO"]);
            var nomeProduto = Convert.ToString(leitorPedidos["NOME_PRODUTO"]);

            var idFuncionario = Convert.ToInt32(leitorPedidos["ID_FUNCIONARIO"]);
            var nomeFuncionario = Convert.ToString(leitorPedidos["NOME_FUNCIONARIO"]);


            var cliente = new Clientes
            {
                Id = idCliente,
                Nome = nomeCliente,
                Endereco = enderecoCliente,
            };

            var produto = new Produtos
            {
                Id = idProduto,
                Nome = nomeProduto,
            };

            var funcionario = new Funcionario
            {
                Id = idFuncionario,
                Nome = nomeFuncionario,
            };

            var pedido = new Pedidos
            {
                Id = id,
                Observacao = observacao,
            };

             
            pedido.ConfigurarCliente(cliente);
            pedido.ConfigurarProduto(produto);
            pedido.ConfigurarFuncionario(funcionario);


            return pedido;
        }
    }
}
