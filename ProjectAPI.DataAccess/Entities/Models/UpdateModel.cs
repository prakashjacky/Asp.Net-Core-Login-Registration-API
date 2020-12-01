using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAPI.DataAccess.Entities.Models
{
    public class UpdateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
