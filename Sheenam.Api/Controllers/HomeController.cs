// ==================================================
//Copyright (c) Coalition of Good-Heartted Enginneers
//Free to use Comfort and Peace
// ==================================================

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult <string> Get() => 
            Ok("Hello mario,the princess is another castle");
    }
}
