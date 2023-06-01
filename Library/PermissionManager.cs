using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class PermissionManager
    {
        public PermissionManager(User user)
        {
            throw new NotImplementedException();
        }

        abstract public bool CanChange { get; set; }
        abstract public Dictionary<string, string> GetReadFilter(); 
    }
}
