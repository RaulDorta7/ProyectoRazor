using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazorFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoRazorFinal.Pages
{
    [IgnoreAntiforgeryToken]
    public class FechaModel : PageModel
    {

        public readonly MisDatos Datos;

        public FechaModel(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
