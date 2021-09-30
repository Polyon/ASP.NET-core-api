using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class AboutMeContext: DbContext
    {
        public AboutMeContext(DbContextOptions<AboutMeContext> options): base(options)
        {

        }
        public DbSet<AboutMe> Abouts {get; set;}
    }
}