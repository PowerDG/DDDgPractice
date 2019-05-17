using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.MongoDB;

namespace Dg.ERM.MongoDB
{
    public class MyDbContext : AbpMongoDbContext
    {
        public IMongoCollection<Question> Questions => Collection<Question>();

        public IMongoCollection<Category> Categories => Collection<Category>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>(b =>
            {
                b.CollectionName = "Questions";
            });
        }
    }

    public class Category
    {
    }

    public class Question
    {
    }
}
