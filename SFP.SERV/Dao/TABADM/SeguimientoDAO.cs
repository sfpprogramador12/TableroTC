using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;

namespace SFP.SIT.SERV.Dao.TABADM
{
    public class SeguimientoDAO : BaseDao
    {

        public SeguimientoDAO(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(Seguimiento oDatos)
        {
            String sSQL = " INSERT INTO TCE_IND_SEGUIMIENTO(  IndClave , segclave , segtipo , segmes1 , segmes2 , segmes3 , " +
                "segmes4 , segmes5 , segmes6 , segmes7 , segmes8 , segmes9 , segmes10 , segmes11 , segmes12 , segresultado  ) VALUES (" +

                    oDatos.IndClave + "," +
                    oDatos.SegClave + ",'" +
                    oDatos.segtipo + "'," +
                    oDatos.segmes1 + "," +
                    oDatos.segmes2 + "," +
                    oDatos.segmes3 + "," +
                    oDatos.segmes4 + "," +
                    oDatos.segmes5 + "," +
                    oDatos.segmes6 + "," +
                    oDatos.segmes7 + "," +
                    oDatos.segmes8 + "," +
                    oDatos.segmes9 + "," +
                    oDatos.segmes10 + "," +
                    oDatos.segmes11 + "," +
                    oDatos.segmes12 + "," +
                    oDatos.segresultado

                    + ") ";

            return EjecutaOracleCommand(sSQL);
        }




        /*INICIO*/
        public List<Seguimiento> dmlSelectByIndClave(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "SELECT * FROM TCE_IND_SEGUIMIENTO WHERE INDCLAVE = "+ dicParametros["indclave"] +"";

            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<Seguimiento> lstAdmUsuMdl = CrearListaMDL<Seguimiento>(dt);
            return lstAdmUsuMdl;
        }

        /*FIN*/



    }
}