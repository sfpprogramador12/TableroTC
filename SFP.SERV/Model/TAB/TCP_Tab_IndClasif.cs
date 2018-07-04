using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_IndClasif
	 {
	 	 public int indclave  { set; get; } 
	 	 public int ipoclave  { set; get; } 
 
	 	 public TCP_Tab_IndClasif () {} 
 
	 	 public TCP_Tab_IndClasif (
	 	  int indclave, int ipoclave
	 	 	 )
	 	 {
	 	 	 this.indclave = indclave;
	 	 	 this.ipoclave = ipoclave;
	 	 }
	 }
}
