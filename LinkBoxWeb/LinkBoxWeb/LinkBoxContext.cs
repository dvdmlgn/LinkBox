using LinkBoxWeb.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LinkBoxWeb
{
    

    public class LinkBoxContext : DbContext
    {
        public LinkBoxContext():base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasIndex(u => u.Username)
                 .IsUnique();
        }

        public LinkBoxContext(DbContextOptions<LinkBoxContext> options)
            : base(options)
        {
            /*
            this.Database.Migrate();

            var thisAssembly = new FileInfo(Assembly.GetExecutingAssembly().Location);
            var thisFolder = thisAssembly.DirectoryName;


            foreach (var subject in File.ReadAllLines(
                Path.Combine(
                    thisFolder,
                    "SeedData\\Subject.txt")))
            {
                if (string.IsNullOrWhiteSpace(subject))
                    continue;

                var subjectRecord = this.Subjects.FirstOrDefaultAsync(_subject => _subject.Name == subject).Result;
                if(subjectRecord == null)
                {
                    this.Subjects.Add(new Subject()
                    {
                        Name = subject,
                        Topics = new List<Topic>()
                        {
                            new Topic(){
                                Name = $"{subject}-Topic-A",
                            },

                            new Topic(){
                                Name = $"{subject}-Topic-B"
                            },

                            new Topic(){
                                Name = $"{subject}-Topic-C"
                            }
                        }
                    });
                }
            }

            this.SaveChanges();
            */
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserTags> UserTagss { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}