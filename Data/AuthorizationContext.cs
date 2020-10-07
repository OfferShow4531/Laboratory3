using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratory6.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratory6.Data
{
    public class AuthorizationContext : DbContext
    {
        public AuthorizationContext(DbContextOptions<AuthorizationContext> options)
            : base(options)
        {
        }

        public DbSet<MarsController> MarsControllers { get; set; }
    }
}
