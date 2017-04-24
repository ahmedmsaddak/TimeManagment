using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
            public ObjectId _id { get; set; }
            public string Name { get; set; }
            public string Adresse { get; set; }
            public Employee[] Employees { get; set; }
       
   }
}
