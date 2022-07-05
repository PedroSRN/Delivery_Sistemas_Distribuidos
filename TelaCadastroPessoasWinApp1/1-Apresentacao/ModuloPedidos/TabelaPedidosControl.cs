using Delivery.WinApp1._2_Dominio.ModuloPedidos;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloPedidos
{
    public partial class TabelaPedidosControl : UserControl
    {
        public TabelaPedidosControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", FillWeight=12F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Nome do Cliente", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Endereço do Cliente", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Funcionario", HeaderText = "Nome do Funcionario", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Produtos", HeaderText = "Nome do Produto", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Produtos", HeaderText = "Nome da Bebida", FillWeight=85F },

                 new DataGridViewTextBoxColumn { DataPropertyName = "Observacao", HeaderText = "Observação do pedido", FillWeight=85F }


            };

            return colunas;
        }

        public int ObtemNumeroPedioSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }


        public void AtualizarRegistros(List<Pedidos> pedidos)
        {
            grid.Rows.Clear();

            foreach (Pedidos pedido in pedidos)
            {
                grid.Rows.Add(pedido.Id, pedido.Cliente.Nome, pedido.Cliente.Endereco, pedido.Funcionario.Nome, pedido.Produtos.Nome, pedido.Produtos.Nome, pedido.Observacao);
            }
        }

    }
}
