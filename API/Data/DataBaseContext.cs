using System;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataBaseContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
