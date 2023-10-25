using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Services
{
    public interface IAddressService
    {
        List<Models.IAddress> GetAllAddress();
        Models.IAddress GetCustomerAddress(Models.ICustomer customer);
    }
}
