using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloProdutos;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloProdutos
{
    public partial class TelaCadastroProdutosForm : Form
    {
        private Produtos produtos;

        public TelaCadastroProdutosForm()
        {
            InitializeComponent();
            CarregarTipo();
            ClassMaskMoeda.AplicaMascaraMoeda2(txt_Preco);
        }
        private void CarregarTipo()
        {
            cbx_Tipo.Items.Add("LANCHE");
            cbx_Tipo.Items.Add("BEBIDA");
        }
        public Func<Produtos, ValidationResult> GravarRegistro { get; set; }
        
        public Produtos Produtos 
        {
            get => produtos;


            set
            {
                produtos = value;

                txt_Nome.Text = produtos.Nome;
                txt_Preco.Text = produtos.Preco.ToString();
                masked_Qtd.Text = produtos.Quantiade.ToString();
                
                cbx_Tipo.Text = produtos.TipoDoProdutor;               
                   

            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            produtos.Nome = txt_Nome.Text;
            produtos.Preco = Convert.ToDouble(txt_Preco.Text.Replace("R$", string.Empty).Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator));
            produtos.Quantiade = Convert.ToInt32(masked_Qtd.Text);
            produtos.TipoDoProdutor = cbx_Tipo.Text;
           

            var resultadoValidacao = GravarRegistro(Produtos);

            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaInicioForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
