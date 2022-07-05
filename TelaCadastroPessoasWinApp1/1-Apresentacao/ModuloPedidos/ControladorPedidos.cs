using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloPedidos;
using Delivery.WinApp1._3_Infra.ModuloCliente;
using Delivery.WinApp1._3_Infra.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.ModuloPedidos;
using Delivery.WinApp1._3_Infra.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.ModuloPedidos
{
    public class ControladorPedidos : ControladorBase
    {
        private RepositorioPedidos repositorioPedidos;
        
        private RepositorioCliente repositorioCliente;
        private RepositorioFuncionario repositorioFuncionario;
        private RepositorioProdutos repositorioProdutos;

        private TabelaPedidosControl tabelaPedidos;

        public ControladorPedidos(RepositorioPedidos repositorioPedidos, RepositorioCliente repositorioCliente, RepositorioFuncionario repositorioFuncionario, RepositorioProdutos repositorioProdutos)
        {
            this.repositorioPedidos = repositorioPedidos;

            this.repositorioCliente = repositorioCliente;
            this.repositorioFuncionario = repositorioFuncionario;
            this.repositorioProdutos = repositorioProdutos;
        }

        public override void Inserir()
        {
            var clientes = repositorioCliente.SelecionarTodos();
            var funcionario = repositorioFuncionario.SelecionarTodos();
            var produtos = repositorioProdutos.SelecionarTodos(); 

            var tela = new TelaCadastroPedidosForm(clientes, funcionario, produtos);

            tela.Pedidos = new Pedidos();

            tela.GravarRegistro = repositorioPedidos.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPedidos();
            }
        }

        public override void Editar()
        {
            var numero = tabelaPedidos.ObtemNumeroPedioSelecionado();

            Pedidos pedidoSelecionado = repositorioPedidos.SelecionarPorId(numero);

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Selecione um pedido primeiro",
                "Edição de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var clientes = repositorioCliente.SelecionarTodos();
            var funcionario = repositorioFuncionario.SelecionarTodos();
            var produtos = repositorioProdutos.SelecionarTodos();

            var tela = new TelaCadastroPedidosForm(clientes, funcionario, produtos);

            tela.Pedidos = pedidoSelecionado;

            tela.GravarRegistro = repositorioPedidos.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarPedidos();
            }
        }

        public override void Excluir()
        {
            var numero = tabelaPedidos.ObtemNumeroPedioSelecionado();

            Pedidos pedidoSelecionado = repositorioPedidos.SelecionarPorId(numero);

            if (pedidoSelecionado == null)
            {
                MessageBox.Show("Selecione um pedido primeiro",
                "Exclusão de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o pedido?",
               "Exclusão de Pedido", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioPedidos.Excluir(pedidoSelecionado);
                CarregarPedidos();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxPedidos();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaPedidos == null)
                tabelaPedidos = new TabelaPedidosControl();

            CarregarPedidos();

            return tabelaPedidos;
        }

        private void CarregarPedidos()
        {
            List<Pedidos> pedidos = repositorioPedidos.SelecionarTodos();

            tabelaPedidos.AtualizarRegistros(pedidos);

            TelaInicioForm.Instancia.AtualizarRodape($"Visualizando {pedidos.Count} Pedido(s)");
        }

    }
}
