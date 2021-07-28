using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinaData
{
    public static class MarinaManager
    {

        ///////////////////////////    Authentication Manager  ////////////////////////
        public static CustomerDTO Authenticate(string username, string password)
        {
            CustomerDTO dto = null;
            MarinaEntities db = new MarinaEntities();
            Authentication auth = db.Authentications.
                SingleOrDefault(a => a.Username == username && a.Password == password);
            if (auth != null) 
            {
                dto = new CustomerDTO
                {
                    ID = auth.Customer.ID,
                    FullName = auth.Customer.FirstName + " " + auth.Customer.LastName
                };
            }
            return dto;
        }

        /// <summary>
        /// finds authentication for student with given id
        /// </summary>
        /// <param name="custId">student ID to find</param>
        /// <returns>authentication record for this customer or null if not found</returns>
        public static Authentication FindAuthentication(int custId)
        {
            MarinaEntities db = new MarinaEntities();
            Authentication auth = db.Authentications.
                SingleOrDefault(a => a.CustomerID == custId);
            return auth;
        }

        /// <summary>
        /// add authentication record to the table
        /// </summary>
        /// <param name="auth">record to add</param>
        public static void AddAuthentication(Authentication auth)
        {
            MarinaEntities db = new MarinaEntities();
            // no need to add record to Student, just add record to Authentication
            db.Authentications.Add(auth);
            db.SaveChanges();
        }

        /// <summary>
        /// update authentication record
        /// </summary>
        /// <param name="auth">new data for update</param>
        public static void UpdateAuthentication(Authentication auth)
        {
            MarinaEntities db = new MarinaEntities();
            // find current authentication record with the same Id
            Authentication authFromContext = db.Authentications.SingleOrDefault(a => a.Id == auth.Id);
            // replace old value with new values
            authFromContext.Username = auth.Username;
            authFromContext.Password = auth.Password;
            authFromContext.Customer.FirstName = auth.Customer.FirstName;
            authFromContext.Customer.LastName = auth.Customer.LastName;
            authFromContext.Customer.Phone = auth.Customer.Phone;
            authFromContext.Customer.City = auth.Customer.City;
            db.SaveChanges();
        }






        ////////////////////////////////    Customer Manager    ////////////////////////////////
        public static Customer FindCustomer(int id)
        {
            MarinaEntities db = new MarinaEntities();
            Customer cust = db.Customers.SingleOrDefault(c => c.ID == id);
            return cust;
        }

        public static void AddCustomer(Customer cust)
        {
            MarinaEntities db = new MarinaEntities();
            db.Customers.Add(cust);
            db.SaveChanges();
        }

        public static void UpdateCustomer(Customer cust)
        {
            MarinaEntities db = new MarinaEntities();
            Customer custFromContext = db.Customers.Single(c => c.ID == cust.ID);
            custFromContext.FirstName = cust.FirstName;
            custFromContext.LastName = cust.LastName;
            custFromContext.Phone = cust.Phone;
            custFromContext.City = cust.City;
            db.SaveChanges();
        }


        /////////////////////////////////     Dock Manager    ////////////////////////////////
        public static List<Dock> GetAll()
        {
            MarinaEntities db = new MarinaEntities();
            List<Dock> docks = db.Docks.ToList();
            return docks;
        }

        /////////////////////////////////     Slip Manager    ////////////////////////////////
        public static List<Slip> GetAllSlips()
        {
            MarinaEntities db = new MarinaEntities();
            List<Slip> slips = db.Slips.ToList();
            return slips;
        }

        public static List<Slip> AvailableSlip(int id)
        {
            MarinaEntities db = new MarinaEntities();
            var availableSlips = db.Slips.
                Where(s => s.Leases.Count == 0 && s.DockID == id).ToList();
            return availableSlips;
        }

        public static void LeaseSlips()
        {
            MarinaEntities db = new MarinaEntities();

        }

    }
}
