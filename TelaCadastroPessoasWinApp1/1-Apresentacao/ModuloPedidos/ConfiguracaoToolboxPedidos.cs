using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._1_Apresentacao.ModuloPedidos
{
    public class ConfiguracaoToolboxFuncionario : ConfiguracaoToolboxBase
    {
        public override string TiposCadastro => "Lista de Pedidos";

        public override string TooltipInserir => "Inserir novo Pedido";

        public override string TooltipEditar => "Editar um Pedido existente";

        public override string TooltipExcluir => "Excluir um Pedido existente";

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }
    }
}
