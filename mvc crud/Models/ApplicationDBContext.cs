﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mvc_crud.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>dbContextOptions) : base(dbContextOptions)
        { }
        
        public DbSet<Student> Students { get; set; }
        
    }
}
