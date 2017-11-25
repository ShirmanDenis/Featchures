using System;
using FormParser.ControlsDescriptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormParserTests
{
    [TestClass]
    public class FormParserUnitTest
    {
        private FormParser.FormParser _formParser;

        [TestInitialize]
        public void Init()
        {
            _formParser = new FormParser.FormParser();
        }


        [TestMethod]
        public void TestRegisterSpecEditor()
        {
            var typeOfControl = "TextBox";

            _formParser.RegisterControlSpec(typeOfControl, () => new TextBoxSpec());

            Assert.IsTrue(_formParser.IsControlRegistered(typeOfControl));
        }
    }
}
