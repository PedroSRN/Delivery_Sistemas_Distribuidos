using Delivery.WinApp1._2_Dominio.ModuloProdutos;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloProdutos
{
    public class RepositorioProdutos : RepositorioBase<Produtos, ValidadorProdutos, MapeadorProdutos>
    {
        private static string enderecoBanco =
            @"Data Source=(LocalDB)\MSSqlLocalDB;
            Initial Catalog=DeliveryDB;Integrated Security=True";
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

        protected string sqlSelecionarPorBebidas =>
          @"SELECT 
                [ID],
                [NOME],
                [PRECO],
                [QUANTIDADE],
                [TIPODOPRODUTO]
            
            FROM [TB_PRODUTOS]
            
            WHERE
                 [TIPODOPRODUTO] = 'BEBIDA';";



      
        public List<Produtos> SelecionarPorBebidas()
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexaoComBanco);
            conexaoComBanco.Open();

            SqlDataReader leitorPaciente = comandoSelecao.ExecuteReader();

            var mapeador = new MapeadorProdutos();

            List<Produtos> produtos = new List<Produtos>();

            while (leitorPaciente.Read())
                produtos.Add(mapeador.ConverterRegistro(leitorPaciente));

            conexaoComBanco.Close();

            return produtos;
        }
    }

}
