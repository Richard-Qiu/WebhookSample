using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Bot.Schema;

namespace webhookSample.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        [Route("api/message")]
        public Activity Post([FromBody]Activity request)
        {
            return new Activity()
            {
                Text = $"you send message is {request.Text}"
            };
        }
    }
}
