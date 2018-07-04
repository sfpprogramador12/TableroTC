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
	 public class TCP_Tab_IndTipoDao : BaseDao
	 {
	 	 public TCP_Tab_IndTipoDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Tab_IndTipo oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_IndTipo( ipoclave, ipodescripcion, ipoicono, ipofecini, ipofecfin) VALUES (  @P0, @P1, @P2, @P3, @P4) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.ipoclave, oDatos.ipodescripcion, oDatos.ipoicono, oDatos.ipofecini, oDatos.ipofecfin ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_IndTipo> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_IndTipo( ipoclave, ipodescripcion, ipoicono, ipofecini, ipofecfin) VALUES (  @P0, @P1, @P2, @P3, @P4) ";  
	 	 	  foreach (TCP_Tab_IndTipo oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.ipoclave, oDatos.ipodescripcion, oDatos.ipoicono, oDatos.ipofecini, oDatos.ipofecfin ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Tab_IndTipo oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_IndTipo oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_IndTipo> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_IndTipo ";
	 	 	  return CrearListaMDL<TCP_Tab_IndTipo>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_IndTipo dmlSelectID(TCP_Tab_IndTipo oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_IndTipo );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_IndTipo );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_IndTipo );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
