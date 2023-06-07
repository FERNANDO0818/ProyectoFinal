namespace ProyectoFinal
{
    partial class Ventana2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana2));
            this.Btnregresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombretabla = new System.Windows.Forms.TextBox();
            this.combolenguaje = new System.Windows.Forms.ComboBox();
            this.comboaccion = new System.Windows.Forms.ComboBox();
            this.txtcampos = new System.Windows.Forms.TextBox();
            this.txtvalues = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcampo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combotipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnombrecampo = new System.Windows.Forms.TextBox();
            this.txtscript = new System.Windows.Forms.TextBox();
            this.btncampos = new System.Windows.Forms.Button();
            this.btnvalores = new System.Windows.Forms.Button();
            this.btngenerar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.saveFileArchivo = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Btnregresar
            // 
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(4, 4);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(29, 24);
            this.Btnregresar.TabIndex = 10;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre de Tabla";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombretabla
            // 
            this.txtnombretabla.Location = new System.Drawing.Point(211, 33);
            this.txtnombretabla.Multiline = true;
            this.txtnombretabla.Name = "txtnombretabla";
            this.txtnombretabla.Size = new System.Drawing.Size(138, 20);
            this.txtnombretabla.TabIndex = 12;
            this.txtnombretabla.TextChanged += new System.EventHandler(this.txtnombretabla_TextChanged);
            // 
            // combolenguaje
            // 
            this.combolenguaje.FormattingEnabled = true;
            this.combolenguaje.Items.AddRange(new object[] {
            "Postgresql",
            "Oracle",
            "MySQL",
            "SQL Server"});
            this.combolenguaje.Location = new System.Drawing.Point(495, 32);
            this.combolenguaje.Name = "combolenguaje";
            this.combolenguaje.Size = new System.Drawing.Size(121, 21);
            this.combolenguaje.TabIndex = 13;
            this.combolenguaje.SelectedIndexChanged += new System.EventHandler(this.combolenguaje_SelectedIndexChanged);
            // 
            // comboaccion
            // 
            this.comboaccion.FormattingEnabled = true;
            this.comboaccion.Items.AddRange(new object[] {
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.comboaccion.Location = new System.Drawing.Point(647, 32);
            this.comboaccion.Name = "comboaccion";
            this.comboaccion.Size = new System.Drawing.Size(121, 21);
            this.comboaccion.TabIndex = 14;
            this.comboaccion.SelectedIndexChanged += new System.EventHandler(this.comboaccion_SelectedIndexChanged);
            // 
            // txtcampos
            // 
            this.txtcampos.Location = new System.Drawing.Point(28, 153);
            this.txtcampos.Multiline = true;
            this.txtcampos.Name = "txtcampos";
            this.txtcampos.Size = new System.Drawing.Size(281, 153);
            this.txtcampos.TabIndex = 16;
            // 
            // txtvalues
            // 
            this.txtvalues.Location = new System.Drawing.Point(417, 153);
            this.txtvalues.Multiline = true;
            this.txtvalues.Name = "txtvalues";
            this.txtvalues.Size = new System.Drawing.Size(280, 153);
            this.txtvalues.TabIndex = 17;
            this.txtvalues.TextChanged += new System.EventHandler(this.txtvalues_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tipo de DATA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Acción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Campo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtcampo
            // 
            this.txtcampo.Location = new System.Drawing.Point(28, 131);
            this.txtcampo.Name = "txtcampo";
            this.txtcampo.Size = new System.Drawing.Size(133, 20);
            this.txtcampo.TabIndex = 21;
            this.txtcampo.TextChanged += new System.EventHandler(this.txtcampo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tipo";
            // 
            // combotipo
            // 
            this.combotipo.FormattingEnabled = true;
            this.combotipo.Location = new System.Drawing.Point(187, 131);
            this.combotipo.Name = "combotipo";
            this.combotipo.Size = new System.Drawing.Size(121, 21);
            this.combotipo.TabIndex = 23;
            this.combotipo.SelectedIndexChanged += new System.EventHandler(this.combotipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre";
            // 
            // txtnombrecampo
            // 
            this.txtnombrecampo.Location = new System.Drawing.Point(417, 132);
            this.txtnombrecampo.Name = "txtnombrecampo";
            this.txtnombrecampo.Size = new System.Drawing.Size(133, 20);
            this.txtnombrecampo.TabIndex = 26;
            this.txtnombrecampo.TextChanged += new System.EventHandler(this.txtnombrecampo_TextChanged);
            // 
            // txtscript
            // 
            this.txtscript.Location = new System.Drawing.Point(270, 320);
            this.txtscript.Multiline = true;
            this.txtscript.Name = "txtscript";
            this.txtscript.Size = new System.Drawing.Size(197, 154);
            this.txtscript.TabIndex = 28;
            // 
            // btncampos
            // 
            this.btncampos.Location = new System.Drawing.Point(324, 122);
            this.btncampos.Name = "btncampos";
            this.btncampos.Size = new System.Drawing.Size(60, 39);
            this.btncampos.TabIndex = 29;
            this.btncampos.Text = "Agregar Campos";
            this.btncampos.UseVisualStyleBackColor = true;
            this.btncampos.Click += new System.EventHandler(this.btncampos_Click);
            // 
            // btnvalores
            // 
            this.btnvalores.Location = new System.Drawing.Point(571, 126);
            this.btnvalores.Name = "btnvalores";
            this.btnvalores.Size = new System.Drawing.Size(60, 29);
            this.btnvalores.TabIndex = 30;
            this.btnvalores.Text = "Agregar Valores";
            this.btnvalores.UseVisualStyleBackColor = true;
            this.btnvalores.Click += new System.EventHandler(this.btnvalores_Click);
            // 
            // btngenerar
            // 
            this.btngenerar.Location = new System.Drawing.Point(491, 320);
            this.btngenerar.Name = "btngenerar";
            this.btngenerar.Size = new System.Drawing.Size(75, 42);
            this.btngenerar.TabIndex = 31;
            this.btngenerar.Text = "Generar";
            this.btngenerar.UseVisualStyleBackColor = true;
            this.btngenerar.Click += new System.EventHandler(this.btngenerar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(491, 368);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 38);
            this.btnguardar.TabIndex = 32;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btngenerar);
            this.Controls.Add(this.btnvalores);
            this.Controls.Add(this.btncampos);
            this.Controls.Add(this.txtscript);
            this.Controls.Add(this.txtnombrecampo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combotipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcampo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalues);
            this.Controls.Add(this.txtcampos);
            this.Controls.Add(this.comboaccion);
            this.Controls.Add(this.combolenguaje);
            this.Controls.Add(this.txtnombretabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnregresar);
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            this.Load += new System.EventHandler(this.Ventana2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombretabla;
        private System.Windows.Forms.ComboBox combolenguaje;
        private System.Windows.Forms.ComboBox comboaccion;
        private System.Windows.Forms.TextBox txtcampos;
        private System.Windows.Forms.TextBox txtvalues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcampo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combotipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnombrecampo;
        private System.Windows.Forms.TextBox txtscript;
        private System.Windows.Forms.Button btncampos;
        private System.Windows.Forms.Button btnvalores;
        private System.Windows.Forms.Button btngenerar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.SaveFileDialog saveFileArchivo;
    }
}