using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using GeradorTeste.WinApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.ModuloProdutos
{
    public partial class TabelaProdutosControl : UserControl
    {
        public TabelaProdutosControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", FillWeight=15F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "TipoDoProduto", HeaderText = "Tipo do Produto", FillWeight=85F },

            };

            return colunas;
        }

        public int ObtemNumeroProdutoSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Produtos> produtos)
        {
            grid.Rows.Clear();

            foreach (Produtos produto in produtos)
            {
                grid.Rows.Add(produto.Id, produto.Nome, produto.Preco, produto.Quantiade, produto.TipoDoProdutor);
            }
        }
    }
}
