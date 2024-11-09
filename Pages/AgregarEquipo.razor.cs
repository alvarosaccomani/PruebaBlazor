using AppPruebaBlazor.Models;

namespace AppPruebaBlazor.Pages
{
    public partial class AgregarEquipo
    {
        private Equipo nuevoEquipo = new Equipo();
        private async Task AgregarEquipoNuevo() 
        {
            await EquipoService.AgregarEquipoAsync(nuevoEquipo);
            NavigationManager.NavigateTo("/equipos");
        }
    }
}
