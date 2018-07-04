using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_AreaTipo
	 {
	 	 public int atpclave  { set; get; } 
	 	 public string atpdescripcion  { set; get; } 
 
	 	 public TCP_Adm_AreaTipo () {} 
 
	 	 public TCP_Adm_AreaTipo (
	 	  int atpclave, string atpdescripcion
	 	 	 )
	 	 {
	 	 	 this.atpclave = atpclave;
	 	 	 this.atpdescripcion = atpdescripcion;
	 	 }
	 }
}
