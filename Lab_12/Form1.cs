using System.Windows.Forms;

namespace Lab_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Для вывода информации в заголовок окна
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);

            // Для вывода суммы координат в TextBox1
            textBox1.Text = (e.X + e.Y).ToString();
        }

    }
}
