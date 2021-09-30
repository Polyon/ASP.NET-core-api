using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class SocialMediaContext: DbContext
    {
        public SocialMediaContext(DbContextOptions<SocialMediaContext> options): base(options)
        {

        }
        public DbSet<SocialMedia> SocialMedias {get; set;}
    }
}