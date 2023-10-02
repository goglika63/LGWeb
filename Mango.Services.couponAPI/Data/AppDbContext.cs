using Mango.Services.couponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.couponAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Coupon> Coupons { get; set; }
    }
}
