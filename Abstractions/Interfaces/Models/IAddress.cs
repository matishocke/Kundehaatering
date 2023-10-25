using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Models
{
    public interface IAddress
    {
        int ID { get; set; }
        string ZipCode { get; set; }
        string StreetName { get; set; }
        string HouseNumber { get; set; }
        string City { get; set; }
    }
}
