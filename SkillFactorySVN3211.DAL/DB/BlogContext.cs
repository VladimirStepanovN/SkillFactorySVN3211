﻿using Microsoft.EntityFrameworkCore;
using SkillFactorySVN3211.DAL.Entities;

namespace SkillFactorySVN3211.DAL.DB
{
    public sealed class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        public DbSet<Request> Requests { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
