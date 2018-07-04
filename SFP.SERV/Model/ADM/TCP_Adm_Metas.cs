using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_Metas
	 {
	 	 public int metclave  { set; get; } 
	 	 public string metdescripcion  { set; get; } 
	 	 public string metetiqueta  { set; get; } 
	 	 public string metbackcolor  { set; get; } 
	 	 public string metforecolor  { set; get; } 
	 	 public int tmpclave  { set; get; } 
 
	 	 public TCP_Adm_Metas () {} 
 
	 	 public TCP_Adm_Metas (
	 	  int metclave, string metdescripcion, string metetiqueta, string metbackcolor, string metforecolor, int tmpclave
	 	 	 )
	 	 {
	 	 	 this.metclave = metclave;
	 	 	 this.metdescripcion = metdescripcion;
	 	 	 this.metetiqueta = metetiqueta;
	 	 	 this.metbackcolor = metbackcolor;
	 	 	 this.metforecolor = metforecolor;
	 	 	 this.tmpclave = tmpclave;
	 	 }
	 }
}
