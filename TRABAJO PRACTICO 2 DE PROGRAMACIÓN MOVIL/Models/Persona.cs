namespace TRABAJO_PRACTICO_2_DE_PROGRAMACIÓN_MOVIL.Models
{
    // La clase Persona representa el modelo de datos solicitado en el trabajo práctico.
    // Un modelo define qué información vamos a guardar o mostrar dentro de la aplicación.
    public class Persona
    {
        // Identificador único de la persona.
        public int Id { get; set; }

        // Nombre completo de la persona.
        public string NombreCompleto { get; set; } = string.Empty;

        // Correo electrónico de la persona.
        public string Email { get; set; } = string.Empty;

        // Domicilio o dirección de la persona.
        public string Domicilio { get; set; } = string.Empty;

        // Fecha de nacimiento de la persona.
        public DateTime FechaNacimiento { get; set; }

        // Ruta de la imagen que se mostrará en la interfaz.
        public string RutaImagen { get; set; } = string.Empty;
    }
}