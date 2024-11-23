using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
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

    public async Task<string> GetAsync() 
    {
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/Values/Get");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al realizar la solicitud GET: {ex.Message}");
            return null;
        }
    }

    
}
