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
        // Ação que exibe a loja de jogos, utilizando o repositório para obter os jogos disponíveis
        public IActionResult List()
        {
            var JogosViewModel = new JogosViewModel();
            JogosViewModel.Jogos = _jogosRepository.Jogos;
            JogosViewModel.CategoriaAtual = "Categoria Atual";
            return View(JogosViewModel);

        }

        // Ação que exibe a loja de jogos, utilizando o repositório para obter os jogos disponíveis
        public IActionResult JogoLoja()
        {
            var JogosViewModel = new JogosViewModel();
            JogosViewModel.Jogos = _jogosRepository.Jogos;
            JogosViewModel.CategoriaAtual = "Categoria Atual";
            return View(JogosViewModel);

        }
    }
}
