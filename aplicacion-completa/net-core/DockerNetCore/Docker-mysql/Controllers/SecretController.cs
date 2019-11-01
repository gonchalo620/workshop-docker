using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Docker_mysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        // GET: api/Secret
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var envVars = Environment.GetEnvironmentVariables();
            var envKeys = envVars.Keys;
            var envList = new List<string>();
            foreach (var key in envVars.Keys)
            {                
                envList.Add(envVars[key].ToString());
            }

            return envList;
        }

       
    }
}
