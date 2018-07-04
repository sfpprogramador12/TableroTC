using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Model.DOC
{
    public class DocContenidoMdl :SIT_DOC_DOCUMENTO
    {
        public Byte[] doc_contenido { get; set; }
        public String extmimetype { get; set; }

        public DocContenidoMdl()
        {
        }
    }
}