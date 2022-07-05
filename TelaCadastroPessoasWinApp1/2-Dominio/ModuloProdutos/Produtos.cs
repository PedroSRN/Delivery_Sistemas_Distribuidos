using Delivery.WinApp1._2_Dominio.Compartilhado;
using Delivery.WinApp1._2_Dominio.ModuloFuncionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._2_Dominio.ModuloProdutos
{
    public class Produtos : EntidadeBase<Produtos>
    {
        public Produtos(string nome, double preco, int quantidade, string tipoDoProduto):this()
        {
            Nome = nome;
            Preco = preco;
            Quantiade = quantidade;
            TipoDoProdutor = tipoDoProduto;
        }

        public Produtos()
        {
            
        }

        public string  Nome {get; set;}
        public double Preco {get; set;}
        public int Quantiade { get; set;}
        public string TipoDoProdutor { get; set;}

        public override void Atualizar(Produtos produtos)
        {
            Nome = produtos.Nome;
            Preco = produtos.Preco;
            Quantiade = produtos.Quantiade;
            TipoDoProdutor = produtos.TipoDoProdutor;
        }

        public override bool Equals(object? obj)
        {
            return obj is Produtos produtos &&
                   Id == produtos.Id &&
                   Nome == produtos.Nome &&
                   Preco == produtos.Preco &&
                   Quantiade == produtos.Quantiade &&
                   TipoDoProdutor == produtos.TipoDoProdutor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Preco, Quantiade, TipoDoProdutor);
        }

        public override string ToString()
        {
            return Nome.ToString();
        }
    }
}
