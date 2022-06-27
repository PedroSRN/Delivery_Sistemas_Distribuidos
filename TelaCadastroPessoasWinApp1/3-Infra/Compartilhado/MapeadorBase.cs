using Delivery.WinApp1._2_Dominio.Compartilhado;
using System.Data.SqlClient;


namespace Delivery.WinApp1._3_Infra.Compartilhado
{
    public abstract class MapeadorBase<T> where T : EntidadeBase<T>
    {
        public abstract void ConfigurarParametros(T registro, SqlCommand comando);

        public abstract T ConverterRegistro(SqlDataReader leitorRegistro);
    }
}
