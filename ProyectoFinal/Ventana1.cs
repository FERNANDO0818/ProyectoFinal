using System;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ventana1 : Form
    {
        private string nombre;
        private string tipo;
        private string resultado;

        public Ventana1()
        {

            InitializeComponent();
        }

        private void Txtnombretb_TextChanged(object sender, EventArgs e)
        {
            nombre = Txtnombretb.Text;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Btngenerar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "Postgresql":

                    resultado = "create database " + nombre + ";";
                    //Txtscript.Text = "create database " + nombre + ";";
                    break;

                case "Oracle":

                    resultado = "CREATE DATABASE " + nombre + ";";
                    //Txtscript.Text = "create database " + nombre + ";";
                    break;

                case "MySQL":

                    resultado = "CREATE DATABASE " + nombre + ";";
                    //Txtscript.Text = "CREATE DATABASE " + nombre + ";";
                    break;

                case "SQL Server":

                    resultado = "CREATE DATABASE " + nombre + ";" + " \r\nUSE " + nombre;
                    // Txtscript.Text = "CREATE DATABASE " + nombre + ";\n" + "\n USE \n" + nombre;


                    break;


            }
            Txtscript.Text = resultado;




        }

        private void Cbbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = Cbbd.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileArchivo.Filter = "ARCHIVO txt | *.txt";
            if (saveFileArchivo.ShowDialog() == DialogResult.OK)

            {
                string rutaArchivo = saveFileArchivo.FileName;
                string textocrear = Txtscript.Text;
                StreamWriter textoArchivo = File.CreateText(rutaArchivo);

                textoArchivo.Write(textocrear);
                textoArchivo.Flush();
                textoArchivo.Close();


            }
            Txtnombretb.Text = "";
            Cbbd.Text = "";
            Txtscript.Text = "";



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Formddl v2 = new Formddl();
            v2.Show();
        }

        private void Ventana1_Load(object sender, EventArgs e)
        {

        }
    }
}
