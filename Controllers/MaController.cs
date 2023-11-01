using Microsoft.AspNetCore.Mvc;
using Certamen.Datos;
using Certamen.Models;

namespace Certamen.Controllers
{
    public class MaController : Controller
    {
        Participantedatos _Participantedatos = new Participantedatos();

        public IActionResult Listar()
        {
            //lista de participantes 
            var oLista = _Participantedatos.Listar();
            return View();
        }

        public IActionResult Guardar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(Participantes oParticipantes)
        {
            var respuesta = _Participantedatos.Guardar(oParticipantes);

            if (respuesta)
                return RedirectToAction("Listar");
            else
            return View();
        }
    }
}
