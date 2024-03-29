﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Blogging.Model
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(

                //"Default": 
                "User ID=postgres;Password=wsx1001;Host=localhost;Port=5432;Database=bloggingDgERM;Pooling=true;"
                //"Data Source=blogging.db"

                );
        }
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}