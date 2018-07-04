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
	 public class TCP_Tab_EstOrgHechosDao : BaseDao
	 {
	 	 public TCP_Tab_EstOrgHechosDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
 
	 	 public Object dmlAgregar(TCP_Tab_EstOrgHechos oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_EstOrgHechos( teocalif, teocalifgpo, teosemaforo, teoavance, teocalcnota, teocalcfecha, teotipo, indclave, tmpclave, agnclave, araclave, objclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.teocalif, oDatos.teocalifgpo, oDatos.teosemaforo, oDatos.teoavance, oDatos.teocalcnota, oDatos.teocalcfecha, oDatos.teotipo, oDatos.indclave, oDatos.tmpclave, oDatos.agnclave, oDatos.araclave, oDatos.objclave ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_EstOrgHechos> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_EstOrgHechos( teocalif, teocalifgpo, teosemaforo, teoavance, teocalcnota, teocalcfecha, teotipo, indclave, tmpclave, agnclave, araclave, objclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11) ";  
	 	 	  foreach (TCP_Tab_EstOrgHechos oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.teocalif, oDatos.teocalifgpo, oDatos.teosemaforo, oDatos.teoavance, oDatos.teocalcnota, oDatos.teocalcfecha, oDatos.teotipo, oDatos.indclave, oDatos.tmpclave, oDatos.agnclave, oDatos.araclave, oDatos.objclave ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Tab_EstOrgHechos oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_EstOrgHechos oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_EstOrgHechos> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_EstOrgHechos ";
	 	 	  return CrearListaMDL<TCP_Tab_EstOrgHechos>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_EstOrgHechos dmlSelectID(TCP_Tab_EstOrgHechos oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_EstOrgHechos );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_EstOrgHechos );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_EstOrgHechos );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
