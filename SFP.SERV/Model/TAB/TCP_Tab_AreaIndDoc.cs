using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_AreaIndDoc
	 {
	 	 public int docclave  { set; get; } 
	 	 public int indclave  { set; get; } 
	 	 public int dcfclave  { set; get; } 
	 	 public int araclave  { set; get; } 
	 	 public int tmpclave  { set; get; } 
 
	 	 public TCP_Tab_AreaIndDoc () {} 
 
	 	 public TCP_Tab_AreaIndDoc (
	 	  int docclave, int indclave, int dcfclave, int araclave, int tmpclave
	 	 	 )
	 	 {
	 	 	 this.docclave = docclave;
	 	 	 this.indclave = indclave;
	 	 	 this.dcfclave = dcfclave;
	 	 	 this.araclave = araclave;
	 	 	 this.tmpclave = tmpclave;
	 	 }
	 }
}
