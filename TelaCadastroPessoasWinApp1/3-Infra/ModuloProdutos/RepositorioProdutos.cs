using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloProdutos
{
    public class RepositorioProdutos : RepositorioBase<Produtos, ValidadorProdutos, MapeadorProdutos>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TB_PRODUTOS]
            (
		        [NOME],
                [PRECO],
                [QUANTIDADE],
                [TIPODOPRODUTO]
		    )
            VALUES
	        (
	           @NOME,
	           @PRECO,
	           @QUANTIDADE,
	           @TIPODOPRODUTO
		   );SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE [TB_PRODUTOS]
            SET
                  [NOME] = @NOME,
                  [PRECO] = @PRECO,
                  [QUANTIDADE] = @QUANTIDADE,
                  [TIPODOPRODUTO] = @TIPODOPRODUTO
            WHERE
                 [ID] = @ID;";

        protected override string sqlExcluir =>
            @"DELETE FROM [TB_PRODUTOS]
             WHERE
                   ID = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                [ID],
                [NOME],
                [PRECO],
                [QUANTIDADE],
                [TIPODOPRODUTO]
            
            FROM [TB_PRODUTOS]
            
            WHERE
                 [ID] = @ID;";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
                [ID],
                [NOME],
                [PRECO],
                [QUANTIDADE],
                [TIPODOPRODUTO]
            
            FROM [TB_PRODUTOS]";
    }
}
