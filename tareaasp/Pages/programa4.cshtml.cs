using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tareaasp.Pages
{
    public class programa4Model : PageModel
    {
        public int[] Numeros { get; set; }
        public int Suma { get; set; }
        public double Promedio { get; set; }
        public int Moda { get; set; }
        public double Mediana { get; set; }

        public void OnGet()
        {
            Random rand = new Random();
            Numeros = Enumerable.Range(0, 20).Select(i => rand.Next(0, 100)).ToArray();
            Suma = Numeros.Sum();
            Promedio = Numeros.Average();
            Moda = Numeros.GroupBy(n => n).OrderByDescending(g => g.Count()).First().Key;
            Mediana = Numeros.OrderBy(n => n).Skip(Numeros.Length / 2).First();
        }
    }
}
