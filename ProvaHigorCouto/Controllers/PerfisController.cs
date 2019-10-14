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
    public class PerfisController : BaseController
    {
        /// <summary>
        /// Listagem de perfis
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida no carregamento (Opcional)</param>
        /// <param name="tipoMensagem">Tipo de mensagem. 1 = Sucesso, 2 = Alerta ou 3 = Erro</param>
        /// <returns></returns>
        public IActionResult Index(string mensagem, TipoMensagem tipoMensagem)
        {
            try
            {
                if(mensagem != null)
                {
                    exibirMensagem("Pronto!", mensagem, tipoMensagem);
                }
                var perfis = unitOfWork.perfilService.listar();
                return View(perfis);
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new List<Perfil>());
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
                var perfil = new Perfil();
                ViewBag.funcionalidades = unitOfWork.funcionalidadeService.listar();
                if (id > 0)
                {
                    perfil = unitOfWork.perfilService.selecionar(id);
                    perfil.FuncionalidadesPerfil = unitOfWork.funcionalidadePerfilService.listarPorPerfil(perfil.id);
                }
                return View(perfil);
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new Perfil());
            }
        }

        /// <summary>
        /// Salvar os dados do formulário. Serve tanto para cadastro quanto para edição
        /// </summary>
        /// <param name="perfil">Perfil a ser criado/alterado</param>
        /// <returns></returns>
        public IActionResult Salvar(Perfil perfil)
        {
            try
            {
                var mensagem = "";
                if (perfil.id != null)
                {
                    unitOfWork.perfilService.alterar(perfil);
                    mensagem = "Perfil alterado com sucesso";
                }
                else
                {
                    perfil = unitOfWork.perfilService.adicionar(perfil);
                    mensagem = "Perfil incluído com sucesso";
                }
                unitOfWork.salvar();

                return RedirectToAction("Index", new { mensagem = mensagem, tipoMensagem = TipoMensagem.Sucesso});
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View("Form", perfil);
            }
        }

        /// <summary>
        /// Excluir um perfil
        /// </summary>
        /// <param name="id">Id do perfil a ser excluído</param>
        /// <returns></returns>
        public IActionResult Excluir(int id)
        {
            try
            {
                unitOfWork.perfilService.excluir(id);
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
