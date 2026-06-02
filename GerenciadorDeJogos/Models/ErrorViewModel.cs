//  Código responsável por definir a classe ErrorViewModel, que é usada para representar informações de erro em uma aplicação ASP.NET Core.
//  A classe inclui uma propriedade RequestId para armazenar o ID da solicitação e uma propriedade ShowRequestId para indicar se o ID da
//  solicitação deve ser exibido. Essa classe é comumente utilizada em páginas de erro para fornecer informações úteis sobre a solicitação
//  que causou o erro.

namespace GerenciadorDeJogos.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
