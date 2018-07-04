using SFP.Persistencia.Dao;
using SFP.Persistencia.Model;
using SFP.SIT.SERV.Model.RESP;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFP.SIT.SERV.Dao.RESP
{
    public class SIT_RESP_CLASIFICARDao : BaseDao
    {
        public SIT_RESP_CLASIFICARDao(DbConnection cn, DbTransaction transaction, String dataAdapter) : base(cn, transaction, dataAdapter)
        {
        }

        public Object dmlAgregar(SIT_RESP_CLASIFICAR oDatos)
        {
            String sSQL = " INSERT INTO SIT_RESP_CLASIFICAR( rtpClave, repClave) VALUES ( :P0, :P1) ";
            return EjecutaDML(sSQL, oDatos.rtpClave, oDatos.repClave);
        }


        public int dmlImportar(List<SIT_RESP_CLASIFICAR> lstDatos)
        {
            int iTotReg = 0;
            String sSQL = " INSERT INTO SIT_RESP_CLASIFICAR( rtpClave, repClave ) VALUES ( :P0, :P1 ) ";
            foreach (SIT_RESP_CLASIFICAR oDatos in lstDatos)
            {
                EjecutaDML(sSQL, oDatos.rtpClave, oDatos.repClave);
                iTotReg++;
            }
            return iTotReg;
        }


        public int dmlEditar(SIT_RESP_CLASIFICAR oDatos)
        {
            throw new NotImplementedException();
        }

        public int dmlBorrar(SIT_RESP_CLASIFICAR oDatos)
        {
            String sSQL = " DELETE FROM SIT_RESP_CLASIFICAR WHERE rtpClave = :P0 AND repClave= :P1 ";
            return (int)EjecutaDML(sSQL, oDatos.rtpClave, oDatos.repClave);
        }

        public List<SIT_RESP_CLASIFICAR> dmlSelectTabla()
        {
            String sSQL = " SELECT * FROM SIT_RESP_CLASIFICAR ";
            return CrearListaMDL<SIT_RESP_CLASIFICAR>(ConsultaDML(sSQL));
        }


        public List<ComboMdl> dmlSelectCombo()
        {
            throw new NotImplementedException();
        }


        public Dictionary<int, string> dmlSelectDiccionario()
        {
            throw new NotImplementedException();
        }


        public SIT_RESP_CLASIFICAR dmlSelectID(SIT_RESP_CLASIFICAR oDatos)
        {
            throw new NotImplementedException();
        }


        /*INICIO*/

        public List<SIT_RESP_CLASIFICAR> dmlSelectRespID(long repClave)
        {
            String sSQL = " SELECT * FROM SIT_RESP_CLASIFICAR WHERE repClave = :P0";
            return CrearListaMDL<SIT_RESP_CLASIFICAR>(ConsultaDML(sSQL));
        }

        /*FIN*/

    }
}
