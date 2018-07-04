using PROJECT.SERV.Model.Adm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace SFP.SERVICIOS.MODEL.ADM
{
    public class TCP_Adm_AreaOrg
    {
        public int Id { get; set; }
        public string descripcion { get; set; }
        public float calificacion { get; set; }
        public int personas { get; set; }
        public int orden { get; set; }
        public float presupuesto { get; set; }
        public string siglas { get; set; }
        public string uni { get; set; }
        public int indicador { get; set; }
        public List<TCP_Adm_Obj> objetivos {get; set;}
        public TCP_Adm_AreaOrg () {} 
 
	 }
}
