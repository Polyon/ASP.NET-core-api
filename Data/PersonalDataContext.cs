using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class PersonalDataContext: DbContext
    {
        public PersonalDataContext(DbContextOptions<PersonalDataContext> options): base(options)
        {

        }
        public DbSet<PersonalData> PersonalData {get; set;}
    }
}