using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpBdaBiblioteca.Models.entidades
{
    public class Prestamo
    {
        public int Id { get; set; }

        public Usuario usuario { get; set; }
        public Libro Libro { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "Campo {0} requerido")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? Multa { get; set; }


    }
}
