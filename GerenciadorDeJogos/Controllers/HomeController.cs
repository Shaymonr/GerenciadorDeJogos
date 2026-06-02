//Esse arquivo define o controlador HomeController para o aplicativo de gerenciamento de jogos.
//Ele inclui ações para as páginas principais do site, como a página inicial (Index) e a página
//de privacidade (Privacy). O controlador também possui uma ação para lidar com erros, que retorna
//uma view de erro com informações sobre a solicitação. O controlador utiliza o serviço de logging
//para registrar informações relevantes durante a execução das ações.

using System.Diagnostics;
using GerenciadorDeJogos.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeJogos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
