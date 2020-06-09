using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCProject2.Models
{
   
    public class Customer
    {
        public enum Gender
        {
            Male,
            Female 
        }
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public Gender gender { get; set; }
        public DateTime Dob { get; set; }
        public string Mobile { get; set; }
        public string Mobil2 { get; set; }
        public string Address { get; set; }
      
      
        public string Remark { get; set; }
        public DateTime Appdate { get; set; }
        public string Followup { get; set; }
       
        public string Status { get; set; }
    }

    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}