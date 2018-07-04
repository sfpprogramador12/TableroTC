using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Model.RED
{
    public class RedAristaSegMdl
    {
        public Int64 Arista { get; set; }
        public Int64 Origen { get; set; }
        public String OrigenSigla { get; set; }
        public String Accion { get; set; }
        public Int64 Destino { get; set; }
        public String DestinoSigla { get; set; }
        public DateTime FecIni { get; set; }
        public DateTime FecFin { get; set; }
        public DateTime FecLectura { get; set; }
        public Int32 DiasLaborales { get; set; }
        public String Observacion { get; set; }
        public String Responsable { get; set; }
        public Int32 Atendido { get; set; }
        public String NodoEstado { get; set; }
        public RedAristaSegMdl() { }
    }
}
