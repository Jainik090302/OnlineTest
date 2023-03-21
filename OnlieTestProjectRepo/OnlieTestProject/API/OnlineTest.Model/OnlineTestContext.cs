﻿using Microsoft.EntityFrameworkCore;

namespace OnlineTest.Models { 
    public class OnlineTestContext : DbContext
    {
        public OnlineTestContext(DbContextOptions<OnlineTestContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            foreach (var fkey in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                fkey.DeleteBehavior = DeleteBehavior.Restrict;
            }

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RToken> rTokens { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public  DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<QueAnsMap> QueAnsMap { get; set;}

    }
}