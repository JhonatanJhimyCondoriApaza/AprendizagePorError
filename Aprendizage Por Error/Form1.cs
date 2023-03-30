using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aprendizage_Por_Error
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0, y = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JEJEJEJEJEJE me atrapaste");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            Random valor = new Random(DateTime.Now.Millisecond);
            button1.Location = new Point(valor.Next(this.ClientSize.Width - button1.ClientSize.Width - listView1.ClientSize.Width), valor.Next(this.ClientSize.Height - button1.ClientSize.Height));
        }
    }
}
