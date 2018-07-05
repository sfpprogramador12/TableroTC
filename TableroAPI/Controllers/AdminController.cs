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
using Newtonsoft.Json;


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
            dbMdl2.connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=172.29.149.10)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=DEV12C))); User Id=SIT; Password=Yi{sW|2XJ[; Max Pool Size= 20; Min Pool Size=1; Connection Lifetime=120; Connection Timeout=60; Incr Pool Size=1; Decr Pool Size=1;";
            dbMdl2.objDbConnection = "Oracle.ManagedDataAccess.Client.OracleConnection, Oracle.ManagedDataAccess, Version=4.122.1.0, Culture=neutral,PublicKeyToken=89b483f429c47342";
            dbMdl2.objDbTransaccion = "Oracle.ManagedDataAccess.Client.SqlTransaction, Oracle.ManagedDataAccess, Version=4.122.1.0, Culture=neutral,PublicKeyToken=89b483f429c47342";
            dbMdl2.objDbDataAdapter = "Oracle.ManagedDataAccess.Client.OracleDataAdapter, Oracle.ManagedDataAccess, Version=4.122.1.0, Culture=neutral,PublicKeyToken=89b483f429c47342";
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
                    dicParam.Add("date", startDateIndex);
                    dicParam.Add("araclave", ahActual.ARACLAVE.ToString());
                    List<EstOrgDetalle> estorgResult = (List<EstOrgDetalle>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetEstOrgByArea), dicParam);
                    partialResult.eoclave = estorgResult[0].EODCLAVE.ToString();
                    partialResult.eodreporta = estorgResult[0].EODREPORTA.ToString();


                    //Por cada Area se Obtienen sus indicadores
                    dicParam = new Dictionary<string, object>();
                    dicParam.Add("date", startDateIndex);
                    dicParam.Add("araclave", ahActual.ARACLAVE.ToString());
                    List<Indicador> indResult = (List<Indicador>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetIndByArea), dicParam);
                    partialResult.aIndicadr = JsonConvert.SerializeObject(indResult);
                    List<Seguimiento> seguimientos = new List<Seguimiento>();

                    foreach(Indicador indactual in indResult)
                    {
                        //Por cada Indicador se Obtienen su seguimiento
                        dicParam = new Dictionary<string, object>();
                        dicParam.Add("indclave", indactual.IndClave);
                        List<Seguimiento> segResult = (List<Seguimiento>)dbSerOracle.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetSegByInd), dicParam);
                        seguimientos.Add(segResult[0]);
                    }
                    partialResult.iSeguimiento = JsonConvert.SerializeObject(seguimientos) ;
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
        public string aIndicadr { get; set; }     // JSON
        public string  iSeguimiento { get; set; } // JSON
    }
}
