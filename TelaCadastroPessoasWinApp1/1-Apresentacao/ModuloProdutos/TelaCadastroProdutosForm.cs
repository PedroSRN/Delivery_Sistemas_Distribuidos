using Delivery.WinApp1._2_Dominio.ModuloProdutos;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloProdutos
{
    public partial class TelaCadastroProdutosForm : Form
    {
        private Produtos produtos;

        public TelaCadastroProdutosForm()
        {
            InitializeComponent();
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
                txt_Qtd.Text = produtos.Quantiade.ToString();
                
                cbx_Tipo.SelectedItem = produtos.TipoDoProdutor;               
                    cbx_Tipo.Items.Add("LANCHE");
                    cbx_Tipo.Items.Add("BEBIDA");

            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            produtos.Nome = txt_Nome.Text;
            produtos.Preco = Convert.ToDouble(txt_Preco.Text);
            produtos.Quantiade = Convert.ToInt32(txt_Qtd.Text);
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
