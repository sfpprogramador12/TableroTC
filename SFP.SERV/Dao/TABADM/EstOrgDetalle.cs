using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFP.SIT.SERV.Dao.TABADM
{
    public class EstOrgDetalle
    {
        public int EOCLAVE { get; set; }
        public int EODCLAVE { get; set; }
        public int ARACLAVE { get; set; }
        public int EODORDEN { get; set; }
        public int EODREPORTA { get; set; }
        

        public string EODPLAZAS { get; set; }
        public string EODPLAZASGPO { get; set; }
        public string EODPRESUPUESTO { get; set; }
        public string EODPRESUPUESTOGPO { get; set; }
        public string EODCALIFICACION { get; set; }
        public string EODCALIFGPO { get; set; }

    }
}