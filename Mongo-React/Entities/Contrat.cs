using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Contrat
    {
            public ObjectId _id { get; set; }
            public String Name { get; set; }
            public string Duree { get; set; }
            public int Montant { get; set; }
            public Employee Employee { get; set; }

    }
}
