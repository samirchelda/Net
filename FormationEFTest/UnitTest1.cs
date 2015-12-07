using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationEF;
using System.Linq;
using System.Collections.Generic;

namespace FormationEFTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EFTest()
        {
            FormationEntities entities = new FormationEntities();

            List<Book> books = entities.Books.ToList();
        }
    }
}
