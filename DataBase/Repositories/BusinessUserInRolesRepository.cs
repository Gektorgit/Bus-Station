using DataBase.BusinessLayer;
using DataBase.DataBaseBuses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories
{
    public class BusinessUserInRolesRepository : IChildRepository<BusinessUserInRoles>
    {
        protected BusStationEntities _context;
        public virtual BusStationEntities context
        {
            get { return _context ?? (_context = new BusStationEntities()); }
        }
        public IEnumerable<BusinessUserInRoles> GetAll()
        {
            return
                (from p in context.UserInRoles
                 select new BusinessUserInRoles
                 {
                     UserInRoleId = p.UserInRoleId,
                     RoleId = p.RoleId,
                     UserId = p.UserId,
                     HireDate = p.HireDate,
                     RoleName = p.Roles.RoleName,
                     UserName = p.Users.UserName
                 }
                     ).ToList();
        }

        public IEnumerable<BusinessUserInRoles> GetAll(int UserId = 0, int RoleId = 0)
        {
            if (RoleId == 0)
            {
                return
                (from p in context.UserInRoles
                 where p.UserId == UserId
                 select new BusinessUserInRoles
                 {
                     UserInRoleId = p.UserInRoleId,
                     RoleId = p.RoleId,
                     UserId = p.UserId,
                     HireDate = p.HireDate,
                     RoleName = p.Roles.RoleName,
                     UserName = p.Users.UserName
                 }
                     ).ToList();
            }
            else
            {
                return
                (from p in context.UserInRoles
                 where p.RoleId == RoleId
                 select new BusinessUserInRoles
                 {
                     UserInRoleId = p.UserInRoleId,
                     RoleId = p.RoleId,
                     UserId = p.UserId,
                     HireDate = p.HireDate,
                     RoleName = p.Roles.RoleName,
                     UserName = p.Users.UserName
                 }
                     ).ToList();
            }
            
        }

        public BusinessUserInRoles Get(int id)
        {
            var p = context.UserInRoles.Find(id);
            return

                    new BusinessUserInRoles
                    {
                        UserInRoleId = p.UserInRoleId,
                        RoleId = p.RoleId,
                        UserId = p.UserId,
                        HireDate = p.HireDate,
                        RoleName = p.Roles.RoleName,
                        UserName = p.Users.UserName
                    };
        }

        public void Save(BusinessUserInRoles obj)
        {
            UserInRoles objSave = context.UserInRoles.Find(obj.UserInRoleId);
            objSave.RoleId = obj.RoleId;
            objSave.HireDate = obj.HireDate;
            objSave.UserId = obj.UserId;

            context.SaveChanges();
        }

        public void Create(BusinessUserInRoles obj)
        {
            UserInRoles objSave = new UserInRoles();
            objSave.UserInRoleId = obj.UserInRoleId;
            objSave.RoleId = obj.RoleId;
            objSave.HireDate = obj.HireDate;
            objSave.UserId = obj.UserId;
            context.UserInRoles.Attach(objSave);
            context.UserInRoles.Add(objSave);
            context.SaveChanges();
        }

        public void Delete(BusinessUserInRoles obj)
        {
            UserInRoles objDelete = context.UserInRoles.Find(obj.UserInRoleId);
            context.UserInRoles.Remove(objDelete);
            context.SaveChanges();
        }
    }
}
