using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string Name { get; set; }

        public virtual List<User> Users { get; set; } /*= new List<User>();*/
    }
}
