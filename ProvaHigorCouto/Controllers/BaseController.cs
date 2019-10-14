using Microsoft.AspNetCore.Mvc;
using ProvaHigorCouto.Enum;
using ProvaHigorCouto.Services;

namespace ProvaHigorCouto.Controllers
{
    public class BaseController : Controller
    {
        protected UnitOfWork unitOfWork = new UnitOfWork();

        protected void exibirMensagem(string titulo, string conteudo, TipoMensagem tipoMensagem)
        {
            ViewBag.tituloMensagem = titulo;
            ViewBag.mensagem = conteudo;
            ViewBag.tipoMensagem = tipoMensagem;
        }
    }
}