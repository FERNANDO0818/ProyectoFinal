namespace ProyectoFinal
{
    partial class Ventanadml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventanadml));
            this.label1 = new System.Windows.Forms.Label();
            this.Txttabla = new System.Windows.Forms.TextBox();
            this.combolenguaje = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtcampo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.txtscript = new System.Windows.Forms.TextBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.txtgenerar = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.saveFileArchivo1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Tabla";
            // 
            // Txttabla
            // 
            this.Txttabla.Location = new System.Drawing.Point(198, 35);
            this.Txttabla.Multiline = true;
            this.Txttabla.Name = "Txttabla";
            this.Txttabla.Size = new System.Drawing.Size(100, 20);
            this.Txttabla.TabIndex = 1;
            this.Txttabla.TextChanged += new System.EventHandler(this.Txttabla_TextChanged);
            // 
            // combolenguaje
            // 
            this.combolenguaje.FormattingEnabled = true;
            this.combolenguaje.Items.AddRange(new object[] {
            "Postgresql",
            "Oracle",
            "MySQL",
            "SQL Server"});
            this.combolenguaje.Location = new System.Drawing.Point(595, 34);
            this.combolenguaje.Name = "combolenguaje";
            this.combolenguaje.Size = new System.Drawing.Size(121, 21);
            this.combolenguaje.TabIndex = 2;
            this.combolenguaje.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione Lenguaje";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Btnregresar
            // 
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(34, 414);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(29, 24);
            this.Btnregresar.TabIndex = 8;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Campo";
            // 
            // Txtcampo
            // 
            this.Txtcampo.Location = new System.Drawing.Point(46, 130);
            this.Txtcampo.Name = "Txtcampo";
            this.Txtcampo.Size = new System.Drawing.Size(133, 20);
            this.Txtcampo.TabIndex = 10;
            this.Txtcampo.TextChanged += new System.EventHandler(this.Txtcampo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo";
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(236, 129);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(121, 21);
            this.combotipo.TabIndex = 12;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.Cbntipo_SelectedIndexChanged);
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(403, 125);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(58, 25);
            this.Btnagregar.TabIndex = 13;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // txtscript
            // 
            this.txtscript.Location = new System.Drawing.Point(46, 170);
            this.txtscript.Multiline = true;
            this.txtscript.Name = "txtscript";
            this.txtscript.Size = new System.Drawing.Size(311, 106);
            this.txtscript.TabIndex = 14;
            this.txtscript.TextChanged += new System.EventHandler(this.txtscript_TextChanged);
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(403, 175);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(57, 23);
            this.btngenerar.TabIndex = 15;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // txtgenerar
            // 
            this.txtgenerar.Location = new System.Drawing.Point(513, 129);
            this.txtgenerar.Multiline = true;
            this.txtgenerar.Name = "txtgenerar";
            this.txtgenerar.Size = new System.Drawing.Size(237, 146);
            this.txtgenerar.TabIndex = 16;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(403, 210);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(57, 35);
            this.btnguardar.TabIndex = 17;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Ventanadml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtgenerar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtscript);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtcampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btnregresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combolenguaje);
            this.Controls.Add(this.Txttabla);
            this.Controls.Add(this.label1);
            this.Name = "Ventanadml";
            this.Text = "Ventanadml";
            this.Load += new System.EventHandler(this.Ventanadml_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txttabla;
        private System.Windows.Forms.ComboBox combolenguaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtcampo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.TextBox txtscript;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.TextBox txtgenerar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.SaveFileDialog saveFileArchivo1;
    }
}