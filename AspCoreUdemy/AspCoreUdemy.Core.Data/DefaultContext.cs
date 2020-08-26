using AspCoreUdemy.Core.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace AspCoreUdemy.Core.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Proposition> Reponses { get; set; }

    }
}
