using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using Delivery.WinApp1._3_Infra.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.ModuloProdutos
{
    public class ControladorProdutos : ControladorBase
    {
        private RepositorioProdutos repositorioProdutos;
        private TabelaProdutosControl tabelaProdutos;

        public ControladorProdutos(RepositorioProdutos repositorioProdutos)
        {
            this.repositorioProdutos = repositorioProdutos;
        }

        public override void Inserir()
        {
            var tela = new TelaCadastroProdutosForm();

            tela.Produtos = new Produtos();

            tela.GravarRegistro = repositorioProdutos.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarProdutos();
            }
        }

        public override void Editar()
        {
            var numero = tabelaProdutos.ObtemNumeroProdutoSelecionado();

            Produtos produtoSelecionado = repositorioProdutos.SelecionarPorId(numero);

            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto primeiro",
                "Edição de Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tela = new TelaCadastroProdutosForm();

            tela.Produtos = produtoSelecionado;

            tela.GravarRegistro = repositorioProdutos.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarProdutos();
            }
        }

        public override void Excluir()
        {
            var numero = tabelaProdutos.ObtemNumeroProdutoSelecionado();

            Produtos produtoSelecionado = repositorioProdutos.SelecionarPorId(numero);

            if (produtoSelecionado == null)
            {
                MessageBox.Show("Selecione um produto primeiro",
                "Exclusão de Produto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o produto?",
               "Exclusão de Produto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioProdutos.Excluir(produtoSelecionado);
                CarregarProdutos();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
           return new ConfiguracaoToolboxProdutos();
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaProdutos == null)
                tabelaProdutos = new TabelaProdutosControl();

            CarregarProdutos();

            return tabelaProdutos;
        }


        private void CarregarProdutos()
        {
            List<Produtos> produtos = repositorioProdutos.SelecionarTodos();

            tabelaProdutos.AtualizarRegistros(produtos);

            TelaInicioForm.Instancia.AtualizarRodape($"Visualizando {produtos.Count} Produto(s)");
        }

    }
}
