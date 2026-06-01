using Microsoft.AspNetCore.Mvc;
using GerenciadorDeJogos.Repositories.Interfaces;
using GerenciadorDeJogos.ViewModels;
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
            /*
            ViewData["Titulo"] = "Todos os Jogos";
            ViewBag.Total = "Total De Jogos";

            var totalJogos = jogos.Count();
            var jogos = _jogosRepository.Jogos;

            ViewBag.TotalJogos = totalJogos;
            return View(jogos);
            */
            
            var JogosViewModel = new JogosViewModel();
            JogosViewModel.Jogos = _jogosRepository.Jogos;
            JogosViewModel.CategoriaAtual = "Categoria Atual";
            return View(JogosViewModel);
        
        }
    }
}
