using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace comestic_csharp.Areas.Identity.Data
{
    public class ShopUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}