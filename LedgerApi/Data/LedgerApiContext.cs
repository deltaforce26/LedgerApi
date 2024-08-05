using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LedgerApi.Model;

namespace LedgerApi.Data
{
    public class LedgerApiContext : DbContext
    {
        public LedgerApiContext (DbContextOptions<LedgerApiContext> options)
            : base(options)
        {
        }

        public DbSet<LedgerApi.Model.User> User { get; set; } = default!;
        public DbSet<LedgerApi.Model.Ledger> Ledger { get; set; } = default!;
        public DbSet<LedgerApi.Model.Expenses> Expenses { get; set; } = default!;
    }
}
