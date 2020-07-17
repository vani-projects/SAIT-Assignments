using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG214.Marina.Data
{
   public class AuthenticationManager
    {
        public static CustomerDTO Authenticate(string fname,string lname) //autheticate the user 
        {
            CustomerDTO dto = null;
            var db = new MarinaEntities();
            var auth = db.Customers.
                SingleOrDefault(a => a.FirstName == fname && a.LastName == lname);
            if (auth != null) // authentication passsed
            {
                dto = new CustomerDTO
                {
                    ID = auth.ID,
                    FullName = $"{auth.FirstName} {auth.LastName}"
                };
            }
            return dto;
        }

        public static Customer Find(int custId) //find the customer if exists in db
        {
            var db = new MarinaEntities();
            var auth = db.Customers.
                SingleOrDefault(a => a.ID == custId);
            return auth;
        }

        public static void Add(Customer auth) //add new customer
        {
            var db = new MarinaEntities();
            db.Customers.Add(auth);
            db.SaveChanges();
        }
    }
}
