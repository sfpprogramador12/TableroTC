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
    public class IndiceController : Controller
    {
        protected readonly DmlDbSer _sitDmlDbSer;
        private readonly IConfiguration config;
        private readonly DmlDbSer dbSer = null;

        public IndiceController(IConfiguration settings)
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

                foreach (TCP_Tab_AreaInd actual in result)
                {
                    IndiceVM AreaMdl = new IndiceVM();
                    AreaMdl.descripcionA = resultAreaDes.Area_Objetivo;
                    AreaMdl.nombreA = resultAreaDes.Area_Nombre;
                    AreaMdl.presupuesto = resultAreaDes.Area_Presupuesto.ToString("0.0");
                    AreaMdl.personas = resultAreaDes.Area_Personas;
                    AreaMdl.calificacion = float.Parse(resultAreaDes.Area_Calificacion).ToString("0.0");
                    if (Int32.Parse(resultAreaDes.Area_Calificacion.Split('.')[0]) >= 10) AreaMdl.calificacion = "10";

                    AreaMdl.comentarios = "Comentario: " + actual.Ind_Comentarios.ToString();
                    if (actual.Ind_Comentarios.ToString().Length < 1) AreaMdl.comentariosflag = "hidden";
                    else { AreaMdl.comentariosflag = ""; }
                    AreaMdl.ID = num.ToString();
                    AreaMdl.num = (num+1).ToString();

                    AreaMdl.avance = actual.Ind_Avance.ToString("0.0");
                    AreaMdl.resultado = actual.Ind_Resultado;
                    AreaMdl.ponderacion = actual.Ind_Ponderacion.ToString();
                    AreaMdl.sat = actual.Ind_Sat;
                    AreaMdl.min = actual.Ind_Min;
                    AreaMdl.sob = actual.Ind_Sob;
                    AreaMdl.indicador = actual.Ind_nombre.ToString();
                    AreaMdl.nombre = actual.Ind_nombre;
                    AreaMdl.descripcion = actual.Ind_descripcion;
                    AreaMdl.semaforo = actual.Ind_Semaforo.ToString();
                    AreaMdl.tipoObjetivo = actual.Ind_TipoObjetivo.ToString();

                    AreaMdl.descripcion = actual.Ind_descripcion;
                    AreaMdl.formula = actual.ind_formula;
                    AreaMdl.responsable = actual.ind_responsable;
                    AreaMdl.correo = actual.ind_correo;
                    AreaMdl.proveedor = actual.ind_proveedor;
                    switch (Int32.Parse(actual.ind_Periodicidad))
                    {
                        case (12):
                            AreaMdl.periodicidad = "Mensual";
                            break;
                        case (4):
                            AreaMdl.periodicidad = "Trimestral";
                            break;
                        case (1):
                            AreaMdl.periodicidad = "Anual";
                            break;
                    }
                    AreaMdl.ponderacion = actual.Ind_Ponderacion.ToString();
                    switch (Int32.Parse(actual.ind_AvanceProject.ToString()))
                    {
                        case (1):
                            AreaMdl.project = "SI";
                            break;
                        case (0):
                            AreaMdl.project = "NO";
                            break;
                    }
                    switch (2)//Int32.Parse(actual.ind_tipoCalculo.ToString()))
                    {

                        case (2):
                            AreaMdl.tipoIndicador = "Porcentaje";
                            break;
                            /*
                        case (1):
                            AreaMdl.tipoIndicador = "Sumatoria";
                            break;
                        case (3):
                            AreaMdl.tipoIndicador = "Independiente";
                            break;
                        case (4):
                            AreaMdl.tipoIndicador = "Fecha";
                            break;
                            */
                    }

                    
                    switch (AreaMdl.tipoObjetivo)
                    {
                        case ("64"):
                            AreaMdl.tipoObjetivo = "mundoBK";
                            break;
                        case ("1"):
                            AreaMdl.tipoObjetivo = "agendaBK";
                            break;
                        case ("8"):
                            AreaMdl.tipoObjetivo = "verdeBK";
                            break;        
                    }
                    
                    switch (actual.Ind_Semaforo)//Int32.Parse(actual.ind_tipoCalculo.ToString()))
                    {

                        case (1):
                            AreaMdl.semaforo = "verde";
                            break;
                        case (2):
                            AreaMdl.semaforo = "amarillo";
                            break;
                        case (8):
                            AreaMdl.semaforo = "reloj";
                            break;
                        case (3):
                            AreaMdl.semaforo = "rojo";
                            break;
                        case (100):
                            AreaMdl.semaforo = "gris";
                            break;
                        default:
                            AreaMdl.semaforo = "rojo";
                            break;
                    }
                    AreaMdl.reglamento = actual.ind_ReglamentoInt.ToString();
                    AreaMdl.valInicial = actual.ind_valor.ToString();

                    Dictionary<string, object> dicParamS = new Dictionary<string, object>();
                    dicParamS.Add("idUnidad", startDateIndex);
                    dicParamS.Add("idIndicador", actual.Ind_ID);
                    List<TCP_Tab_Seguimiento> seguimienots = (List<TCP_Tab_Seguimiento>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetSeguminetosById), dicParamS);
                    string seguimientoP = "";
                    string seguimientoR = "";
                    int sgID = 0;
                    foreach (TCP_Tab_Seguimiento sgm in seguimienots)
                    {
                        //primero P
                        if(sgID == 0)
                        {
                            seguimientoP = sgm.Seg_Mes1 + "," + sgm.Seg_Mes2 + "," + sgm.Seg_Mes3 + "," + sgm.Seg_Mes4 + "," + sgm.Seg_Mes5 + "," + sgm.Seg_Mes6 + "," + sgm.Seg_Mes7 + "," + sgm.Seg_Mes8 + "," + sgm.Seg_Mes9 + "," + sgm.Seg_Mes10 + "," + sgm.Seg_Mes11 + "," + sgm.Seg_Mes12 + "," + sgm.Seg_Resultado;
                        }
                        //segundo R
                        else
                        {
                            seguimientoR = sgm.Seg_Mes1 + "," + sgm.Seg_Mes2 + "," + sgm.Seg_Mes3 + "," + sgm.Seg_Mes4 + "," + sgm.Seg_Mes5 + "," + sgm.Seg_Mes6 + "," + sgm.Seg_Mes7 + "," + sgm.Seg_Mes8 + "," + sgm.Seg_Mes9 + "," + sgm.Seg_Mes10 + "," + sgm.Seg_Mes11 + "," + sgm.Seg_Mes12 + "," + sgm.Seg_Resultado;

                        }
                        sgID++;
                    }
                    AreaMdl.seguimientoP = seguimientoP;
                    AreaMdl.seguimientoR = seguimientoR;
                        num++;
                    orga.Add(AreaMdl);
                }
                indices = orga;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }

            return indices;

        }

        [HttpGet("[action]")]
        public IEnumerable<AreaVM> GetIndicesHome(int id)
        {
            
            List<AreaVM> Tacometros = new List<AreaVM>();
            try
            {
                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                dicParam.Add("idPadre", id);
                List<AreaVM> orga = new List<AreaVM>();
                List<TCP_Adm_AreaOrg> result = (List<TCP_Adm_AreaOrg>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoTacometrosById), dicParam);
                TCP_Adm_AreaOrg parent = (TCP_Adm_AreaOrg)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetInfoTacometroParent), dicParam);

                AreaVM AreaMdl = new AreaVM();
                AreaMdl.calificacion = parent.calificacion.ToString("0.0");
                AreaMdl.Id = parent.Id;
                AreaMdl.personas = parent.personas;
                AreaMdl.presupuesto = parent.presupuesto.ToString("0.0");
                AreaMdl.descripcion = parent.descripcion;
                AreaMdl.siglas = parent.siglas;
                orga.Add(AreaMdl);

                foreach (TCP_Adm_AreaOrg actual in result)
                {
                    AreaMdl = new AreaVM();
                    AreaMdl.calificacion = actual.calificacion.ToString("0.0");
                    AreaMdl.Id = actual.Id;
                    AreaMdl.personas = actual.personas;
                    AreaMdl.presupuesto = actual.presupuesto.ToString("0.0");
                    AreaMdl.descripcion = actual.descripcion;
                    AreaMdl.siglas = actual.siglas;
                    AreaMdl.indicador = actual.indicador;

                    orga.Add(AreaMdl);
                }
                Tacometros = orga;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            return Tacometros;
        }

    }

    public class IndiceVM
    {
       
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string personas { get; set; }
        public string presupuesto { get; set; }
        public string calificacion { get; set; }

        public string comentarios { get; set; }
        public string comentariosflag { get; set; }
        public string nombreA { get; set; }
        public string descripcionA { get; set; }
        public string indicador { get; set; }
        public string min { get; set; }
        public string sat { get; set; }
        public string sob { get; set; }
        public string avance { get; set; }
        public string resultado { get; set; }
        public string ponderacion { get; set; }
        public string semaforo { get; set; }
        public string tipoObjetivo { get; set; }

        public string seguimientoP { get; set; }
        public string seguimientoR { get; set; }

        public string num { get; set; }
        public string ID { get; set; }
        public string formula { get; set; }
        public string responsable { get; set; }
        public string correo { get; set; }
        public string proveedor { get; set; }
        public string periodicidad { get; set; }
        public string project { get; set; }
        public string tipoIndicador { get; set; }
        public string reglamento { get; set; }
        public string uMedida { get; set; }
        public string valInicial { get; set; }
    }
}
