using ApiSolution.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiSolution.Infrastructure
{
    public class SolutionContext : DbContext
    {
        public SolutionContext()
        {

        }

        public DbSet<Posts> Employee { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}