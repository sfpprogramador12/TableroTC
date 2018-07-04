using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_UsuPerArea
	 {
	 	 public int araclave  { set; get; } 
	 	 public int usuclave  { set; get; } 
	 	 public int prlclave  { set; get; } 
 
	 	 public TCP_Adm_UsuPerArea () {} 
 
	 	 public TCP_Adm_UsuPerArea (
	 	  int araclave, int usuclave, int prlclave
	 	 	 )
	 	 {
	 	 	 this.araclave = araclave;
	 	 	 this.usuclave = usuclave;
	 	 	 this.prlclave = prlclave;
	 	 }
	 }
}
