using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MovieApp.Models;

public partial class MovieAppDbContext : DbContext
{
    public MovieAppDbContext()
    {
    }

    public MovieAppDbContext(DbContextOptions<MovieAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Review> Reviews { get; set; }

<<<<<<< HEAD
    public virtual DbSet<TopMovies> TopMovies { get; set; }

=======
>>>>>>> a8ed6b4471308c552fab4e9b303e26967f16785c
    public virtual DbSet<Watchlist> Watchlists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MovieAppDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Review>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImdbId).HasMaxLength(50);
            entity.Property(e => e.Review1).HasColumnName("Review");
        });

<<<<<<< HEAD
        modelBuilder.Entity<TopMovies>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ImdbId).HasMaxLength(50);
            entity.Property(e => e.ImdbRating).HasMaxLength(50);
            entity.Property(e => e.ImdbRatingCount).HasMaxLength(50);
            entity.Property(e => e.Rank).HasMaxLength(50);
            entity.Property(e => e.Year).HasMaxLength(50);
        });

=======
>>>>>>> a8ed6b4471308c552fab4e9b303e26967f16785c
        modelBuilder.Entity<Watchlist>(entity =>
        {
            entity.ToTable("Watchlist");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ImdbId).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
