using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class RecieveMassageContext: DbContext
    {
        public RecieveMassageContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<RecieveMassage> RecieveMassages {get; set;}
    }
}