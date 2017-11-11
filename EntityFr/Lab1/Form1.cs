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

namespace Lab1
{
    public partial class Form1 : Form
    {
        private readonly TouristDbContext _touristDbContext = new TouristDbContext();
        private long id_count = 0;
        public Form1()
        {
            InitializeComponent();

            Closing += Form1_Closing;

            _touristDbContext.Tourist.Load();

            dataView.DataSource = _touristDbContext.Tourist.Local.ToBindingList();
            if (_touristDbContext.Tourist.Any())
                id_count = _touristDbContext.Tourist.Local.Last().Tourist_ID;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            _touristDbContext.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newTourist = _touristDbContext.Tourist.Create();
            newTourist.Tourist_ID = ++id_count;
            _touristDbContext.Tourist.Add(newTourist);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _touristDbContext.SaveChanges();

            dataView.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var row = dataView.CurrentRow;
            if (row == null) return;
            
            var id = int.Parse(row.Cells[0].Value.ToString());

            var foundTourist = _touristDbContext.Tourist.Find(id);

            if (foundTourist != null)
            {
                _touristDbContext.Tourist.Remove(foundTourist);
            }

        }
    }
}
