using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_DocTipo
	 {
	 	 public int dtpclave  { set; get; } 
	 	 public string dtpdescripcion  { set; get; } 
	 	 public string dtpmime  { set; get; } 
 
	 	 public TCP_Tab_DocTipo () {} 
 
	 	 public TCP_Tab_DocTipo (
	 	  int dtpclave, string dtpdescripcion, string dtpmime
	 	 	 )
	 	 {
	 	 	 this.dtpclave = dtpclave;
	 	 	 this.dtpdescripcion = dtpdescripcion;
	 	 	 this.dtpmime = dtpmime;
	 	 }
	 }
}
