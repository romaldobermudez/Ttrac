using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ttrac.Presentacion.Pages._Generales
{
    public class IngresoModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost(string email, string password)
        {
            // Validar las credenciales de prueba (correo y contrase�a)
            if (email == "helberth.roman@tecoop.cr" && password == "H.Roman2023")
            {
                // Crear una cookie de sesi�n para mantener al usuario autenticado
                HttpContext.Response.Cookies.Append("LoggedIn", "true");

                return RedirectToPage("/Estadisticas/Estadisticas");
            }
            else
            {
                // Credenciales incorrectas, mostrar mensaje de error
                ModelState.AddModelError(string.Empty, "Credenciales incorrectas.");
                return Page();
            }
        }

        public IActionResult OnPostLogout()
        {
            // Eliminar la cookie de sesi�n para cerrar la sesi�n
            HttpContext.Response.Cookies.Delete("LoggedIn");

            // Redirigir a la p�gina de inicio de sesi�n
            return RedirectToPage("/Inicio/Ingreso");
        }
    }
}
