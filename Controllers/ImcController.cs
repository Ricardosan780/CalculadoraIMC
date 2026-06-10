using Microsoft.AspNetCore.Mvc;
using CalculadoraIMC.Models;

namespace CalculadoraIMC.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Abre a página com o formulário limpo
            return View(new ImcModel());
        }

        [HttpPost]
        public IActionResult Index(ImcModel model)
        {
            if (ModelState.IsValid)
            {
                // Cálculo do IMC no Server Side
                model.ResultadoImc = model.Peso / (model.Altura * model.Altura);

                // Classificação com base no resultado
                if (model.ResultadoImc < 18.5)
                    model.Classificacao = "Abaixo do peso";
                else if (model.ResultadoImc < 25)
                    model.Classificacao = "Peso normal";
                else if (model.ResultadoImc < 30)
                    model.Classificacao = "Sobrepeso";
                else
                    model.Classificacao = "Obesidade";

                return View(model);
            }

            return View(model);
        }
    }
}