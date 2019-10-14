using System;
using System.Linq;
using ProvaHigorCouto.Models;

namespace ProvaHigorCouto.Services
{
    public class FuncionalidadeService : BaseService<Funcionalidade>
    {
        public FuncionalidadeService(ProvaHigorCoutoContext db) : base(db)
        {
        }

        public new void excluir(object id)
        {
            var perfilFuncionalidade = db.funcionalidadePerfil.FirstOrDefault(u => u.idFuncionalidade == (int)id);

            if (perfilFuncionalidade != null)
            {
                var perfil = db.perfil.FirstOrDefault(p => p.id == perfilFuncionalidade.idPerfil);
                throw new Exception("Não é possível excluir. Essa funcionalidade está vinculada ao perfil \"" + perfil.nome + "\"");
            }
                
            base.excluir(id);
        }
    }
}