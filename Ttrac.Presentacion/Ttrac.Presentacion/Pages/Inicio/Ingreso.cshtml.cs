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
            // Validar las credenciales de prueba (correo y contraseña)
            if (email == "helberth.roman@tecoop.cr" && password == "H.Roman2023")
            {
                // Crear una cookie de sesión para mantener al usuario autenticado
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
            // Eliminar la cookie de sesión para cerrar la sesión
            HttpContext.Response.Cookies.Delete("LoggedIn");

            // Redirigir a la página de inicio de sesión
            return RedirectToPage("/Inicio/Ingreso");
        }
    }
}
