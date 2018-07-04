using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SFP.SIT.SERV.Model.SOL
{
    public class SolBuscarMdl
    {
        public long FolioIni { get; set; }
        public long FolioFin { get; set; }


        [DataType(DataType.Date)]
        public DateTime? FecIngresoIni { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FecIngresoFin { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FecConcIni { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FecConcFin { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FecRespIni { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FecRespFin { get; set; }
        public Int32 Periodo{ get; set; }
        public Int32 SolicitudEstado { get; set; }
        public Int32 SolicitudTipo { get; set; }
        public String Descripcion { get; set; }
        public Int32 ProcesoTipo { get; set; }
        public Int32 Area { get; set; }
        public String Areas { get; set; }
        public Int32 Accion { get; set; }


        /* ---------------------------------- */
        public Int32 perClave { get; set; }
        public Int32 araClave { get; set; }
        public Int32 usrclave { get; set; }
        public Int32 consClave { get; set; }
        public Dictionary<int, int> dicUsrPer { get; set; }

        public SolBuscarMdl() { }
    }
}

