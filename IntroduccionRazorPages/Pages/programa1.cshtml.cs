using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazorPages.Pages
{
    public class programa1Model : PageModel
    {
        [BindProperty]
        public double peso { get; set; }
        [BindProperty]
        public double altura { get; set; }

        public double calculo = 0;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //Recibimos el peso y la altura.
            double peso1 = Convert.ToDouble(peso);
            double altura1 = Convert.ToDouble(altura);

            //Realizamos calculos
            calculo = ((double)(peso1 / (altura1 * 2)));

            //Limpiamos la pantalla
            ModelState.Clear();
        }
    }
}
