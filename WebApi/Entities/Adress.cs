using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Entities
{
    public partial class Adress
    {
        public Adress()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string AdressLine { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
