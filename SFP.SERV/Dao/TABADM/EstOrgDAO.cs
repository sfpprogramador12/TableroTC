

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SFP.Persistencia.Dao;

namespace SFP.SIT.SERV.Dao.TABADM
{
    public class EstOrgDAO : BaseDao
    {
        public EstOrgDAO(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }


        public Object dmlAgregarDetalle(EstOrgDetalle oDatos)
        {
            String sSQL = " INSERT INTO TCE_ADM_EstOrgDet( " +
                "EOCLAVE, EODCLAVE, ARACLAVE, EODOrden, EODReporta, " +
                "EODPLAZAS, EODPLAZASGPO, EODPRESUPUESTO, EODPRESUPUESTOGPO, EODCALIFICACION, " +
                "EODCALIFGPO )" +
                " VALUES ( " +
                
                "' ) ";
            //return EjecutaDML(sSQL, oDatos.EOD_EOId, oDatos.EOD_Id, oDatos.EOD_NivelId, oDatos.EOD_Orden, oDatos.EOD_Reporta, oDatos.EOD_ReportaOrg);
            return EjecutaOracleCommand(sSQL);
        }


      


        public int dmlEditar(EstOrgDetalle oDatos)
        {
            throw new NotImplementedException();
        }


        public int dmlBorrar(EstOrgDetalle oDatos)
        {
            throw new NotImplementedException();
        }


        public List<EstOrgDetalle> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM Area ";
            return CrearListaMDL<EstOrgDetalle>(ConsultaDML(sSQL) as DataTable);
        }





        /*INICIO*/
        public List<EstOrgDetalle> dmlSelectByAreaYear(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = "SELECT * FROM TCE_ADM_ESTORGDET WHERE  EOCLAVE = "+dicParametros["date"]+" and araclave = "+dicParametros["araclave"]+"";

            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = ConsultaDML(sqlQuery, dicParam);
            List<EstOrgDetalle> lstAdmUsuMdl = CrearListaMDL<EstOrgDetalle>(dt);
            return lstAdmUsuMdl;
        }




        /*FIN*/

    }
}

