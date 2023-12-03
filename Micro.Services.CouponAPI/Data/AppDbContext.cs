using Micro.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Micro.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "300RRR",
                DiscountAmount = 30,
                MinAmount = 20

            });
        }
    }
}
