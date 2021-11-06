using System;
using System.Collections.Generic;

#nullable disable

namespace RentalKendaran.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customers = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        public string NamaGender { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
