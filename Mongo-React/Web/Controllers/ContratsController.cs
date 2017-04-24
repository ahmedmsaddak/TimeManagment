using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services;
using Entities;

namespace Web.Controllers
{
    public class ContratsController : ApiController
    {
        EmployeeService Emp = new EmployeeService();

        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Contrat> Get()
        {
            return Emp.GetContrats();
        }
    }
}
