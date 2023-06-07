using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btncrear_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formddl v1 = new Formddl();
            v1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana2 v1 = new Ventana2();
            v1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
 }

