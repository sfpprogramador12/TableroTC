using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using SFP.SIT.SERV.Model.RESP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Dao.RESP
{
    public class SIT_RESP_HABILITARDao : BaseDao
    {
        public SIT_RESP_HABILITARDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(SIT_RESP_HABILITAR oDatos)
        {
            String sSQL = " INSERT INTO SIT_RESP_HABILITAR( rtpclave, araclave, solclave) VALUES ( :P0, :P1, :P2) ";
            return EjecutaDML(sSQL, oDatos.rtpclave, oDatos.araclave);
        }


        public int dmlImportar(List<SIT_RESP_HABILITAR> lstDatos)
        {
            int iTotReg = 0;
            String sSQL = " INSERT INTO SIT_RESP_HABILITAR( rtpclave, araclave, solclave) VALUES (  :P0, :P1, :P2) ";
            foreach (SIT_RESP_HABILITAR oDatos in lstDatos)
            {
                EjecutaDML(sSQL, oDatos.rtpclave, oDatos.araclave);
                iTotReg++;
            }
            return iTotReg;
        }


        public int dmlEditar(SIT_RESP_HABILITAR oDatos)
        {
            throw new NotImplementedException();
        }


        public int dmlBorrar(SIT_RESP_HABILITAR oDatos)
        {
            String sSQL = " DELETE FROM SIT_RESP_HABILITAR WHERE rtpclave = :P0 AND araclave = :P1 AND solclave = :P0 ";
            return (int)EjecutaDML(sSQL, oDatos.araclave);
        }


        public List<SIT_RESP_HABILITAR> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM SIT_RESP_HABILITAR ";
            return CrearListaMDL<SIT_RESP_HABILITAR>(ConsultaDML(sSQL) as DataTable);
        }


        public List<ComboMdl> dmlSelectCombo()
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> dmlSelectDiccionario()
        {
            throw new NotImplementedException();
        }


        public SIT_RESP_HABILITAR dmlSelectID(SIT_RESP_HABILITAR oDatos)
        {
            String sSQL = " SELECT * FROM SIT_RESP_HABILITAR WHERE  rtpclave = :P0 AND araclave = :P1 AND solclave = :P0  ";
            return CrearListaMDL<SIT_RESP_HABILITAR>(ConsultaDML(sSQL, oDatos.rtpclave, oDatos.araclave, oDatos.solclave) as DataTable)[0];
        }

        public object dmlCRUD(Dictionary<string, object> dicParam)
        {
            int iOper = (int)dicParam[CMD_OPERACION];

            if (iOper == OPE_INSERTAR)
                return dmlAgregar(dicParam[CMD_ENTIDAD] as SIT_RESP_HABILITAR);

            else if (iOper == OPE_EDITAR)
                return dmlEditar(dicParam[CMD_ENTIDAD] as SIT_RESP_HABILITAR);

            else if (iOper == OPE_BORRAR)
                return dmlBorrar(dicParam[CMD_ENTIDAD] as SIT_RESP_HABILITAR);
            else
                return 0;

        }


        /*INICIO*/

        public DataTable dmlSelectGrid(BasePagMdl baseMdl)
        {
            String sqlQuery = " WITH Resultado AS( select COUNT(*) OVER() RESULT_COUNT, rownum recid, a.* from ( "
                + " SELECT * from SIT_RESP_HABILITAR "
                + " ) a ) SELECT * from Resultado  WHERE recid  between :P0 and :P1 ";
            return (DataTable)ConsultaDML(sqlQuery, baseMdl.LimInf, baseMdl.LimSup);
        }


        /*FIN*/

    }
}
