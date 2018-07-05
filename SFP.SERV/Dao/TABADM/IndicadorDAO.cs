using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;

namespace SFP.SIT.SERV.Dao.TABADM
{
    public class IndicadorDAO : BaseDao
    {

        public IndicadorDAO(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(Indicador oDatos)
        {
            String sSQL = " INSERT INTO TCE_IND_INDICADOR(  ARACLAVE, IndClave, GPOCLAVE, IndAño, IndUniID, IndReporta, IndConsecutivo, IndNombre, " +
                "IndDescripcion, IndMin, IndSat, IndSob, IndResultado, IndSemaforo, IndAvance, IndCalificacion, IndPonderacion, IndFormula, " +
                "IndUnidad, IndPeriodicidad, IndValor, IndProveedor, IndResponsable, IndCorreo, IndComentarios, IndTipoCalculo, IndMPP, " +
                "IndNotaCalculo, IndTipoObj, IndTipoAvance, IndAvanceProj, IndExcepcionCalc, IndReglamentoInt, IndTerminado, " +
                "IndPonderacionAjuste, IndFechaCalculo, IndOrdenMP) VALUES ("

                      + " '" + oDatos.IndUniClave
                      + "'," + oDatos.IndClave
                      + "," + oDatos.IndGPOCLAVE
                      + "," + oDatos.IndAño
                      + ",'" + oDatos.IndUniId
                      + "'," + oDatos.IndReporta
                      + "," + oDatos.IndConsecutivo
                      + ",'" + oDatos.IndNombre
                      + "','" + oDatos.IndDescripcion
                      + "','" + oDatos.IndMin
                      + "','" + oDatos.IndSat
                      + "','" + oDatos.IndSob
                      + "','" + oDatos.IndResultado
                      + "'," + oDatos.IndSemaforo
                      + "," + oDatos.IndAvance
                      + "," + oDatos.IndCalificacion
                      + "," + oDatos.IndPonderacion
                      + ",'" + oDatos.IndFormula
                      + "','" + oDatos.IndUnidad
                      + "','" + oDatos.IndPeriodicidad
                      + "','" + oDatos.IndValor
                      + "','" + oDatos.IndProveedor
                      + "','" + oDatos.IndResponsable
                      + "','" + oDatos.IndCorreo
                      + "','" + oDatos.IndComentarios
                      + "'," + oDatos.IndTipoCalculo
                      + ",'" + oDatos.IndMPP
                      + "','" + oDatos.IndNotaCalculo
                      + "'," + oDatos.IndTipoObj
                      + "," + oDatos.IndTipoAvance
                      + "," + oDatos.IndAvanceProj
                      + "," + oDatos.IndExcepcionCalc
                      + ",'" + oDatos.IndReglamentoInt
                      + "'," + oDatos.IndTerminado
                      + "," + oDatos.IndPonderacionAjuste
                      + "," + oDatos.IndFechaCalculo
                      + "," + oDatos.IndOrdenMP

                    + ") ";

            return EjecutaOracleCommand(sSQL);
        }

        /*
        public Object dmlAgregarIndObj(IndObj oDatos)
        {
            String sSQL = " INSERT INTO TCE_IND_OBJ( IndClave, ObjClave ) VALUES ("

                     + " " + oDatos.Indclave
                     + "," + oDatos.ObjClave
                     + ") ";

            return EjecutaOracleCommand(sSQL);

        }
        */

        public List<Indicador> GetIndicadores(Dictionary<string, object> dicParam)
        {
            String sqlQuery = " SELECT * FROM TCE_IND_INDICADOR WHERE araclave = " +dicParam["araclave"]+ " and indaño = " + dicParam["date"];

            DataTable dt = EjecutaOracleSelect(sqlQuery);
            List<Indicador> lstAdmUsuMdl = CrearListaMDL<Indicador>(dt);
            return lstAdmUsuMdl;
        }

    }
}