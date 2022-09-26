using calculadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculadora.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular(CalcModel calcular)
        {
            if (ModelState.IsValid)
            {
                switch (calcular.operation)
                {
                    case "Soma":
                        calcular.result = calcular.fist + calcular.second;
                        return View("Index", calcular);
                    case "Subtrair":
                        calcular.result = calcular.fist - calcular.second;
                        return View("Index", calcular);
                    case "multiplicar":
                        calcular.result = calcular.fist * calcular.second;
                        return View("Index", calcular);
                    case "dividir":
                        calcular.result = calcular.fist / calcular.second;
                        return View("Index", calcular);
                    default:
                        calcular.result = 0000;
                        return View("Index", calcular);
                }
            }
            return View("Index",calcular);
        }

    }
}
