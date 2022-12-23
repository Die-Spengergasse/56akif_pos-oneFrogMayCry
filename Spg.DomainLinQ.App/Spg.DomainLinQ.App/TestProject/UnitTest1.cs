using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;

namespace TestProject
{
    public class UnitTest1
    {
        private School2000Context genDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=TestDB.db");

            School2000Context db = new School2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }


        [Fact]
        public void Exam_addOneEntity_SuccessTest()
        {
            School2000Context db = genDb();

            Exam ex = new Exam(new Guid(), DateTime.Now, null, 3, new Subject("hi", new SchoolClass("Name", new Teacher("a", "b", "mail", Gender.MALE, new Guid(), new Address("Test", "Test", "Test")), new Guid())), DateTime.Now);
            db.Add(ex);

            Assert.Equal(1, db.Exams.Count());
        }

        [Fact]
        public void SchoolClass_addOneEntity_SuccessTest()
        {
            School2000Context db = genDb();

            SchoolClass ex = new SchoolClass("Name", new Teacher("a", "b", "mail", Gender.MALE, new Guid(), new Address("Test", "Test", "Test")), new Guid());
            db.Add(ex);

            Assert.Equal(1, db.SchoolClasses.Count());
        }

        [Fact]
        public void Student_addOneEntity_SuccessTest()
        {
            School2000Context db = genDb();

            Student ex = new Student(1, new Guid, "i", "b", "Mail", Gender.FEMALE, new SchoolClass("a", new Teacher("a", "b", "mail", Gender.FEMALE, new Guid(), new Address("a", "s", "v"), new Guid(), new Address("a", "c", "g"))));
            db.Add(ex);

            Assert.Equal(1, db.Students.Count());
        }

        [Fact]
        public void Subject_addOneEntity_SuccessTest()
        {
            School2000Context db = genDb();

            Subject ex = new Subject("hi", new SchoolClass("teach", new Teacher("fn", "ln", "em", Gender.FEMALE, new Guid(), new Address("a", "v", "g")), new Guid()));
                db.Add(ex);

            Assert.Equal(1, db.Subjects.Count());
        }

        [Fact]
        public void Teacher_addOneEntity_SuccessTest()
        {
            School2000Context db = genDb();

            Teacher ex = new Teacher("a", "b", "e", Gender.FEMALE, new Guid(), new Address("a", "g", "c"));
                db.Add(ex);

            Assert.Equal(1, db.Teachers.Count());
        }
    }
}