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
        private readonly FormParser _parser = new FormParser();
        private readonly Lua _lua = new Lua();
        private LuaFunction _luaFunction;
        
        public MainWindow()
        {
            InitializeComponent();

            var directory = Directory.GetCurrentDirectory();

            _lua.LoadCLRPackage();
            jsonFileDialog1.InitialDirectory = directory;
            luaFileDialog1.InitialDirectory = directory;

            _parser.RegisterControlSpec("Button", () => new ButtonSpec());
            _parser.RegisterControlSpec("TextBox", () => new TextBoxSpec());
            _parser.RegisterControlSpec("Label", () => new LabelSpec());
            _parser.RegisterControlSpec("Form", () => new FormSpec());
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            var dialogResult = jsonFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                jsonTextBox.Text = jsonFileDialog1.SafeFileName;
                buttonExecute.Enabled = true;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (_lua == null)
            {
                MessageBox.Show("The lua is not loaded");
                return;
            }

            var json = File.ReadAllText(jsonFileDialog1.FileName);

            Control control;
            try
            {
                control = _parser.ParseFromJson(json, _lua);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            control.Show();
        }

        private void luaButtonOpen_Click(object sender, EventArgs e)
        {
            var dialogResult = luaFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                luaTextBox.Text = luaFileDialog1.SafeFileName;
                _lua.DoFile(luaFileDialog1.FileName);
                openFileButton.Enabled = true;
            }
        }
    }
}
