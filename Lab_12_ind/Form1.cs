using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Индивидуальное
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string zoo;
            double x = e.X;
            double y = e.Y;
            double z = Convert.ToDouble(textBox2.Text);
            double as_9 = Convert.ToDouble(textBox1.Text);
            zoo = (z * Math.Cos(y) + Math.Sqrt(Math.Pow(Math.E, 7)) - Math.Abs(x + Math.Cos(as_9 + y))).ToString();
            Text = string.Format("Координаты: {0}", zoo);
        }
    }
}