using LibApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibApp.Controllers.Api
{
    public class ApiBooksController : ControllerBase
    {
        private readonly IHttpClientFactory ClientFactory;



        public ApiBooksController(IHttpClientFactory httpClientFactory)
        {
            ClientFactory = httpClientFactory;
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {

            var client = ClientFactory.CreateClient();

            var response = await client.GetAsync("https://localhost:7192/Controllers/api/booksapi");
            response.EnsureSuccessStatusCode();

            var books = await response.Content.ReadFromJsonAsync<IEnumerable<Book>>();


            return Ok(books);
        }
    }
}
