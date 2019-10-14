using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaHigorCouto.Models
{
    public class Usuario
    {
        [Key]
        public int? id { get; set; }

        [Required(ErrorMessage = "(Obrigat�rio)")]
        public string nome { get; set; }

        [Required(ErrorMessage = "(Obrigat�rio)")]
        public int? idPerfil { get; set; }

        [NotMapped]
        public Perfil Perfil { get; set; }
    }
}