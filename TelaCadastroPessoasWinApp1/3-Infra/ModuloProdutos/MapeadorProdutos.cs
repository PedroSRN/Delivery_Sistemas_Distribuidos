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
    public class MapeadorProdutos : MapeadorBase<Produtos>
    {
        public override void ConfigurarParametros(Produtos produtos, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("ID", produtos.Id);
            comando.Parameters.AddWithValue("NOME", produtos.Nome);
            comando.Parameters.AddWithValue("PRECO", produtos.Preco);
            comando.Parameters.AddWithValue("QUANTIDADE", produtos.Quantiade);
            comando.Parameters.AddWithValue("TIPODOPRODUTO", produtos.TipoDoProdutor);
        }

        public override Produtos ConverterRegistro(SqlDataReader leitorProduto)
        {
            var id = Convert.ToInt32(leitorProduto["ID"]);
            var nome = Convert.ToString(leitorProduto["NOME"]);
            var preco = Convert.ToDouble(leitorProduto["PRECO"]);
            var quantidade = Convert.ToInt32(leitorProduto["QUANTIDADE"]);
            var tipoProduto = Convert.ToString(leitorProduto["TIPODOPRODUTO"]);

            Produtos produtos = new Produtos();
            produtos.Id = id;
            produtos.Nome = nome;
            produtos.Preco = preco;
            produtos.Quantiade = quantidade;
            produtos.TipoDoProdutor = tipoProduto;

            return produtos;
        }
    }
}
