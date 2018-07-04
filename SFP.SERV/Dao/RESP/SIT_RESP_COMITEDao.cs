using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using SFP.SIT.SERV.Model.RESP;
using System;
using System.Collections.Generic;
using System.Data.Common;

namespace SFP.SIT.SERV.Dao.RESP
{
    public class SIT_RESP_COMITEDao : BaseDao
    {
        public SIT_RESP_COMITEDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(SIT_RESP_COMITE oDatos)
        {
            String sSQL = " INSERT INTO SIT_RESP_COMITE( corClave, repClave) VALUES ( :P0, :P1) ";
            return EjecutaDML(sSQL, oDatos.corClave, oDatos.repClave );
        }


        public int dmlImportar(List<SIT_RESP_COMITE> lstDatos)
        {
            int iTotReg = 0;
            String sSQL = " INSERT INTO SIT_RESP_COMITE( corClave, repClave ) VALUES ( :P0, :P1 ) ";
            foreach (SIT_RESP_COMITE oDatos in lstDatos)
            {
                EjecutaDML(sSQL, oDatos.corClave, oDatos.repClave);
                iTotReg++;
            }
            return iTotReg;
        }


        public int dmlEditar(SIT_RESP_COMITE oDatos)
        {
            throw new NotImplementedException();            
        }

        public int dmlBorrar(SIT_RESP_COMITE oDatos)
        {
            String sSQL = " DELETE FROM SIT_RESP_COMITE WHERE corClave = :P0 AND repClave= :P1 ";
            return (int)EjecutaDML(sSQL, oDatos.corClave, oDatos.repClave);
        }

        public List<SIT_RESP_COMITE> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM SIT_RESP_COMITE ";
            return CrearListaMDL<SIT_RESP_COMITE>(ConsultaDML(sSQL));
        }


        public List<ComboMdl> dmlSelectCombo()
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> dmlSelectDiccionario()
        {
            throw new NotImplementedException();
        }


        public SIT_RESP_COMITE dmlSelectID(SIT_RESP_COMITE oDatos)
        {
            throw new NotImplementedException();
        }


        /*INICIO*/

        public List<SIT_RESP_COMITE> dmlSelectRespID( long repClave)
        {
            String sSQL = " SELECT * FROM SIT_RESP_COMITE WHERE repClave = :P0";
            return CrearListaMDL<SIT_RESP_COMITE>(ConsultaDML(sSQL));
        }

        /*FIN*/

    }
}
