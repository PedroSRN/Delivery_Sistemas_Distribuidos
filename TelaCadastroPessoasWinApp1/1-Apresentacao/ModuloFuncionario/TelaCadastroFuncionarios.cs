using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            ClassMaskMoeda.AplicaMascaraMoeda2(txt_salario);
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
                maskedTextBox_Cpf.Text = funcionario.CPF;
                txt_salario.Text = funcionario.Salario.ToString();

                if (funcionario.DataNascimento > DateTimePicker.MinimumDateTime)
                {
                    dateTimePicker_Data_Nascimento.Value = funcionario.DataNascimento;
                }
                else
                    dateTimePicker_Data_Nascimento.Value = DateTime.Now;
            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txt_Nome.Text;
            funcionario.Cargo = txt_cargo.Text;
            funcionario.CPF = maskedTextBox_Cpf.Text;
            funcionario.Salario = Convert.ToDouble(txt_salario.Text.Replace("R$", string.Empty).Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
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
