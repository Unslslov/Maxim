using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using c__z9_webAPI;

namespace c__z9_webAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringProcessingController : ControllerBase
    {
        // —чЄтчик http запросов 
        private static int kolvo = 1;

        [HttpGet(Name = "StringProcessing")]
        public IActionResult Get(string stroka, int choice)
        {
            if (kolvo <= ForOtherFiles.getParallelLimit())
            {
                kolvo++;
                var result = StringProcessing.WorkWithString(stroka, choice);
                kolvo--;
                return result;
            }
            else
            {
                var error = new { Code = 503, Message = "Service Unavailable" };
                return new JsonResult(error) { StatusCode = 503 };
            }
        }
    }
}