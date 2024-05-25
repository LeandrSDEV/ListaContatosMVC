using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContatosMVC.Models;

namespace ContatosMVC.Data
{
    public class ContatosMVCContext : DbContext
    {
        public ContatosMVCContext (DbContextOptions<ContatosMVCContext> options)
            : base(options)
        {
        }

        public DbSet<ContatosMVC.Models.DepartmentModel> DepartmentModel { get; set; }
    }
}
