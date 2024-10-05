using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TpBdaBiblioteca.Models.entidades
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo{0} es obligatorio")]
        public string Titulo { get; set; }
        public string Description { get; set; }
        public string? URLImagen { get; set; }


        [Required(ErrorMessage = "Campo {0} requerido")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Precio { get; set; }

        public Autor Autor { get; set; }
        public Categoria Categoria { get; set; }

    }
}
