using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_Usuario
	 {
	 	 public int usuclave  { set; get; } 
	 	 public string usunombre  { set; get; } 
	 	 public string usupaterno  { set; get; } 
	 	 public string usumaterno  { set; get; } 
	 	 public double usucredencial  { set; get; } 
 
	 	 public TCP_Adm_Usuario () {} 
 
	 	 public TCP_Adm_Usuario (
	 	  int usuclave, string usunombre, string usupaterno, string usumaterno, double usucredencial
	 	 	 )
	 	 {
	 	 	 this.usuclave = usuclave;
	 	 	 this.usunombre = usunombre;
	 	 	 this.usupaterno = usupaterno;
	 	 	 this.usumaterno = usumaterno;
	 	 	 this.usucredencial = usucredencial;
	 	 }
	 }
}
