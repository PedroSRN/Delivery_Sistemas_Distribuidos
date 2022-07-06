using Delivery.WinApp1._2_Dominio.ModuloClientes;
using FluentValidation.Results;
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
    public partial class TelaCadastroClienteForm : Form
    {
        private Clientes cliente;

        public TelaCadastroClienteForm()
        {
            InitializeComponent();
        }

        public Func<Clientes, ValidationResult> GravarRegistro { get; internal set; }
        
        public Clientes Cliente 
        {
            get => cliente;

            set
            {
                cliente = value;

                txt_Nome.Text = cliente.Nome;
                masked_Telefone.Text = cliente.Telefone;
                maskedTextBox_Cpf.Text = cliente.CPF;
                txt_Endereco.Text = cliente.Endereco;
            }

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txt_Nome.Text;
            cliente.Telefone = masked_Telefone.Text;
            cliente.CPF = maskedTextBox_Cpf.Text;
            cliente.Endereco = txt_Endereco.Text;

            var resultadoValidacao = GravarRegistro(Cliente);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaInicioForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
