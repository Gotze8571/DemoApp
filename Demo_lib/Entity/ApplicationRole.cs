using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Data.Entity
{
    public class ApplicationRole
    {
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Code { get; set; }
        public bool IsAdmin { get; set; } = false;
    }
}
