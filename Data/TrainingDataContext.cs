using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MineApi.Data
{
    public class TrainingDataContext: DbContext
    {
        public TrainingDataContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<TrainingData> Trainings {get; set;}
    }
}