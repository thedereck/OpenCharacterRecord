using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private string Validate(string xmlFileName)
        {
            string valid = "VALID";
            XDocument xml = XDocument.Load(xmlFileName);
            XmlSchemaSet xsd = new XmlSchemaSet();
            xsd.Add("", "OpenCharacterRecord.xsd");
            xml.Validate(xsd, (o, e) => { valid = e.Message; });
            return valid;
        }

        [TestMethod]
        public void HumanFighter0001()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0001.xml"); 
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0002()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0002.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0003()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0003.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0004()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0004.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0005()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0005.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0006()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0006.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0007()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0007.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0008()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0008.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0009()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0009.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0010()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0010.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0011()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0011.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0012()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0012.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0013()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0013.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0014()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0014.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanCleric0001()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Cleric-0001.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanMagicUser0001()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-MagicUser-0001.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanThief0001()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Thief-0001.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }
    }
}
