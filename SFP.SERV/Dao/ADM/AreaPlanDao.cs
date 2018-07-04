using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using PROJECT.SERV.Model.Adm;

namespace SERV.Dao.Adm
{
	 public class TCP_Adm_AreaPlanDao : BaseDao
	 {
	 	 public TCP_Adm_AreaPlanDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Adm_AreaPlan oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaPlan( plnpp, plnpeimir, plnpeigi, plnpgcind, plnariind, plnaricocodi, plnriesgo, plncuadrante, plnresultado, plnalineacion, plnnivel, plnclasificacion, plnimpacto, plnocurrencia, plncontrolado, plnestrategia, plnptar, araclave, plnaño) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13, @P14, @P15, @P16, @P17, @P18) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.plnpp, oDatos.plnpeimir, oDatos.plnpeigi, oDatos.plnpgcind, oDatos.plnariind, oDatos.plnaricocodi, oDatos.plnriesgo, oDatos.plncuadrante, oDatos.plnresultado, oDatos.plnalineacion, oDatos.plnnivel, oDatos.plnclasificacion, oDatos.plnimpacto, oDatos.plnocurrencia, oDatos.plncontrolado, oDatos.plnestrategia, oDatos.plnptar, oDatos.araclave, oDatos.plnaño ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Adm_AreaPlan> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaPlan( plnpp, plnpeimir, plnpeigi, plnpgcind, plnariind, plnaricocodi, plnriesgo, plncuadrante, plnresultado, plnalineacion, plnnivel, plnclasificacion, plnimpacto, plnocurrencia, plncontrolado, plnestrategia, plnptar, araclave, plnaño) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13, @P14, @P15, @P16, @P17, @P18) ";  
	 	 	  foreach (TCP_Adm_AreaPlan oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.plnpp, oDatos.plnpeimir, oDatos.plnpeigi, oDatos.plnpgcind, oDatos.plnariind, oDatos.plnaricocodi, oDatos.plnriesgo, oDatos.plncuadrante, oDatos.plnresultado, oDatos.plnalineacion, oDatos.plnnivel, oDatos.plnclasificacion, oDatos.plnimpacto, oDatos.plnocurrencia, oDatos.plncontrolado, oDatos.plnestrategia, oDatos.plnptar, oDatos.araclave, oDatos.plnaño ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Adm_AreaPlan oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Adm_AreaPlan oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Adm_AreaPlan> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Adm_AreaPlan ";
	 	 	  return CrearListaMDL<TCP_Adm_AreaPlan>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Adm_AreaPlan dmlSelectID(TCP_Adm_AreaPlan oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaPlan );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaPlan );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaPlan );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
