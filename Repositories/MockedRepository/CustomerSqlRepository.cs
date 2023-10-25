using Abstractions.Interfaces.Models;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repositories.MockedRepository
{
    public class CustomerSqlRepository : Abstractions.Interfaces.Repositories.ICustomerRepository
    {
        public bool CreateCustomer(string fornavn, string efternavn, string tlf, string email)
        {
            Customer customerToSave = new Customer();
            customerToSave.FirstName = fornavn;
            customerToSave.LastName = efternavn;
            customerToSave.PhoneNumber = tlf;
            customerToSave.Email = email;

            using (DataBase.CustomerEditorDbContext context = new DataBase.CustomerEditorDbContext())
            {
                context.Customers.Add(customerToSave);
                context.SaveChanges(); //denne metode gemmer i databasen ????????? ikke?
            }
            return true;
        }
       

        public List<ICustomer> GetAllCutomers()
        {
            using (DataBase.CustomerEditorDbContext context = new DataBase.CustomerEditorDbContext())
            {
                return context.Customers.ToList<ICustomer>();
            }
        }

        public ICustomer GetCustomer(int id)
        {
            using (DataBase.CustomerEditorDbContext context = new DataBase.CustomerEditorDbContext())
            {
                return context.Customers.Where(x => x.ID == id).FirstOrDefault(); //why firstOrDefault
            }
        }

        public bool UpdateCustomer(string fornavn, string efternavn, string tlf, string email, int id)
        {
            using (DataBase.CustomerEditorDbContext context = new DataBase.CustomerEditorDbContext())
            {

                var customerToUpdate = context.Customers.FirstOrDefault(x => x.ID == id);

                if (customerToUpdate != null)
                {
                    customerToUpdate.FirstName = fornavn;
                    customerToUpdate.LastName = efternavn;
                    customerToUpdate.Email = email;
                    customerToUpdate.PhoneNumber = tlf;

                    context.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool DeleteCustomer(int id)
        {

            using (DataBase.CustomerEditorDbContext context = new DataBase.CustomerEditorDbContext())
            {
                var customerToUpdate = context.Customers.FirstOrDefault(x => x.ID == id);

                if (customerToUpdate != null)
                {
                    context.Customers.Remove(customerToUpdate);
                    context.SaveChanges();
                    return true;
                }
                return false;

                //context.Customers.FirstOrDefault.Remove(x => x.ID == id); ???????????? kan man?
            }
        }
    }
}
