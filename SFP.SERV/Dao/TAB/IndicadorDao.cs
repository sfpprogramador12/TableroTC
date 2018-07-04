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
	 public class TCP_Tab_IndicadorDao : BaseDao
	 {
	 	 public TCP_Tab_IndicadorDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	}
 
        /*
	 	 public Object dmlAgregar(TCP_Tab_Indicador oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Indicador( indclave, inddescripcion, indnombre, indreglamint, indfeccreacion, indformula, indunidad, indperiodicidad, indproveedor, indtipocalculo, indmpp, indtipoavance, indfeccalculo) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.indclave, oDatos.inddescripcion, oDatos.indnombre, oDatos.indreglamint, oDatos.indfeccreacion, oDatos.indformula, oDatos.indunidad, oDatos.indperiodicidad, oDatos.indproveedor, oDatos.indtipocalculo, oDatos.indmpp, oDatos.indtipoavance, oDatos.indfeccalculo ); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Tab_Indicador> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Tab_Indicador( indclave, inddescripcion, indnombre, indreglamint, indfeccreacion, indformula, indunidad, indperiodicidad, indproveedor, indtipocalculo, indmpp, indtipoavance, indfeccalculo) VALUES (  @P0, @P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8, @P9, @P10, @P11, @P12) ";  
	 	 	  foreach (TCP_Tab_Indicador oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.indclave, oDatos.inddescripcion, oDatos.indnombre, oDatos.indreglamint, oDatos.indfeccreacion, oDatos.indformula, oDatos.indunidad, oDatos.indperiodicidad, oDatos.indproveedor, oDatos.indtipocalculo, oDatos.indmpp, oDatos.indtipoavance, oDatos.indfeccalculo ); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
        */
	 	 public int dmlEditar(TCP_Tab_Indicador oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Tab_Indicador oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Tab_Indicador> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Tab_Indicador ";
	 	 	  return CrearListaMDL<TCP_Tab_Indicador>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Tab_Indicador dmlSelectID(TCP_Tab_Indicador oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
            /*
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Tab_Indicador );
            */
	 	 	 if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Tab_Indicador );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Tab_Indicador );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }


        /*INICIO*/


        public List<TCP_Tab_Indicador> dmlSelectIndicadoresById(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            sqlQuery = "SELECT " + "Uni_id,ind_id,ind_tipo,ind_reporta,ind_consecutivo,ind_Nombre, " +
                " ind_Min, ind_Comentarios, ind_descripcion,  ind_Sat, ind_Sob, Ind_Resultado, Ind_Semaforo, ind_Tipo_Avance, ind_avance, ind_AvanceProject," +
                " ind_tipoobjetivo, ind_calificacion , ind_ponderacion, ind_periodicidad, " +
                " ind_valor, ind_reglamentoint, ind_formula, ind_correo, ind_proveedor, ind_responsable, " +
                "(Select Cat_Nombre  from Tablero_Catalogo where cat_valor_int = 2 and cat_tipo like 'OBJETIVO') as obj  , " +
                "(Select area_siglas from areas where ct_id = Uni_id and area_año = " +
                "(Select par_valor from tablero_parametros where par_nombre like 'AÑO_ACTIVO'))as unidad " +
                "FROM Tablero_Indicador WHERE Ind_año = (Select par_valor from tablero_parametros where par_nombre like 'AÑO_ACTIVO')  " +
                "And ind_tipoobjetivo<>0  ORDER BY uni_id,ind_tipo,ind_reporta,ind_consecutivo";
            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Tab_Indicador> lstAdmUsuMdl = CrearListaMDL<TCP_Tab_Indicador>(dt);
            return lstAdmUsuMdl;
        }



        /*FIN*/

    }
}
