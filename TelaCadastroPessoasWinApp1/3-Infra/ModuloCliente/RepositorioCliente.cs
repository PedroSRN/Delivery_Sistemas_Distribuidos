using Delivery.WinApp1._2_Dominio.ModuloClientes;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloCliente
{
    public class RepositorioCliente : RepositorioBase<Clientes, ValidadorCliente, MapeadorCliente>
    {
        protected override string sqlInserir =>
            @"INSERT INTO [TB_CLIENTES]
            (
		      [NOME],
              [TELEFONE],
              [CPF],
              [ENDERECO])
            VALUES
            (
		        @NOME,
			    @TELEFONE,
			    @CPF,
			    @ENDERECO
		   );SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar =>
            @"UPDATE[TB_CLIENTES]
            SET
                  [NOME] = @NOME,
                  [TELEFONE] = @TELEFONE,
                  [CPF] = @CPF,
                  [ENDERECO] = @ENDERECO
            WHERE
                   ID = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM[TB_CLIENTES]
            WHERE
                ID = @ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                [ID],
                [NOME],
                [TELEFONE],
                [CPF],
                [ENDERECO]
            FROM [TB_CLIENTES]
            
            WHERE
                [ID] = @ID;";

        protected override string sqlSelecionarTodos =>
            @"SELECT 
                [ID],
                [NOME],
                [TELEFONE],
                [CPF],
                [ENDERECO]
            FROM [TB_CLIENTES]";
    }
}
