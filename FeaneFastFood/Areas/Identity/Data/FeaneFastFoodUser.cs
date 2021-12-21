using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace FeaneFastFood.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the FeaneFastFoodUser class
    public class FeaneFastFoodUser : IdentityUser 
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public string Surname { get; set; }

    }
}
