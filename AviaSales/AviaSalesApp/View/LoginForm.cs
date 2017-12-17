using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviaSalesApp.Common;
using AviaSalesApp.Controllers;
using AppContext = AviaSalesApp.Common.AppContext;

namespace AviaSalesApp.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private readonly LoginController _controller;
        private readonly AppContext _context;

        public new IAviaSalesView Parent { get; set; } = null;
        public IControlFactory Factory => WinFormsControlFactory.Instance;

        public AppContext Context { get; }

        public LoginForm()
        {
            InitializeComponent();
            SetRoles(Enum.GetNames(typeof(AppRoles)));
            cmBxRoles.SelectedIndex = 1;
            _controller = new LoginController(this);
            _controller.LoggingValidated += _controller_LoggingValidated;

            Closing += LoginForm_Closing;
        }

        private void LoginForm_Closing(object sender, CancelEventArgs e)
        {
            _controller.Dispose();
        }

        private void _controller_LoggingValidated(bool success, string msg)
        {
            if (!success)
            {
                MessageBox.Show(msg);
            }
        }

        public event EventHandler Logged
        {
            add => buttonLogin.Click += value;
            remove => buttonLogin.Click -= value;
        }

        public event EventHandler RoleSelected
        {
            add => cmBxRoles.SelectedValueChanged += value;
            remove => cmBxRoles.SelectedValueChanged -= value;
        }

        public AppRoles Role
        {
            get => (AppRoles) Enum.Parse(typeof(AppRoles), cmBxRoles.SelectedItem.ToString());
            set => cmBxRoles.SelectedItem = value;
        }

        public string Password
        {
            get => txBxPassword.Text;
            set => txBxPassword.Text = value;
        }

        public bool PasswordEnabled
        {
            get => txBxPassword.Enabled;
            set => txBxPassword.Enabled = value;
        }

        public void SetRoles(IEnumerable<string> roles)
        {
            cmBxRoles.Items.AddRange(roles.Select(i => (object)i).ToArray());
        }
    }
}
