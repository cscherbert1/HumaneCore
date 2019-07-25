﻿using System;
using System.Collections.Generic;
using System.Text;
using HumaneCore.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HumaneCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<IdentityUser> ApplicationUsers { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<Restriction> Restrictions { get; set; }
        public DbSet<Species> Species { get; set; }
    }
}