using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public Role Role { get; set; }
    }
}
