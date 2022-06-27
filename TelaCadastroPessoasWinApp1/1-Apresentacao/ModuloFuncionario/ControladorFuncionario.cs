using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.ModuloFuncionario
{
    public class ControladorFuncionario : ControladorBase
    {
        private RepositorioFuncionario repositorioFuncionario;
        private TabelaFuncionarioControl tabelaFuncionario;

        public ControladorFuncionario(RepositorioFuncionario repositorioFuncionario)
        {
            this.repositorioFuncionario = repositorioFuncionario;
        }

        public override void Inserir()
        {
             var tela = new TelaCadastroFuncionarios();

             tela.Funcionario = new Funcionario();

             tela.GravarRegistro = repositorioFuncionario.Inserir;

             DialogResult resultado = tela.ShowDialog();

             if (resultado == DialogResult.OK)
             {
                 CarregarFuncionarios();
             }
        }

        public override void Editar()
        {
            var numero = tabelaFuncionario.ObtemNumeroFuncionarioSelecionado();

            Funcionario funcionarioSelecionado = repositorioFuncionario.SelecionarPorId(numero);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Edição de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tela = new TelaCadastroFuncionarios();

            tela.Funcionario = funcionarioSelecionado;

            tela.GravarRegistro = repositorioFuncionario.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarFuncionarios();
            }

        }

        public override void Excluir()
        {
            var numero = tabelaFuncionario.ObtemNumeroFuncionarioSelecionado();

            Funcionario funcionarioSelecionado = repositorioFuncionario.SelecionarPorId(numero);

            if (funcionarioSelecionado == null)
            {
                MessageBox.Show("Selecione um funcionario primeiro",
                "Exclusão de Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir o funcionario?",
               "Exclusão de Funcionario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioFuncionario.Excluir(funcionarioSelecionado);
                CarregarFuncionarios();
            }
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxFuncionario();
        }

        public override UserControl ObtemListagem()
        {
            if(tabelaFuncionario == null)
                tabelaFuncionario = new TabelaFuncionarioControl();

            CarregarFuncionarios();

            return tabelaFuncionario;
           
        }

        private void CarregarFuncionarios()
        {
            List<Funcionario> funcionarios = repositorioFuncionario.SelecionarTodos();

            tabelaFuncionario.AtualizarRegistros(funcionarios);

            TelaInicioForm.Instancia.AtualizarRodape($"Visualizando {funcionarios.Count} Funcionario(s)");
        }
    }
}
