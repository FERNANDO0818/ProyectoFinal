﻿namespace ProyectoFinal
{
    partial class Ventana1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana1));
            this.label1 = new System.Windows.Forms.Label();
            this.Txtnombretb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbbd = new System.Windows.Forms.ComboBox();
            this.Txtscript = new System.Windows.Forms.TextBox();
            this.Btngenerar = new System.Windows.Forms.Button();
            this.Btnguardar = new System.Windows.Forms.Button();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.saveFileArchivo = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = " DATA BASE";
            // 
            // Txtnombretb
            // 
            this.Txtnombretb.Location = new System.Drawing.Point(200, 28);
            this.Txtnombretb.Multiline = true;
            this.Txtnombretb.Name = "Txtnombretb";
            this.Txtnombretb.Size = new System.Drawing.Size(134, 20);
            this.Txtnombretb.TabIndex = 1;
            this.Txtnombretb.TextChanged += new System.EventHandler(this.Txtnombretb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TIPO DE DATA";
            // 
            // Cbbd
            // 
            this.Cbbd.FormattingEnabled = true;
            this.Cbbd.Items.AddRange(new object[] {
            "Postgresql",
            "Oracle",
            "MySQL",
            "SQL Server"});
            this.Cbbd.Location = new System.Drawing.Point(590, 27);
            this.Cbbd.Name = "Cbbd";
            this.Cbbd.Size = new System.Drawing.Size(121, 21);
            this.Cbbd.TabIndex = 3;
            this.Cbbd.SelectedIndexChanged += new System.EventHandler(this.Cbbd_SelectedIndexChanged);
            // 
            // Txtscript
            // 
            this.Txtscript.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtscript.Location = new System.Drawing.Point(63, 99);
            this.Txtscript.Multiline = true;
            this.Txtscript.Name = "Txtscript";
            this.Txtscript.Size = new System.Drawing.Size(313, 162);
            this.Txtscript.TabIndex = 4;
            this.Txtscript.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Btngenerar
            // 
            this.Btngenerar.Location = new System.Drawing.Point(507, 102);
            this.Btngenerar.Name = "Btngenerar";
            this.Btngenerar.Size = new System.Drawing.Size(83, 43);
            this.Btngenerar.TabIndex = 5;
            this.Btngenerar.Text = "Generar";
            this.Btngenerar.UseVisualStyleBackColor = true;
            this.Btngenerar.Click += new System.EventHandler(this.Btngenerar_Click);
            // 
            // Btnguardar
            // 
            this.Btnguardar.Location = new System.Drawing.Point(514, 163);
            this.Btnguardar.Name = "Btnguardar";
            this.Btnguardar.Size = new System.Drawing.Size(76, 53);
            this.Btnguardar.TabIndex = 6;
            this.Btnguardar.Text = "Guardar";
            this.Btnguardar.UseVisualStyleBackColor = true;
            this.Btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btnregresar
            // 
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(63, 284);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(29, 24);
            this.Btnregresar.TabIndex = 7;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ventana1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnregresar);
            this.Controls.Add(this.Btnguardar);
            this.Controls.Add(this.Btngenerar);
            this.Controls.Add(this.Txtscript);
            this.Controls.Add(this.Cbbd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtnombretb);
            this.Controls.Add(this.label1);
            this.Name = "Ventana1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ventana1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtnombretb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbbd;
        private System.Windows.Forms.TextBox Txtscript;
        private System.Windows.Forms.Button Btngenerar;
        private System.Windows.Forms.Button Btnguardar;
        private System.Windows.Forms.Button Btnregresar;
        private System.Windows.Forms.SaveFileDialog saveFileArchivo;
    }
}

