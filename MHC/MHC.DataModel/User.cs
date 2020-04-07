using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.DataModel
{
    public class User
    {
        public User()
        {

        }

        public int Id  { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string StudentNum { get; set; }

        public Role Role { get; set; }

    }
}
