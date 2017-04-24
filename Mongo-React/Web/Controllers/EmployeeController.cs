using Entities;
using MongoDB.Bson;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{

    public class EmployeeController : ApiController
    {
        EmployeeService Emp = new EmployeeService();


        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return Emp.GetEmployees();
        }

        [HttpGet]
        public IHttpActionResult GetById(string id)
        {
            var employee = Emp.GetEmployeesByCompany(new ObjectId(id));
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpGet]
        public IEnumerable<Employee> GetByCompanyName(string companyname)
        {
            return Emp.GetEmployeesByCompanyName(companyname);
        }


        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}