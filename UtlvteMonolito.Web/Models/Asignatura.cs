using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UtlvteMonolito.Web.Models
{
    public class Asignatura
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El código es obligatorio.")]
        public string Codigo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre de la asignatura es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Range(1, 10, ErrorMessage = "Los créditos deben estar entre 1 y 10.")]
        public int Creditos { get; set; }

        [Required(ErrorMessage = "El nivel es obligatorio.")]
        public string Nivel { get; set; } = string.Empty;

        public ICollection<Matricula> Matriculas { get; set; } = new List<Matricula>();
    }
}