using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_IndTipo
	 {
	 	 public int ipoclave  { set; get; } 
	 	 public string ipodescripcion  { set; get; } 
	 	 public string ipoicono  { set; get; } 
	 	 public DateTime ipofecini  { set; get; } 
	 	 public DateTime ipofecfin  { set; get; } 
 
	 	 public TCP_Tab_IndTipo () {} 
 
	 	 public TCP_Tab_IndTipo (
	 	  int ipoclave, string ipodescripcion, string ipoicono, DateTime ipofecini, DateTime ipofecfin
	 	 	 )
	 	 {
	 	 	 this.ipoclave = ipoclave;
	 	 	 this.ipodescripcion = ipodescripcion;
	 	 	 this.ipoicono = ipoicono;
	 	 	 this.ipofecini = ipofecini;
	 	 	 this.ipofecfin = ipofecfin;
	 	 }
	 }
}
