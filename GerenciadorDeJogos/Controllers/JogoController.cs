using Microsoft.AspNetCore.Mvc;
using GerenciadorDeJogos.Repositories.Interfaces;
namespace GerenciadorDeJogos.Controllers
{
    // Controlador responsável por gerenciar as ações relacionadas aos jogos
    public class JogoController : Controller
    {
        private readonly IJogosRepository _jogosRepository;

        // Construtor que recebe o repositório de jogos por meio de injeção de dependência
        public JogoController(IJogosRepository jogosRepository)
        {
            _jogosRepository = jogosRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os Jogos";

            var jogos = _jogosRepository.Jogos;

            var totalJogos = jogos.Count();
            ViewBag.Total = "Total De Jogos";
            ViewBag.TotalJogos = totalJogos;
            return View(jogos);
        }
    }
}
