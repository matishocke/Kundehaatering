using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{

    //ICustomerService interface ke az interface base migire hame dataro
    public class CustomerService : Abstractions.Interfaces.Services.ICustomerService
    {



        //ma faghat mikhaym ke ICustomerRepository inja faghat khoonde beshe
        //ICustomerRepository ham dataro az base migire vali aslesh az khode repository class miad
        //dependency injection
        private readonly Abstractions.Interfaces.Repositories.ICustomerRepository _customerRepository;



        //ye ctor ke  ??? hvis jeg sletter denne ctor
        public CustomerService(Abstractions.Interfaces.Repositories.ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }



        //repository kolle method createsho mifreste too in method vase BL class
        public bool CreateCustomer(string fornavn, string efternavn, string tlf, string email)
        {
            return _customerRepository.CreateCustomer(fornavn, efternavn, tlf, email);
        }


        public bool DeleteCustomer(int id)
        {
            return _customerRepository.DeleteCustomer(id);
        }


        public List<ICustomer> GetAllCutomers()
        {
            return _customerRepository.GetAllCutomers();
        }


        public ICustomer GetCustomer(int id)
        {
            return _customerRepository.GetCustomer(id);
        }


        public bool UpdateCustomer(string fornavn, string efternavn, string tlf, string email, int id)
        {
            return _customerRepository.UpdateCustomer(fornavn,efternavn, tlf, email, id);
        }
    }
}
