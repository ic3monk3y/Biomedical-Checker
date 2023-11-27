using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
{
    class ActEmpleado
    {
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public DataTable spActualizarEmp(Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spActualizarEmp", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dat.Fill(tabla);
                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                var trycathch = new ActEmpleado();
                trycathch.actCatch = true;
                //throw new ApplicationException(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }
    }
}
