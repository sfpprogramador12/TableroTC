//using PROJECT.SERV.Model.Adm;
using System;
using System.Collections.Generic;
using System.Data.Common;
using PROJECT.SERV.Model.Adm;
using PROJECT.SERV.Model.Tab;
using SERV.Dao.Tab;
using SFP.Persistencia;
using SFP.SERVICIOS.DAO.Adm;
using SFP.SERVICIOS.MODEL.ADM;
using SFP.SIT.SERV.Model.Adm;

namespace SFP.SERV.Services
{
    public class SeguridadSer : BaseFunc
    {
        /////// private readonly ILogger _logger;
        public const string PARAM_IP = "IP";
        public const string PARAM_ARCHIVO_MENSAJE = "ARCHIVO_MENSAJE";
        public const string PARAM_CFGCORREO = "CFGCORREO";

        public SeguridadSer(DbConnection cn, DbTransaction transaction, String sDataAdapter)
            : base(cn, transaction, sDataAdapter)
        {
        }


        /********************************ORGANIGRAMA*************************/
        public List<TCP_Adm_AreaOrg> GetInfoTacometros(Dictionary<string, object> dicParam)
        {
            List<TCP_Adm_AreaOrg> orga = new List<TCP_Adm_AreaOrg>();
            TCP_Adm_AreaOrg AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Adm_AreaDao(_cn, _transaction, _sDataAdapter).dmlSelectOrganigrama(dicParam);
            return orga;
        }

        public List<TCP_Adm_Obj> GetInfoObjetivos(Dictionary<string, object> dicParam)
        {
            List<TCP_Adm_Obj> orga = new List<TCP_Adm_Obj>();
            orga = new TCP_Adm_AreaDao(_cn, _transaction, _sDataAdapter).dmlSelectObjetivos(dicParam);
            return orga;
        }

        public List<TCP_Adm_AreaOrg> GetInfoTacometrosById(Dictionary<string, object> dicParam)
        {
            List<TCP_Adm_AreaOrg> orga = new List<TCP_Adm_AreaOrg>();
            TCP_Adm_AreaOrg AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Adm_AreaDao(_cn, _transaction, _sDataAdapter).dmlSelectOrganigramaById(dicParam);
            return orga;
        }

        public TCP_Adm_AreaOrg GetInfoTacometroParent(Dictionary<string, object> dicParam)
        {
            TCP_Adm_AreaOrg orga = new TCP_Adm_AreaOrg();
            TCP_Adm_AreaOrg AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Adm_AreaDao(_cn, _transaction, _sDataAdapter).dmlSelectOrganigramaParent(dicParam);
            return orga;
        }


        /********************************INDICES*************************************/
        public List<TCP_Tab_AreaInd> GetIndicesById(Dictionary<string, object> dicParam)
        {
            List<TCP_Tab_AreaInd> orga = new List<TCP_Tab_AreaInd>();
            TCP_Tab_AreaInd AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Tab_AreaIndDao(_cn, _transaction, _sDataAdapter).dmlSelectIndicesById(dicParam);
            return orga;
        }

        public TCP_Adm_Area GetInfoAreaIndice(Dictionary<string, object> dicParam)
        {
            TCP_Adm_Area orga = new TCP_Adm_Area();
            List<TCP_Adm_Area> organ = new List<TCP_Adm_Area>();
            TCP_Adm_Area AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            organ = new TCP_Adm_AreaDao(_cn, _transaction, _sDataAdapter).dmlSelectAreaIndice(dicParam);
            orga = organ.ToArray()[0];
            return orga;
        }



        /********************************INDICADORES*************************************/
        public List<TCP_Tab_Indicador> GetIndicadoresById(Dictionary<string, object> dicParam)
        {
            List<TCP_Tab_Indicador> orga = new List<TCP_Tab_Indicador>();
            TCP_Tab_AreaInd AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Tab_IndicadorDao(_cn, _transaction, _sDataAdapter).dmlSelectIndicadoresById(dicParam);
            return orga;
        }





        /********************************Seguimiento*************************************/
        public List<TCP_Tab_Seguimiento> GetSeguminetosById(Dictionary<string, object> dicParam)
        {
            List<TCP_Tab_Seguimiento> orga = new List<TCP_Tab_Seguimiento>();
            TCP_Tab_AreaInd AreaMdl = null;
            /* BUSCAR LOS DATOS DE LOS TACOMETROS*/
            orga = new TCP_Tab_SeguimientoDao(_cn, _transaction, _sDataAdapter).dmlSelectSeguimientosById(dicParam);
            return orga;
        }

    }
}
