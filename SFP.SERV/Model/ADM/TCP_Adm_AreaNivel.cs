using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_AreaNivel
	 {
	 	 public int anlclave  { set; get; } 
	 	 public string anldescripcion  { set; get; } 
 
	 	 public TCP_Adm_AreaNivel () {} 
 
	 	 public TCP_Adm_AreaNivel (
	 	  int anlclave, string anldescripcion
	 	 	 )
	 	 {
	 	 	 this.anlclave = anlclave;
	 	 	 this.anldescripcion = anldescripcion;
	 	 }
	 }
}
