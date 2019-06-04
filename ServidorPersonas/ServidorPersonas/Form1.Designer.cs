namespace ServidorPersonas
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.botonIniciarSV = new System.Windows.Forms.Button();
            this.consola = new System.Windows.Forms.TextBox();
            this.botonEscuchar = new System.Windows.Forms.Button();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.botonEncontrarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Viajes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // botonIniciarSV
            // 
            this.botonIniciarSV.Location = new System.Drawing.Point(310, 23);
            this.botonIniciarSV.Name = "botonIniciarSV";
            this.botonIniciarSV.Size = new System.Drawing.Size(130, 23);
            this.botonIniciarSV.TabIndex = 1;
            this.botonIniciarSV.Text = "Iniciar Servidor";
            this.botonIniciarSV.UseVisualStyleBackColor = true;
            this.botonIniciarSV.Click += new System.EventHandler(this.botonIniciarSV_Click);
            // 
            // consola
            // 
            this.consola.BackColor = System.Drawing.SystemColors.ControlText;
            this.consola.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.consola.Location = new System.Drawing.Point(446, 23);
            this.consola.Multiline = true;
            this.consola.Name = "consola";
            this.consola.ReadOnly = true;
            this.consola.Size = new System.Drawing.Size(342, 277);
            this.consola.TabIndex = 2;
            // 
            // botonEscuchar
            // 
            this.botonEscuchar.Location = new System.Drawing.Point(310, 81);
            this.botonEscuchar.Name = "botonEscuchar";
            this.botonEscuchar.Size = new System.Drawing.Size(130, 23);
            this.botonEscuchar.TabIndex = 3;
            this.botonEscuchar.Text = "Escuchar";
            this.botonEscuchar.UseVisualStyleBackColor = true;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(310, 110);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(130, 23);
            this.botonEnviar.TabIndex = 4;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            // 
            // botonEncontrarUsuario
            // 
            this.botonEncontrarUsuario.Enabled = false;
            this.botonEncontrarUsuario.Location = new System.Drawing.Point(310, 52);
            this.botonEncontrarUsuario.Name = "botonEncontrarUsuario";
            this.botonEncontrarUsuario.Size = new System.Drawing.Size(130, 23);
            this.botonEncontrarUsuario.TabIndex = 5;
            this.botonEncontrarUsuario.Text = "Buscar Usuario";
            this.botonEncontrarUsuario.UseVisualStyleBackColor = true;
            this.botonEncontrarUsuario.Click += new System.EventHandler(this.BotonEncontrarUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonEncontrarUsuario);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.botonEscuchar);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.botonIniciarSV);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonIniciarSV;
        private System.Windows.Forms.TextBox consola;
        private System.Windows.Forms.Button botonEscuchar;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.Button botonEncontrarUsuario;
    }
}

