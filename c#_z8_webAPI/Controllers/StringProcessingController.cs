using Microsoft.AspNetCore.Mvc;

namespace c__z8_webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringProcessingController : ControllerBase
    {
        [HttpGet(Name = "StringProcessing")]
        public string Get(string stroka, int choice)
        {
            return StringProcessing.WorkWithString(stroka, choice);
        }
    }
}