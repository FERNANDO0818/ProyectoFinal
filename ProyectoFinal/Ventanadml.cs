using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ventanadml : Form
    {
        private string cbtipo;
        private string nombre;
        private string campo;
        private string cblenguaje;
        private string resultado;
        private string generar;
        private string acumulador;



        public Ventanadml()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            List<string> posgtrt = new List<string>();

            posgtrt.Add("int");
            posgtrt.Add("char");
            posgtrt.Add("date");
            posgtrt.Add("time");
            posgtrt.Add("bool");
            posgtrt.Add("char(n)");
            posgtrt.Add("varchar(n)");
            posgtrt.Add("float4/8");
            posgtrt.Add("float8");
            posgtrt.Add("int2");
            posgtrt.Add("int4");
            posgtrt.Add("int4");
            posgtrt.Add("int4");
            posgtrt.Add("money");
            posgtrt.Add("timespan");
            posgtrt.Add("timestamp");

            List<string> mysql = new List<string>();
            mysql.Add("INTEGER");
            mysql.Add("DECIMAL");
            mysql.Add("CHAR");
            mysql.Add("VARCHAR");
            mysql.Add("TINYINT");
            mysql.Add("SMALLINT");
            mysql.Add("MEDIUMINT");
            mysql.Add("BIGINT");
            mysql.Add("NUMERIC");
            mysql.Add("FLOAT");
            mysql.Add("DOUBLE");
            mysql.Add("CHAR");
            mysql.Add("DATE");
            mysql.Add("TIME");
            mysql.Add("BINARY");
            mysql.Add("VARBINARY");
            mysql.Add("TINYBLOB");
            mysql.Add("TINYTEXT");
            mysql.Add("BLOB");
            mysql.Add("TEXT");
            mysql.Add("MEDIUMBLOB");
            mysql.Add("MEDIUMTEXT");
            mysql.Add("LONGBLOB");
            mysql.Add("LONGTEX");
            mysql.Add("ENUM");
            mysql.Add("SET");
            mysql.Add("DATETIME");
            mysql.Add("TIMESTAMP");


            List<string> oracle = new List<string>();
            oracle.Add("Byte[]");
            oracle.Add("String");
            oracle.Add("DateTime");
            oracle.Add("Decimal");
            oracle.Add("Int32");
            oracle.Add("TimeSpan");
            oracle.Add("Byte[]");
            oracle.Add("Number");



            List<string> sqlserver = new List<string>();

            sqlserver.Add("char (n)");
            sqlserver.Add("varchar (n)");
            sqlserver.Add("varchar (max)");
            sqlserver.Add("text");
            sqlserver.Add("nchar");
            sqlserver.Add("nvarchar");
            sqlserver.Add("nvarchar (max)");
            sqlserver.Add("ntext");
            sqlserver.Add("binary (n)");
            sqlserver.Add("varbinary");
            sqlserver.Add("varbinary (max)");
            sqlserver.Add("image");
            sqlserver.Add("bit");
            sqlserver.Add("tinyint");
            sqlserver.Add("smallint");
            sqlserver.Add("int");
            sqlserver.Add("bigint");
            sqlserver.Add("decimal (p, s)");
            sqlserver.Add("numeric (p, s)");
            sqlserver.Add("smallmoney");
            sqlserver.Add("money");
            sqlserver.Add("float (n)");
            sqlserver.Add("real");
            sqlserver.Add("datetime");
            sqlserver.Add("datetime2");
            sqlserver.Add("smalldatetime");
            sqlserver.Add("date");
            sqlserver.Add("time");
            sqlserver.Add("datetimeoffset");
            sqlserver.Add("timestamp");
            sqlserver.Add("sql_variant");
            sqlserver.Add("uniqueidentifier");
            sqlserver.Add("xml");
            sqlserver.Add("cursor");
            sqlserver.Add("table");


            if (combolenguaje.Text == "Postgresql")
            {

                combotipo.DataSource = posgtrt;
            }
            else if (combolenguaje.Text == "MySQL")
            {

                combotipo.DataSource = mysql;
            }
            else if (combolenguaje.Text == "Oracle")
            {

                combotipo.DataSource = oracle;
            }
            else if (combolenguaje.Text == "SQL Server")
            {

                combotipo.DataSource = sqlserver;
            }

            cblenguaje = combolenguaje.Text;


        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formddl v2 = new Formddl();
            v2.Show();
        }

        private void Cbntipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtipo = combotipo.Text;

        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            switch (cblenguaje)
            {
                case "Postgresql":

                    acumulador = txtscript.Text;
                    if (acumulador == "")
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "\r\n";
                        Txtcampo.Text = "";


                    }
                    else
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "," + "\r\n";
                        Txtcampo.Text = "";
                    }



                    break;

                case "Oracle":

                    acumulador = txtscript.Text;
                    if (acumulador == "")
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "\r\n";
                        Txtcampo.Text = "";


                    }
                    else
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "," + "\r\n";
                        Txtcampo.Text = "";
                    }
                    break;

                case "MySQL":

                    acumulador = txtscript.Text;
                    if (acumulador == "")
                    {
                        resultado = acumulador + campo + "  " + cbtipo +" NOT NULL," + "\r\n";
                        Txtcampo.Text = "";


                    }
                    else
                    {
                        resultado = acumulador + campo + "  " + cbtipo +" NOT NULL" + "," + "\r\n";
                        Txtcampo.Text = "";
                    }
                    break;

                case "SQL Server":

                    acumulador = txtscript.Text;
                    if (acumulador == "")
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "\r\n";
                        Txtcampo.Text = "";


                    }
                    else
                    {
                        resultado = acumulador + campo + "  " + cbtipo + "," + "\r\n";
                        Txtcampo.Text = "";
                    }


                    break;





            }
            txtscript.Text = resultado;

        }

        private void Ventanadml_Load(object sender, EventArgs e)
        {



        }

        private void Txttabla_TextChanged(object sender, EventArgs e)
        {
            nombre = Txttabla.Text;
        }

        private void Txtcampo_TextChanged(object sender, EventArgs e)
        {
            campo = Txtcampo.Text;
        }

        private void txtscript_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {



            switch (cblenguaje)
            {
                case "Postgresql":

                    generar = "CREATE TABLE " + nombre + " (" + "\r\n" + resultado + "\r\n);";
                    break;

                case "Oracle":

                    generar = "create table  " + nombre + " (" + "\r\n" + resultado + "\r\n);";
                    break;

                case "MySQL":

                    generar = "CREATE TABLE " + nombre + " (" + "\r\n" + resultado +"PRIMARY KEY ('" +nombre + "'));";
                    break;

                case "SQL Server":

                    generar = "CREATE TABLE " + nombre + " (" + "\r\n" + resultado + "\r\n);";


                    break;





            }
            txtgenerar.Text = generar;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            saveFileArchivo1.Filter = "ARCHIVO txt | *.txt";
            if (saveFileArchivo1.ShowDialog() == DialogResult.OK)

            {
                string rutaArchivo = saveFileArchivo1.FileName;
                string textocrear = txtgenerar.Text;
                StreamWriter textoArchivo = File.CreateText(rutaArchivo);

                textoArchivo.Write(textocrear);
                textoArchivo.Flush();
                textoArchivo.Close();


            }
            Txttabla.Text = "";
            combolenguaje.Text = "";
            Txtcampo.Text = "";
            combotipo.Text = "";
            txtscript.Text = "";
            txtgenerar.Text = "";
        }
    }



}


