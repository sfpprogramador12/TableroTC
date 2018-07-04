using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SFP.SIT.SERV.Model.DOC
{
	 public class SIT_DOC_DOCUMENTO
	 {
	 	 public string docmd5  { set; get; } 
	 	 public string docurl  { set; get; } 
	 	 public DateTime docfilesystem  { set; get; } 
	 	 public Int64 docclave  { set; get; } 
	 	 public int? extclave  { set; get; } 
	 	 public string docnombre  { set; get; } 
	 	 public string docfolio  { set; get; } 
	 	 public string docruta  { set; get; } 
	 	 public Int64 doctamaño  { set; get; } 
	 	 public DateTime docfecha  { set; get; } 
 
	 	 public SIT_DOC_DOCUMENTO () {}  
	 }
}
