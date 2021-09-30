using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class SendMassageContext: DbContext
    {
        public SendMassageContext(DbContextOptions<SendMassageContext> options): base(options)
        {

        }
        public DbSet<SendMassage> Send {get; set;}
    }
}