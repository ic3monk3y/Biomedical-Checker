using System;
using System.Data;
using System.Data.SqlClient;

namespace SincroEjecucion.Entidades
{
    class Envio
    {
        public static void RespuestaCentral(string Response, string OrigenIDEnviado, Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.Conexionbd())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spSincroXMLEnviado ", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@JSONRespuesta", SqlDbType.VarChar, int.MaxValue).Value = Response;
                    dat.SelectCommand.Parameters.Add("@OrigenIDEnviado", SqlDbType.VarChar, int.MaxValue).Value = OrigenIDEnviado;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void RegistrarError(string Error, string OrigenID, Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.Conexionbd())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spRegistrarErrorSincroXML ", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@Error", SqlDbType.VarChar, int.MaxValue).Value = Error;
                    dat.SelectCommand.Parameters.Add("@OrigenID", SqlDbType.VarChar, int.MaxValue).Value = OrigenID;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw
                    new ApplicationException(ex.Message);
            }
        }
    }
}
