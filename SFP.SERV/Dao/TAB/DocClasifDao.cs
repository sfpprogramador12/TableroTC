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
	 public class TCP_Tab_DocClasifDao : BaseDao
	 {
	 	 public TCP_Tab_DocClasifDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Tab_DocClasif oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_DocClasif( dcfclave, dcfdescripcion) VALUES (  @P0, @P1) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.dcfclave, oDatos.dcfdescripcion ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_DocClasif> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_DocClasif( dcfclave, dcfdescripcion) VALUES (  @P0, @P1) ";  
	 	 	  foreach (TCP_Tab_DocClasif oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.dcfclave, oDatos.dcfdescripcion ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Tab_DocClasif oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_DocClasif oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_DocClasif> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_DocClasif ";
	 	 	  return CrearListaMDL<TCP_Tab_DocClasif>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_DocClasif dmlSelectID(TCP_Tab_DocClasif oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_DocClasif );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_DocClasif );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_DocClasif );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
