using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class WorkExpContext: DbContext
    {
        public WorkExpContext(DbContextOptions<WorkExpContext> options): base(options)
        {

        }
        public DbSet<WorkExp> Exprience {get; set;}
    }
}