using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Formddl : Form
    {
        public Formddl()
        {
            InitializeComponent();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu v2 = new Menu();
            v2.Show();
        }

        private void btnbd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana1 v2 = new Ventana1();
            v2.Show();

        }

        private void btntabla_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventanadml v2 = new Ventanadml();
            v2.Show();
        }

        private void bntalter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana_alter v2 = new Ventana_alter();
            v2.Show();

        }
    }
}
