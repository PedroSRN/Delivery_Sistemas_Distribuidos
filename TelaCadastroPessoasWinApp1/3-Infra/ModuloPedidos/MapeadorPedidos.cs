using Delivery.WinApp1._2_Dominio.ModuloPedidos;
using Delivery.WinApp1._3_Infra.Compartilhado;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.WinApp1._3_Infra.ModuloPedidos
{
    public class MapeadorPedidos : MapeadorBase<Pedidos>
    {
        public override void ConfigurarParametros(Pedidos registro, SqlCommand comando)
        {
            throw new NotImplementedException();
        }

        public override Pedidos ConverterRegistro(SqlDataReader leitorRegistro)
        {
            throw new NotImplementedException();
        }
    }
}
