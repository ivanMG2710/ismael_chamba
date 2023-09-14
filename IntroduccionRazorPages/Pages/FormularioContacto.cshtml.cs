using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace IntroduccionRazorPages.Pages
{
    public class FormularioContactoModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage ="El nombre es requerido")]
        public string Nombre { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "El correo es requerido")]
        public string? Correo { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "El mensaje es requerido")]

        public string Mensaje { get; set; } = "";

        public string mensajeRespuesta = "";
        public string error = "";
        
        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                error = "La validaci�n de datos fall�";
                return;
            }

            mensajeRespuesta += Nombre + " T� mensaje ha sido enviado";

            Nombre = "";
            Correo = "";
            Mensaje = "";

            ModelState.Clear();
        }
    }
}
