using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Bildirim.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BildirimController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public BildirimController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // instance or static variable
            HttpClient client = new HttpClient();

            // get answer in non-blocking way
            using (var response = await client.GetAsync("https://www.bonus.com.tr/kampanyalar"))
            {
                using (var content = response.Content)
                {
                    try
                    {
                        // read answer in non-blocking way
                        var result = await content.ReadAsStringAsync();
                        var document = new HtmlAgilityPack.HtmlDocument();
                        document.LoadHtml(result);
                        //var nodes = document.DocumentNode.SelectNodes("//div[@class=\"campaign-box check-box-item\"]");
                        var nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'campaign-box check-box-item')]");

                        foreach (var node in nodes)
                        {
                            var header = node.Attributes["data-text"].Value.FirstOrDefault();

                            var link = node.Descendants("a").Where(d => d.Attributes["class"].Value.Contains("direct"))
                                                .FirstOrDefault()
                                                .Attributes["href"].Value;

                            var mainImagePath = node.Descendants("img").Where(d => d.Attributes["class"].Value.Contains("campaign-box__image"))
                                                        .FirstOrDefault()
                                                        .Attributes["src"].Value;

                            var logoImagePath = node.Descendants("img").Where(d => d.Attributes["class"].Value.Contains("campaign-box__brand-logo"))
                                                        .FirstOrDefault()
                                                        .Attributes["src"].Value;
                        }

                        //var nodes = document.DocumentNode.SelectSingleNode("//div[contains(@class, 'campaign-list check-box-list')]").ChildNodes;
                        //Some work with page....
                    }
                    catch (Exception e)
                    {
                    }
                    
                }
            }

            return Ok(null);
        }
    }
}
