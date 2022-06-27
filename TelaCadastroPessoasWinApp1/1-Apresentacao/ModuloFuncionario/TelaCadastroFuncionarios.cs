using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloFuncionario
{
    public partial class TelaCadastroFuncionarios : Form
    {
        private Funcionario funcionario;
        
        public TelaCadastroFuncionarios()
        {
            InitializeComponent();
        }

        public Func<Funcionario, ValidationResult> GravarRegistro { get; set; }

        public Funcionario Funcionario 
        {
            get => funcionario;

            set
            {
                funcionario = value;
                
                txt_Nome.Text = funcionario.Nome;
                txt_cargo.Text = funcionario.Cargo;
                maskedTextBox_Cpf.Text = funcionario.Cpf;
                numericUpDown_Salario.Value = funcionario.Salario;

                if (funcionario.DataNascimento > DateTimePicker.MinimumDateTime)
                {
                    dateTimePicker_Data_Nascimento.Value = funcionario.DataNascimento;
                }
                else
                    dateTimePicker_Data_Nascimento.Value = DateTimePicker.MinimumDateTime;
            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txt_Nome.Text;
            funcionario.Cargo = txt_cargo.Text;
            funcionario.Cpf = maskedTextBox_Cpf.Text;
            funcionario.Salario = numericUpDown_Salario.Value;
            funcionario.DataNascimento = dateTimePicker_Data_Nascimento.Value;

            var resultadoValidacao = GravarRegistro(Funcionario);

            if(resultadoValidacao.IsValid == false) 
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaInicioForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
