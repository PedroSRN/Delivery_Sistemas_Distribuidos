using System.Windows.Forms;

namespace Delivery.WinApp1._1_Apresentacao.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract UserControl ObtemListagem();
        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();

    }
}
