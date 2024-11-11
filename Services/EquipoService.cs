using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppPruebaBlazor.Models;

public class EquipoService {
    private readonly HttpClient _httpClient;
    public EquipoService(HttpClient httpClient) {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Add("Origin", "https://localhost:7185");
        _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
        _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
        _httpClient.DefaultRequestHeaders.Add("Access-Control-Allow-Headers", "Content-Type");
    }
    public async Task<List<Equipo>> ObtenerEquiposAsync() {
        return await _httpClient.GetFromJsonAsync<List<Equipo>>("https://localhost:7204/api/equipos");
    }
    public async Task<Equipo> ObtenerEquipoPorIdAsync(int eq_Id)
    {
        return await _httpClient.GetFromJsonAsync<Equipo>($"https://localhost:7204/api/equipos/{eq_Id}");
    }
    public async Task AgregarEquipoAsync(Equipo equipo) {
        await _httpClient.PostAsJsonAsync("https://localhost:7204/api/equipos", equipo);
    }
    public async Task ActualizarEquipoAsync(Equipo equipo) {
        await _httpClient.PutAsJsonAsync($"https://localhost:7204/api/equipos/{equipo.eq_Id}", equipo);
    }
}