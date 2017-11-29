using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using FormParser;
namespace UnitTestProject1
{
    [TestClass]
    public class FormSpecTests
    {
        private FormParser.FormSpec _formSpec;

        [TestInitialize]
        public void Init()
        {
            _formSpec = new FormSpec();
        }

        [TestMethod]
        public void SizeTest()
        {
            var size = new Size(100, 200);
            _formSpec.ClientSize = size;
            Assert.AreEqual(_formSpec.ClientSize, size);
        }
        [TestMethod]
        public void ControlTypeTest()
        {
            Assert.AreEqual(_formSpec.ControlType, "Form");
        }
        
        [TestMethod]
        public void NameTest()
        {
            string str = "form1";
            _formSpec.Name = str;
            Assert.AreEqual(_formSpec.Name, str);
        }

        [TestMethod]
        public void TextTest()
        {
            string str = "text1";
            _formSpec.Text = str;
            Assert.AreEqual(_formSpec.Text, str);
        }

        [TestMethod]
        public void LocationTest()
        {
            var p =new Point (3, 6);
            _formSpec.Location = p;
            Assert.AreEqual(_formSpec.Location, p);
        }
    }
}
