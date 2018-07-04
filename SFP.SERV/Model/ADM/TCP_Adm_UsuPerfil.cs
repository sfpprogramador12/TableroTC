using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_UsuPerfil
	 {
	 	 public int usuclave  { set; get; } 
	 	 public int prlclave  { set; get; } 
 
	 	 public TCP_Adm_UsuPerfil () {} 
 
	 	 public TCP_Adm_UsuPerfil (
	 	  int usuclave, int prlclave
	 	 	 )
	 	 {
	 	 	 this.usuclave = usuclave;
	 	 	 this.prlclave = prlclave;
	 	 }
	 }
}
