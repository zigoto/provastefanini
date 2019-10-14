using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProvaHigorCouto.Enum;
using ProvaHigorCouto.Models;
using ProvaHigorCouto.Services;

namespace ProvaHigorCouto.Controllers
{
    public class FuncionalidadesController : BaseController
    {
        /// <summary>
        /// Listagem de funcionalidades
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

                var funcionalidades = unitOfWork.funcionalidadeService.listar();
                return View(funcionalidades);
            }
            catch(Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new List<Funcionalidade>());
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
                var funcionalidade = new Funcionalidade();
                if(id > 0)
                {
                    funcionalidade = unitOfWork.funcionalidadeService.selecionar(id);
                }
                return View(funcionalidade);
            }
            catch(Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View(new Funcionalidade());
            }
        }

        /// <summary>
        /// Salvar os dados do formulário. Serve tanto para cadastro quanto para edição
        /// </summary>
        /// <param name="funcionalidade">Funcionalidade a ser criada/alterada</param>
        /// <returns></returns>
        public IActionResult Salvar(Funcionalidade funcionalidade)
        {
            try
            {
                var mensagem = "";
                if (funcionalidade.id != null)
                {
                    unitOfWork.funcionalidadeService.alterar(funcionalidade);
                    mensagem = "Funcionalidade alterada com sucesso";
                }
                else
                {
                    funcionalidade = unitOfWork.funcionalidadeService.adicionar(funcionalidade);
                    mensagem = "Funcionalidade incluída com sucesso";
                }
                unitOfWork.salvar();

                return RedirectToAction("Index", new { mensagem = mensagem, tipoMensagem = TipoMensagem.Sucesso });
            }
            catch (Exception e)
            {
                exibirMensagem("Ops...", e.Message, TipoMensagem.Erro);
                return View("Form", funcionalidade);
            }
        }

        /// <summary>
        /// Excluir uma funcionalidade
        /// </summary>
        /// <param name="id">Id da funcionalidade a ser excluída</param>
        /// <returns></returns>
        public IActionResult Excluir(int id)
        {
            try
            {
                unitOfWork.funcionalidadeService.excluir(id);
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
