using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IntroduccionRazorPages.Pages
{
    public class SumaNumerosModel : PageModel
    {
        //Definir los atributos
        [BindProperty]
        public string num1 { get; set; } = "";
        [BindProperty]
        public string num2 { get; set; } = "";

        public int suma = 0;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //Recibimos los dos números y convertimos a Int(entero).
            int numero1 = Convert.ToInt32(num1);
            int numero2 = Convert.ToInt32(num2);

            suma = numero1 + numero2;

            ModelState.Clear();
        }
    }
}
