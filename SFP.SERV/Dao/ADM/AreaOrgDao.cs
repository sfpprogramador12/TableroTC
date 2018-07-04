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
using SFP.SERVICIOS.MODEL.ADM;

namespace SERV.Dao.Adm
{
	 public class TCP_Adm_AreaOrgDao : BaseDao
	 {
	 	 public TCP_Adm_AreaOrgDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
        /*
	 	 public Object dmlAgregar(TCP_Adm_AreaOrg oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaOrg( araclavereporta, araclave, agnclave, araorden, arapresupuesto, arapersonas, aragpopersonas, aragrppresupuesto) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.araclavereporta, oDatos.araclave, oDatos.agnclave, oDatos.araorden, oDatos.arapresupuesto, oDatos.arapersonas, oDatos.aragpopersonas, oDatos.aragrppresupuesto ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Adm_AreaOrg> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_AreaOrg( araclavereporta, araclave, agnclave, araorden, arapresupuesto, arapersonas, aragpopersonas, aragrppresupuesto) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7) ";  
	 	 	  foreach (TCP_Adm_AreaOrg oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.araclavereporta, oDatos.araclave, oDatos.agnclave, oDatos.araorden, oDatos.arapresupuesto, oDatos.arapersonas, oDatos.aragpopersonas, oDatos.aragrppresupuesto ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
        */
 
 
	 	 public int dmlEditar(TCP_Adm_AreaOrg oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Adm_AreaOrg oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Adm_AreaOrg> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Adm_AreaOrg ";
	 	 	  return CrearListaMDL<TCP_Adm_AreaOrg>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Adm_AreaOrg dmlSelectID(TCP_Adm_AreaOrg oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
            /*
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaOrg );
            */
	 	 	 if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaOrg );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Adm_AreaOrg );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }
 
 
/*INICIO*/
 
 
/*FIN*/
 
	 }
}
