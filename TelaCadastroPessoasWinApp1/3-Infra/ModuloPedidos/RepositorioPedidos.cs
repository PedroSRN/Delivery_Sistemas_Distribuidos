using Delivery.WinApp1._2_Dominio.ModuloPedidos;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloPedidos
{
    public class RepositorioPedidos : RepositorioBase<Pedidos, ValidadorPedidos, MapeadorPedidos>
    {
        protected override string sqlInserir =>
			@"INSERT INTO [TB_PEDIDOS]
            (
				[CLIENTE_ID],
				[PRODUTOS_ID],
				[FUNCIONARIO_ID],
				[OBSERVACAO]
		    )
            VALUES
            (
				@CLIENTE_ID,
				@PRODUTOS_ID,
				@FUNCIONARIO_ID,
				@OBSERVACAO
		    );SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
			@"UPDATE [TB_PEDIDOS]	
			SET
					[CLIENTE_ID] = @CLIENTE_ID,
					[PRODUTOS_ID] = @PRODUTOS_ID,
					[FUNCIONARIO_ID] = @FUNCIONARIO_ID,
					[OBSERVACAO] = @OBSERVACAO
			WHERE
			      [ID] = @ID;";

        protected override string sqlExcluir =>
			@"DELETE FROM[TB_PEDIDOS]
			WHERE
			      [ID] = @ID;";

		protected override string sqlSelecionarPorId =>
			@"SELECT
				PEDIDO.ID,
	 
				CLIENTE.ID AS ID_CLIENTE,
				CLIENTE.NOME AS NOME_CLIENTE,
                CLIENTE.ENDERECO AS ENDERECO_CLIENTE,

				PRODUTO.ID AS ID_PRODUTO,
				PRODUTO.NOME AS  NOME_PRODUTO,

				FUNCIONARIO.ID AS ID_FUNCIONARIO,
				FUNCIONARIO.NOME AS NOME_FUNCIONARIO,

				PEDIDO.OBSERVACAO
			FROM 
			      TB_PEDIDOS AS PEDIDO INNER JOIN  TB_CLIENTES AS CLIENTE
				  ON
				    PEDIDO.CLIENTE_ID = CLIENTE.ID INNER JOIN TB_PRODUTOS AS PRODUTO
				  ON
				    PEDIDO.PRODUTOS_ID = PRODUTO.ID INNER JOIN TB_FUNCIONARIO AS FUNCIONARIO
				  ON
				    PEDIDO.FUNCIONARIO_ID = FUNCIONARIO.ID

				  WHERE
				  		  PEDIDO.ID = @ID;";

		protected override string sqlSelecionarTodos =>
			@"SELECT
				PEDIDO.ID,
	 
				CLIENTE.ID AS ID_CLIENTE,
				CLIENTE.NOME AS NOME_CLIENTE,
                CLIENTE.ENDERECO AS ENDERECO_CLIENTE,

				PRODUTO.ID AS ID_PRODUTO,
				PRODUTO.NOME AS  NOME_PRODUTO,

				FUNCIONARIO.ID AS ID_FUNCIONARIO,
				FUNCIONARIO.NOME AS NOME_FUNCIONARIO,

				PEDIDO.OBSERVACAO
			FROM 
			      TB_PEDIDOS AS PEDIDO INNER JOIN  TB_CLIENTES AS CLIENTE
				  ON
				    PEDIDO.CLIENTE_ID = CLIENTE.ID INNER JOIN TB_PRODUTOS AS PRODUTO
				  ON
				    PEDIDO.PRODUTOS_ID = PRODUTO.ID INNER JOIN TB_FUNCIONARIO AS FUNCIONARIO
				  ON
				    PEDIDO.FUNCIONARIO_ID = FUNCIONARIO.ID";
    }
}
