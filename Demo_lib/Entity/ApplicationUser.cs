using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Data.Entity
{
    public class ApplicationUser
    {
        [Key]
        public int Cust_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
