using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace tareaasp.Pages
{
    public class programa3Model : PageModel
    {
        [BindProperty]
        public double? A { get; set; }
        [BindProperty]
        public double? B { get; set; }
        [BindProperty]
        public double? X { get; set; }
        [BindProperty]
        public double? Y { get; set; }
        [BindProperty]
        public int? N { get; set; }
        public double? Result { get; set; }
        public List<double> IntermediateResults { get; set; }

        public void OnPost()
        {
            //verificamos que tengan valores
            if (A.HasValue && B.HasValue && X.HasValue && Y.HasValue && N.HasValue)
                
            {
                Result = 0;
                IntermediateResults = new List<double>();
                for (int k = 0; k <= N.Value; k++)
                {
                    double intermediateResult = Choose(N.Value, k) * Math.Pow(A.Value * X.Value, N.Value - k) * Math.Pow(B.Value * Y.Value, k);
                    IntermediateResults.Add(intermediateResult);
                    Result += intermediateResult;
                }
            }
        }

        private static double Choose(int n, int k)
        {
            double result = 1;
            for (int i = 1; i <= k; i++)
            {
                result *= (n - (k - i)) / (double)i;
            }
            return result;
        }
    }
}
