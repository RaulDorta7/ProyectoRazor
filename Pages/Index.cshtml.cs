using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazorFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoRazorFinal
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public readonly MisDatos Datos;

        public IndexModel(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
