using Microsoft.Extensions.Configuration;
//using SFP.Persistencia.Model;
//using SFP.Persistencia.Servicio;
using System;
using System.Collections.Generic;


namespace TableroControl.Injection
{
    public interface ICacheWeb
    {
        Object ObtenerDato(String Clave);
        void AgregarDato(String Clave, Object Valor);
        void Inicializar(IConfigurationRoot config);
        int EstadoFinal(Int32 iEstadoInicial, Int32 iArista);
        string BuscarLista(string sColeccion, string sValor);
        string BuscarDiccionario(string sColeccion, int iValor);
    }

    public class CacheWeb : ICacheWeb
    {
        public const string APP_BD_CONFIG = "BD_CONFIG";
        public const string APP_SIT_CONEXION_BD = "SIT_DB";
        public const string APP_SESSION_TIMEOUT = "SessionTimeout";
        public const string APP_SHAREPOINT_CONFIG = "SHAREPOINT_CONFIG";
        public const string APP_CORREO_CONFIG = "CORREO_CONFIG";

        public const String CONEXION = "CONEXION";

        public const int AREA_ORIGEN = 1;

        public const String DIC_CATALOGOS_CLASE = "DIC_CATALOGOS_CLASE";
        public const String DIC_DIA_NO_LABORAL = "DIC_DIA_NO_LABORAL";

        public const String DIC_AFD_PREFIJO = "DIC_AFD_PREFIJO";
        public const String DIC_AFD_FLUJO = "DIC_AFD_FLUJO";

        public const String DIC_SOL_MODOENTREGA = "DIC_SOL_MODOENTREGA";
        public const String DIC_SOL_MODOENTREGA_VISIBLE = "DIC_SOL_MODOENTREGA_VISIBLE";

        public const String DIC_NODO_ESTADO = "DIC_NODO_ESTADO";
        public const String DIC_NODO_ESTADO_URL = "DIC_NODO_ESTADO_URL";
        public const String DIC_NODO_ESTADO_PERFIL = "DIC_NODO_ESTADO_PERFIL";

        
        
        public const String DIC_DOC_EXTENSION = "DIC_DOC_EXTENSION";          
        
               
        public const String DIC_SNT_ESTADO = "DIC_SNT_ESTADO";
        public const String DIC_SNT_MUNICIPIO = "DIC_SNT_MUNICIPIO";
        public const String DIC_SNT_OCUPACION = "DIC_SNT_OCUPACION";
        public const String DIC_SNT_PAIS = "DIC_SNT_PAIS";
        public const String DIC_SNT_TIPO = "DIC_SNT_TIPO";

        public const String DIC_RESP_CLASINFO = "DIC_RESP_CLASINFO";
        public const String DIC_RESP_TIPO = "DIC_RESP_TIPO";
        public const string DIC_RESP_MOMENTO = "DIC_RESP_MOMENTO";
        public const String DIC_RESP_REPRODUCCION = "DIC_RESP_REPRODUCCION";
        public const String DIC_RESP_INAI = "DIC_RESP_INAI";


        public const String DT_TIPO_ARISTA_DOC = "DT_TIPO_ARISTA_DOC";
        public const string DT_CI_RUBRO = "DT_CI_RUBRO";

        public const string LST_SOL_PROCESOPLAZOS = "LST_SOL_PROCESOPLAZOS";
        public const string LST_SOL_TIPO = "LST_SOL_TIPO";
        public const string LST_SOL_PROCESO = "LST_SOL_PROCESO";
        public const string LST_PERFIL = "LST_PERFIL";
        

        Dictionary<String, Object> _dicCacheSIT;
        public CacheWeb()
        {
            _dicCacheSIT = new Dictionary<String, Object>();
        }

        public void AgregarDato(string Clave, object Valor)
        {
            if (_dicCacheSIT.ContainsKey(Clave) == false)
            {
                _dicCacheSIT.Add(Clave, Valor);
            }
            else
            {
                _dicCacheSIT[Clave] =  Valor;
            }
        }

        public object ObtenerDato(string Clave)
        {
            return _dicCacheSIT[Clave];
        }
        /*
        private string ObtenerConfiguracion(ref DmlDbSer oracleSer, string sClave)
        {
            String sConsultaClave;
            sConsultaClave = (String)oracleSer.operEjecutar<SIT_ADM_CONFIGURACIONDao>(nameof(SIT_ADM_CONFIGURACIONDao.dmlSelectClave), sClave);
            return sConsultaClave;
        }
        */
        public void Inicializar(IConfigurationRoot config)
        {
            try
            {
                SFP.Persistencia.Model.BaseDbMdl baseDbSit = new SFP.Persistencia.Model.BaseDbMdl();
                baseDbSit.connectionString = config.GetConnectionString(CacheWeb.APP_SIT_CONEXION_BD);
                baseDbSit.objDbConnection  = config.GetSection("DataBaseObj")["objCxn"].ToString();
                baseDbSit.objDbTransaccion = config.GetSection("DataBaseObj")["objTran"].ToString();
                baseDbSit.objDbDataAdapter = config.GetSection("DataBaseObj")["objDataAdapter"].ToString();

                _dicCacheSIT.Add(CacheWeb.APP_BD_CONFIG, baseDbSit);

                SFP.Persistencia.Model.CfgSharePointMdl spModel = new SFP.Persistencia.Model.CfgSharePointMdl(
                    config.GetSection("SharePoint")["Servidor"].ToString(),
                    config.GetSection("SharePoint")["Usuario"].ToString(),
                    config.GetSection("SharePoint")["Contraseña"].ToString(),
                    config.GetSection("SharePoint")["Dominio"].ToString(),
                    config.GetSection("SharePoint")["Folder"].ToString()
                );
                _dicCacheSIT.Add(APP_SHAREPOINT_CONFIG, spModel);

                SFP.Persistencia.Model.CfgCorreoMdl sCorreo = new SFP.Persistencia.Model.CfgCorreoMdl(
                    config.GetSection("correo")["Servidor"].ToString(),
                    config.GetSection("correo")["Puerto"].ToString(),
                    config.GetSection("correo")["Usuario"].ToString(),
                    config.GetSection("correo")["Contraseña"].ToString()
                    );
                _dicCacheSIT.Add(APP_CORREO_CONFIG, sCorreo);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("Error al leer archivo JSON de configuración : " + ex.ToString());
            }
        }

        public string BuscarLista(string sColeccion, string sValor)
        {
            string sResultado = "";
            List<SFP.Persistencia.Model.ComboMdl> lstDatos = _dicCacheSIT[sColeccion] as List<SFP.Persistencia.Model.ComboMdl>;

            var busqueda = lstDatos.Find(r => r.ID == sValor).DESCRIP;
            if (busqueda != null)
                sResultado = busqueda.ToString();

            return sResultado;
        }

        public string BuscarDiccionario(string sColeccion, int iValor)
        {
            string sResultado = "";
            Dictionary<int, string> dicDatos = _dicCacheSIT[sColeccion] as Dictionary<int, string>;

            if (dicDatos.ContainsKey(iValor))
                return dicDatos[iValor];
            else
                return sResultado;
        }

        public int EstadoFinal(int iEstadoInicial, int iArista)
        {
            throw new NotImplementedException();
        }
    }
}
