using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using GuanYouETongService.Data;
using GuanYouETongService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GuanYouETongService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryDutyController : ControllerBase
    {
        private readonly WebPostClient _postServiceClient;

        private readonly ILogger _logger;
        public EntryDutyController(IOptions<PostDataServiceOptions> options, ILogger<EntryDutyController> logger)
        {
            _postServiceClient = new WebPostClient(new BasicHttpBinding(), new EndpointAddress(options.Value.EndPointUrl));
            _logger = logger;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello";
        }

        // GET api/values/5
        [HttpGet("{mailNo}/{taxNo}")]
        [ProducesResponseType(404)]
        public async Task<ActionResult<string>> Get(string mailNo, string taxNo)
        {
            _logger.LogInformation("Querying with MailNo: {mailNo}, TaxNo: {taxNo}", mailNo, taxNo);

            await _postServiceClient.OpenAsync();
            var resp = await _postServiceClient.getPostJsonAsync(mailNo, taxNo);
            var jsonBody = resp.Body.@return;
            
            await _postServiceClient.CloseAsync();
            jsonBody.Replace("RecvAdress", "RecvAddress");
            return Content(jsonBody, "application/json", contentEncoding: System.Text.Encoding.UTF8);
            

            // return new JG47FormEntity
            // {
            //     EntryNo = mailNo,
            //     DutyId = taxNo,
            //     PostValueFact = 100.23M,
            //     Creator = "Beeven",
            //     DateCreated = DateTime.Now,
            //     RecvName = "Bee2",
            //     RecvAddress = "Home",
            //     GoodsInfo = new List<GoodInfo>(){
            //         new GoodInfo {
            //             No = "1",
            //             Name = "Item One",
            //             Quantity = 1,
            //             TradeTotal = 100.2M,
            //             PostRate = 0.5M,
            //             PostValue = 50.1M
            //         }
            //     }
            // };
        }

    }
}
