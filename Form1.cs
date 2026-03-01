using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labyrinth
{
    public partial class Labyrinth : Form
    {
        public Labyrinth()
        {
            InitializeComponent();
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Давай по-новой!");
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y +60);
        }

        private void Labyrinth_Load(object sender, EventArgs e)
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Умница! Так держать!");
        }
    }
}
