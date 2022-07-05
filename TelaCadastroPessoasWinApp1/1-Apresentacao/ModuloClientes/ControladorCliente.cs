using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._3_Infra.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.ModuloClientes
{
    public class ControladorCliente : ControladorBase
    {
        private RepositorioCliente repositorioCliente;
        private TabelaClientesControl tabelaClientes;

        public ControladorCliente(RepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

       

        public override void Inserir()
        {
            var tela = new TelaCadastroClienteForm();

            tela.Cliente = new Clientes();

            tela.GravarRegistro = repositorioCliente.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            }
        }

        public override void Editar()
        {
            var numero = tabelaClientes.ObtemNumeroClienteSelecionado();

            Clientes clienteSelecionado = repositorioCliente.SelecionarPorId(numero);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tela = new TelaCadastroClienteForm();

            tela.Cliente = clienteSelecionado;

            tela.GravarRegistro = repositorioCliente.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarClientes();
            };
        }

        public override void Excluir()
        {
            var numero = tabelaClientes.ObtemNumeroClienteSelecionado();

            Clientes clienteSelecionado = repositorioCliente.SelecionarPorId(numero);

            if (clienteSelecionado == null)
            {
                MessageBox.Show("Selecione um cliente primeiro",
                "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o funcionario?",
               "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioCliente.Excluir(clienteSelecionado);
                CarregarClientes();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxCliente();
        }

        public override UserControl ObtemListagem()
        {
            if(tabelaClientes == null)
                tabelaClientes = new TabelaClientesControl();

            CarregarClientes();

             return tabelaClientes;

        }

        public void CarregarClientes()
        {
           List<Clientes> clientes = repositorioCliente.SelecionarTodos();

            tabelaClientes.AtualizarRegistros(clientes);

            TelaInicioForm.Instancia.AtualizarRodape($"Visualizando {clientes.Count} Cliente(s)");
        }

    }
}
