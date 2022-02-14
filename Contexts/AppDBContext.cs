using GenericRHSystemBackEnd.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRHSystemBackEnd.Contexts
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options)
        {

        }

        //this must match the name of the table in the database
        public DbSet<UserEntity> Usuario { get; set; }

    }
}
