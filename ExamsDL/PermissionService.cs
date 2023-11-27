using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsDL.Models;
namespace ExamsDL
{
    public class PermissionService : IPermissionService
    {
        ExamsContext _permissionContext = new ExamsContext();

        public List<Permission> GetPermissions()
        {
            List<Permission> permissions = _permissionContext.Permissions.ToList();
            return permissions;
        }

        public bool Add(Permission permission)
        {
            try
            {

                _permissionContext.Permissions.Add(permission);
                _permissionContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public bool Remove(int Id_permission)
        {
            try
            {

                Permission currentPermission = _permissionContext.Permissions.SingleOrDefault(item => item.IdPermissions == Id_permission);
                _permissionContext.Permissions.Remove(currentPermission);
                _permissionContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(int Id_permission)
        {
            try
            {

                Permission currentPermission = _permissionContext.Permissions.SingleOrDefault(item => item.IdPermissions == Id_permission);
                _permissionContext.Permissions.Update(currentPermission);
                _permissionContext.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}