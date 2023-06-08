using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Contract
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime SigningDate { get; set; }
        public DateTime ValidUntil { get; set; }
        public Organization Executor { get; set; }
        public Organization Client { get; set; }
        public List<Locality> LocalitiesList { get; set; } = new List<Locality>();
    }
}
