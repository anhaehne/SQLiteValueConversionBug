using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SQLiteValueConversionBug
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestDatabase>();
            optionsBuilder.UseSqlite("DataSource=:memory:");

            var db = new TestDatabase(optionsBuilder.Options);
            db.Database.EnsureCreated();
        }
    }
}