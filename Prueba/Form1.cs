using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - button2.Width);
            int y = r.Next(0, this.Height - button2.Height);
            button2.Location = new Point(x, y);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (button2.Location == button1.Location || button2.Location == label1.Location)
            {
                MoverBoton();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sgte = new Form2();
            this.Hide();
            sgte.Show();
        }
    }
}
