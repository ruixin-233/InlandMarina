using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public class CustomerManager
    {
        public static Customer Find(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Customer cust = db.Customers.SingleOrDefault(c => c.ID == id);
            return cust;
        }
        
        public static void Add(Customer cust)
        {
            MarinaEntities db = new MarinaEntities();
            db.Customers.Add(cust);
            db.SaveChanges();
        }

        public static void Update(Customer cust)
        {
            MarinaEntities db = new MarinaEntities();
            Customer custFromContext = db.Customers.Single(c => c.ID == cust.ID);
            custFromContext.FirstName = cust.FirstName;
            custFromContext.LastName = cust.LastName;
            custFromContext.Phone = cust.Phone;
            custFromContext.City = cust.City;
            db.SaveChanges();
        }

        public static CustomerDTO Authenticate(string username, string password)
        {
            CustomerDTO dto = null;
            MarinaEntities db = new MarinaEntities();
            Customer authCust = db.Customers.
                SingleOrDefault(a => a.FirstName == username && a.LastName == password);
            if (authCust != null) // authentication passed
            {
                dto = new CustomerDTO
                {
                    ID = authCust.ID,
                    FirstName = authCust.FirstName,
                    LastName = authCust.LastName
                };
            }

            return dto;
        }
    }
}
