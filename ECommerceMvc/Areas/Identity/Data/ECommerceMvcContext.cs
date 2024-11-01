using ECommerceMvc.Areas.Identity.Data;
using ECommerceShared.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceMvc.Areas.Identity.Data;

public class ECommerceMvcContext : IdentityDbContext<ApplicationUser>
{
    public ECommerceMvcContext(DbContextOptions<ECommerceMvcContext> options)
        : base(options)
    {
    }

    //protected override void OnModelCreating(ModelBuilder builder)
    //{
    //    base.OnModelCreating(builder);
    //    // Customize the ASP.NET Identity model and override the defaults if needed.
    //    // For example, you can rename the ASP.NET Identity table names and more.
    //    // Add your customizations after calling base.OnModelCreating(builder);
    //}

    public  DbSet<Category> Categories { get; set; }
    public  DbSet<Product> Products { get; set; }

}
