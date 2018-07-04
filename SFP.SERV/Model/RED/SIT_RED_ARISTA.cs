using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SFP.SIT.SERV.Model.RED
{
	 public class SIT_RED_ARISTA
	 {
	 	 public int? rtpclave  { set; get; } 
	 	 public int? prcclave  { set; get; } 
	 	 public Int64? solclave  { set; get; } 
	 	 public int arihito  { set; get; } 
	 	 public int aridiasnat  { set; get; } 
	 	 public int aridiaslab  { set; get; } 
	 	 public DateTime arifecenvio  { set; get; } 
	 	 public Int64 ariclave  { set; get; } 
	 	 public Int64? noddestino  { set; get; } 
	 	 public Int64? nodorigen  { set; get; } 
 
	 	 public SIT_RED_ARISTA () {} 
	 }
}
