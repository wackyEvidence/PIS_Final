using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library
{
    public abstract class PermissionManager
    {
        abstract public bool CanChangeAnimalsRegistry { get;}
        abstract public bool CanChangeOrganizationsRegistry { get; }
        abstract public bool CanChangeContractsRegistry { get; }
        abstract public List<Filter> GetAnimalsReadFilters { get; }
        abstract public List<Filter> GetOrganizationsReadFilters { get; }
        abstract public List<Filter> GetContractsReadFilters { get; }
        //abstract public Dictionary<string, string> GetAnimalsReadFilter { get; }
        //abstract public Dictionary<string, string> GetOrganizationsReadFilter { get; }
        //abstract public Dictionary<string, string> GetContractsReadFilter { get; }
    }
}
