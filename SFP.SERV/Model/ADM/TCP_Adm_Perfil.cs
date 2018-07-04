using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_Perfil
	 {
	 	 public int prlclave  { set; get; } 
	 	 public string prfdescripcion  { set; get; } 
 
	 	 public TCP_Adm_Perfil () {} 
 
	 	 public TCP_Adm_Perfil (
	 	  int prlclave, string prfdescripcion
	 	 	 )
	 	 {
	 	 	 this.prlclave = prlclave;
	 	 	 this.prfdescripcion = prfdescripcion;
	 	 }
	 }
}
