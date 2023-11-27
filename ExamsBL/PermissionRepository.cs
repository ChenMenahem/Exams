using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;


using ExamsDL;

namespace ExamsBL
{

    public class PermissionRepository : IPermissionRepository1
    {
        IPermissionService _PermissionsDL;

        public PermissionRepository(PermissionService permissionDL)
        {
            _PermissionsDL = permissionDL;
        }

        public PermissionRepository()
        {
            _PermissionsDL = new PermissionService();
        }

        public List<Permission> GetPermissions()
        {
            List<Permission> permission = _PermissionsDL.GetPermissions();
            return permission;
        }


        public bool AddPermission(Permission Id_Permission)
        {
            bool isAdd = _PermissionsDL.Add(Id_Permission);
            return isAdd;
        }
        public bool RemovePermission(int Id_Permission)
        {
            bool isRemovePermission = _PermissionsDL.Remove(Id_Permission);
            return isRemovePermission;
        }
        public bool UpdatePermission(int Id_Permission)
        {
            bool isUpdatePermission = _PermissionsDL.Update(Id_Permission);
            return isUpdatePermission;
        }
    }
}

