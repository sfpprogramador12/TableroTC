using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Model._Consultas
{
    public class NodoResp
    {
        public long nodclave { get; set; }
        public long repclave { get; set; }
        public int rtpclave { get; set; }
        public string rtpdescripcion { get; set; }
        public string rtpforma { get; set; }
        public string detdescripcion { get; set; }

        public NodoResp() { }        
    }
}
