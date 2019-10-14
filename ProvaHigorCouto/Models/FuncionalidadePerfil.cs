using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaHigorCouto.Models
{
    public class FuncionalidadePerfil
    {
        [Key]
        public int? id { get; set; }

        public int idPerfil { get; set; }
        public int idFuncionalidade { get; set; }

        [NotMapped]
        public Perfil Perfil { get; set; }
        [NotMapped]
        public Funcionalidade Funcionalidade { get; set; }
    }
}