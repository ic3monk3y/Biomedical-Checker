using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
{
    class Registr
    {
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public static DataTable spNvoRegistr(String Personal, String Tipo, String Usuario, byte[] HuellaByte,Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {

                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spNvoRegistroAsistencia", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@Accion", SqlDbType.VarChar).Value = Tipo;
                    dat.SelectCommand.Parameters.Add("@Personal", SqlDbType.VarChar).Value = Personal;
                    dat.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario;
                    dat.SelectCommand.Parameters.Add("@Huella", SqlDbType.VarBinary).Value = HuellaByte;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }

            }
            catch (Exception ex)
            {
                var trycathch = new DatosPersonal();
                trycathch.actCatch = true;
                //throw new ApplicationException(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }
    }
}
