using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Models
{
    public class Customer : Abstractions.Interfaces.Models.ICustomer
    {
        public int ID { get; set ; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        [NotMapped]
        public IAddress Address { get; set; }
    }
}
