using Microsoft.EntityFrameworkCore;
using Spg.Ganymed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Test
{
    public class BaseDB
    {
        protected GanymedContext generateTestDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=GanymedTest.db");
            GanymedContext db = new GanymedContext(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }
    }
}
