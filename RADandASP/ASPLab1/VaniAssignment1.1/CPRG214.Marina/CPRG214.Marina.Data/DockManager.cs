using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// data access methods. using LINQ to select and insert rows in db
/// </summary>

namespace CPRG214.Marina.Data
{
    public class DockManager
    {
        public IList GetAllAsListItems()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.Select(d => new
            { ID = d.ID, Name = d.Name }).ToList();
            return docks;
        }

        public static List<Dock> GetAll()
        {
            var db = new MarinaEntities();
            var docks = db.Docks.ToList();
            return docks;
        }

        public static Dock Find(int id)
        {
            var db = new MarinaEntities();
            var dcks = db.Docks.SingleOrDefault(d => d.ID == id);
            return dcks;
        }

        public static IList FindSlip(int id)
        {
           
            var db = new MarinaEntities();
            
            var availableSlips =db.Slips.Where(s => s.Leases.Count == 0 && s.DockID == id).Select(a => new { a.ID }).ToList();         
            
            return availableSlips;

        }

        //select leased slips for the customer

        public static IList FindLeasedSlip(int customerId)
        {
            var db = new MarinaEntities();
            var leasedSlips = db.Leases.Where(s => s.CustomerID == customerId).Select(s => new { SlipsLeased = s.SlipID }).ToList();
            return leasedSlips;
        }

        //add lease to db
        public static void Add(Lease lease)
        {
            var db = new MarinaEntities();
            db.Leases.Add(lease);
            db.SaveChanges();
        }

    }
}
