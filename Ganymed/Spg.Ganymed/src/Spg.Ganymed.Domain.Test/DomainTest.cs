using Spg.Ganymed.Domain.Model;
using Spg.Ganymed.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Test
{
    public class DomainTest : BaseDB
    {
        [Fact]
        public void CartEntryAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();

            CartEntry newCartEntry = TestFixtures.createCartEntry();

            ; db.Add(newCartEntry);
            db.SaveChanges();

            Assert.Equal(1, db.CartEntries.Count());
        }

        [Fact]
        public void CartAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();
            Cart newCart = TestFixtures.createCart();

            db.Add(newCart);
            db.SaveChanges();

            Assert.Equal(1, db.Carts.Count());
        }

        [Fact]
        public void EquipmentAddOneEtitySuccessTest()
        {
            GanymedContext db = generateTestDb();
            Equipment newEquipment = TestFixtures.createEquipment();

            db.Add(newEquipment);
            db.SaveChanges();

            Assert.Equal(1, db.Equipment.Count());
        }

        [Fact]
        public void EquipmentTypeAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();
            EquipmentType newEquipmentType = TestFixtures.createEquipmentType();

            db.Add(newEquipmentType);
            db.SaveChanges();

            Assert.Equal(1, db.EquipmentTypes.Count());
        }

        [Fact]
        public void HappeningLocationAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();
            HappeningLocation newHappeningLocation = TestFixtures.createHappeningLocation();

            db.Add(newHappeningLocation);
            db.SaveChanges();

            Assert.Equal(1, db.HappeningLocations.Count());
        }

        [Fact]
        public void HappeningAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();
            Happening newHappening = TestFixtures.createHappening();

            db.Add(newHappening);
            db.SaveChanges();

            Assert.Equal(1, db.Happenings.Count());
        }

        [Fact]
        public void UserAddOneEntity_SuccessText()
        {
            GanymedContext db = generateTestDb();
            User newUser = TestFixtures.createUser();

            db.Users.Add(newUser);
            db.SaveChanges();

            Assert.Equal(1, db.Users.Count());
        }

        [Fact]
        public void WarehousePositionAddOneEntity_SuccessTest()
        {
            GanymedContext db = generateTestDb();
            WarehousePosition newWarehousePosition = TestFixtures.createWarehousePosition();

            db.Add(newWarehousePosition);
            db.SaveChanges();

            Assert.Equal(1, db.WarehousePositions.Count());
        }

        [Fact]
        public void WarehouseAddOneEtity_SuccessTest()
        {

            GanymedContext db = generateTestDb();
            Warehouse newWarehouse = TestFixtures.createWarehouse();

            db.Warehouses.Add(newWarehouse);
            db.SaveChanges();

            Assert.Equal(1, db.Warehouses.Count());
        }


    }
}
