using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class SkillDataContext: DbContext
    {
        public SkillDataContext(DbContextOptions<SkillDataContext> options): base(options)
        {

        }
        public DbSet<SkillsData> Skills {get; set;}
    }
}