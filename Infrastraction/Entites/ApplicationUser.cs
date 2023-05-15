using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Entites
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAgree { get; set; }

        public string ImageUrl { get; set; }
    }
}
