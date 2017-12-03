using System;
using System.IO;
using FormParser.ControlsDescriptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormParser;
using NLua;

namespace FormParserTests
{
    [TestClass]
    public class FormParserUnitTest
    {
        private FormParser.FormParser _formParser;
        private Lua _lua;

        [TestInitialize]
        public void InitTestMethod()
        {
            _formParser = new FormParser.FormParser();
            _lua = new Lua();

            _formParser.RegisterControlSpec("Button", () => new ButtonSpec());
            _formParser.RegisterControlSpec("TextBox", () => new TextBoxSpec());
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

            var form = _formParser.ParseFromJson(json, _lua);

            Assert.IsNotNull(form);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMissingJsonProperty()
        {
            var json = "     {\n      \"ControlType\": \"Label\",\n      " +
                       "\"Text\": \"label2\",\n      " +
                       "\"Name\": \"label2\",\n      " +
                       "\"ClientSize\": \"35, 13\",\n      " +
                       "\"nothing\": \"149, 245\"\n    }";

            _formParser.ParseFromJson(json, _lua);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestInvalidArgumentProperty()
        {
            var json = "     {\n      \"ControlType\": \"Label\",\n      " +
                       "\"Text\": \"label2\",\n      " +
                       "\"Name\": \"label2\",\n      " +
                       "\"ClientSize\": \"-5, 13\",\n      " +
                       "\"Location\": \"149, 245\"\n    }";

            _formParser.ParseFromJson(json, _lua).Show();
        }
    }
}
