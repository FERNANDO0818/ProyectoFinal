using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Ventana_alter : Form
    {
        private string cbaccion;
        private string nombre;
        private string campo;
        private string cblenguaje;
        private string acumulador;
        private string resultado;
        private string cbtipo;

        public Ventana_alter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbaccion = comboaccion.Text;

            switch (cblenguaje)
            {
                case "Postgresql":
                    switch (cbaccion)
                    {
                        case "DROP DATABASE":

                            txtcampo.Enabled = false;

                            break;

                        case "DROP TABLE":

                            txtcampo.Enabled = false;
                            break;

                        case "ALTER TABLE DROP COLUMN":

                            txtcampo.Enabled = true;

                            break;

                        case "ALTER TABLE RENAME TO":

                            txtcampo.Enabled = true;
                            break;

                    }
                    break;

                case "Oracle":
                    switch (cbaccion)
                    {
                        case "DROP A COLUMN":

                            combotipo.Enabled = false;

                            break;

                        case "DROP DATABASE":

                            combotipo.Enabled = false;
                            txtcampo.Enabled = false;
                            break;

                        case "ALTER TABLE":

                            txtcampo.Enabled = true;
                            combotipo.Enabled = true;
                            break;
                    }
                    break;

                case "MySQL":
                    switch (cbaccion)
                    {
                        case "DROP DATABASE":
                            txtcampo.Enabled = false;
                            combotipo.Enabled = false;
                            break;
                        case "ALTER TABLE":
                            combotipo.Enabled = !false;
                            break;
                        case "DROP A COLUMN":
                            combotipo.Enabled = false;
                            break;

                    }
                    break;

                case "SQL Server":
                    switch (cbaccion)
                    {
                        case "ALTER TABLE DROP COLUMN":
                            combotipo.Enabled=false;
                            txtcampo.Enabled=true;
                            break;
                        case "ALTER TABLE COLUMN":
                            txtcampo.Enabled=true;
                            combotipo.Enabled=true;
                            break;

                        case "ALTER TABLE ADD":
                            txtcampo.Enabled=true;
                            combotipo.Enabled=true;
                            break;
                        
                        case "DROP DATABASE":
                            txtcampo.Enabled=false;
                            combotipo.Enabled=false;
                            break;

                    }
                       break;



            }



        }

            private void combolenguaje_SelectedIndexChanged(object sender, EventArgs e)
            {
                List<string> posgtrt = new List<string>();

                posgtrt.Add("ALTER TABLE DROP COLUMN");
                posgtrt.Add("ALTER TABLE RENAME TO");
                posgtrt.Add("DROP TABLE");
                posgtrt.Add("DROP DATABASE");

                List<string> mysql = new List<string>();

                mysql.Add("ALTER TABLE");
                mysql.Add("DROP DATABASE");
                mysql.Add("DROP A COLUMN");


                List<string> oracle = new List<string>();

                oracle.Add("ALTER TABLE");
                oracle.Add("DROP A COLUMN");
                oracle.Add("DROP DATABASE");

                List<string> sqlserver = new List<string>();

                sqlserver.Add("ALTER TABLE COLUMN");
                sqlserver.Add("ALTER TABLE ADD");
                sqlserver.Add("ALTER TABLE DROP COLUMN");
                 sqlserver.Add("DROP DATABASE");



                //----------------------------------------------------------

                List<string> posgtrt2 = new List<string>();

                posgtrt2.Add("bool");
                posgtrt2.Add("char(n)");
                posgtrt2.Add("date");
                posgtrt2.Add("float4/8");
                posgtrt2.Add("float8");
                posgtrt2.Add("int2");
                posgtrt2.Add("int4");
                posgtrt2.Add("int4");
                posgtrt2.Add("int4");
                posgtrt2.Add("money");
                posgtrt2.Add("time");
                posgtrt2.Add("timespan");
                posgtrt2.Add("timestamp");
                posgtrt2.Add("varchar(n)");
                posgtrt2.Add("int");
                posgtrt2.Add("char");

                List<string> mysql2 = new List<string>();
                mysql2.Add("TINYINT");
                mysql2.Add("SMALLINT");
                mysql2.Add("MEDIUMINT");
                mysql2.Add("INTEGER");
                mysql2.Add("BIGINT");
                mysql2.Add("DECIMAL");
                mysql2.Add("NUMERIC");
                mysql2.Add("FLOAT");
                mysql2.Add("DOUBLE");
                mysql2.Add("CHAR");
                mysql2.Add("VARCHAR");
                mysql2.Add("BINARY");
                mysql2.Add("VARBINARY");
                mysql2.Add("TINYBLOB");
                mysql2.Add("TINYTEXT");
                mysql2.Add("BLOB");
                mysql2.Add("TEXT");
                mysql2.Add("MEDIUMBLOB");
                mysql2.Add("MEDIUMTEXT");
                mysql2.Add("LONGBLOB");
                mysql2.Add("LONGTEX");
                mysql2.Add("ENUM");
                mysql2.Add("SET");
                mysql2.Add("DATE");
                mysql2.Add("TIME");
                mysql2.Add("DATETIME");
                mysql2.Add("TIMESTAMP");

                List<string> oracle2 = new List<string>();
                oracle2.Add("Byte[]");
                oracle2.Add("Byte[]");
                oracle2.Add("String");
                oracle2.Add("String");
                oracle2.Add("DateTime");
                oracle2.Add("Decimal");
                oracle2.Add("Decimal");
                oracle2.Add("Int32");
                oracle2.Add("TimeSpan");
                oracle2.Add("String");
                oracle2.Add("Byte[]");
                oracle2.Add("String");
                oracle2.Add("String");
                oracle2.Add("Decimal");
                oracle2.Add("String");
                oracle2.Add("Byte[]");
                oracle2.Add("String");
                oracle2.Add("DateTime");
                oracle2.Add("DateTime");
                oracle2.Add("DateTime");
                oracle2.Add("Number");
                oracle2.Add("String");



                List<string> sqlserver2 = new List<string>();

                sqlserver2.Add("char (n)");
                sqlserver2.Add("varchar (n)");
                sqlserver2.Add("varchar (max)");
                sqlserver2.Add("text");
                sqlserver2.Add("nchar");
                sqlserver2.Add("nvarchar");
                sqlserver2.Add("nvarchar (max)");
                sqlserver2.Add("ntext");
                sqlserver2.Add("binary (n)");
                sqlserver2.Add("varbinary");
                sqlserver2.Add("varbinary (max)");
                sqlserver2.Add("image");
                sqlserver2.Add("bit");
                sqlserver2.Add("tinyint");
                sqlserver2.Add("smallint");
                sqlserver2.Add("int");
                sqlserver2.Add("bigint");
                sqlserver2.Add("decimal (p, s)");
                sqlserver2.Add("numeric (p, s)");
                sqlserver2.Add("smallmoney");
                sqlserver2.Add("money");
                sqlserver2.Add("float (n)");
                sqlserver2.Add("real");
                sqlserver2.Add("datetime");
                sqlserver2.Add("datetime2");
                sqlserver2.Add("smalldatetime");
                sqlserver2.Add("date");
                sqlserver2.Add("time");
                sqlserver2.Add("datetimeoffset");
                sqlserver2.Add("timestamp");
                sqlserver2.Add("sql_variant");
                sqlserver2.Add("uniqueidentifier");
                sqlserver2.Add("xml");
                sqlserver2.Add("cursor");
                sqlserver2.Add("table");


                if (combolenguaje.Text == "Postgresql")
                {

                    comboaccion.DataSource = posgtrt;
                    combotipo.DataSource = posgtrt2;
                }
                else if (combolenguaje.Text == "MySQL")
                {

                    comboaccion.DataSource = mysql;
                    combotipo.DataSource = mysql2;
                }
                else if (combolenguaje.Text == "Oracle")
                {

                    comboaccion.DataSource = oracle;
                    combotipo.DataSource = oracle2;
                }
                else if (combolenguaje.Text == "SQL Server")
                {

                    comboaccion.DataSource = sqlserver;
                    combotipo.DataSource = sqlserver2;
                }

                cblenguaje = combolenguaje.Text;
            }

            private void Btnregresar_Click(object sender, EventArgs e)
            {
                this.Hide();
                Formddl v2 = new Formddl();
                v2.Show();
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void btngenerar_Click(object sender, EventArgs e)
            {
                switch (cblenguaje)
                {
                    case "Postgresql":

                        switch (cbaccion)
                        {

                            case "ALTER TABLE DROP COLUMN":

                                resultado = "ALTER TABLE " + nombre + "\r\n" + "DROP COLUMN " + campo + ";";

                                break;

                            case "DROP TABLE":

                                resultado = "DROP TABLE " + nombre + ";";

                                break;

                            case "DROP DATABASE":


                                resultado = "DROP DATABASE " + nombre + ";";

                                break;

                        }

                        break;

                    case "Oracle":

                        switch (cbaccion)
                        {

                            case "ALTER TABLE":

                                resultado = "ALTER TABLE " + nombre + "\r\n" + "ADD " + campo + " " + cbtipo + ";";

                                break;

                            case "DROP A COLUMN":

                                resultado = "ALTER TABLE " + nombre + " DROP COLUMN " + campo + ";";

                                break;

                            case "DROP DATABASE":


                                resultado = "shutdown immediate; " + "\r\n" + "startup mount exclusive restrict; " + "\r\n" + "DROP DATABASE " + nombre + ";";

                                break;

                        }
                        break;


                    case "MySQL":
                        switch (cbaccion)
                        {
                            case "DROP DATABASE":
                                resultado = "DROP DATABASE " + nombre + ";";
                                break;

                            case "ALTER TABLE":
                                resultado = "ALTER TABLE " + nombre + " RENAME " + campo + ";";
                                break;

                            case "DROP A COLUMN":
                                resultado = "ALTER TABLE " + nombre + " DROP COLUMN " + campo + ";";
                                break;


                        }

                        break;

                    case "SQL Server":
                        switch (cbaccion)
                        {
                            case "ALTER TABLE DROP COLUMN":

                                resultado = "ALTER TABLE " + nombre + "\r\n" + "DROP COLUMN " + campo + ";";

                                break;
                            case "ALTER TABLE COLUMN":
                                resultado = "ALTER TABLE " + nombre + "\r\n" + "ALTER COLUMN " + campo + ";";
                                break;

                            case "ALTER TABLE ADD":
                                resultado = "ALTER TABLE " + nombre + "\r\n" + "ADD " + campo + " " + cbtipo + ";";
                                break;
                            
                            case "DROP DATABASE":
                                resultado = "DROP DATABASE " + nombre + ";";
                                break;


                        }

                        break;





                }
                txtscript.Text = resultado;

            }

            private void txtnombre_TextChanged(object sender, EventArgs e)
            {
                nombre = txtnombre.Text;
            }

            private void txtcampo_TextChanged(object sender, EventArgs e)
            {
                campo = txtcampo.Text;
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
                combolenguaje.Text = "";
                comboaccion.Text = "";
                txtnombre.Text = "";
                txtcampo.Text = "";
                txtscript.Text = "";
                combotipo.Text = "";

                txtcampo.Enabled = true;
                combotipo.Enabled = true;
            }

            private void combotipo_SelectedIndexChanged(object sender, EventArgs e)
            {
                cbtipo = combotipo.Text;
            }
        }
    }
    