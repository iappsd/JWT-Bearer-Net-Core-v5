using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string Role { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }

        public User User { get; set; }
    }
}
