using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TableroControl.Controllers
{
    public class HomeController : Controller
    {

        public IList<AreaVM> _areas;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Organigrama()
        {
            return View();
        }


        [HttpGet("[action]")]
        public IEnumerable<AreaVM> GetAreas(int startDateIndex)
        {
            _areas = new List<AreaVM>();
            return _areas;
        }



        [HttpGet("[action]")]
        public IEnumerable<AreaVM> Get(int startDateIndex)
        {
            _areas = new List<AreaVM>();
            return _areas;
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }

    public class AreaVM
    {
        public int Id { get; set; }
        public string   descripcion { get; set; }
        public string siglas { get; set; }
        public string calificacion { get; set; }
        public string calificacionGral { get; set; }
        public int personas { get; set; }
        public int indicador { get; set; }
        public string presupuesto { get; set; }
        public string svgM { get; set; }

        public string obj1 { get; set; }
        public string obj2 { get; set; }
        public string obj3 { get; set; }
        public string obj4 { get; set; }
        public string linkActive { get; set; }

        public string tp { get; set; }
        public string tp1 { get; set; }
        public string tp2 { get; set; }
        public string tp3 { get; set; }
        public string tp4 { get; set; }
        public string tp5 { get; set; }
        public string tp6 { get; set; }
        public string tp7 { get; set; }
        public string url { get; set; }
        public int posx { get; set; }
        public int posy { get; set; }
    }
}
