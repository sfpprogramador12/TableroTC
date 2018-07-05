using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PROJECT.SERV.Model.Adm;
using PROJECT.SERV.Model.Tab;
using SERV.Dao.TABADM;
using SFP.Persistencia.Model;
using SFP.Persistencia.Servicio;
using SFP.SERVICIOS.MODEL.ADM;
using SFP.SIT.SERV.Dao.TABADM;
using SFP.SIT.SERV.Model.Adm;
using TableroControl.Dao;
using TableroControl.Injection;


namespace TableroControl.Controllers
{
    [Route("TableroAPI/[controller]")]
    public class AdminController : Controller
    {
        protected readonly DmlDbSer _sitDmlDbSer;
        private readonly IConfiguration config;
        private readonly DmlDbSer dbSer = null;
        private readonly DmlDbSer dbSerOracle = null;


        public AdminController(IConfiguration settings)
        {
            config = settings;
            BaseDbMdl baseDb = new BaseDbMdl();

            baseDb.connectionString = config.GetConnectionString("_DB");
            baseDb.objDbConnection  = config.GetSection ("DataBaseObj")["objCxn"].ToString();
            baseDb.objDbTransaccion = config.GetSection("DataBaseObj")["objTran"].ToString();
            baseDb.objDbDataAdapter = config.GetSection("DataBaseObj")["objDataAdapter"].ToString();
            dbSer = new DmlDbSer(baseDb);


            BaseDbMdl dbMdl2 = new BaseDbMdl();
           dbSerOracle = new DmlDbSer(dbMdl2);
        }

        [HttpGet("[action]")]
        public IEnumerable<AreasIndicadoresVM> GetAreasIndicadoresByYear(int startDateIndex)
        {
            List<AreasIndicadoresVM> resultado = new List<AreasIndicadoresVM>();
            List<AreaHistorial> ah = new List<AreaHistorial>();

            try
            {
                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                dicParam.Add("date", "31/12/" + startDateIndex);
                List<AreaHistorial> result = (List<AreaHistorial>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetAreasByYear), dicParam);
                AreasIndicadoresVM partialResult = null;

                foreach (AreaHistorial ahActual in result)
                {
                    partialResult = new AreasIndicadoresVM();
                    partialResult.araclave = ahActual.ARACLAVE.ToString();
                    partialResult.histnombre = ahActual.HISTNOMBRE.ToString();
                    partialResult.histsiglas = ahActual.HISTSIGLAS.ToString();

                    //Por cada Area se obtiene su ESTORGDETALLE
                    dicParam = new Dictionary<string, object>();
                    dicParam.Add("date", "31/12/" + startDateIndex);
                    dicParam.Add("araclave", ahActual.ARACLAVE.ToString());
                    List<EstOrgDetalle> estorgResult = (List<EstOrgDetalle>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetEstOrgByArea), dicParam);
                    partialResult.eoclave = estorgResult[0].EODCLAVE.ToString();
                    partialResult.eodreporta = estorgResult[0].EODREPORTA.ToString();


                    //Por cada Area se Obtienen sus indicadores
                    dicParam = new Dictionary<string, object>();
                    dicParam.Add("date", "31/12/" + startDateIndex);
                    dicParam.Add("araclave", ahActual.ARACLAVE.ToString());
                    List<Indicador> indResult = (List<Indicador>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetIndByArea), dicParam);
                    partialResult.aIndicadr = indResult;
                    List<Seguimiento> seguimientos = new List<Seguimiento>();

                    foreach(Indicador indactual in indResult)
                    {
                        //Por cada Indicador se Obtienen su seguimiento
                        dicParam = new Dictionary<string, object>();
                        dicParam.Add("indclave", indactual.IndClave);
                        List<Seguimiento> segResult = (List<Seguimiento>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetSegByInd), dicParam);
                        seguimientos.Add(segResult[0]);
                    }
                    partialResult.iSeguimiento = seguimientos;
                    resultado.Add(partialResult);
                }

                
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return resultado;
        }

    }

    public class AreasIndicadoresVM
    {
        public string araclave {get; set;}
        public string histnombre {get; set;}
        public string eoclave {get; set;}
        public string eodreporta {get; set;}
        public string histsiglas {get; set;}
        //public string  {get; set;}
        public List<Indicador> aIndicadr { get; set; }
        public List<Seguimiento> iSeguimiento { get; set; }
    }
}
