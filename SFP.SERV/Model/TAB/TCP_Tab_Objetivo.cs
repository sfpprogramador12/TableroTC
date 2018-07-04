using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_Objetivo
	 {
	 	 public int objclave  { set; get; } 
	 	 public string objdescripcion  { set; get; } 
	 	 public DateTime objfeccreacion  { set; get; } 
	 	 public string objtipo  { set; get; } 
 
	 	 public TCP_Tab_Objetivo () {} 
 
	 	 public TCP_Tab_Objetivo (
	 	  int objclave, string objdescripcion, DateTime objfeccreacion, string objtipo
	 	 	 )
	 	 {
	 	 	 this.objclave = objclave;
	 	 	 this.objdescripcion = objdescripcion;
	 	 	 this.objfeccreacion = objfeccreacion;
	 	 	 this.objtipo = objtipo;
	 	 }
	 }
}
