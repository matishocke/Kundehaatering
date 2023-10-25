using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Interfaces.Base
{
    public interface ICustomerBaseService
    {
        List<Models.ICustomer> GetAllCutomers();
        Models.ICustomer GetCustomer(int id);
        bool CreateCustomer(string fornavn, string efternavn, string tlf, string email);
        bool UpdateCustomer(string fornavn, string efternavn, string tlf, string email, int id);
        bool DeleteCustomer(int id);
    }
}
