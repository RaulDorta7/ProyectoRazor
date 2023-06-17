using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoRazorFinal.Models;
using Microsoft.AspNetCore.Mvc;


namespace ProyectoRazorFinal.Pages
{
    [IgnoreAntiforgeryToken]
    public class SeleccionModel : PageModel
    {
        public readonly MisDatos Datos;

        public SeleccionModel(MisDatos datos)
        {
            Datos = datos;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {

        }
    }
}
