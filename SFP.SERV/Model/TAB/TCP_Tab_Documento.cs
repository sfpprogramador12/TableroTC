using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_Documento
	 {
	 	 public int docclave  { set; get; } 
	 	 public DateTime docfec  { set; get; } 
	 	 public string docnombre  { set; get; } 
	 	 public string docruta  { set; get; } 
	 	 public int dtpclave  { set; get; } 
	 	 public int doctamaño  { set; get; } 
 
	 	 public TCP_Tab_Documento () {} 
 
	 	 public TCP_Tab_Documento (
	 	  int docclave, DateTime docfec, string docnombre, string docruta, int dtpclave, int doctamaño
	 	 	 )
	 	 {
	 	 	 this.docclave = docclave;
	 	 	 this.docfec = docfec;
	 	 	 this.docnombre = docnombre;
	 	 	 this.docruta = docruta;
	 	 	 this.dtpclave = dtpclave;
	 	 	 this.doctamaño = doctamaño;
	 	 }
	 }
}
