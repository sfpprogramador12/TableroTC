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
using SFP.SIT.SERV.Model.Adm;

namespace SFP.SERVICIOS.DAO.Adm
{
	 public class TCP_Adm_AreaDao : BaseDao
	 {
	 	 public TCP_Adm_AreaDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
	 	 {
	 	 }
 
 
	 	 public Object dmlAgregar(TCP_Adm_Area oDatos)
	 	 {
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_Area( araclave, arafeccreacion) VALUES (  @P0, @P1) ";  
	 	 	  return EjecutaDML ( sSQL,  oDatos.Area_Nombre, oDatos.Area_Objetivo); 
	 	 }
 
 
	 	 public int dmlImportar( List<TCP_Adm_Area> lstDatos)
	 	 {
	 	 	 int iTotReg = 0; 
	 	 	  String  sSQL = " INSERT INTO TCP_Adm_Area( araclave, arafeccreacion) VALUES (  @P0, @P1) ";  
	 	 	  foreach (TCP_Adm_Area oDatos in lstDatos) 
	 	 	  { 
	 	 	 	  EjecutaDML ( sSQL,  oDatos.Area_Objetivo, oDatos.Area_Objetivo); 
	 	 	 	  iTotReg++; 
	 	 	  } 
	 	 	  return iTotReg; 
	 	 }
 
 
	 	 public int dmlEditar(TCP_Adm_Area oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public int dmlBorrar(TCP_Adm_Area oDatos)
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public List<TCP_Adm_Area> dmlSelectTabla( )
	 	 {
	 	 	  String  sSQL = " SELECT * FROM TCP_Adm_Area ";
	 	 	  return CrearListaMDL<TCP_Adm_Area>(ConsultaDML(sSQL) as DataTable); 
	 	 }
 
 
	 	 public List<ComboMdl> dmlSelectCombo( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public Dictionary<int, string> dmlSelectDiccionario( )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
 
	 	 public TCP_Adm_Area dmlSelectID(TCP_Adm_Area oDatos )
	 	 {
	 	 	 throw new NotImplementedException(); 
	 	 }
 
	 	 public object dmlCRUD( Dictionary<string, object> dicParam )
	 	 {
	 	 	 int iOper = (int)dicParam[CMD_OPERACION]; 
 
	 	 	 if (iOper == OPE_INSERTAR) 
	 	 	 	 return dmlAgregar(dicParam[CMD_ENTIDAD] as TCP_Adm_Area );
 
	 	 	 else if (iOper == OPE_EDITAR)
	 	 	 	 return dmlEditar(dicParam[CMD_ENTIDAD] as TCP_Adm_Area );
 
	 	 	 else if (iOper == OPE_BORRAR)
	 	 	 	 return dmlBorrar(dicParam[CMD_ENTIDAD] as TCP_Adm_Area );
	 	 	 else 
	 	 	 	 return 0;
 
	 	 }


        /*INICIO*/
        public List<TCP_Adm_AreaOrg> dmlSelectOrganigrama(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = " SELECT(case when Area_Presupuesto is not null Then Area_Presupuesto / 1000000 Else 0 END) as " +
                "presupuesto, ROUND((CASE WHEN Area_CalifGpo IS NOT NULL THEN Area_CalifGpo ELSE 5 END), 1 ,1 ) " +
                "AS calificacion, (CASE WHEN Area_Personas IS NOT NULL THEN area_personas ELSE 0 END) AS personas, Area_Orden as Orden, Ct_ID as uni,  " +
                "Area_Nombre as descripcion, Area_siglas as siglas, Area_ID as Id FROM areas  WHERE Area_año = 2018 and Area_Reporta=4 order by Orden";


            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Adm_AreaOrg> lstAdmUsuMdl = CrearListaMDL<TCP_Adm_AreaOrg>(dt);
            return lstAdmUsuMdl;
        }


        public List<TCP_Adm_AreaOrg> dmlSelectOrganigramaById(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            sqlQuery = " SELECT(case when Area_Presupuesto is not null Then Area_Presupuesto / 1000000 Else 0 END) as presupuesto, " +
                " Area_CalifGpo AS calificacion," +
                "(CASE WHEN Area_Personas IS NOT NULL THEN area_personas ELSE 0 END) AS personas, Area_Nombre as descripcion, " +
                "Area_siglas as siglas, Area_ID as Id, Area_Orden as Orden,  Ct_ID as indicador  FROM areas " +
                "WHERE Area_año = 2018 and Area_Reporta = "+ dicParametros.First().Value + " order by Orden";
            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Adm_AreaOrg> lstAdmUsuMdl = CrearListaMDL<TCP_Adm_AreaOrg>(dt);
            return lstAdmUsuMdl;
        }

        public TCP_Adm_AreaOrg dmlSelectOrganigramaParent(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            sqlQuery = " SELECT(case when Area_Presupuesto is not null Then Area_Presupuesto / 1000000 Else 0 END) as presupuesto, " +
                "Area_CalifGpo  AS calificacion," +
                "(CASE WHEN Area_Personas IS NOT NULL THEN area_personas ELSE 0 END) AS personas, Area_Nombre as descripcion, " +
                "Area_siglas as siglas, Area_ID as Id, Area_Orden as Orden, Ct_ID as indicador  FROM areas " +
                "WHERE (Area_ID = " + dicParametros.First().Value + " and Area_Reporta = 4 and Area_año = 2018) order by Orden";
            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            TCP_Adm_AreaOrg lstAdmUsuMdl = CrearMDL<TCP_Adm_AreaOrg>(dt);
            return lstAdmUsuMdl;
        }

        public List<TCP_Adm_Area> dmlSelectAreaIndice(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "";
            
            sqlQuery = "SELECT Area_Objetivo, Area_Nombre, Area_Personas, Area_Presupuesto/1000000 as Area_Presupuesto, Area_CalifGpo as Area_Calificacion  FROM areas  " +
                "WHERE Ct_ID = '"+ dicParametros.First().Value + "' and Area_año = 2018  order by Area_Orden";
            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Adm_Area> lstAdmUsuMdl = CrearListaMDL<TCP_Adm_Area>(dt);
            return lstAdmUsuMdl;
        }



        public List<TCP_Adm_Obj> dmlSelectObjetivos(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "select Obj_ID, Obj_Descripcion from Tablero_Objetivos where Obj_Año = '2018' ";


            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<TCP_Adm_Obj> lstAdmUsuMdl = CrearListaMDL<TCP_Adm_Obj>(dt);
            return lstAdmUsuMdl;
        }


        /*FIN*/

    }
}
