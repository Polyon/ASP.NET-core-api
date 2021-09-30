using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class ProjectDataContext: DbContext
    {
        public ProjectDataContext(DbContextOptions<ProjectDataContext> options): base(options)
        {

        }
        public DbSet<ProjectData> Projects {get; set;}
    }
}