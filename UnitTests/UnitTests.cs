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
        public void HumanFighter0015()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0015.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0016()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0016.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0017()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0017.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0018()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0018.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0019()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0019.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0020()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0020.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0021()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0021.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0022()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0022.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0023()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0023.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0024()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0024.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0025()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0025.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0026()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0026.xml");
            Assert.AreNotEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0027()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0027.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0028()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0028.xml");
            Assert.AreEqual("VALID", valid, false, valid);
        }

        [TestMethod]
        public void HumanFighter0029()
        {
            string valid = Validate(@"XmlTestFiles\BFRPG2-Human-Fighter-0029.xml");
            Assert.AreEqual("VALID", valid, false, valid);
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
