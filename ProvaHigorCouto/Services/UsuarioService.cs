using System;
using System.Collections.Generic;
using System.Linq;
using ProvaHigorCouto.Models;

namespace ProvaHigorCouto.Services
{
    public class UsuarioService : BaseService<Usuario>
    {
        public UsuarioService(ProvaHigorCoutoContext db):base(db)
        {
        }

        public new IEnumerable<Usuario> listar()
        {
            var usuarios = base.listar();
            foreach(var usuario in usuarios)
            {
                usuario.Perfil = db.perfil.FirstOrDefault(p => p.id == usuario.idPerfil);
            }

            return usuarios;
        }
    }
}