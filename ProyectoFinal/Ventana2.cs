using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ventana2 : Form

    {
        private string cblenguaje;
        private string cbtipo;
        private string cbaccion;
        private string nombretabla;
        private string campo;
        private string nombrecampo;
        private string generar;
        private string resultado1;
        private string resultado2;
        private string acumulador1;
        private string acumulador2;
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Btnregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu v2 = new Menu();
            v2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtvalues_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //valor = txtvalor.Text;
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void combolenguaje_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtnombretabla_TextChanged(object sender, EventArgs e)
        {
            nombretabla = txtnombretabla.Text;
        }

        private void comboaccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbaccion = comboaccion.Text;
        }

        private void txtcampo_TextChanged(object sender, EventArgs e)
        {
            campo = txtcampo.Text;
        }

        private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbtipo = combotipo.Text;
        }

        private void txtnombrecampo_TextChanged(object sender, EventArgs e)
        {
            nombrecampo = txtnombrecampo.Text;
        }

        private void btncampos_Click(object sender, EventArgs e)
        {
            switch (cblenguaje)
            {
                case "Postgresql":
                    switch (cbaccion)
                    {
                        case "INSERT":
                            acumulador1 = txtcampos.Text;

                            if (acumulador1 == "")
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "\r\n";

                            }
                            else
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "," + "\r\n";
                            }
                            txtcampo.Text = "";
                            break;
                        case "UPDATE":
                            acumulador1 = txtcampos.Text;

                            if (acumulador1 == "")
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "\r\n";
                            }
                            else
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "," + "\r\n";
                            }
                            txtcampo.Text = "";

                            break;
                        case "DELETE":
                            acumulador1 = txtcampos.Text;

                            if (acumulador1 == "")
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "\r\n";
                            }
                            else
                            {
                                resultado1 = acumulador1 + campo + " " + cbtipo + "," + "\r\n";
                            }
                            txtcampo.Text = "";

                            break;


                    }

                    break;
            }
            txtcampos.Text = resultado1;

        }

        private void btnvalores_Click(object sender, EventArgs e)
        {
            switch (cblenguaje)
            {
                case "Postgresql":

                    acumulador2 = txtvalues.Text;
                    if (acumulador2 == "")
                    {
                        resultado2 = acumulador2 + nombrecampo + "\r\n";



                    }
                    else
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + "," + "\r\n";
                    }
                    txtnombrecampo.Text = "";



                    break;

                case "Oracle":

                    acumulador2 = txtscript.Text;
                    if (acumulador2 == "")
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + "\r\n";



                    }
                    else
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + "," + "\r\n";
                    }
                    txtnombrecampo.Text = "";
                    break;

                case "MySQL":

                    acumulador2 = txtscript.Text;
                    if (acumulador2 == "")
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + " NOT NULL," + "\r\n";



                    }
                    else
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + " NOT NULL" + "," + "\r\n";
                    }
                    txtnombrecampo.Text = "";
                    break;

                case "SQL Server":

                    acumulador2 = txtscript.Text;
                    if (acumulador2 == "")
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + "\r\n";



                    }
                    else
                    {
                        resultado2 = acumulador2 + nombrecampo + " " + "," + "\r\n";
                    }
                    txtnombrecampo.Text = "";

                    break;





            }
            txtvalues.Text = resultado2;
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            switch (cblenguaje)
            {
                case "Postgresql":
                    switch (cbaccion)
                    {
                        case "INSERT":
                            generar = "INSERT INTO " + nombretabla + " (" + resultado1 + ")" + "\r\n" + "VALUES(" + resultado2 + ");";
                            break;

                        case "UPDATE":
                            
                            generar = "UPDATE " + nombretabla + "\r\n" + " SET " + resultado1 + " = " + resultado2+"\r\n" + "WHERE condition" + ";";

                            break;
                    }


                    break;

                case "Oracle":

                    //generar = "create table  " + nombre + " (" + "\r\n" + resultado + "\r\n);";
                    break;

                case "MySQL":

                    //generar = "CREATE TABLE " + nombre + " (" + "\r\n" + resultado + "PRIMARY KEY ('" + nombre + "'));";
                    break;

                case "SQL Server":

                    //generar = "CREATE TABLE " + nombre + " (" + "\r\n" + resultado + "\r\n);";


                    break;





            }
            txtscript.Text = generar;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            saveFileArchivo.Filter = "ARCHIVO txt | *.txt";
            if (saveFileArchivo.ShowDialog() == DialogResult.OK)

            {
                string rutaArchivo = saveFileArchivo.FileName;
                string textocrear = txtscript.Text;
                StreamWriter textoArchivo = File.CreateText(rutaArchivo);

                textoArchivo.Write(textocrear);
                textoArchivo.Flush();
                textoArchivo.Close();


            }
            txtnombretabla.Text = "";
            combolenguaje.Text = "";
            comboaccion.Text = "";
            txtcampo.Text = "";
            combotipo.Text = "";
            txtnombrecampo.Text = "";
            txtcampos.Text = "";
            txtvalues.Text = "";
            txtscript.Text = "";
        }
    }
}
