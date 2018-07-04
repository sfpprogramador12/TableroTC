using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_Tiempo
	 {
	 	 public int tmpclave  { set; get; } 
	 	 public int tmpaño  { set; get; } 
	 	 public int tmpsemestre  { set; get; } 
	 	 public int tmpcuatrimestre  { set; get; } 
	 	 public int tmptrimestre  { set; get; } 
	 	 public int tmpbimestre  { set; get; } 
	 	 public int tmpmes  { set; get; } 
 
	 	 public TCP_Tab_Tiempo () {} 
 
	 	 public TCP_Tab_Tiempo (
	 	  int tmpclave, int tmpaño, int tmpsemestre, int tmpcuatrimestre, int tmptrimestre, int tmpbimestre, int tmpmes
	 	 	 )
	 	 {
	 	 	 this.tmpclave = tmpclave;
	 	 	 this.tmpaño = tmpaño;
	 	 	 this.tmpsemestre = tmpsemestre;
	 	 	 this.tmpcuatrimestre = tmpcuatrimestre;
	 	 	 this.tmptrimestre = tmptrimestre;
	 	 	 this.tmpbimestre = tmpbimestre;
	 	 	 this.tmpmes = tmpmes;
	 	 }
	 }
}
