

using Microsoft.EntityFrameworkCore;
using app.models;

namespace app.data;

public class AppDbcontext : DbContext
{
    public DbSet<UserObject> Users {get;set;}
    public DbSet<ImageObject> Images{get;set;}

    public AppDbcontext() {} //avoid migation issue

    public AppDbcontext(DbContextOptions<AppDbcontext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageObject>() //implement one-many relationship
            .HasOne(i => i.User)
            .WithMany(u => u.ImagesGallery)
            .HasForeignKey(i => i.User_ID);
    }
}