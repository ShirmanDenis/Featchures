using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FormParser.ControlsDescriptions;
using NLua;
namespace FormParser
{
    public partial class MainWindow : Form
    {
        private readonly Lua _lua = new Lua();
        private LuaFunction _luaFunction;
        public MainWindow()
        {
            InitializeComponent();
            buttonShow.Enabled = true;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = jsonFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                jsonTextBox.Text = jsonFileDialog1.SafeFileName;
                buttonShow.Enabled = true;
                luaButtonOpen.Enabled = true;
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            var filePath = "testForm1.json";

            var json = File.ReadAllText(filePath);

            var parser = new FormParser();
            parser.RegisterControlSpec("Button", () => new ButtonSpec());
            parser.RegisterControlSpec("TextBox", () => new TextBoxSpec());
            parser.RegisterControlSpec("Label", () => new LabelSpec());
            parser.RegisterControlSpec("Form", () => new FormSpec());

            var control = parser.ParseFromJson(json);

            control.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = luaFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                jsonTextBox.Text = luaFileDialog1.SafeFileName;
                _luaFunction = _lua.LoadFile(luaFileDialog1.FileName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_luaFunction == null)
            {
                MessageBox.Show("The lua function is not loaded");
                return;
            }

            _luaFunction.Call();
        }
    }
}
