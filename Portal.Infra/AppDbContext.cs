using System;
using Microsoft.EntityFrameworkCore;

namespace Portal.Infra;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
}
