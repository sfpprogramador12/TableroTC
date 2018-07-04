using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace PROJECT.SERV.Model.Tab
{
	 public class TCP_Tab_Indicador
	 {
	 	 //public int indAño  { set; get; } 
	 	 public int Uni_id{ set; get; } 
	 	 public int ind_id  { set; get; } 
	 	 public string ind_tipo { set; get; }
         public int ind_reporta { set; get; }

        public string ind_ReglamentoInt { set; get; }
        public string ind_Periodicidad { set; get; }
        public string ind_valor { set; get; }
        public string ind_formula { set; get; }
        public string ind_responsable { set; get; }
        public string ind_correo { set; get; }
        public string ind_proveedor { set; get; }

        public int ind_consecutivo { set; get; }
        public string ind_Nombre { set; get; }
        public string ind_Descripcion { set; get; }
        public string ind_Min { set; get; }
        public string ind_Sat { set; get; }
        public string ind_Sob { set; get; }
        public string ind_Comentarios { set; get; }
        public string ind_Resultado { set; get; }
        public int Ind_Semaforo { set; get; }
        public int ind_Tipo_Avance { set; get; }
        public int ind_TipoCalculo { set; get; }
        public float ind_avance { set; get; }
        public float ind_AvanceProject { set; get; }
        //public string ind_tipoCalculo { set; get; }
        public int ind_tipoobjetivo { set; get; }
        public float ind_calificacion { set; get; }
        public float ind_Ponderacion { set; get; }
        public string obj { set; get; }
        public string unidad { set; get; }


        public TCP_Tab_Indicador () {} 
 
	 	 
	 }
}
