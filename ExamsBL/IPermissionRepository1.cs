using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsBL
{
    public interface IPermissionRepository1
    {
        bool AddPermission(Permission Id_Permission);
        List<Permission> GetPermissions();
        bool RemovePermission(int Id_Permission);
        bool UpdatePermission(int Id_Permission);
    }
}