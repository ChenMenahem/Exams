using ExamsDL.Models;
using System.Collections.Generic;

namespace ExamsDL
{
    public interface IPermissionService
    {
        bool Add(Permission permission);
        void Dispose();
        List<Permission> GetPermissions();
        bool Remove(int Id_permission);
        bool Update(int Id_permission);
    }
}