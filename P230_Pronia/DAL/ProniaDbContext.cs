﻿using Microsoft.EntityFrameworkCore;
using P230_Pronia.Entities;
using P230_Pronia.Models;
using System;

namespace P230_Pronia.DAL
{
    public class ProniaDbContext :DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PlantDeliveryInformation> PlantDeliveryInformation { get; set; }
        public DbSet<PlantImage> PlantImages { get; set; }
    }
}
