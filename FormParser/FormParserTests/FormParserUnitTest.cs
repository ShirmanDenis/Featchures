using System;
using System.IO;
using FormParser.ControlsDescriptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormParser;

namespace FormParserTests
{
    [TestClass]
    public class FormParserUnitTest
    {
        private FormParser.FormParser _formParser;

        [TestInitialize]
        public void InitTestMethod()
        {
            _formParser = new FormParser.FormParser();

            _formParser.RegisterControlSpec("Button", () => new ButtonSpec());
            _formParser.RegisterControlSpec("TextBox", () => new FormParser.ControlsDescriptions.TextBoxSpec());
            _formParser.RegisterControlSpec("Label", () => new LabelSpec());
            _formParser.RegisterControlSpec("Form", () => new FormSpec());
        }


        [TestMethod]
        public void TestRegisterControlSpec()
        {
            var typeOfControl = "TextBox";

            Assert.IsTrue(_formParser.IsControlRegistered(typeOfControl));
        }

        [TestMethod]
        public void TestParseFromJson()
        {
            var filePath = "testForm1.json";

            var json = File.ReadAllText(filePath);

            var form = _formParser.ParseFromJson(json);

            Assert.IsNotNull(form);
        }
    }
}
