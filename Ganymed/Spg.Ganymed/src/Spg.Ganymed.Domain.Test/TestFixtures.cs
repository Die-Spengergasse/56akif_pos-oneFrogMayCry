using Spg.Ganymed.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Ganymed.Domain.Test
{
    public class TestFixtures
    {
        public static Address createAddress()
        {
            return new Address("TestStreet", "23/12", 1230, "TestCity");
        }

        public static User createUser()
        {
            return new User(Genders.Female, "Io", "Gschwentner", "OneFrogMayCry", "email.email@email.com", "qwertzuiop", DateTime.Now);
        }

        public static Cart createCart()
        {
            return new Cart(CartStates.Sent, createUser());
        }

        public static Happening createHappening()
        {
            return new Happening(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-5));
        }

        public static HappeningLocation createHappeningLocation()
        {
            return new HappeningLocation(createAddress());
        }

        public static EquipmentType createEquipmentType()
        {
            return new EquipmentType("TestType");
        }

        public static Warehouse createWarehouse()
        {
            return new Warehouse(createAddress());
        }

        public static WarehousePosition createWarehousePosition()
        {
            return new WarehousePosition("TestRoom",
                                        "TestShelf",
                                        "TestLevel",
                                        "TestCompartment",
                                        createWarehouse()
                                        );
        }

        public static Equipment createEquipment()
        {
            return new Equipment("Test",
                                "Test Description",
                                true,
                                createHappeningLocation(),
                                createEquipmentType(),
                                createWarehousePosition()
                                );
        }

        public static CartEntry createCartEntry()
        {
            return new CartEntry(createHappening(), createCart(), createEquipment());
        }
    } 
}
