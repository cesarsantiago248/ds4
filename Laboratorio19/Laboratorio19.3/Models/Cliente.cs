using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44304/")
        };
    }

    public async Task<string> GetAsync(int id)
    {
        try
        {
            // Realiza la solicitud GET con el ID especificado
            HttpResponseMessage response = await _httpClient.GetAsync($"api/Values/Get/{id}");
            response.EnsureSuccessStatusCode(); // Lanza una excepción si el código de estado no es exitoso (200-299)

            // Retorna directamente el contenido como una cadena
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Captura y muestra errores
            Console.WriteLine($"Error al realizar la solicitud GET: {ex.Message}");
            return null;
        }
    }
}
