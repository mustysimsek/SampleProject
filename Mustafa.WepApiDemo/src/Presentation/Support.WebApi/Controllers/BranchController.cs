using Mapster;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Support.Application.Business.Abstracts;
using Support.Application.Business.Concretes;
using Support.WebApi.Models;

namespace Support.WebApi.Controllers
{
    [Route("api/v1/branches")]
    public class BranchController : Controller
    {
        private readonly IBranchBusiness _branchBusiness;
        private readonly IHttpClientFactory _httpClientFactory;

        public BranchController(IBranchBusiness branchBusiness,IHttpClientFactory httpClientFactory)
        {
            _branchBusiness = branchBusiness;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ViewResult> GetBranchProductByCurrentCodePage()
        {//localhost:44338/WeatherForecast
            #region apiservise bağlan ve çek
            //var httpClient = _httpClientFactory.CreateClient();
            //httpClient.BaseAddress = new Uri("http://localhost:5003");
            //var response = await httpClient.GetAsync("WeatherForecast");
            //var a = await response.Content.ReadAsStringAsync();
            //var b = JsonConvert.DeserializeObject<List<WeatherForecast>>(a);
            //// .net 5 >= var c = System.Text.Json.JsonSerializer.Deserialize<List<WeatherForecast>>(a); 
            #endregion
            return View();
        }



        [HttpGet("{currentCode}")]
        public async Task<ViewResult> GetBranchProductByCurrentCode([FromRoute] int currentCode)
        {
            var product = await _branchBusiness.GetBranchProducts(currentCode);
            return View(product.Adapt<List<GetBranchProductViewModel>>());
        }
    }
    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
