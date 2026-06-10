using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BoletimNotas.Models;

namespace BoletimNotas.Controllers
{
    public class BoletimController : Controller
    {
        public IActionResult Index()
        {
            var boletim = new List<BoletimItem>
            {
                new BoletimItem { Id = 1, Materia = "Desenvolvimento para internet", Nota = 8.5m, Professor = "Prof. Ana", Observacao = "Bom desempenho" },
                new BoletimItem { Id = 2, Materia = "Arquitetura de computadores", Nota = 7.0m, Professor = "Prof. Bruno", Observacao = "Precisa revisar microarquitetura" },
                new BoletimItem { Id = 3, Materia = "Programação Front-End", Nota = 9.2m, Professor = "Prof. Carla", Observacao = "Excelente em CSS e JS" },
                new BoletimItem { Id = 4, Materia = "IoT", Nota = 6.8m, Professor = "Prof. Diego", Observacao = "Melhorar integração de sensores" }
            };

            ViewBag.Boletim = boletim;
            ViewBag.Titulo = "Boletim de Notas";

            return View();
        }
    }
}