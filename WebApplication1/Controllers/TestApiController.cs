using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestApiController : ApiController
    {
        private readonly IMessageService _message;

        public TestApiController(IMessageService message)
        {
            _message = message;
        }

        // GET: api/Test
        public IHttpActionResult Get()
        {
            var result = _message.Send("Hello DI");

            return Ok(result);
        }

    }
}
