using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.UnitTests.GuidExTests
{
    [TestClass]
    public class GuidExTst
    {
        [TestMethod]
        public void ConstructorTestEmpty()
        {
            var g = new GuidEx();
            Assert.IsInstanceOfType(g, typeof(GuidEx));
        }

        [TestMethod]
        public void ConstructorTestGuid()
        {
            var guid = new Guid("{274ebe15-447b-4863-bf89-eb75c3653694}");
            var g = new GuidEx(guid);
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), guid.ToString());
        }

        [TestMethod]
        public void ConstructorTestByteArray()
        {
            var guid = new Guid("{274ebe15-447b-4863-bf89-eb75c3653694}");
            var g = new GuidEx(guid.ToByteArray());
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), guid.ToString());
        }

        [TestMethod]
        public void ConstructorTestFourParametersSigned()
        {
            var g = new GuidEx(-123456789, 13564, -10223, new byte[] { 12, 12, 12, 12, 12, 12, 12, 12 });
            Assert.IsInstanceOfType(g, typeof(GuidEx));
        }

        [TestMethod]
        public void ConstructorTestFourParametersUnSigned()
        {
            var g = new GuidEx(uint.MaxValue, 13564, ushort.MaxValue, new byte[] { 12, 12, 12, 12, 12, 12, 12, 12 });
            Assert.IsInstanceOfType(g, typeof(GuidEx));
        }

        [TestMethod]
        public void ConstructorTest12ParametersSigned()
        {
            var g = new GuidEx(-123456789, 13564, -10223, 12, 12, 12, 12, 12, 12, 12, 12);
            Assert.IsInstanceOfType(g, typeof(GuidEx));
        }

        [TestMethod]
        public void ConstructorTest12ParametersUnSigned()
        {
            var g = new GuidEx(uint.MaxValue, 13564, ushort.MaxValue, 12, 12, 12, 12, 12, 12, 12, 12);
            Assert.IsInstanceOfType(g, typeof(GuidEx));
        }

        [TestMethod]
        public void ConstructorTestTextGuid()
        {
            var guid = new Guid("{274ebe15-447b-4863-bf89-eb75c3653694}");
            var g = new GuidEx(guid.ToString());
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), guid.ToString());
        }

        [TestMethod]
        public void ConstructorTestTextRandom()
        {
            var g = new GuidEx("ThisIsARandomText");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "46526dd3-d88b-5da5-73ba-82023776e697");
        }

        [TestMethod]
        public void ConstructorTestText2ParamsUnknownGuid()
        {
            var g = new GuidEx("ThisIsARandomText", GuidEx.NameSpaceUnknown);
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "46526dd3-d88b-5da5-73ba-82023776e697");
        }

        [TestMethod]
        public void ConstructorTestText2Params()
        {
            var g = new GuidEx("ThisIsARandomText", "AnotherRandomText");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "ee436a5b-7af8-56d0-67a6-77b9e411fab7");
        }

        [TestMethod]
        public void ConstructorTestText2ParamsTextGuidText()
        {
            var g = new GuidEx("ThisIsARandomText", "ed1dff6c-9c86-41be-9a3c-692526f7ecb7");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "80e79921-b800-52a1-666a-5b924957d5fd");
        }

        [TestMethod]
        public void ConstructorTestText2ParamsTextGuidRandom()
        {
            var g = new GuidEx("ThisIsARandomText", new GuidEx("AnotherRandomText", GuidEx.NameSpaceKeyName));
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "ee436a5b-7af8-56d0-67a6-77b9e411fab7");
        }

        [TestMethod]
        public void ConstructorTestText2ParamsTextGuid()
        {
            var g = new GuidEx("ThisIsARandomText", Guid.Parse("ed1dff6c-9c86-41be-9a3c-692526f7ecb7"));
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "80e79921-b800-52a1-666a-5b924957d5fd");
        }

        [TestMethod]
        public void VersionTestFour()
        {
            var g = GuidEx.NewGuid();
            Assert.AreEqual(g.Version, 4);
        }

        [TestMethod]
        public void VersionTestFive()
        {
            var g = new GuidEx("ThisIsARandomText");
            Assert.AreEqual(g.Version, 5);
        }

        [TestMethod]
        public void VersionTestOne()
        {
            var g = new GuidEx("7B61F78A-C0B1-1D50-9865-6B27D8146807");
            Assert.AreEqual(g.Version, 1);
        }

        [TestMethod]
        public void NewGuidParameter()
        {
            var g = GuidEx.NewGuid();
            Assert.AreEqual(g.Version, 4);
        }

        [TestMethod]
        public void NewGuidTestTextGuid()
        {
            var guid = new Guid("{274ebe15-447b-4863-bf89-eb75c3653694}");
            var g = GuidEx.NewGuid(guid.ToString());
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), guid.ToString());
        }

        [TestMethod]
        public void NewGuidTestTextRandom()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "46526dd3-d88b-5da5-73ba-82023776e697");
        }

        [TestMethod]
        public void ExplicitFromStringTestGuid()
        {
            var g = (GuidEx)"e7240525-e6a9-4801-ac65-fa2f35824846";
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "e7240525-e6a9-4801-ac65-fa2f35824846");
        }

        [TestMethod]
        public void ExplicitFromStringTestRandom()
        {
            var g = (GuidEx)"ThisIsARandomText";
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "46526dd3-d88b-5da5-73ba-82023776e697");
        }

        [TestMethod]
        public void NewGuidTestText2ParamsUnknownGuid()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText", GuidEx.NameSpaceUnknown);
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "46526dd3-d88b-5da5-73ba-82023776e697");
        }

        [TestMethod]
        public void NewGuidTestText2Params()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText", "AnotherRandomText");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "ee436a5b-7af8-56d0-67a6-77b9e411fab7");
        }

        [TestMethod]
        public void NewGuidTestText2ParamsTextGuidText()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText", "ed1dff6c-9c86-41be-9a3c-692526f7ecb7");
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "80e79921-b800-52a1-666a-5b924957d5fd");
        }

        [TestMethod]
        public void NewGuidTestText2ParamsTextGuidRandom()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText", GuidEx.NewGuid("AnotherRandomText", GuidEx.NameSpaceKeyName));
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "ee436a5b-7af8-56d0-67a6-77b9e411fab7");
        }

        [TestMethod]
        public void NewGuidTestText2ParamsTextGuid()
        {
            var g = GuidEx.NewGuid("ThisIsARandomText", Guid.Parse("ed1dff6c-9c86-41be-9a3c-692526f7ecb7"));
            Assert.IsInstanceOfType(g, typeof(GuidEx));
            Assert.AreEqual(g.ToString(), "80e79921-b800-52a1-666a-5b924957d5fd");
        }

        [TestMethod]
        public void ToStringFormat()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.AreEqual(g.ToString("X"), gx.ToString("X"));
        }

        [TestMethod]
        public void ToStringFormatIFormatProvider()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.AreEqual(g.ToString("X", CultureInfo.GetCultureInfo("en-US")), gx.ToString("X", CultureInfo.GetCultureInfo("en-US")));
        }

        [TestMethod]
        public void ToByteArray()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.AreEqual(g.ToByteArray()[4], gx.ToByteArray()[4]);
        }

        [TestMethod]
        public void EqualsTestOne()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.IsTrue(gx.Equals((GuidEx)g));
        }

        [TestMethod]
        public void EqualsTestTwo()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.IsTrue(gx.Equals(g));
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            var g = new Guid("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx(g);
            Assert.AreEqual(g.GetHashCode(), gx.GetHashCode());
        }

        [TestMethod]
        public void CompareToTestOne()
        {
            var g = new GuidEx("a7f9be96-3cb8-4c00-828a-ad0505e72eb2");
            var gx = new GuidEx("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            Assert.IsTrue(g.CompareTo(gx) > 0);
        }

        [TestMethod]
        public void CompareToTestTwo()
        {
            var g = new GuidEx("a7f9be96-3cb8-4c00-828a-ad0505e72eb2");
            var gx = new GuidEx("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            Assert.IsTrue(gx.CompareTo(g) < 0);
        }

        [TestMethod]
        public void CompareToTestThree()
        {
            var g = new GuidEx("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            var gx = new GuidEx("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            Assert.IsTrue(gx.CompareTo(g) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToTestFour()
        {
            var g = "A random string again.";
            var gx = new GuidEx("a7f9be96-3cb8-4c00-828a-ac0505e72eb2");
            gx.CompareTo(g);
        }
    }
}

