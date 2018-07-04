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
using PROJECT.SERV.Model.Tab;

namespace SERV.Dao.Tab
{
	 public class TCP_Tab_AreaIndDocDao : BaseDao
	 {
	 	 public TCP_Tab_AreaIndDocDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Tab_AreaIndDoc oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_AreaIndDoc( docclave, indclave, dcfclave, araclave, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.docclave, oDatos.indclave, oDatos.dcfclave, oDatos.araclave, oDatos.tmpclave ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_AreaIndDoc> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_AreaIndDoc( docclave, indclave, dcfclave, araclave, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4) ";  
	 	 	  foreach (TCP_Tab_AreaIndDoc oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.docclave, oDatos.indclave, oDatos.dcfclave, oDatos.araclave, oDatos.tmpclave ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Tab_AreaIndDoc oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_AreaIndDoc oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_AreaIndDoc> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_AreaIndDoc ";
	 	 	  return CrearListaMDL<TCP_Tab_AreaIndDoc>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_AreaIndDoc dmlSelectID(TCP_Tab_AreaIndDoc oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaIndDoc );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaIndDoc );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaIndDoc );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
