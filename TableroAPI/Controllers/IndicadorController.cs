using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SFP.Persistencia.Model;
using SFP.Persistencia.Servicio;
using TableroControl.Dao;
using TableroControl.Injection;
using PROJECT.SERV.Model.Tab;

namespace TableroControl.Controllers
{
    [Route("TableroAPI/[controller]")]
    public class IndicadorController : Controller
    {
        protected readonly DmlDbSer _sitDmlDbSer;
        private readonly IConfiguration config;
        private readonly DmlDbSer dbSer = null;

        public IndicadorController(IConfiguration settings)
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
        public IEnumerable<IndicadorVM> GetIndicadoresByID(int startDateIndex)
        {
         
            List<IndicadorVM> indicadores = new List<IndicadorVM>();
            string title = "";
            int filtro = 1;
            switch (startDateIndex)
            {
                case (777382):
                    title = "MIR";
                    filtro = 1;
                    break;
                case (807167):
                    title = "PGCM";
                    filtro = 8;
                    break;

                case (7173):
                    title = "GI";
                    filtro = 64;
                    break;

                case (806973):
                    title = "PEI";
                    filtro = 73;
                    break;

            }
            try
            {

                Dictionary<string, object> dicParam = new Dictionary<string, object>();
                //dicParam.Add("idIndicador", startDateIndex);
                List<IndicadorVM> orga = new List<IndicadorVM>();
                List<TCP_Tab_Indicador> result = (List<TCP_Tab_Indicador>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetIndicadoresById), dicParam);

                int num = 0;
                foreach (TCP_Tab_Indicador actual in result)
                {
                    if ((actual.ind_tipoobjetivo & filtro) == filtro | filtro == 73)
                    {
                        IndicadorVM AreaMdl = new IndicadorVM();
                        AreaMdl.ID = num.ToString();
                        AreaMdl.num = (num+1).ToString();
                        AreaMdl.title = title;
                        AreaMdl.sat = actual.ind_Sat.ToString();
                        AreaMdl.min = actual.ind_Min.ToString();
                        AreaMdl.sob = actual.ind_Sob.ToString();
                        AreaMdl.nombre = actual.ind_Nombre.ToString();
                        AreaMdl.ua = actual.unidad.ToString();
                        AreaMdl.semaforo = actual.Ind_Semaforo.ToString();
                        AreaMdl.comentarios = "Cometario: " + actual.ind_Comentarios.ToString();
                        if (actual.ind_Comentarios.ToString().Length < 1) AreaMdl.comentariosflag = "hidden";
                        else { AreaMdl.comentariosflag = ""; }

                        AreaMdl.descripcion = actual.ind_Descripcion;
                        AreaMdl.formula = actual.ind_formula;
                        AreaMdl.responsable = actual.ind_responsable;
                        AreaMdl.correo = actual.ind_correo;
                        AreaMdl.proveedor = actual.ind_proveedor;
                        AreaMdl.tipoObjetivo = actual.ind_tipoobjetivo.ToString();

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
                        AreaMdl.ponderacion = actual.ind_Ponderacion.ToString();
                        switch (Int32.Parse(actual.ind_AvanceProject.ToString()))
                        {
                            case (1):
                                AreaMdl.project = "SI";
                                break;
                            case (0):
                                AreaMdl.project = "NO";
                                break;
                        }
                        switch (2)
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
                        switch (actual.Ind_Semaforo)
                        {

                            case (8):
                                AreaMdl.semaforo = "reloj";
                                break;
                            case (9):
                                AreaMdl.semaforo = "verde";
                                break;
                            case (10):
                                AreaMdl.semaforo = "verde";
                                break;
                            case (-1):
                                AreaMdl.semaforo = "reloj";
                                break;
                            case (0):
                                AreaMdl.semaforo = "gris";
                                break;
                            default:
                                AreaMdl.semaforo = "rojo";
                                break;
                        }
                        
                        AreaMdl.reglamento = actual.ind_ReglamentoInt.ToString();
                        AreaMdl.uMedida = actual.unidad.ToString();
                        AreaMdl.valInicial = actual.ind_valor.ToString();

                        Dictionary<string, object> dicParamS = new Dictionary<string, object>();
                        dicParamS.Add("idUnidad", actual.Uni_id);
                        dicParamS.Add("idIndicador", actual.ind_id);
                        List<TCP_Tab_Seguimiento> seguimienots = (List<TCP_Tab_Seguimiento>)dbSer.operEjecutar<SFP.SERV.Services.SeguridadSer>(nameof(SFP.SERV.Services.SeguridadSer.GetSeguminetosById), dicParamS);
                        string seguimientoP = "";
                        string seguimientoR = "";
                        int sgID = 0;
                        foreach (TCP_Tab_Seguimiento sgm in seguimienots)
                        {
                            //primero P
                            if (sgID == 0)
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

                        orga.Add(AreaMdl);
                        num++;
                    }
                }
                indicadores = orga;
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            
            return indicadores;

        }
    }

    public class IndicadorVM
    {
        public string ID { get; set; }
        public string num { get; set; }
        public string title { get; set; }
        public string nombre { get; set; }
        public string ua { get; set; }
        public string min { get; set; }
        public string sat { get; set; }
        public string sob { get; set; }
        public string semaforo { get; set; }
        public string seguimientoP { get; set; }
        public string seguimientoR { get; set; }
        public string tipoObjetivo { get; set; }


        public string descripcion { get; set; }
        public string descripcionA { get; set; }
        public string comentarios { get; set; }
        public string comentariosflag { get; set; }
        public string formula { get; set; }
        public string responsable { get; set; }
        public string correo { get; set; }
        public string proveedor { get; set; }
        public string periodicidad { get; set; }
        public string ponderacion { get; set; }
        public string project { get; set; }
        public string tipoIndicador { get; set; }
        public string reglamento { get; set; }
        public string uMedida { get; set; }
        public string valInicial { get; set; }


    }
}
