using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SFP.SIT.SERV.Model.Adm
{
	 public class TCP_Adm_Area
	 {
	 	 public string Area_Objetivo { set; get; } 
	 	 public string Area_Nombre { set; get; }

        public float Area_Presupuesto { set; get; }
        public string Area_Personas { set; get; }
        public string Area_Calificacion { set; get; }

        public TCP_Adm_Area () {} 
 
	 	 public TCP_Adm_Area (
	 	  string araclave, string arafeccreacion
	 	 	 )
	 	 {
	 	 	 this.Area_Nombre = araclave;
	 	 	 this.Area_Objetivo = arafeccreacion;
	 	 }
	 }
}
