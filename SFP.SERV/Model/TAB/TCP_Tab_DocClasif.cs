using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_DocClasif
	 {
	 	 public int dcfclave  { set; get; } 
	 	 public string dcfdescripcion  { set; get; } 
 
	 	 public TCP_Tab_DocClasif () {} 
 
	 	 public TCP_Tab_DocClasif (
	 	  int dcfclave, string dcfdescripcion
	 	 	 )
	 	 {
	 	 	 this.dcfclave = dcfclave;
	 	 	 this.dcfdescripcion = dcfdescripcion;
	 	 }
	 }
}
