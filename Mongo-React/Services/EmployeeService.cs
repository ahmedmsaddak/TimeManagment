using Data;
using Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService
    {
        MongoDatabase _db;
        ConnectionMongo con = new ConnectionMongo();

        public EmployeeService()
        {
            _db = con.mongodb;
        }
        
        public IEnumerable<Employee> GetEmployees()
        {
            return _db.GetCollection<Employee>("Employee").FindAll();
        }

        public Company GetCompanyByCompanyName(string companyname)
        {
            var res = Query<Company>.EQ(x => x.Name, companyname);
            return _db.GetCollection<Company>("Company").FindOne(res) ;
        }
        public IEnumerable<Employee> GetEmployeesByCompanyName(string companyname)
        {
            var res = Query<Employee>.EQ(x => x.Company.Name, companyname);
            return _db.GetCollection<Employee>("Employee").Find(res);
        }
        public IEnumerable<Company> GetCompany()
        {
            return _db.GetCollection<Company>("Company").FindAll();
        }

        public Company GetCompanyByCompany(ObjectId id)
        {
            var res = Query<Company>.EQ(x => x._id, id);
            return _db.GetCollection<Company>("Company").FindOne(res);

        }
        public Employee GetEmployeesByCompany(ObjectId id)
        {
            var res = Query<Employee>.EQ(x => x._id, id);
            return _db.GetCollection<Employee>("Employee").FindOne(res);

        }
        public IEnumerable<Contrat> GetContrats()
        {
            return _db.GetCollection<Contrat>("Contrat").FindAll();
        }
    }
}
