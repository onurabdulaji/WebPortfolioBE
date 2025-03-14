﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebPortfolio.Domain.Entities;

namespace WebPortfolio.Persistence.Context;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public AppDbContext(DbContextOptions options) : base(options) { }
    public AppDbContext()
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Form> Forms { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<SMedia> SMedias { get; set; }
    public DbSet<Stat> Stats { get; set; }
    public DbSet<Summary> Summaries { get; set; }
}
