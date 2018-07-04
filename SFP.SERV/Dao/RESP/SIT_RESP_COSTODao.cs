using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using SFP.SIT.SERV.Model.RESP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SFP.SIT.SERV.Dao.RESP
{
    class SIT_RESP_COSTODao : BaseDao
    {
        public SIT_RESP_COSTODao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(SIT_RESP_COSTO oDatos)
        {
            String sSQL = " INSERT INTO SIT_RESP_COSTO( cosclave, coscd, coscarta, coscertificada) VALUES (  :P0, :P1, :P2, :P3) ";
            return EjecutaDML(sSQL, oDatos.cosclave, oDatos.coscd, oDatos.coscarta, oDatos.coscertificada);
        }


        public int dmlImportar(List<SIT_RESP_COSTO> lstDatos)
        {
            int iTotReg = 0;
            String sSQL = " INSERT INTO SIT_RESP_COSTO( cosclave, coscd, coscarta, coscertificada) VALUES (  :P0, :P1, :P2, :P3) ";
            foreach (SIT_RESP_COSTO oDatos in lstDatos)
            {
                EjecutaDML(sSQL, oDatos.cosclave, oDatos.coscd, oDatos.coscarta, oDatos.coscertificada);
                iTotReg++;
            }
            return iTotReg;
        }


        public int dmlEditar(SIT_RESP_COSTO oDatos)
        {
            String sSQL = " UPDATE SIT_RESP_COSTO SET  coscd= :P0, coscarta= :P1, coscertificada= :P2 WHERE  cosclave = :P3 ";
            return (int)EjecutaDML(sSQL, oDatos.cosclave, oDatos.coscd);
        }


        public int dmlBorrar(SIT_RESP_COSTO oDatos)
        {
            String sSQL = " DELETE FROM SIT_RESP_COSTO WHERE  cosclave = :P0 ";
            return (int)EjecutaDML(sSQL, oDatos.coscd);
        }


        public List<SIT_RESP_COSTO> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM SIT_RESP_COSTO ";
            return CrearListaMDL<SIT_RESP_COSTO>(ConsultaDML(sSQL) as DataTable);
        }


        public List<ComboMdl> dmlSelectCombo()
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> dmlSelectDiccionario()
        {
            throw new NotImplementedException();
        }


        public SIT_RESP_COSTO dmlSelectID(SIT_RESP_COSTO oDatos)
        {
            String sSQL = " SELECT * FROM SIT_RESP_COSTO WHERE  cosclave = :P0 ";
            return CrearListaMDL<SIT_RESP_COSTO>(ConsultaDML(sSQL, oDatos.coscd) as DataTable)[0];
        }

        public object dmlCRUD(Dictionary<string, object> dicParam)
        {
            int iOper = (int)dicParam[CMD_OPERACION];

            if (iOper == OPE_INSERTAR)
                return dmlAgregar(dicParam[CMD_ENTIDAD] as SIT_RESP_COSTO);

            else if (iOper == OPE_EDITAR)
                return dmlEditar(dicParam[CMD_ENTIDAD] as SIT_RESP_COSTO);

            else if (iOper == OPE_BORRAR)
                return dmlBorrar(dicParam[CMD_ENTIDAD] as SIT_RESP_COSTO);
            else
                return 0;

        }


        /*INICIO*/

        public DataTable dmlSelectGrid(BasePagMdl baseMdl)
        {
            String sqlQuery = " WITH Resultado AS( select COUNT(*) OVER() RESULT_COUNT, rownum recid, a.* from ( "
                + " SELECT coscd, cosclave from SIT_RESP_COSTO "
                + " ) a ) SELECT * from Resultado  WHERE recid  between :P0 and :P1 ";
            return (DataTable)ConsultaDML(sqlQuery, baseMdl.LimInf, baseMdl.LimSup);
        }

        /*FIN*/

    }
}
