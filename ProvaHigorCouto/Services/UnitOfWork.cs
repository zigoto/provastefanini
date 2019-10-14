using ProvaHigorCouto.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaHigorCouto.Services
{
    public class UnitOfWork{
        public UnitOfWork()
        {
            db = new ProvaHigorCoutoContext();
        }

        private ProvaHigorCoutoContext db;

        private UsuarioService _usuarioService;
        public UsuarioService usuarioService {
            get
            {
                if (_usuarioService == null)
                    _usuarioService = new UsuarioService(db);

                return _usuarioService;
            }
        }

        private PerfilService _perfilService;
        public PerfilService perfilService
        {
            get
            {
                if (_perfilService == null)
                    _perfilService = new PerfilService(db);

                return _perfilService;
            }
        }

        private FuncionalidadeService _funcionalidadeService;
        public FuncionalidadeService funcionalidadeService
        {
            get
            {
                if (_funcionalidadeService == null)
                    _funcionalidadeService = new FuncionalidadeService(db);

                return _funcionalidadeService;
            }
        }

        private FuncionalidadePerfilService _funcionalidadePerfilService;
        public FuncionalidadePerfilService funcionalidadePerfilService
        {
            get
            {
                if (_funcionalidadePerfilService == null)
                    _funcionalidadePerfilService = new FuncionalidadePerfilService(db);

                return _funcionalidadePerfilService;
            }
        }



        public int salvar()
        {
            return db.SaveChanges();
        }

        public void dispose()
        {
            db.Dispose();
        }
    }
}