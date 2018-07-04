using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PROJECT.SERV.Model.Adm;
using PROJECT.SERV.Model.Tab;
using SFP.Persistencia.Model;
using SFP.Persistencia.Servicio;
using SFP.SERVICIOS.MODEL.ADM;
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

        public AdminController(IConfiguration settings)
        {
            config = settings;
            BaseDbMdl baseDb = new BaseDbMdl();

            baseDb.connectionString = config.GetConnectionString("_DB");
            baseDb.objDbConnection = config.GetSection("DataBaseObj")["objCxn"].ToString();
            baseDb.objDbTransaccion = config.GetSection("DataBaseObj")["objTran"].ToString();
            baseDb.objDbDataAdapter = config.GetSection("DataBaseObj")["objDataAdapter"].ToString();

            dbSer = new DmlDbSer(baseDb);
        }

        [HttpGet("[action]")]
        public IEnumerable<IndiceVM> GetIndicesByID(int startDateIndex)
        {
            
            List<IndiceVM> indices = new List<IndiceVM>();
            
            try
            {
                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                dicParam.Add("idIndicador", startDateIndex);
                List<IndiceVM> orga = new List<IndiceVM>();
                TCP_Adm_Area resultAreaDes = (TCP_Adm_Area)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoAreaIndice), dicParam);
                
                List<TCP_Tab_AreaInd> result = (List<TCP_Tab_AreaInd>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetIndicesById), dicParam);

                int num = 0;

               
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return indices;

        }

       
}
