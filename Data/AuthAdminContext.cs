using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class AuthAdminContext: DbContext
    {
        public AuthAdminContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<AuthAdmin> Admins { get; set; }
    }
}