using AppPruebaBlazor.Models;
using Microsoft.AspNetCore.Components;

namespace AppPruebaBlazor.Pages
{
    public partial class EditarEquipo
    {
        [Parameter] 
        public int eq_Id { get; set; } 
        private Equipo equipo = new Equipo(); 
        protected override async Task OnInitializedAsync() { 
            equipo = await EquipoService.ObtenerEquipoPorIdAsync(eq_Id);
        }
        private async Task ActualizarEquipo() { 
            await EquipoService.ActualizarEquipoAsync(equipo); 
            NavigationManager.NavigateTo("/equipos"); 
        }
    }
}
