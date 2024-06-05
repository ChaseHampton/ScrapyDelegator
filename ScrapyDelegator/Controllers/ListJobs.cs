using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SDDB.Models;

namespace ScrapyDelegator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : Controller
    {
        private readonly HttpClient _client;

        public JobsController(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("scrapyd");
        }

        [HttpGet]
        public async Task<IActionResult> Get(string? parameter)
        {
            var content = new StringContent(JsonConvert.SerializeObject(new { project = parameter }), System.Text.Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/listjobs.json", content);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStreamAsync();
                using var reader = new StreamReader(responseContent);
                var parsedResponse = JsonConvert.DeserializeObject(responseContent);
                return Ok(parsedResponse);
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}
