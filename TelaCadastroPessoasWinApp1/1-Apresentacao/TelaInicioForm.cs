using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._1_Apresentacao.ModuloClientes;
using Delivery.WinApp1._1_Apresentacao.ModuloFuncionario;
using Delivery.WinApp1._1_Apresentacao.ModuloPedidos;
using Delivery.WinApp1._1_Apresentacao.ModuloProdutos;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.ModuloCliente;
using Delivery.WinApp1._3_Infra.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.ModuloProdutos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1
{
    public partial class TelaInicioForm : Form
    {
        private ControladorBase controlador;
        private Dictionary<string, ControladorBase> controladores;
     
        public TelaInicioForm()
        {
            InitializeComponent();

            Instancia = this;
            labelRodape.Text = string.Empty;
            labelTipoCadastro.Text = string.Empty;

            InicializarControladores();
        }

        public static TelaInicioForm Instancia
        {
            get;
            private set;
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void btn_Funcionarios_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(btn_Funcionarios);
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(btn_Clientes);
        }

        private void btn_Produtos_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(btn_Produtos);
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            ConfigurarTelaPrincipal(btn_Pedidos);
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btn_Editar_Click_1(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btn_Excluir_Click_1(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarBotoes(ConfiguracaoToolboxBase configuracao)
        {
            btn_Inserir.Enabled = configuracao.InserirHabilitado;
            btn_Editar.Enabled = configuracao.EditarHabilitado;
            btn_Excluir.Enabled = configuracao.ExcluirHabilitado;
        }

        private void ConfigurarToolTips(ConfiguracaoToolboxBase configuracao)
        {
            btn_Inserir.ToolTipText = configuracao.TooltipInserir;
            btn_Editar.ToolTipText = configuracao.TooltipEditar;
            btn_Excluir.ToolTipText = configuracao.TooltipExcluir;
        }

        private void ConfigurarTelaPrincipal(Button opcaoSelecionada)
        {
            if (panel1.Controls.Count > 0)
                panel1.Controls.Clear();
           
            if(opcaoSelecionada.Text == "tela") 
            {       
                panel1.Controls.Add(panel_Defundo);
                panel1.Tag = panel_Defundo;

                panel_Defundo.Show();
                return;
            }
            //var tipo = opcaoSelecionada.Text;

            controlador = controladores[opcaoSelecionada.Text];


            ConfigurarToolbox();

            ConfigurarListagem();
        }

        private void ConfigurarToolbox()
        {
            
            ConfiguracaoToolboxBase configuracao = controlador.ObtemConfiguracaoToolbox();
           

            if(configuracao != null)
            {
                toolbox.Enabled = true;

                labelTipoCadastro.Text = configuracao.TiposCadastro;

                ConfigurarToolTips(configuracao);

                ConfigurarBotoes(configuracao);
            }
        }

        private void ConfigurarListagem()
        {
            AtualizarRodape("");

            var listagemControl = controlador.ObtemListagem();

            tela.Controls.Clear();

            listagemControl.Dock = DockStyle.Fill;

            tela.Controls.Add(listagemControl);
        }

        private void InicializarControladores()
        {
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario();
            RepositorioCliente repositorioCliente = new RepositorioCliente();
            RepositorioProdutos repositorioProdutos = new RepositorioProdutos();
            controladores = new Dictionary<string, ControladorBase>();

            controladores.Add("Funcionarios",new ControladorFuncionario(repositorioFuncionario));
            controladores.Add("Clientes", new ControladorCliente(repositorioCliente));
            controladores.Add("Pedidos", new ControladorPedidos());
            controladores.Add("Produtos", new ControladorProdutos(repositorioProdutos));
        }

      
    }
}
