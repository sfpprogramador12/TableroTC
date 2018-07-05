
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SERV.Dao.TABADM;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;

namespace SFP.SIT.SERV.Dao.TABADM
{
    public class AreaHistorialDao : BaseDao
    {
        public AreaHistorialDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }



        public int dmlEditar(AreaHistorial oDatos)
        {
            throw new NotImplementedException();
        }


        public int dmlBorrar(AreaHistorial oDatos)
        {
            throw new NotImplementedException();
        }


        public List<AreaHistorial> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM Area ";
            return CrearListaMDL<AreaHistorial>(ConsultaDML(sSQL) as DataTable);
        }


        public List<ComboMdl> dmlSelectCombo()
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> dmlSelectDiccionario()
        {
            throw new NotImplementedException();
        }


        public AreaHistorial dmlSelectID(AreaHistorial oDatos)
        {
            throw new NotImplementedException();
        }



        /*INICIO*/
        public List<AreaHistorial> dmlSelectAllByYear(Dictionary<string, object> dicParametros)
        {
            String sqlQuery = " SELECT MAX(histnombre) AS histnombre, araclave, HISTFECHAFIN, HISTFECHAINI, HISTUA, HISTSIGLAS, HISTOBJETIVO " +
                "FROM TCE_ADM_AREAHIST  WHERE  '"+ dicParametros["date"] + "' between HISTFECHAINI and HISTFECHAFIN " +
                "GROUP BY araclave, HISTFECHAFIN, HISTFECHAINI, HISTUA, HISTSIGLAS, HISTOBJETIVO ";


            Dictionary<string, object> dicParam = new Dictionary<string, object>();
            DataTable dt = EjecutaOracleSelect(sqlQuery);
            List<AreaHistorial> lstAdmUsuMdl = CrearListaMDL<AreaHistorial>(dt);
            return lstAdmUsuMdl;
        }




        /*FIN*/

    }
}

