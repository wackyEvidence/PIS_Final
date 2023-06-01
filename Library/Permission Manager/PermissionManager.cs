using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library
{
    public class PermissionManager
    {
        public PermissionManager(User user)
        {
            throw new NotImplementedException();
        }

        public bool CanChangeAnimalsRegistry { get; private set; }
        public bool CanChangeContractsRegistry { get; private set; }
        public bool CanChangeOrganizationsRegistry { get; private set; }
        public Dictionary<string, string> GetAnimalsReadFilter { get; private set; }
        public Dictionary<string, string> GetOrganizationsReadFilter { get; private set; }
        public Dictionary<string, string> GetContractsReadFilter { get; private set; }
    }
}
