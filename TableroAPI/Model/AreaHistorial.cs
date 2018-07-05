using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TableroAPI.Model
{
    public class AreaHistorial
    {
        public int Hist_AreaId { get; set; }
        public int Hist_EstOrgId { get; set; }
        public int Hist_ClaveUA { get; set; }
        public string Hist_Nombre { get; set; }
        public string Hist_Objetivo { get; set; }
        public string Hist_Siglas { get; set; }
        public string CTID { get; set; }
        public string OBJUR { get; set; }

        public DateTime Hist_FechaInicio { get; set; }
        public DateTime Hist_FechaFin { get; set; }



    }
}