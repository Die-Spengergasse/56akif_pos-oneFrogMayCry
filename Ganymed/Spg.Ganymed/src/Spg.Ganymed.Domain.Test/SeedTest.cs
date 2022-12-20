using Microsoft.EntityFrameworkCore;
using Spg.Ganymed.Domain.Model;
using Spg.Ganymed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Test
{
    public class SeedTest : BaseDB
    {
        [Fact]
        public void SeedDb()
        {
            GanymedContext db = generateTestDb();
            db.Seed();
        }
    }
}
