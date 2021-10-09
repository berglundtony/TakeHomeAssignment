using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TakeHomeAssignment.Data;
using Newtonsoft.Json;
using System.Text.Json;
using System.Net.Http.Headers;
using TakeHomeAssignment.HttpClients;
using Newtonsoft.Json.Linq;
using System.IO;
using NPOI.Util;

namespace TakeHomeAssignment.Controllers
{
    [Route("api/exchange")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        private readonly TakeHomeClient takehomeClient;
        public ExchangeRateController(TakeHomeClient takehomeClient)
        {
            this.takehomeClient = takehomeClient;
        }

        [HttpGet]
        [Route("{dates}/{from}/{to}")]
        public async Task<ReturnRateInformation> GetRates([FromQuery]string[] dates, [FromQuery]string from, [FromQuery]string to)
        {
            return await takehomeClient.GetRate(dates, from, to);         
        }
    }
}

  


