namespace TpBdaBiblioteca.Models.entidades
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string? URLFotoPerfil { get; set; }
        public int Clave { get; set; }
        public string Rol { get; set; }

    }
}
