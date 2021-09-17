using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class OtherInterestContext: DbContext
    {
        public OtherInterestContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<OtherInterest> Others { get; set; }
    }
}