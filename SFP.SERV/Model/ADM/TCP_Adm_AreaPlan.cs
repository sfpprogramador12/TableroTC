using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Adm
{
	 public class TCP_Adm_AreaPlan
	 {
	 	 public string plnpp  { set; get; } 
	 	 public int plnpeimir  { set; get; } 
	 	 public int plnpeigi  { set; get; } 
	 	 public int plnpgcind  { set; get; } 
	 	 public int plnariind  { set; get; } 
	 	 public int plnaricocodi  { set; get; } 
	 	 public string plnriesgo  { set; get; } 
	 	 public int plncuadrante  { set; get; } 
	 	 public string plnresultado  { set; get; } 
	 	 public string plnalineacion  { set; get; } 
	 	 public string plnnivel  { set; get; } 
	 	 public string plnclasificacion  { set; get; } 
	 	 public int plnimpacto  { set; get; } 
	 	 public int plnocurrencia  { set; get; } 
	 	 public int plncontrolado  { set; get; } 
	 	 public string plnestrategia  { set; get; } 
	 	 public string plnptar  { set; get; } 
	 	 public int araclave  { set; get; } 
	 	 public int plnaño  { set; get; } 
 
	 	 public TCP_Adm_AreaPlan () {} 
 
	 	 public TCP_Adm_AreaPlan (
	 	  string plnpp, int plnpeimir, int plnpeigi, int plnpgcind, int plnariind, int plnaricocodi, string plnriesgo, int plncuadrante, string plnresultado, string plnalineacion, string plnnivel, string plnclasificacion, int plnimpacto, int plnocurrencia, int plncontrolado, string plnestrategia, string plnptar, int araclave, int plnaño
	 	 	 )
	 	 {
	 	 	 this.plnpp = plnpp;
	 	 	 this.plnpeimir = plnpeimir;
	 	 	 this.plnpeigi = plnpeigi;
	 	 	 this.plnpgcind = plnpgcind;
	 	 	 this.plnariind = plnariind;
	 	 	 this.plnaricocodi = plnaricocodi;
	 	 	 this.plnriesgo = plnriesgo;
	 	 	 this.plncuadrante = plncuadrante;
	 	 	 this.plnresultado = plnresultado;
	 	 	 this.plnalineacion = plnalineacion;
	 	 	 this.plnnivel = plnnivel;
	 	 	 this.plnclasificacion = plnclasificacion;
	 	 	 this.plnimpacto = plnimpacto;
	 	 	 this.plnocurrencia = plnocurrencia;
	 	 	 this.plncontrolado = plncontrolado;
	 	 	 this.plnestrategia = plnestrategia;
	 	 	 this.plnptar = plnptar;
	 	 	 this.araclave = araclave;
	 	 	 this.plnaño = plnaño;
	 	 }
	 }
}
