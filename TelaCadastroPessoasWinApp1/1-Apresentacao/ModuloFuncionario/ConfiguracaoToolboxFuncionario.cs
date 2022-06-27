using Delivery.WinApp1._1_Apresentacao.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._1_Apresentacao.ModuloFuncionario
{
    public class ConfiguracaoToolboxFuncionario : ConfiguracaoToolboxBase
    {
        public override string TiposCadastro => "Lista de Funcionários";

        public override string TooltipInserir => "Inserir novo Funcionario";

        public override string TooltipEditar => "Editar um Funcioário existente";

        public override string TooltipExcluir => "Excluir um Funcionário existente";

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }


    }
}
