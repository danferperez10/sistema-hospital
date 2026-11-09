using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hospital.Datos
{
    public sealed class Db : IDisposable
    {
        readonly SqlConnection cn;
        readonly SqlTransaction tx;
        public Db(bool transaccion = false)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            cn.Open();
            if (transaccion)
            {
                tx = cn.BeginTransaction(IsolationLevel.Serializable);
            }
        }

        public static SqlParameter P(string nombre, object valor)
        {
            return new SqlParameter(nombre, valor ?? DBNull.Value);
        }

        SqlCommand Cmd(string sql, SqlParameter[] ps)
        {
            var c = new SqlCommand(sql, cn, tx);
            c.Parameters.AddRange(ps);
            return c;
        }

        public DataTable Tabla(string sql, params SqlParameter[] ps)
        {
            using (var c = Cmd(sql, ps))
            {
                using (var a = new SqlDataAdapter(c))
                {
                    var t = new DataTable();
                    a.Fill(t);
                    return t;
                }
            }
        }

        public int Ejecutar(string sql, params SqlParameter[] ps)
        {
            using (var c = Cmd(sql, ps))
            {
                return c.ExecuteNonQuery();
            }
        }

        public object Valor(string sql, params SqlParameter[] ps)
        {
            using (var c = Cmd(sql, ps))
            {
                return c.ExecuteScalar();
            }
        }

        public void Confirmar()
        {
            if (tx != null)
            {
                tx.Commit();
            }
        }

        public void Dispose()
        {
            if (tx != null)
            {
                tx.Dispose();
            }

            cn.Dispose();
        }
    }
}
