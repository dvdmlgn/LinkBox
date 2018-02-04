using LinkBoxWeb.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinkBoxWeb
{
    public class LinkBoxContext : DbContext
    {
        public LinkBoxContext(DbContextOptions<LinkBoxContext> options)
            : base(options)
        { }

        public DbSet<Subject> Subjects { get; set; }
    }
}
