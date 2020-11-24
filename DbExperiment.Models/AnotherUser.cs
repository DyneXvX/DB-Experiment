using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DbExperiment.Models
{
    public class AnotherUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
