using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    // Add profile data for application users by adding properties to the FeaneFastFoodUser class
    public class ApplicationUser : IdentityUser 
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
