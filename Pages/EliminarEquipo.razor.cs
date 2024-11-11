using Microsoft.AspNetCore.Components;

namespace AppPruebaBlazor.Pages
{
    public partial class EliminarEquipo
    {
        [Parameter]
        public int eq_Id { get; set; }
        
        private async Task BorrarEquipo() {        
            await EquipoService.EliminarEquipoAsync(eq_Id);
            NavigationManager.NavigateTo("/equipos");
        }
        
        private void Cancelar() {
            NavigationManager.NavigateTo("/equipos");
        }
    }
}
