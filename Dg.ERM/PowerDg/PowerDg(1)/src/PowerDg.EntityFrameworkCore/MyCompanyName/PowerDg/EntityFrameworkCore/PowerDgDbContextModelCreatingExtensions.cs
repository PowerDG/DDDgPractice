﻿using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace PowerDg.EntityFrameworkCore
{
    public static class PowerDgDbContextModelCreatingExtensions
    {
        public static void ConfigurePowerDg(
            this ModelBuilder builder,
            Action<PowerDgModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new PowerDgModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                //b.ToTable(options.TablePrefix + "Questions", options.Schema);
                
                //Properties
                //b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Configure relations
                //b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Configure indexes
                //b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}