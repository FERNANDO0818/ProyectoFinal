namespace ProyectoFinal
{
    partial class Formddl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formddl));
            this.btnbd = new System.Windows.Forms.Button();
            this.btntabla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntalter = new System.Windows.Forms.Button();
            this.Btnregresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbd
            // 
            this.btnbd.Location = new System.Drawing.Point(43, 47);
            this.btnbd.Name = "btnbd";
            this.btnbd.Size = new System.Drawing.Size(66, 72);
            this.btnbd.TabIndex = 0;
            this.btnbd.Text = "BASE DE DATOS";
            this.btnbd.UseVisualStyleBackColor = true;
            this.btnbd.Click += new System.EventHandler(this.btnbd_Click);
            // 
            // btntabla
            // 
            this.btntabla.Location = new System.Drawing.Point(115, 47);
            this.btntabla.Name = "btntabla";
            this.btntabla.Size = new System.Drawing.Size(66, 72);
            this.btntabla.TabIndex = 1;
            this.btntabla.Text = "TABLA";
            this.btntabla.UseVisualStyleBackColor = true;
            this.btntabla.Click += new System.EventHandler(this.btntabla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CREATE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntalter
            // 
            this.bntalter.Location = new System.Drawing.Point(250, 47);
            this.bntalter.Name = "bntalter";
            this.bntalter.Size = new System.Drawing.Size(95, 72);
            this.bntalter.TabIndex = 3;
            this.bntalter.Text = "ALTER Y DROP";
            this.bntalter.UseVisualStyleBackColor = true;
            this.bntalter.Click += new System.EventHandler(this.bntalter_Click);
            // 
            // Btnregresar
            // 
            this.Btnregresar.Image = ((System.Drawing.Image)(resources.GetObject("Btnregresar.Image")));
            this.Btnregresar.Location = new System.Drawing.Point(43, 168);
            this.Btnregresar.Name = "Btnregresar";
            this.Btnregresar.Size = new System.Drawing.Size(29, 24);
            this.Btnregresar.TabIndex = 8;
            this.Btnregresar.UseVisualStyleBackColor = true;
            this.Btnregresar.Click += new System.EventHandler(this.Btnregresar_Click);
            // 
            // Formddl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 216);
            this.Controls.Add(this.Btnregresar);
            this.Controls.Add(this.bntalter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntabla);
            this.Controls.Add(this.btnbd);
            this.Name = "Formddl";
            this.Text = "Formddl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbd;
        private System.Windows.Forms.Button btntabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntalter;
        private System.Windows.Forms.Button Btnregresar;
    }
}