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
	 public class TCP_Tab_SeguimientoDao : BaseDao
	 {
	 	 public TCP_Tab_SeguimientoDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
        /*
	 	 public Object dmlAgregar(TCP_Tab_Seguimiento oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Seguimiento( araclave, indclave, segtipo, segmes1, segmes2, segmes3, segmes4, segmes5, segmes6, segmes7, segmes8, segmes9, segmes10, segmes11, segmes12, segresultado, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13, @P14, @P15, @P16) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.araclave, oDatos.indclave, oDatos.segtipo, oDatos.segmes1, oDatos.segmes2, oDatos.segmes3, oDatos.segmes4, oDatos.segmes5, oDatos.segmes6, oDatos.segmes7, oDatos.segmes8, oDatos.segmes9, oDatos.segmes10, oDatos.segmes11, oDatos.segmes12, oDatos.segresultado, oDatos.tmpclave ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_Seguimiento> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Seguimiento( araclave, indclave, segtipo, segmes1, segmes2, segmes3, segmes4, segmes5, segmes6, segmes7, segmes8, segmes9, segmes10, segmes11, segmes12, segresultado, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13, @P14, @P15, @P16) ";  
	 	 	  foreach (TCP_Tab_Seguimiento oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.araclave, oDatos.indclave, oDatos.segtipo, oDatos.segmes1, oDatos.segmes2, oDatos.segmes3, oDatos.segmes4, oDatos.segmes5, oDatos.segmes6, oDatos.segmes7, oDatos.segmes8, oDatos.segmes9, oDatos.segmes10, oDatos.segmes11, oDatos.segmes12, oDatos.segresultado, oDatos.tmpclave ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
        */
 
	 	 public int dmlEditar(TCP_Tab_Seguimiento oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_Seguimiento oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_Seguimiento> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_Seguimiento ";
	 	 	  return CrearListaMDL<TCP_Tab_Seguimiento>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_Seguimiento dmlSelectID(TCP_Tab_Seguimiento oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 

	 	 	  if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_Seguimiento );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_Seguimiento );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }


        /*INICIO*/
        public List<TCP_Tab_Seguimiento> dmlSelectSeguimientosById(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            sqlQuery = "Select * from tablero_seguimiento where Ind_Año='2018' and Uni_ID = '" + dicParametros.First().Value + "' AND Ind_ID='"+ dicParametros.Last().Value + "'";
            //Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParametros);
            List<TCP_Tab_Seguimiento> lstAdmUsuMdl = CrearListaMDL<TCP_Tab_Seguimiento>(dt);
            return lstAdmUsuMdl;
        }


        /*FIN*/

    }
}
