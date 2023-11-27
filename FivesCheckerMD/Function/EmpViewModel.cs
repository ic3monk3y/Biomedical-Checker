using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FivesCheckerMD.Function
{
    public class EmpViewModel
    {
        public string Personal { get; set; }
        public string Nombre { get; set; }
        public int Estatus { get; set; }
        public int Sucursal { get; internal set; }
    }
}
