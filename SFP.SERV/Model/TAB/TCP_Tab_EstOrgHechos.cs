using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_EstOrgHechos
	 {
	 	 public float teocalif  { set; get; } 
	 	 public float teocalifgpo  { set; get; } 
	 	 public int teosemaforo  { set; get; } 
	 	 public float teoavance  { set; get; } 
	 	 public string teocalcnota  { set; get; } 
	 	 public DateTime teocalcfecha  { set; get; } 
	 	 public string teotipo  { set; get; } 
	 	 public int indclave  { set; get; } 
	 	 public int tmpclave  { set; get; } 
	 	 public int agnclave  { set; get; } 
	 	 public int araclave  { set; get; } 
	 	 public int objclave  { set; get; } 
 
	 	 public TCP_Tab_EstOrgHechos () {} 
 
	 	 public TCP_Tab_EstOrgHechos (
	 	  float teocalif, float teocalifgpo, int teosemaforo, float teoavance, string teocalcnota, DateTime teocalcfecha, string teotipo, int indclave, int tmpclave, int agnclave, int araclave, int objclave
	 	 	 )
	 	 {
	 	 	 this.teocalif = teocalif;
	 	 	 this.teocalifgpo = teocalifgpo;
	 	 	 this.teosemaforo = teosemaforo;
	 	 	 this.teoavance = teoavance;
	 	 	 this.teocalcnota = teocalcnota;
	 	 	 this.teocalcfecha = teocalcfecha;
	 	 	 this.teotipo = teotipo;
	 	 	 this.indclave = indclave;
	 	 	 this.tmpclave = tmpclave;
	 	 	 this.agnclave = agnclave;
	 	 	 this.araclave = araclave;
	 	 	 this.objclave = objclave;
	 	 }
	 }
}
