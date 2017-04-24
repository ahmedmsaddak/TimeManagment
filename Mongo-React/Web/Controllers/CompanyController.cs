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
    public class CompanyController : ApiController
    {
        EmployeeService Emp = new EmployeeService();
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            return Emp.GetCompany();
        }

        [HttpGet]
        public IHttpActionResult GetById(string id)
        {
            var employee = Emp.GetCompanyByCompany(new ObjectId(id));
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
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
        [HttpGet]
        public IHttpActionResult GetByCompanyName(string companyname)
        {
            var company = Emp.GetCompanyByCompanyName(companyname);
            if (company == null)
            {
                return NotFound();
            }
            return Ok(company);
        }
    }
}