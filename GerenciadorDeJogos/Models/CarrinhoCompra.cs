using GerenciadorDeJogos.Context;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeJogos.Models
{
    //Classe responsável pelo carrinho de compras
    public class CarrinhoCompra
    {

        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoComprasItens> CarrinhoComprasItens { get; set; }
        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string CarrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId", CarrinhoId);

            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = CarrinhoId,
            };
        }
        //Método para adicionar itens ao carrinho
        public void AddCarrinho(Jogo jogo)
        {
            var carrinhoComprasItens = _context.carrinhoCompras.FirstOrDefault(
                s => s.Jogo.JogoId == jogo.JogoId && 
                s.CarrinhoComprasId == CarrinhoCompraId);

            if (carrinhoComprasItens == null)
            {

                carrinhoComprasItens = new CarrinhoComprasItens
                {
                    CarrinhoComprasId = CarrinhoCompraId,
                    Jogo = jogo,
                    Quantidade = 1
                };

                _context.carrinhoCompras.Add(carrinhoComprasItens);

            }
            else {

                carrinhoComprasItens.Quantidade++;

            }
            _context.SaveChanges();
        }

        //Método para remover itens do carrinho
        public int RemoverDoCarrinho(Jogo jogo)
        {
            var carrinhoComprasItens = _context.carrinhoCompras.FirstOrDefault(
                s => s.Jogo.JogoId == jogo.JogoId &&
                s.CarrinhoComprasId == CarrinhoCompraId);
            var quantidadeLocal = 0;
            if (carrinhoComprasItens != null)
            {
                if (carrinhoComprasItens.Quantidade > 1)
                {
                    carrinhoComprasItens.Quantidade--;
                    quantidadeLocal = carrinhoComprasItens.Quantidade;
                }
                else
                {
                    _context.carrinhoCompras.Remove(carrinhoComprasItens);
                }
            }
            _context.SaveChanges();
            return quantidadeLocal;
        }

        public List<CarrinhoComprasItens> GetCarrinhoComprasItens() {

            return CarrinhoComprasItens ?? (CarrinhoComprasItens = _context.carrinhoCompras
                    .Where(c => c.CarrinhoComprasId == CarrinhoCompraId)
                    .Include(s => s.Jogo).ToList());

        }
        //Método para limpar o carrinho
        public void LimparCarrinho()
        {

            var carrinhoItens = _context.carrinhoCompras
                .Where(carrinho => carrinho.CarrinhoComprasId == CarrinhoCompraId);

            _context.carrinhoCompras.RemoveRange(carrinhoItens);
            _context.SaveChanges();

        }
        //Método para calcular o valor total do carrinho
        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.carrinhoCompras
                .Where(c=>CarrinhoCompraId == CarrinhoCompraId)
                .Select(c=>c.Jogo.JogoPreco * c.Quantidade).Sum();
            return total;  
        }

    }
}
