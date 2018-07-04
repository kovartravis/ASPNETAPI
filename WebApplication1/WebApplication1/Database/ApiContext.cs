using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercisesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercisesAPI.Database
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options): base(options)
        {

        }

        public DbSet<Act> Actions { get; set; }
    }
}
