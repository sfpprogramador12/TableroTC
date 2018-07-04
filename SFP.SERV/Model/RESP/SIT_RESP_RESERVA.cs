using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SFP.SIT.SERV.Model.RESP
{
	 public class SIT_RESP_RESERVA
	 {
	 	 public int? sdoclave  { set; get; } 
	 	 public int rsvdias  { set; get; } 
	 	 public int rsvmeses  { set; get; } 
	 	 public int rsvaños  { set; get; } 
	 	 public string rsvexpediente  { set; get; } 
	 	 public Int64 repclave  { set; get; } 
	 	 public int? momclave  { set; get; } 
	 	 public int? temclave  { set; get; } 
	 	 public int? araclave  { set; get; } 
	 	 public int rsvtipoclasif  { set; get; } 
	 	 public int rsvplazo  { set; get; } 
	 	 public DateTime rsvfecfin  { set; get; } 
	 	 public DateTime rsvfecini  { set; get; } 
	 	 public int rsvtiporeserva  { set; get; } 
 
	 	 public SIT_RESP_RESERVA () {} 
	 }
}
