using LinkBoxWeb.DataModel;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Content> Contents { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserTags> UserTagss { get; set; }
    }
}