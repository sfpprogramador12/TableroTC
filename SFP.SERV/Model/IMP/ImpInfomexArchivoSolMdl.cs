using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Model.IMP
{
    public class ImpInfomexArchivoSolMdl : ImportarSolicitudMdl
    {
        public int EstadoSolicitud { get; set; }
        public String UnidadEnlace { get; set; }
        public String TipoUsuario { get; set; }
        public String Pais { get; set; }
        public String EstidadFederativa { get; set; }
        public String Municipio { get; set; }
        public String Ocupacion { get; set; }
        public String ModoEntrega{ get; set; }
        public String Mensaje { get; set; }
        public int Error { get; set; }

        public ImpInfomexArchivoSolMdl() { }
    }
}

