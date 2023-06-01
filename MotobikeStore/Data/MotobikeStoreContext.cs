using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MotobikeStore.Models;

namespace MotobikeStore.Data
{
    public class MotobikeStoreContext : DbContext
    {
        public MotobikeStoreContext (DbContextOptions<MotobikeStoreContext> options)
            : base(options)
        {
        }

        public DbSet<MotobikeStore.Models.DongXe> DongXe { get; set; } = default!;

        public DbSet<MotobikeStore.Models.HangXe>? HangXe { get; set; }

        public DbSet<MotobikeStore.Models.SanPham>? SanPham { get; set; }
    }
}
