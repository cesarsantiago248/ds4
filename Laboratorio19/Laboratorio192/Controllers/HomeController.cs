using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

public class HomeController : Controller
{
    public async Task<ActionResult> ConsumeValuesApi()
    {
        // Create a new HttpClient instance for this request
        using (HttpClient client = new HttpClient())
        {
            client.BaseAddress = new Uri(Request.Url.GetLeftPart(UriPartial.Authority)); // Use the running app's base address
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Send a GET request to the api/Values/Get endpoint
                HttpResponseMessage response = await client.GetAsync("api/Values/Get");

                if (response.IsSuccessStatusCode)
                {
                    // Read the response as a string
                    var data = await response.Content.ReadAsStringAsync();

                    // Pass the data to the view
                    ViewBag.Data = data;
                    return View();
                }
                else
                {
                    // Handle non-success responses
                    ViewBag.Data = "Error: " + response.StatusCode;
                    return View();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                ViewBag.Data = "Exception: " + ex.Message;
                return View();
            }
        }
    }

    public ActionResult Index()
    {
        // Redirect the default route to ConsumeValuesApi
        return RedirectToAction("ConsumeValuesApi");
    }
}
