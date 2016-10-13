using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.BusinessLayer
{
    public class BusinessUserInRoles
    {
        public int UserInRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public System.DateTime HireDate { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
}
