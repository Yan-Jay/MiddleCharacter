using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleCharacter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacter.Tests
{
    [TestClass()]
    public class MiddleCharacterTests
    {
        [TestMethod()]
        public void GetMiddleTest()
        {
            Assert.AreEqual("es", MiddleCharacter.GetMiddle("test"));
        }
        [TestMethod()]
        public void GetMiddleTest2()
        {
            Assert.AreEqual("t", MiddleCharacter.GetMiddle("testing"));
        }
        [TestMethod()]
        public void GetMiddleTest3()
        {
            Assert.AreEqual("dd", MiddleCharacter.GetMiddle("middle"));
        }
        [TestMethod()]
        public void GetMiddleTest4()
        {
            Assert.AreEqual("A", MiddleCharacter.GetMiddle("A"));
        }
    }
}