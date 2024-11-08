using AppPruebaBlazor.Models;

namespace AppPruebaBlazor.Pages
{
    public partial class ListaDeEquipos
    {
        private List<Equipo> equipos;
        protected override async Task OnInitializedAsync()
        {
            equipos = await EquipoService.ObtenerEquiposAsync();
        }
    }
}
