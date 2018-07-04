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
	 public class TCP_Adm_AreaGestionDao : BaseDao
	 {
	 	 public TCP_Adm_AreaGestionDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Adm_AreaGestion oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaGestion( agnclave, agnfecini, agnfecfin, agndescripcion) VALUES (  @P0, @P1, @P2, @P3) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.agnclave, oDatos.agnfecini, oDatos.agnfecfin, oDatos.agndescripcion ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Adm_AreaGestion> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaGestion( agnclave, agnfecini, agnfecfin, agndescripcion) VALUES (  @P0, @P1, @P2, @P3) ";  
	 	 	  foreach (TCP_Adm_AreaGestion oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.agnclave, oDatos.agnfecini, oDatos.agnfecfin, oDatos.agndescripcion ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Adm_AreaGestion oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Adm_AreaGestion oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Adm_AreaGestion> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Adm_AreaGestion ";
	 	 	  return CrearListaMDL<TCP_Adm_AreaGestion>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Adm_AreaGestion dmlSelectID(TCP_Adm_AreaGestion oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaGestion );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaGestion );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaGestion );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
