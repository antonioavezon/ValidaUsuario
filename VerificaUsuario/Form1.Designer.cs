namespace VerificaUsuario
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RutTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.botonBaseDatos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.vez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese sus credenciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RutTxt
            // 
            this.RutTxt.Location = new System.Drawing.Point(168, 125);
            this.RutTxt.Name = "RutTxt";
            this.RutTxt.Size = new System.Drawing.Size(108, 20);
            this.RutTxt.TabIndex = 4;
            // 
            // PassTxt
            // 
            this.PassTxt.ForeColor = System.Drawing.Color.Black;
            this.PassTxt.Location = new System.Drawing.Point(168, 183);
            this.PassTxt.MaxLength = 10;
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.PasswordChar = '*';
            this.PassTxt.Size = new System.Drawing.Size(73, 20);
            this.PassTxt.TabIndex = 5;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // botonBaseDatos
            // 
            this.botonBaseDatos.Location = new System.Drawing.Point(94, 273);
            this.botonBaseDatos.Name = "botonBaseDatos";
            this.botonBaseDatos.Size = new System.Drawing.Size(80, 21);
            this.botonBaseDatos.TabIndex = 6;
            this.botonBaseDatos.Text = "Test BD";
            this.botonBaseDatos.UseVisualStyleBackColor = true;
            this.botonBaseDatos.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Intento  :";
            // 
            // vez
            // 
            this.vez.AutoSize = true;
            this.vez.Location = new System.Drawing.Point(380, 246);
            this.vez.Name = "vez";
            this.vez.Size = new System.Drawing.Size(13, 13);
            this.vez.TabIndex = 8;
            this.vez.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 350);
            this.Controls.Add(this.vez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botonBaseDatos);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.RutTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RutTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button botonBaseDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label vez;
    }
}

