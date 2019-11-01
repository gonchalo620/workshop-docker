using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Docker_mysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MysqlController : ControllerBase
    {
        // GET: api/Mysql
        [HttpGet]
        public string Get()
        {
            var host = Environment.GetEnvironmentVariable("db_host") ?? throw new Exception("db_host");
            var db = Environment.GetEnvironmentVariable("db_name") ?? throw new Exception("db_name");
            var user = Environment.GetEnvironmentVariable("db_user") ?? throw new Exception("db_user");
            var pass = Environment.GetEnvironmentVariable("db_pass") ?? throw new Exception("db_pass");
            MySqlConnection mysqlConn = null;

            string connectionString;
            connectionString = $"SERVER={host};DATABASE={db}; UID={user}; PASSWORD={pass}";
            try
            {
                mysqlConn = new MySqlConnection(connectionString);
                mysqlConn.Open();
                var sql = "select first_name, last_name, department, email from employees";

                var output = new StringBuilder("");
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = mysqlConn;

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    output.Append("Nombre : " + result["first_name"].ToString() +
                        "<br />Apellidos : " + result["last_name"].ToString() +
                        "<br />Departamento : " + result["department"].ToString() +
                        "<br />Email : " + result["email"].ToString());
                }

                return output.ToString();                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                if (mysqlConn != null)
                {
                    mysqlConn.Close();
                }
            }

        }

        // GET: api/Mysql/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mysql
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Mysql/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
