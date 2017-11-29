using System;
using System.Drawing;
using FormParser.ControlsDescriptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FormParserTests
{
    [TestClass]
    public class TextBoxSpecTests
    {
        private TextBoxSpec _textBoxSpec;

        [TestInitialize]
        public void Init()
        {
            _textBoxSpec = new TextBoxSpec();
        }

        [TestMethod]
        public void Test_TextBox_BackColorChanged_whenCanInputNumbers_IsFalse()
        {
            _textBoxSpec.CanInputNumbers = false;
            var control = _textBoxSpec.CreateControl();

            control.Text = "abc";
            Assert.AreEqual(Color.AliceBlue, control.BackColor);

            control.Text = "abc1";
            Assert.AreEqual(Color.Red, control.BackColor);
        }
    }
}
