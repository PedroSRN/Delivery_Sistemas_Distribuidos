using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._1_Apresentacao.ModuloProdutos
{
    public class ConfiguracaoToolboxProdutos : ConfiguracaoToolboxBase
    {
        public override string TiposCadastro => "Lista de Produtos";

        public override string TooltipInserir => "Inserir novo Produtos";

        public override string TooltipEditar => "Editar um Produtos existente";

        public override string TooltipExcluir => "Excluir um Produtos existente";

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }
    }
}
