using System;
using System.Data;
using System.Data.SqlClient;

namespace FivesCheckerMD.Function
{
    class PendientesSincro
    {
        public bool actCatch = false;
        public DataTable slctPendientesSincro(Conexion conn)
        {
            DataTable resultado = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    string cadena = "select * from RegistroXML Where Enviado = 0";
                    SqlCommand comando = new SqlCommand(cadena, Conne);
                    SqlDataReader registros = comando.ExecuteReader();
                    resultado.Load(registros);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (SqlException sqlex)
            {
                actCatch = true;
                Console.WriteLine(sqlex.Message);
            }
            return resultado;
        }
    }
}
