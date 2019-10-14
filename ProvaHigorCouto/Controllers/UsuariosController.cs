using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProvaHigorCouto.Enum;
using ProvaHigorCouto.Models;

namespace ProvaHigorCouto.Controllers
{
    public class UsuariosController : BaseController
    {
        /// <summary>
        /// Listagem de usuários
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida no carregamento (Opcional)</param>
        /// <param name="tipoMensagem">Tipo de mensagem. 1 = Sucesso, 2 = Alerta ou 3 = Erro</param>
        /// <returns></returns>
        public IActionResult Index(string mensagem, TipoMensagem tipoMensagem)
        {
            try
            {
                if (mensagem != null)
                {
                    exibirMensagem("Pronto!", mensagem, tipoMensagem);
                }
                var usuarios = unitOfWork.usuarioService.listar();
                return View(usuarios);
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new List<Usuario>());
            }
        }

        /// <summary>
        /// Formulário de cadastro/edição
        /// </summary>
        /// <param name="id">Id do registro a ser editado. Para cadastro, enviar nulo</param>
        /// <returns></returns>
        public IActionResult Form(int id = 0)
        {
            try
            {
                var usuario = new Usuario();
                if (id > 0)
                {
                    usuario = unitOfWork.usuarioService.selecionar(id);
                }
                ViewBag.perfis = unitOfWork.perfilService.listar();
                return View(usuario);
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new Usuario());
            }
        }

        /// <summary>
        /// Salvar os dados do formulário. Serve tanto para cadastro quanto para edição
        /// </summary>
        /// <param name="usuario">Usuário a ser criado/alterado</param>
        /// <returns></returns>
        public IActionResult Salvar(Usuario usuario)
        {
            try
            {
                var mensagem = "";
                if (usuario.id != null)
                {
                    unitOfWork.usuarioService.alterar(usuario);
                    mensagem = "Usuário alterado com sucesso";
                }
                else
                {
                    usuario = unitOfWork.usuarioService.adicionar(usuario);
                    mensagem = "Usuário incluído com sucesso";
                }
                unitOfWork.salvar();

                return RedirectToAction("Index", new { mensagem = mensagem, tipoMensagem = TipoMensagem.Sucesso });
            }
            catch (Exception e)
            {
                ViewBag.perfis = unitOfWork.perfilService.listar();
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View("Form", usuario);
            }
        }

        /// <summary>
        /// Excluir um usuário
        /// </summary>
        /// <param name="id">Id do usuário a ser excluído</param>
        /// <returns></returns>
        public IActionResult Excluir(int id)
        {
            try
            {
                unitOfWork.usuarioService.excluir(id);
                unitOfWork.salvar();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", new { mensagem = e.Message, tipoMensagem = TipoMensagem.Erro });
            }
        }
    }
}
