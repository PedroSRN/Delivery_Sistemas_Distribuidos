using Delivery.WinApp1._2_Dominio.ModuloClientes;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloClientes
{
    public partial class TabelaClientesControl : UserControl
    {
        public TabelaClientesControl()
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id", FillWeight=15F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "CPF", HeaderText = "CPF", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço", FillWeight=85F },

             };

            return colunas;
        }

        public int ObtemNumeroClienteSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }
        public void AtualizarRegistros(List<Clientes> clientes)
        {
            grid.Rows.Clear();

            foreach (Clientes cliente in clientes)
            {
                grid.Rows.Add(cliente.Id, cliente.Nome.ToUpper(), cliente.Telefone, cliente.CPF, cliente.Endereco.ToUpper());
            }
        }

    }
}
