using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SFP.SIT.SERV.Model;
using SFP.Persistencia.Model;
using SFP.Persistencia.Servicio;
using TableroControl.Dao;
using TableroControl.Injection;
using SFP.SERVICIOS.MODEL.ADM;
using PROJECT.SERV.Model.Adm;

using System.Web.Http.Cors;

namespace TableroControl.Controllers
{
    [Route("TableroAPI/[controller]")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    
    public class OrganigramaController : Controller
    {
        public IList<AreaVM> _areas;

        protected readonly DmlDbSer _sitDmlDbSer;
        private readonly IConfiguration config;
        private readonly DmlDbSer dbSer = null;

        public OrganigramaController(IConfiguration settings)
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
        public IEnumerable<AreaVM> GetTacometrosHome()
        {
            int cont = 0;
            List<AreaVM> Tacometros = new List<AreaVM>();
            try
            {

                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                List<AreaVM> orga = new List<AreaVM>();
                List<TCP_Adm_AreaOrg> result = (List<TCP_Adm_AreaOrg>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoTacometros), dicParam);
                List<TCP_Adm_Obj> objs = (List<TCP_Adm_Obj>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoObjetivos), dicParam);

                float califGral = 0;
                float resultado = 0;
                int conta = 0;
                foreach (TCP_Adm_AreaOrg actual in result)
                {
                    //actual.objetivos = objs;
                    resultado = resultado + actual.calificacion;
                    conta++;
                }
                califGral = resultado / conta;
                if (califGral >= 10) califGral = 10;

                foreach (TCP_Adm_AreaOrg actual in result)
                {
                    AreaVM AreaMdl = new AreaVM();

                    AreaMdl.obj1 = objs.ToArray()[0].Obj_Descripcion;
                    AreaMdl.obj2 = objs.ToArray()[1].Obj_Descripcion;
                    AreaMdl.obj3 = objs.ToArray()[2].Obj_Descripcion;
                    AreaMdl.obj4 = objs.ToArray()[3].Obj_Descripcion;

                    AreaMdl.calificacion = actual.calificacion.ToString("0.0"); ;
                    AreaMdl.calificacionGral = califGral.ToString("0.0");
                    if (califGral >= 10) AreaMdl.calificacionGral = "10";
                    if (actual.calificacion >= 10) AreaMdl.calificacion = "10";

                    AreaMdl.Id = actual.Id;
                    AreaMdl.personas = actual.personas;
                    AreaMdl.presupuesto = actual.presupuesto.ToString("0.0");
                    AreaMdl.descripcion = actual.descripcion;
                    AreaMdl.siglas = actual.siglas;
                    if (cont >= 4) { AreaMdl.url = "/Indice/" + actual.uni; }
                    else { AreaMdl.url = "/Organigrama/"+actual.Id; }
                    if (cont == 5) { AreaMdl.url = "/Organigrama/" + actual.Id; }
                    orga.Add(AreaMdl);
                    cont++;
                }
                Tacometros = orga;
            }
            catch (Exception e) {
                Console.Write(e.Message);
            }
            
            return Tacometros;
            
        }

        [HttpGet("[action]")]
        public IEnumerable<AreaVM> GetTacometrosByID(int id)
        {
            List<AreaVM> Tacometros = new List<AreaVM>();
            try
            {
                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                dicParam.Add("idPadre", id);
                var orga = new List<AreaVM>();
                List<TCP_Adm_AreaOrg> result = (List<TCP_Adm_AreaOrg>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoTacometrosById), dicParam);
                TCP_Adm_AreaOrg parent = (TCP_Adm_AreaOrg)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoTacometroParent), dicParam);

                AreaVM AreaMdl = new AreaVM();
                AreaMdl.calificacion = parent.calificacion.ToString("0.0");
                if (parent.calificacion >= 10) AreaMdl.calificacion = "10";

                AreaMdl.Id = parent.Id;
                AreaMdl.personas = parent.personas;
                AreaMdl.presupuesto = parent.presupuesto.ToString("0.0");
                AreaMdl.descripcion = parent.descripcion;
                AreaMdl.indicador = parent.indicador;
                AreaMdl.siglas = parent.siglas;
                AreaMdl.linkActive = "isDisabled";

                orga.Add(AreaMdl);

                int cont = 0; 
                foreach (TCP_Adm_AreaOrg actual in result)
                {
                    AreaMdl = new AreaVM();
                    AreaMdl.calificacion = actual.calificacion.ToString("0.0");
                    if (actual.calificacion >= 10) AreaMdl.calificacion = "10";
                    AreaMdl.Id = actual.Id;
                    AreaMdl.personas = actual.personas;
                    AreaMdl.presupuesto = actual.presupuesto.ToString("0.0");
                    AreaMdl.descripcion = actual.descripcion;
                    AreaMdl.siglas = actual.siglas;
                    AreaMdl.indicador = actual.indicador;
                    AreaMdl.linkActive = "";
                    orga.Add(AreaMdl);
                    cont++;
                }
                switch (cont)
                {
                    case (1):
                        var setm = 0; int posFM = 0;
                        AreaVM AreaMdlF = new AreaVM();
                        foreach (AreaVM p in orga) {
                            p.tp = "tp1"; if (setm == 0) { p.linkActive = "";  setm++; }
                            p.tp1 = "tp11";
                            p.tp2 = "s";
                            p.tp3 = "null";
                            p.tp4 = "";
                            p.tp5 = "tablecontainer3";
                            p.tp7 = "tacHead1";
                            p.svgM = "hidden,hidden,hidden,showed";
                            //if (posFM == 1) orga[1] = AreaMdlF;
                        }
                        
                       // orga.Add(AreaMdl);
                        //orga.Add(AreaMdl);
                        break;

                    case (4):
                        foreach (AreaVM p in orga) {
                            p.tp = "tp4";
                            p.tp1 = "tp41";
                            p.tp2 = "tp42";
                            p.tp3 = "s";
                            p.tp4 = "null";
                            p.tp5 = "s";
                            p.tp6 = "null";
                            p.tp7 = "tacHead4";
                            p.svgM = "hidden,hidden,showed,hidden";
                        }
                        break;

                    case (5):
                        foreach (AreaVM p in orga) {
                            p.tp = "null";
                            p.tp1 = "t51";
                            p.tp2 = "t52";
                            p.tp3 = "s";
                            p.tp4 = "null";
                            p.tp5 = "s";
                            p.tp6 = "null";
                            p.tp7 = "tacHead5";
                            p.svgM = "hidden,showed,hidden,hidden";
                        }
                        break;

                    case (6):
                        foreach (AreaVM p in orga) {
                            p.tp = "null";
                            p.tp1 = "t61";
                            p.tp2 = "t62";
                            p.tp3 = "separationC";
                            p.tp4 = "null";
                            p.tp5 = "s";
                            p.tp6 = "s";
                            p.tp7 = "tacHead6";
                            p.svgM = "showed,hidden,hidden,hidden"; }
                        break;

                }
                Tacometros = orga;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return Tacometros;
        }

        [HttpGet("[action]")]
        public IEnumerable<AreaVM> GetAreas(int startDateIndex)
        {
            _areas = new List<AreaVM>();
            return _areas;
        }

    }
}
