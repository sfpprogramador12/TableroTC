using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJECT.SERV.Model.Tab;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
 
namespace SERV.Dao.Tab
{
	 public class TCP_Tab_AreaIndDao : BaseDao
	 {
	 	 public TCP_Tab_AreaIndDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
            /*
	 	 public Object dmlAgregar(TCP_Tab_AreaInd oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_AreaInd( indclave, andorden, andmin, andsat, andsob, andpond, andavanceproject, andterminado, andresponsable, andcorreo, andcomentarios, andvalini, araclave, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.indclave, oDatos.andorden, oDatos.andmin, oDatos.andsat, oDatos.andsob, oDatos.andpond, oDatos.andavanceproject, oDatos.andterminado, oDatos.andresponsable, oDatos.andcorreo, oDatos.andcomentarios, oDatos.andvalini, oDatos.araclave, oDatos.tmpclave ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_AreaInd> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_AreaInd( indclave, andorden, andmin, andsat, andsob, andpond, andavanceproject, andterminado, andresponsable, andcorreo, andcomentarios, andvalini, araclave, tmpclave) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12, @P13) ";  
	 	 	  foreach (TCP_Tab_AreaInd oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.indclave, oDatos.andorden, oDatos.andmin, oDatos.andsat, oDatos.andsob, oDatos.andpond, oDatos.andavanceproject, oDatos.andterminado, oDatos.andresponsable, oDatos.andcorreo, oDatos.andcomentarios, oDatos.andvalini, oDatos.araclave, oDatos.tmpclave ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
        */
	 	 public int dmlEditar(TCP_Tab_AreaInd oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_AreaInd oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_AreaInd> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_AreaInd ";
	 	 	  return CrearListaMDL<TCP_Tab_AreaInd>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_AreaInd dmlSelectID(TCP_Tab_AreaInd oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
            /*
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaInd );
                */
	 	 	  if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaInd );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_AreaInd );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }


        /*INICIO*/


        public List<TCP_Tab_AreaInd> dmlSelectIndicesById(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            sqlQuery = "SELECT Ind_ID, Ind_tipo ,Ind_nombre, Ind_descripcion,  " +
                "Ind_Avance, Ind_Comentarios, " +
                " Ind_Calificacion, Ind_TipoObjetivo, " +
                " Uni_id,ind_reporta,ind_consecutivo, " +
                " ind_Min, ind_Sat, ind_Sob, Ind_Resultado," +
                " Ind_Semaforo, ind_Tipo_Avance, ind_AvanceProject," +
                " ind_ponderacion, ind_periodicidad, " +
                " ind_valor, ind_reglamentoint, ind_formula, ind_correo," +
                " ind_proveedor, ind_responsable, ind_unidad  " + 
                " FROM Tablero_Indicador WHERE " +
                "Uni_ID = '"+ dicParametros.First().Value + "' AND Ind_año = 2018 AND Ind_tipo = 'PRC'" +
                "ORDER BY Ind_nombre";

            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Tab_AreaInd> lstAdmUsuMdl = CrearListaMDL<TCP_Tab_AreaInd>(dt);
            return lstAdmUsuMdl;
        }


        /*FIN*/

    }
}
