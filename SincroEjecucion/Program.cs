using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Net.Http;
using SincroEjecucion.Entidades;


namespace SincroEjecucion
{
    class Program
    {
        private static readonly HttpClient cliente = new HttpClient();

        static void Main(string[] args)
        {
            string OrigenIDEnviado = string.Empty;
            bool banderaConn = false;

            using (Conexion conn = new Conexion())
            {
                banderaConn = conn.validarConn();

                if (banderaConn == true)
                {
                    try
                    {
                        DataTable tablaReg = new DataTable();

                        tablaReg = Sincronizacion.spSincro(conn);
                        if (tablaReg != null)
                            OrigenIDEnviado = tablaReg.Rows[0].Field<string>("OrigenID");
                        else
                            Console.WriteLine("No hay registros.");

                        if (tablaReg.Rows.Count > 0)
                        {
                            try
                            {
                                EnviaRegistroXML_Suc_a_Central(tablaReg, conn).Wait();
                            }
                            catch (Exception ex)
                            {
                                Envio.RegistrarError(ex.Message, OrigenIDEnviado, conn);
                            }
                        }
                        Console.WriteLine("RecibePosAutoXML Correcta");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                    Console.WriteLine("Sin conexion con el servidor de base de datos");

            }
        }

        static async Task EnviaRegistroXML_Suc_a_Central(DataTable tabla, Conexion conn)
        {
            string OrigenID = tabla.Rows[0].Field<string>("OrigenID");
            string OrigenXML = tabla.Rows[0].Field<string>("OrigenXML");
            string FechaRegistro = tabla.Rows[0].Field<string>("FechaRegistro");
            string Enviado = tabla.Rows[0].Field<string>("Enviado");
            string Recibido = tabla.Rows[0].Field<string>("Recibido");
            string Procesado = tabla.Rows[0].Field<string>("Procesado");
            string FechaEnviado = tabla.Rows[0].Field<string>("FechaEnviado");
            string FechaRecibido = tabla.Rows[0].Field<string>("FechaRecibido");
            string FechaProcesado = tabla.Rows[0].Field<string>("FechaProcesado");
            string Sucursal = tabla.Rows[0].Field<string>("Sucursal");
            string URLAPI = tabla.Rows[0].Field<string>("URLAPI");
            string ConfSucursal = conn.slctSucursal();

            string tipo = "EnvioCheckerXML";
            var values = new List<KeyValuePair<string, string>>();

            values.Add(new KeyValuePair<string, string>("tipo", tipo));
            values.Add(new KeyValuePair<string, string>("OrigenID", OrigenID));
            values.Add(new KeyValuePair<string, string>("OrigenXML", OrigenXML));
            values.Add(new KeyValuePair<string, string>("FechaRegistro", FechaRegistro));
            values.Add(new KeyValuePair<string, string>("Enviado", Enviado));
            values.Add(new KeyValuePair<string, string>("Recibido", Recibido));
            values.Add(new KeyValuePair<string, string>("Procesado", Procesado));
            values.Add(new KeyValuePair<string, string>("FechaEnviado", FechaEnviado));
            values.Add(new KeyValuePair<string, string>("FechaRecibido", FechaRecibido));
            values.Add(new KeyValuePair<string, string>("FechaProcesado", FechaProcesado));
            values.Add(new KeyValuePair<string, string>("Sucursal", Sucursal));
            values.Add(new KeyValuePair<string, string>("ConfSucursal", ConfSucursal));

            var content = new FormUrlEncodedContent(values);

            try
            {
                var response = await cliente.PostAsync(URLAPI, content);
                string responseString = await response.Content.ReadAsStringAsync();
                //string responseString = response.Result.ToString();
                System.Diagnostics.Debug.WriteLine(responseString);
                Console.WriteLine(responseString);

                if (responseString.Contains("0"))
                {
                    Envio.RespuestaCentral(responseString, OrigenID, conn);
                    Console.WriteLine("ENTRO REGISTROS");
                }
            }
            catch (HttpRequestException clientEx)
            {
                Console.WriteLine(clientEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
