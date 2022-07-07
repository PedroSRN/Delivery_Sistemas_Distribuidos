using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._2_Dominio.ModuloPedidos;
using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using Delivery.WinApp1._3_Infra.ModuloProdutos;
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

namespace Delivery.WinApp1._1_Apresentacao.ModuloPedidos
{
    public partial class TelaCadastroPedidosForm : Form
    {
        private Pedidos pedido;
        

        public TelaCadastroPedidosForm(List<Clientes> clientes, List<Funcionario> funcionarios, List<Produtos> produtos)
        {
            InitializeComponent();

            CarregarNomeCliente(clientes);
            CarregarEnderecoCliente(clientes);
            CarregarNomeFuncionario(funcionarios);
            CarregarProdutos(produtos);
        }

        public Func<Pedidos, ValidationResult> GravarRegistro { get; set; }


        private void CarregarNomeCliente(List<Clientes> clientes)
        {
            cbx_clientes.Items.Clear();

            foreach (var item in clientes) 
            {
                cbx_clientes.Items.Add(item);
            }
            
        }

        private void CarregarEnderecoCliente(List<Clientes> clientes)
        {
            cbx_EnderecoCliente.Items.Clear();
            
            foreach (var item in clientes)
            {
                cbx_EnderecoCliente.Items.Add(item);
                
            }
            cbx_EnderecoCliente.DisplayMember = "endereco";
        }

        private void CarregarNomeFuncionario(List<Funcionario> funcionario)
        {
            cbx_Funcionarios.Items.Clear();

            foreach (var item in funcionario)
            {
                cbx_Funcionarios.Items.Add(item);
            }
        }

        private void CarregarProdutos(List<Produtos> produtos)
        {
            cbx_Produtos.Items.Clear();

            foreach (var item in produtos)
            {
              cbx_Produtos.Items.Add(item);
 
            }
        }

        public Pedidos Pedidos 
        {
            get => pedido;

            set
            {
                pedido = value;

                cbx_clientes.SelectedItem = Pedidos.Cliente;
 
                cbx_EnderecoCliente.SelectedItem = Pedidos.Cliente;
                cbx_Funcionarios.SelectedItem = Pedidos.Funcionario;
                cbx_Produtos.SelectedItem = Pedidos.Produtos;
                txt_Observacao.Text = Pedidos.Observacao;
                
            }
        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            if (cbx_clientes.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira o campo 'Cliente'.", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                pedido.Cliente = (Clientes)cbx_clientes.SelectedItem;
            }

            if (cbx_EnderecoCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira o campo 'Endereço do Cliente'.", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                pedido.Cliente = (Clientes)cbx_EnderecoCliente.SelectedItem;
            }

            if (cbx_Produtos.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira o campo 'Produto'.", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                pedido.Produtos = (Produtos)cbx_Produtos.SelectedItem;
            }

            if (cbx_Funcionarios.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Insira o campo 'Produto'.", "Cadastro de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                pedido.Funcionario = (Funcionario)cbx_Funcionarios.SelectedItem;
            }


            pedido.Observacao = txt_Observacao.Text;

            if (txt_Observacao.Text == string.Empty)
            {
                pedido.Observacao = "Não Informada";
            }
             
            var resultadoValidacao = GravarRegistro(Pedidos);
           
            if (resultadoValidacao.IsValid == false)
            {
                string erro = resultadoValidacao.Errors[0].ErrorMessage;

                TelaInicioForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
           

        }

        
    }
}
