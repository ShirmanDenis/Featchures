using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviaSalesApp.View
{
    public partial class PassangerInfoView : UserControl
    {
        public string PassangerName => txBxName.Text;

        public string Surname => txBxSurname.Text;

        public string Patronymic => txBxPatronymic.Text;

        public int Passport => GetPassport();

        private int GetPassport()
        {
            if (int.TryParse(txBxPassport.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out int parsedInt))
                return parsedInt;

            return -1;
        }

        public PassangerInfoView()
        {
            InitializeComponent();
            passportValidatingError.Active = false;
            passportValidatingError.SetToolTip(txBxPassport, "series and passport number");
            passportValidatingError.UseAnimation = true;

        }

        private void txBxPassport_Validating(object sender, CancelEventArgs e)
        {
            var regex = new Regex(@"^\d{10}$");

            if (!regex.IsMatch(txBxPassport.Text) && !string.IsNullOrEmpty(txBxPassport.Text))
            {
                passportValidatingError.Active = true;
                passportValidatingError.Show("series and passport number", txBxPassport);
                e.Cancel = true;
            }
            else
            {
                passportValidatingError.Active = false;
            }

        }
    }
}
