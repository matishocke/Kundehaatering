using Abstractions.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.MockedRepository
{
    public class CustomerMockedRepository : Abstractions.Interfaces.Repositories.ICustomerRepository
    {
        private readonly List<Abstractions.Interfaces.Models.ICustomer> _customers;

        public CustomerMockedRepository()
        {
            _customers = new List<Abstractions.Interfaces.Models.ICustomer>();

            _customers.Add(new Models.Customer() { ID = 1, FirstName = "Mati 1", LastName = "Shock 1", 
                                          Email = "Lara1@gmail.com", PhoneNumber = "20343050" });

            _customers.Add(new Models.Customer() { ID = 2, FirstName = "Mati 2", LastName = "Shock 2", 
                                          Email = "Lade31@gmail.com", PhoneNumber = "45304050" });

            _customers.Add(new Models.Customer() { ID = 3, FirstName = "Mati 3", LastName = "Shock 3", 
                                          Email = "Lar443@gmail.com", PhoneNumber = "21304050" });

            _customers.Add(new Models.Customer() { ID = 4, FirstName = "Mati 4", LastName = "Shock 4", 
                                          Email = "Lahaha@gmail.com", PhoneNumber = "40304450" });

            _customers.Add(new Models.Customer() { ID = 5, FirstName = "Mati 5", LastName = "Shock 5", 
                                          Email = "L12135@gmail.com", PhoneNumber = "90304040" });
        }



        public bool CreateCustomer(string fornavn, string efternavn, string tlf, string email)
        {
            Models.Customer newCustomer = new Models.Customer();
            newCustomer.FirstName = fornavn;
            newCustomer.LastName = efternavn;
            newCustomer.Email = email;
            newCustomer.PhoneNumber = tlf;
            newCustomer.ID = _customers.Count + 1;
            _customers.Add(newCustomer);
            
            return true;
        }



        public bool DeleteCustomer(int id)
        {
            var foundPerson = _customers.Find(x => x.ID == id);
            if (foundPerson != null)
            {
                _customers.Remove(foundPerson);
                return true;
            }
            else 
            { 
                return false; 
            }
        }




        public List<ICustomer> GetAllCutomers()
        {
            return _customers;
        }




        public ICustomer GetCustomer(int id)
        {
            
            var foundPerson = _customers.Find(x => x.ID == id);
            return foundPerson;
        }



        public bool UpdateCustomer(string fornavn, string efternavn, string tlf, string email, int id)
        {
            var foundPerson = _customers.Find(x => x.ID == id);

            if (foundPerson != null)
            {
                foundPerson.FirstName = fornavn;
                foundPerson.LastName = efternavn;
                foundPerson.Email = email;
                foundPerson.PhoneNumber = tlf;
                return true;
            }
            else 
            {
                return false; 
            }
            
        }
    }
}
