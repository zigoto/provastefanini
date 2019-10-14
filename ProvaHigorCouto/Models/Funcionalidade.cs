using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaHigorCouto.Models
{
    public class Funcionalidade
    {
        [Key]
        public int? id { get; set; }

        [Required(ErrorMessage = "(Obrigatório)")]
        public string nome { get; set; }

        [NotMapped]
        public ICollection<FuncionalidadePerfil> FuncionalidadesPerfil { get; set; }
    }
}