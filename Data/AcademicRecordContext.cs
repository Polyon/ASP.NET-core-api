using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class AcademicRecordContext: DbContext
    {
        public AcademicRecordContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<AcademicRecord> Academics { get; set; }        
    }
}