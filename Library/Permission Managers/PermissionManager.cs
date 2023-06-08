using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library
{
    class Sample
    {
        private int privateVar;
        public int publicVar; 
        protected int protectedVar;
        public int MyProperty { get; set; }
    }

    public abstract class PermissionManager
    {
        abstract public bool CanChangeAnimalsRegistry { get;}
        abstract public bool CanChangeContractsRegistry { get; }
        abstract public bool CanChangeOrganizationsRegistry { get; }
        abstract public Filter GetAnimalsReadFilter { get; }
        abstract public Filter GetOrganizationsReadFilter { get; }
        abstract public Filter GetContractsReadFilter { get; }
        //abstract public Dictionary<string, string> GetAnimalsReadFilter { get; }
        //abstract public Dictionary<string, string> GetOrganizationsReadFilter { get; }
        //abstract public Dictionary<string, string> GetContractsReadFilter { get; }
    }
}
