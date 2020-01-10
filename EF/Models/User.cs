using System.Collections.Generic;

namespace EF.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GenderId { get; set; }
        public List<int> Qualifications { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual Gender Gender { get; set; }
    }
}
