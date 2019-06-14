using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticingCrud.Models
{
    public class Student
    {
        public int StudentID { get; set; }
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       

        public string Address { get; set; }
       
        public string City { get; set; }
       
        public string State { get; set; }
       
        public string Mobile { get; set; }
       
        public string Emailid { get; set; }
        

    }
}