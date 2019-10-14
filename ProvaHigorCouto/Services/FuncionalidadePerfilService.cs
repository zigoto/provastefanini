using System;
using System.Collections.Generic;
using System.Linq;
using ProvaHigorCouto.Models;

namespace ProvaHigorCouto.Services
{
    public class FuncionalidadePerfilService : BaseService<FuncionalidadePerfil>
    {
        public FuncionalidadePerfilService(ProvaHigorCoutoContext db):base(db)
        {
        }

        internal List<FuncionalidadePerfil> listarPorPerfil(int? id)
        {
            return db.funcionalidadePerfil.Where(f => f.idPerfil == id).ToList();
        }
    }
}