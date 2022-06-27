using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloFuncionario
{
    public partial class TabelaFuncionarioControl : UserControl
    {
        public TabelaFuncionarioControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Cpf", HeaderText = "CPF", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "Salario", HeaderText = "Salário", FillWeight=85F },

                new DataGridViewTextBoxColumn { DataPropertyName = "DataNascimento", HeaderText = "Data de Nascimento", FillWeight=85F }

            };

            return colunas;
        }

        public int ObtemNumeroFuncionarioSelecionado()
        {
            return grid.SelecionarNumero<int>();
        }

        public void AtualizarRegistros(List<Funcionario> funcionarios)
        {
            grid.Rows.Clear();

            foreach(Funcionario funcionario in funcionarios)
            {
                grid.Rows.Add(funcionario.Id, funcionario.Nome, funcionario.Cargo, funcionario.Cpf, funcionario.Salario, funcionario.DataNascimento);
            }
        }
    }
}
