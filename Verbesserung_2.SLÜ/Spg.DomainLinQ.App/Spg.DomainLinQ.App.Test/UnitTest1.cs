using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;

namespace Spg.DomainLinQ.App.Test
{
    public class UnitTest1
    {
        private School2000Context generateDb()
        {
            DbContextOptionsBuilder ob  = new DbContextOptionsBuilder();
            ob.UseSqlite("Data Source=Test.db");

            School2000Context db = new School2000Context(ob.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            return db;
        }
        [Fact]
        public void Exam_addOneEntity_SuccessTest()
        {
            Exam ex = new Exam(
                                new Guid(),
                                DateTime.Now,
                                null,
                                1,
                                new Subject(
                                    "description",
                                     new SchoolClass(
                                        "name",
                                        new Teacher(
                                            "fn",
                                            "ln",
                                            "email",
                                            Gender.FEMALE,
                                            new Guid(),
                                            new Address(
                                                "street",
                                                "zip",
                                                "city")
                                            ),
                                        new Guid()
                                        )
                                     ),
                                DateTime.Now);

            School2000Context db = generateDb();
            db.Add(ex);
            db.SaveChanges();
            Assert.Equal(1, db.Exams.Count());
        }

        [Fact]
        public void SchoolClass_addOneEntity_SuccessTest()
        {
            SchoolClass sc = new SchoolClass(
                                        "name",
                                        new Teacher(
                                            "fn",
                                            "ln",
                                            "email",
                                            Gender.FEMALE,
                                            new Guid(),
                                            new Address(
                                                "Street",
                                                "zip",
                                                "City")),
                                        new Guid());

            School2000Context db = generateDb();
            db.Add(sc);
            db.SaveChanges();
            Assert.Equal(1, db.Teachers.Count());
        }

        [Fact]
        public void Student_addOneEntity_SuccessTest()
        {
            Student st = new Student(
                                    1,
                                    new Guid(),
                                    "fn",
                                    "ln",
                                    "email",
                                    Gender.FEMALE,
                                    new SchoolClass(
                                        "name",
                                        new Teacher(
                                            "fn",
                                            "ln",
                                            "email",
                                            Gender.FEMALE,
                                            new Guid(),
                                            new Address(
                                                "Street",
                                                "Zip",
                                                "City")),
                                        new Guid()),
                                    new Address(
                                        "Street",
                                        "Zip",
                                        "City"),
                                    new PhoneNumber("+22"));

            School2000Context db = generateDb();
            db.Add(st);
            db.SaveChanges();
            Assert.Equal(1, db.Students.Count());
        }

        [Fact]
        public void Subject_addOneEntity_SuccessTest()
        {
            Subject sj = new Subject(
                                "description",
                                new SchoolClass(
                                    "Name",
                                    new Teacher(
                                        "fn",
                                        "ln",
                                        "email",
                                        Gender.FEMALE,
                                        new Guid(),
                                        new Address(
                                            "Street",
                                            "Zip",
                                            "City")),
                                    new Guid()));


            School2000Context db = generateDb();
            db.Add(sj);
            db.SaveChanges();
            Assert.Equal(1, db.Subjects.Count());
        }

        [Fact]
        public void Teacher_addOneEntity_SuccessTest()
        {
            Teacher t = new Teacher(
                                "fn",
                                "ln",
                                "email",
                                Gender.FEMALE,
                                new Guid(),
                                new Address(
                                    "Street",
                                    "Zip",
                                    "City"));

            School2000Context db = generateDb();
            db.Add(t);
            db.SaveChanges();
            Assert.Equal(1, db.Teachers.Count());
        }
    }
}