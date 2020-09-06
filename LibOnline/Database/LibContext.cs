using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibOnline.Database.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibOnline.Database
{
    public class LibContext : IdentityDbContext<User>
    {
        public DbSet<Microsoft.AspNetCore.Identity.IdentityUserClaim<Guid>> IdentityUserClaims { get; set; }
        public LibContext(DbContextOptions<LibContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
