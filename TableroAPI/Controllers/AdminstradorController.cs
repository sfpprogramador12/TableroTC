using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;
using Newtonsoft.Json;
using PROJECT.SERV.Model.ADM;
using Newtonsoft.Json.Linq;
using PROJECT.SERV.Dao.ADM;
using SFP.Persistencia.Servicio;
using SFP.Persistencia.Model;

namespace TableroControl.Controllers
{
    public class AdminstradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        /////* ********************************************
        ////       EDITOR DEFLUJO de HISTORIAL DE AREAS
        ////******************************************** */
        //    [HttpGet]
        //    public IActionResult AreasHistorial()
        //    {
        //        DmlDbSer dbSer = null;
        //        BaseDbMdl dbMdl = new BaseDbMdl();
        //        //dbMdl.connectionString = config.GetConnectionString("_DB");
        //        dbMdl.connectionString = "Server=sfp-dgmap1;Database=DGMAP;User Id=dgmap;Password=dgmap;";
        //        dbMdl.objDbConnection = "System.Data.SqlClient.SqlConnection,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbTransaccion = "System.Data.SqlClient.SqlTransacction,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbDataAdapter = "System.Data.SqlClient.SqlDataAdapter,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbSer = new DmlDbSer(dbMdl);

        //        AreaHistorialViewModel _catViewMdl = new AreaHistorialViewModel();
        //        DateTime date = Convert.ToDateTime("01/01/2018");
        //        date = date.Date;
        //        //_catViewMdl.lstAreaHist = JsonTransform.convertJson((List<TCP_ADM_AREAHIST>)dbSer.operEjecutar<TCP_ADM_AREAHISTDao>(nameof(TCP_ADM_AREAHISTDao.dmlSelectComboFecActual), date));
        //        string sRes = _catViewMdl.lstAreaHist.ToString();
        //        ViewBag.Areas = sRes;
        //        return View();
        //    }


        //    [HttpPost]
        //    public string FlujoAreas(string fechaF)
        //    {
        //        DmlDbSer dbSer = null;
        //        BaseDbMdl dbMdl = new BaseDbMdl();
        //        //dbMdl.connectionString = config.GetConnectionString("_DB");
        //        dbMdl.connectionString = "Server=sfp-dgmap1;Database=DGMAP;User Id=dgmap;Password=dgmap;";
        //        dbMdl.objDbConnection = "System.Data.SqlClient.SqlConnection,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbTransaccion = "System.Data.SqlClient.SqlTransacction,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbDataAdapter = "System.Data.SqlClient.SqlDataAdapter,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbSer = new DmlDbSer(dbMdl);

        //        string sRes = "";
        //        fechaF = fechaF.Replace('-', '/');
        //        AreaHistorialViewModel _catViewMdl = new AreaHistorialViewModel();
        //        DateTime date = Convert.ToDateTime(fechaF);
        //        date = date.Date;

        //        //_catViewMdl.lstAreaHist = JsonTransform.convertJson((List<TCP_ADM_AREAHIST>)dbSer.operEjecutar<TCP_ADM_AREAHISTDao>(nameof(TCP_ADM_AREAHISTDao.dmlSelectComboFecActual), date));
        //        sRes = _catViewMdl.lstAreaHist.ToString();
        //        return sRes;

        //    }


        //    [HttpPost]
        //    public string FlujoAreasTraerHijos(string fechaF, string id)
        //    {
        //        DmlDbSer dbSer = null;
        //        BaseDbMdl dbMdl = new BaseDbMdl();
        //        //dbMdl.connectionString = config.GetConnectionString("_DB");
        //        dbMdl.connectionString = "Server=sfp-dgmap1;Database=DGMAP;User Id=dgmap;Password=dgmap;";
        //        dbMdl.objDbConnection = "System.Data.SqlClient.SqlConnection,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbTransaccion = "System.Data.SqlClient.SqlTransacction,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbMdl.objDbDataAdapter = "System.Data.SqlClient.SqlDataAdapter,System.data, version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089";
        //        dbSer = new DmlDbSer(dbMdl);

        //        string sRes = "";
        //        fechaF = fechaF.Replace('-', '/');
        //        AreaHistorialViewModel _catViewMdl = new AreaHistorialViewModel();
        //        DateTime date = Convert.ToDateTime(fechaF);
        //        date = date.Date;
        //        string dataP = date.ToString("d") + "|" + id;
        //        //_catViewMdl.lstAreaHist = JsonTransform.convertJson((List<TCP_ADM_AREAHIST>)dbSer.operEjecutar<TCP_ADM_AREAHISTDao>(nameof(TCP_ADM_AREAHISTDao.dmlSelectAreaHijos), dataP));
        //        sRes = _catViewMdl.lstAreaHist.ToString();
        //        return sRes;

        //    }

        //    [HttpPost]
        //    public string FlujoAreasGuardarCambios(string JsonData)
        //    {
        //        JObject json = JObject.Parse(JsonData);
        //        //string first = json.fir;

        //        AreaVM areasToSave = JsonConvert.DeserializeObject<AreaVM>(JsonData);
        //        return "0";
        //    }

        //    [HttpGet]
        //    public string ARHGetParent(string id)
        //    {
        //        return "[{'text' : 'Root', 'id' : '1', 'children' : true}]";
        //    }

        //}

        //public class AreaHistorialViewModel
        //{
        //    public string lstAreaHist { get; set; }
        //}

    }   
}