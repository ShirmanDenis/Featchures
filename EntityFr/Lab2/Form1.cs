using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        readonly TourBaseContext _context = new TourBaseContext();

        public Form1()
        {
            InitializeComponent();

            _context.Tourist.Load();
            _context.Base.Load();

            Closing += Form1_Closing;

            dataViewBases.DataSource = _context.Base.Local.ToBindingList();
            dataViewBases.Columns["Tourist"].Visible = false;

        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            _context.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something goes wrong, try again later ;)");
                return;
            }
            

            dataViewBases.Invalidate();
            dataViewTourist.Invalidate();
        }

        private void bDeleteTourist_Click(object sender, EventArgs e)
        {
            var row = dataViewTourist.CurrentRow;
            if (row == null) return;

            var id = int.Parse(row.Cells[0].Value.ToString());

            var foundTourist = _context.Tourist.Find(id);

            if (foundTourist != null)
            {
                _context.Tourist.Remove(foundTourist);
            }
            dataViewBases_CellClick(this, null);
        }

        private void bDeleteBase_Click(object sender, EventArgs e)
        {
            var row = dataViewBases.CurrentRow;
            if (row == null) return;

            var id = int.Parse(row.Cells[0].Value.ToString());

            var foundBase = _context.Base.Find(id);

            if (foundBase != null)
            {
                _context.Base.Remove(foundBase);
            }
        }

        private void dataViewBases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var curRow = dataViewBases.CurrentRow;
            if (curRow == null) return;

            var indexOfBase = int.Parse(curRow.Cells[0].Value.ToString());
            var curBase = _context.Base.Find(indexOfBase);

            if (curBase == null) return;

            _context.Entry(curBase).Collection("Tourist").Load();

            dataViewTourist.DataSource = curBase.Tourist.ToList();
            dataViewTourist.Columns["Base"].Visible = false;
            dataViewTourist.Invalidate();
        }

        private void bFind_Click(object sender, EventArgs e)
        {
            var tName = touristNameTextBox.Text;
            var bName = baseNameTextBox.Text;
            var foundT = false;

            if (string.IsNullOrEmpty(tName) && string.IsNullOrEmpty(bName)) return;

            var tBase = _context.Base.Local.FirstOrDefault( b => b.Name == bName);

            if (tBase == null)
            {
                MessageBox.Show(string.Format("Found = {0}", foundT));
                return;
            }

            var tourist = from t in _context.Tourist
                          where t.FullName == tName && t.Base_ID == tBase.Base_ID
                          select t;
            foundT = tourist.First() != null;
            MessageBox.Show(string.Format("Found = {0}", foundT));
        }
    }
}
