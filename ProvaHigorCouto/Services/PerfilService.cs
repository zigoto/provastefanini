using System;
using System.Collections.Generic;
using System.Linq;
using ProvaHigorCouto.Models;

namespace ProvaHigorCouto.Services
{
    public class PerfilService : BaseService<Perfil>
    {
        public PerfilService(ProvaHigorCoutoContext db) : base(db)
        {
        }

        public new Perfil adicionar(Perfil perfil)
        {
            base.adicionar(perfil);
            db.SaveChanges();

            if (perfil.idsFuncionalidades != null)
            {
                incluirFuncionalidadesPorPerfil((int)perfil.id, perfil.idsFuncionalidades.Split(";").ToList());
            }
            
            return perfil;
        }

        public new Perfil alterar(Perfil perfil)
        {
            base.alterar(perfil);
            excluirFuncionalidadesPorPerfil((int) perfil.id);
            if (perfil.idsFuncionalidades != null)
            {
                incluirFuncionalidadesPorPerfil((int)perfil.id, perfil.idsFuncionalidades.Split(";").ToList());
            }
            return perfil;
        }

        public new void excluir(object id)
        {
            var usuarioComEssePerfil = db.usuario.FirstOrDefault(u => u.idPerfil == (int) id);
            if (usuarioComEssePerfil != null)
                throw new Exception("Não é possível excluir. Existe um usuário cadastrado com esse perfil");
            excluirFuncionalidadesPorPerfil((int) id);
            base.excluir(id);
        }

        private void excluirFuncionalidadesPorPerfil(int idPerfil){
            var funcionalidades = db.funcionalidadePerfil.Where(f => f.idPerfil == idPerfil).ToList();
            foreach(var funcionalidade in funcionalidades)
            {
                db.funcionalidadePerfil.Remove(funcionalidade);
            }
        }

        private void incluirFuncionalidadesPorPerfil(int idPerfil, List<string> idsFuncionalidades)
        {
            foreach(var idFuncionalidade in idsFuncionalidades)
            {
                if (idFuncionalidade == "")
                    continue;

                var funcionalidadePerfil = new FuncionalidadePerfil
                {
                    idPerfil = idPerfil,
                    idFuncionalidade = Convert.ToInt32(idFuncionalidade)
                };
                db.funcionalidadePerfil.Add(funcionalidadePerfil);
            }
        }
    }
}