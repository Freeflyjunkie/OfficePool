using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePool.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public int LoginId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Login Login { get; set; }
        public virtual Department Department { get; set; }
    }
}
