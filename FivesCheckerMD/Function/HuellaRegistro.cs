using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
{
    class HuellaRegistro
    {   
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public DataTable spRegistroHuellas(String Personal, int Dedo, byte[] HuellaByte, Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spRegistroHuellas", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@Personal", SqlDbType.VarChar).Value = Personal;
                    dat.SelectCommand.Parameters.Add("@Dedo", SqlDbType.Int).Value = Dedo;
                    dat.SelectCommand.Parameters.Add("@Huella", SqlDbType.VarBinary).Value = HuellaByte;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }

            }
            catch (Exception ex)
            {
                actCatch = true;
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }

    }
}
