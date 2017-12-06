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

namespace AviaSalesApp.View
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginController _controller;

        public LoginForm()
        {
            InitializeComponent();

            _controller = new LoginController(this);
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
