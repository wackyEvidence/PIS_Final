using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Permission_Manager;
using Library.Permission_Managers;

namespace Library
{
    public static class PermissionManagerFactory
    {
        public static PermissionManager GetPermissionManager(User user)
        {
            if (user.Role == UserRole.Veterinarian || user.Role == UserRole.AnimalShelterVeterinarian || user.Role == UserRole.AnimalShelterOperator)
                return new VetPermissionManager();
            else if (user.Role == UserRole.OMSU_Operator)
                return new OMSU_OperatorPermissionManager(user);
            else if (user.Role == UserRole.OMSU_Signatory || user.Role == UserRole.OMSU_Curator)
                return new OMSU_PermissionManager(user);
            else if (user.Role == UserRole.AnimalShelterSignatory || user.Role == UserRole.TrappingSignatory)
                return new SignatoryPermissionManager(user);
            else if (user.Role == UserRole.VetServiceSignatory || user.Role == UserRole.VetServiceCurator)
                return new VetServicePermissionManager(user);
            else if (user.Role == UserRole.TrappingOperator)
                return new TrappingOperatorPermissionManager(user);
            else if (user.Role == UserRole.VetServiceOperator)
                return new VetServiceOperatorPermissionManager(user);
            else
                return new CuratorPermissionManager(user); 
        }
    }
}
