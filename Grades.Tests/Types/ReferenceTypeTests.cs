using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Maciej";
            string name2 = "maciej";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IntVariablesHoldValue()
        {
            int x1 = 100;
            Int32 x2 = x1;
            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }


        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Maciej's Grade book";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
