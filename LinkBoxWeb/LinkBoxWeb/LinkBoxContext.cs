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

        public DbSet<Site> Sites { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
