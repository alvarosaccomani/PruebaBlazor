using AppPruebaBlazor.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace AppPruebaBlazor.Pages
{
    public partial class AgregarEquipo
    {
        private Equipo nuevoEquipo = new Equipo();
        private IBrowserFile archivoPdf;

        private async Task SeleccionarArchivo(InputFileChangeEventArgs e) {
            archivoPdf = e.File;
        }
        private async Task AgregarEquipoNuevo() 
        {
            try
            {
                using var ms = new MemoryStream();
                if (archivoPdf != null)
                {
                    await archivoPdf.OpenReadStream(50000000).CopyToAsync(ms); // Limitar a 50 MB
                    nuevoEquipo.eq_Documentacion = archivoPdf.Name;
                    nuevoEquipo.eq_Contenido = ms.ToArray();
                }

                await EquipoService.AgregarEquipoAsync(nuevoEquipo);
                NavigationManager.NavigateTo("/equipos");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
