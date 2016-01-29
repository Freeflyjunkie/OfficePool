using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficePool.Domain
{
    public class Department
    {
        public int DepartmentId { get; set;}  
        public string Name { get; set;}        
        public virtual ICollection<User> Users { get; set; } 
    }
}
