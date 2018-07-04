using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using PROJECT.SERV.Model.Tab;


namespace SERV.Dao.Tab
{
	 public class TCP_Tab_ObjetivoDao : BaseDao
	 {
	 	 public TCP_Tab_ObjetivoDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Tab_Objetivo oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Objetivo( objclave, objdescripcion, objfeccreacion, objtipo) VALUES (  @P0, @P1, @P2, @P3) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.objclave, oDatos.objdescripcion, oDatos.objfeccreacion, oDatos.objtipo ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_Objetivo> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Objetivo( objclave, objdescripcion, objfeccreacion, objtipo) VALUES (  @P0, @P1, @P2, @P3) ";  
	 	 	  foreach (TCP_Tab_Objetivo oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.objclave, oDatos.objdescripcion, oDatos.objfeccreacion, oDatos.objtipo ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Tab_Objetivo oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_Objetivo oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_Objetivo> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_Objetivo ";
	 	 	  return CrearListaMDL<TCP_Tab_Objetivo>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_Objetivo dmlSelectID(TCP_Tab_Objetivo oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_Objetivo );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_Objetivo );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_Objetivo );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
