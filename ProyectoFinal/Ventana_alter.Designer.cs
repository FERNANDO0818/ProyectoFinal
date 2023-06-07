namespace ProyectoFinal
{
    partial class Ventana_alter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_alter));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.combolenguaje = new System.Windows.Forms.ComboBox();
            this.comboaccion = new System.Windows.Forms.ComboBox();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcampo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtscript = new System.Windows.Forms.TextBox();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.saveFileArchivo = new System.Windows.Forms.SaveFileDialog();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(164, 120);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(185, 20);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // combolenguaje
            // 
            this.combolenguaje.FormattingEnabled = true;
            this.combolenguaje.Items.AddRange(new object[] {
            "Postgresql",
            "Oracle",
            "MySQL",
            "SQL Server"});
            this.combolenguaje.Location = new System.Drawing.Point(158, 47);
            this.combolenguaje.Name = "combolenguaje";
            this.combolenguaje.Size = new System.Drawing.Size(121, 21);
            this.combolenguaje.TabIndex = 2;
            this.combolenguaje.SelectedIndexChanged += new System.EventHandler(this.combolenguaje_SelectedIndexChanged);
            // 
            // comboaccion
            // 
            this.comboaccion.FormattingEnabled = true;
            this.comboaccion.Location = new System.Drawing.Point(397, 46);
            this.comboaccion.Name = "comboaccion";
            this.comboaccion.Size = new System.Drawing.Size(167, 21);
            this.comboaccion.TabIndex = 3;
            this.comboaccion.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Btnregresar
            // 
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(2, 2);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(29, 24);
            this.Btnregresar.TabIndex = 9;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccion Lenguaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Acción";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcampo
            // 
            this.txtcampo.Location = new System.Drawing.Point(406, 120);
            this.txtcampo.Multiline = true;
            this.txtcampo.Name = "txtcampo";
            this.txtcampo.Size = new System.Drawing.Size(158, 20);
            this.txtcampo.TabIndex = 13;
            this.txtcampo.TextChanged += new System.EventHandler(this.txtcampo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Campo";
            // 
            // txtscript
            // 
            this.txtscript.Location = new System.Drawing.Point(173, 162);
            this.txtscript.Multiline = true;
            this.txtscript.Name = "txtscript";
            this.txtscript.Size = new System.Drawing.Size(390, 156);
            this.txtscript.TabIndex = 14;
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(590, 168);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(64, 40);
            this.btngenerar.TabIndex = 15;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(594, 228);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(59, 36);
            this.btnguardar.TabIndex = 16;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(617, 119);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(121, 21);
            this.combotipo.TabIndex = 17;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(644, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tipo";
            // 
            // Ventana_alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.txtscript);
            this.Controls.Add(this.txtcampo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btnregresar);
            this.Controls.Add(this.comboaccion);
            this.Controls.Add(this.combolenguaje);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Ventana_alter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox combolenguaje;
        private System.Windows.Forms.ComboBox comboaccion;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcampo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtscript;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.SaveFileDialog saveFileArchivo;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.Label label5;
    }
}