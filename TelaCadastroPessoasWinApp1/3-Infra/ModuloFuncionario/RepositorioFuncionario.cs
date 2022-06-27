using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario, ValidadorFuncionario, MapeadorFuncionario>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TB_FUNCIONARIO]
            (
		     [NOME],
             [CARGO],
             [CPF],
             [SALARIO],
             [DATANASCIMENTO]
		    )
            VALUES
            (
		        @NOME,
			    @CARGO,
			    @CPF,
			    @SALARIO,
			    @DATANASCIMENTO
		    );SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE[TB_FUNCIONARIO]
            SET
                [NOME] = @NOME,
                [CARGO] = @CARGO,
                [CPF] = @CPF,
                [SALARIO] = @SALARIO,
                [DATANASCIMENTO] = @DATANASCIMENTO
            WHERE
                 ID = @ID;";

        protected override string sqlExcluir =>
            @"DELETE FROM[TB_FUNCIONARIO]
            WHERE
                 ID = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                [ID],
                [NOME],
                [CARGO],
                [CPF],
                [SALARIO],
                [DATANASCIMENTO]
                FROM [TB_FUNCIONARIO]
                WHERE
                      [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
                [ID],
                [NOME],
                [CARGO],
                [CPF],
                [SALARIO],
                [DATANASCIMENTO]
            FROM [TB_FUNCIONARIO]";
    }
}
