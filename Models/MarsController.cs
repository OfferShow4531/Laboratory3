using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Laboratory6.Models
{
    public class MarsController
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Country { get; set; }
        
    }
}
