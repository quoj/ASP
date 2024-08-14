using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamInASP.NET_MVC.Entities;

public partial class HrManageContext : DbContext
{
    public HrManageContext()
    {
    }

    public HrManageContext(DbContextOptions<HrManageContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost,1433;Database=HR_MANAGE;User Id=sa;Password=Password789;TrustServerCertificate=true");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
