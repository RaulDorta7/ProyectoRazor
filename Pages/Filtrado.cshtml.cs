using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazorFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace ProyectoRazorFinal.Pages
{
    [IgnoreAntiforgeryToken]
    public class FiltradoModel : PageModel
    {
        public readonly MisDatos Datos;

        public FiltradoModel(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {
        }
    }
}
