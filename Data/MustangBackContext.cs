using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mustang_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang_Back.Data
{
    public class MustangBackContext : IdentityDbContext
    {
        public MustangBackContext(DbContextOptions<MustangBackContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Pedido>  Pedido { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
