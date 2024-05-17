using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tareaasp.Pages
{
    public class programa1Model : PageModel
    {
        [BindProperty]
        public string Peso { get; set; } = "";
        [BindProperty]
        public string Altura { get; set; } = "";
        public double IMC;
        public void OnPost()
        {
            double Peso1 = double.Parse(Peso);
            double Altura1 = double.Parse(Altura);
            IMC = Peso1 / Math.Pow(Altura1, 2);
            ModelState.Clear();
        }
    }
}
