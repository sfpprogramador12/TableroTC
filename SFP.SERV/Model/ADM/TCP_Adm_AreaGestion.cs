using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_AreaGestion
	 {
	 	 public int agnclave  { set; get; } 
	 	 public DateTime agnfecini  { set; get; } 
	 	 public DateTime agnfecfin  { set; get; } 
	 	 public string agndescripcion  { set; get; } 
 
	 	 public TCP_Adm_AreaGestion () {} 
 
	 	 public TCP_Adm_AreaGestion (
	 	  int agnclave, DateTime agnfecini, DateTime agnfecfin, string agndescripcion
	 	 	 )
	 	 {
	 	 	 this.agnclave = agnclave;
	 	 	 this.agnfecini = agnfecini;
	 	 	 this.agnfecfin = agnfecfin;
	 	 	 this.agndescripcion = agndescripcion;
	 	 }
	 }
}
