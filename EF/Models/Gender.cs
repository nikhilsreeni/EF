using System.Collections.Generic;

namespace EF.Models
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> User { get; set; }

    }
}