using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "john_admin", EmailAddress = "john.admin@email.com",
                Password = "Password", GivenName = "John", Surname = "Bryant", Role = "Administrator" },
            new UserModel() { Username = "mark_seller", EmailAddress = "Mark.seller@email.com",
                Password = "Password", GivenName = "Mark", Surname = "Lambert", Role = "Seller" },
        };
    }
}
