using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PoluPoker.Properties;
using PoluPoker.Tools;
using PoluPoker.GameTable;
namespace PoluPoker
{
    public partial class Main : Form, INotifier
    {
        private readonly Settings _settings;
        private readonly List<GameTable.GameTable> _tables = new List<GameTable.GameTable>();
        private readonly Image _defaultCloseBtn =
            Resources.This_is_my_close_button_for_this_image__e08deb6b87983b314d88a24c09f4d13f;

        private readonly Image _defaulRollUpBtn = Resources.icons8_вычитание_96;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
            int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Main()
        {
            InitializeComponent();
            GameTablesPanel.BackColor = Color.FromArgb(206, 211, 219);
            FunctionalPanel.BackColor = Color.FromArgb(151, 152, 153);
            var path = AppDomain.CurrentDomain.BaseDirectory + "Settings.json";
            if (File.Exists(path))
            {
                try
                {
                    _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(path));
                }
                catch (Exception)
                {
                    MessageBox.Show("Накасяпорил с форматом настроек в файле, криворук!!!");
                    _settings = new Settings();
                    _settings.TableNames = new List<TableDesc>();
                    for (int i = 0; i < 7; i++)
                    {
                        _settings.TableNames.Add(new TableDesc()
                        {
                            Name = "Введи сам!",
                            Id = i
                        });
                    }
                }
            }
            else
            {
                _settings = new Settings();
            }
            ClosePanel.BackgroundImage = Helpers.SetImageOpacity(_defaultCloseBtn, 0.7f);
            HeaderPanel.MouseDown += Form1_MouseDown;
            for (int i = 0; i < _settings.TableNames.Count; i++)
            {
                _tables.Add(CreateTable(i));
            }
            _tables.ForEach(table => GameTablesPanel.Controls.Add(table));
        }

        private void ClosePanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClosePanel_MouseEnter(object sender, EventArgs e)
        {
            OnEnterMouse(ClosePanel, _defaultCloseBtn);
        }

        private void ClosePanel_MouseLeave(object sender, EventArgs e)
        {
            OnLeaveMouse(ClosePanel, _defaultCloseBtn);
        }
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTablesPanel.Controls.Add(CreateTable(_tables.Count));
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            OnEnterMouse(RollUpPanel, _defaulRollUpBtn);
        }

        private void OnEnterMouse(Panel panel, Image img)
        {
            panel.BackgroundImage.Dispose();
            panel.BackgroundImage = Helpers.SetImageOpacity(img, 1f);
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void OnLeaveMouse(Panel panel, Image img)
        {
            panel.BackgroundImage.Dispose();
            panel.BackgroundImage = Helpers.SetImageOpacity(img, 0.7f);
            panel.BorderStyle = BorderStyle.None;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            OnLeaveMouse(RollUpPanel, _defaulRollUpBtn);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = true;
            
            if (_settings.RollUpMode == RollUpMode.Tray)
            {
                this.Hide();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;

            this.Show();
        }

        private GameTable.GameTable CreateTable(int id)
        {
            var tdesc = _settings.TableNames.FirstOrDefault(desc => desc.Id == id);
            if (tdesc == null)
            {
                tdesc = new TableDesc()
                {
                    Name = "Введи сам!",
                    Id = id
                };
                _settings.TableNames.Add(tdesc);
                _settings.Update(tdesc.Id, tdesc.Name);
            }

            var t = new GameTable.GameTable(_settings, this)
            {
                Id = id,
                TableText = tdesc.Name,
                Size = new Size(240, 136),
                BackColor = Color.FromArgb(150, 66, 134, 244)
            };
            _tables.Add(t);
            return t;
        }

        public void Notify(string title, string text)
        {
            notifyIcon.ShowBalloonTip(500, title, text, ToolTipIcon.Info);
        }
    }
}
