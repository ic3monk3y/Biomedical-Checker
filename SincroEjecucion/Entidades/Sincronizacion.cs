using System;
using System.Data;
using System.Data.SqlClient;

namespace SincroEjecucion.Entidades
{
    class Sincronizacion
    {
        public static DataTable spSincro(Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.Conexionbd())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spSincroXML", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return tabla;
        }
    }
}
