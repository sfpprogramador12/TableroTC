using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_AreaInd
	 {
	 	 public int Ind_ID  { set; get; } 
	 	 public string Ind_tipo  { set; get; }
         public string Ind_nombre { set; get; }
         public string Ind_descripcion { set; get; }
         public string Ind_Min  { set; get; } 
	 	 public string Ind_Sat  { set; get; } 
	 	 public string Ind_Sob  { set; get; }
         public string Ind_Resultado { set; get; }
	 	 public float Ind_Avance  { set; get; }
         public float Ind_Ponderacion { set; get; }
         public int Ind_Semaforo { set; get; }
         public float Ind_Calificacion { set; get; }
         public string Ind_Comentarios { set; get; }
         public int Ind_TipoObjetivo { get; set; }

        public string Uni_id { set; get; }
        public string ind_unidad { set; get; }
        public int ind_reporta { set; get; }
        public string ind_ReglamentoInt { set; get; }
        public string ind_Periodicidad { set; get; }
        public string ind_valor { set; get; }
        public string ind_formula { set; get; }
        public string ind_responsable { set; get; }
        public string ind_correo { set; get; }
        public string ind_proveedor { set; get; }
        public int ind_consecutivo { set; get; }
        public int ind_Tipo_Avance { set; get; }
        public int ind_TipoCalculo { set; get; }
        public float ind_AvanceProject { set; get; }
        public string obj { set; get; }
        public string unidad { set; get; }

        public TCP_Tab_AreaInd () {} 
 
	 }
}
