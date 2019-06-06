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
            this.buttonCrearPersona = new System.Windows.Forms.Button();
            this.botonIniciarSV = new System.Windows.Forms.Button();
            this.consola = new System.Windows.Forms.TextBox();
            this.botonEscuchar = new System.Windows.Forms.Button();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.botonEncontrarUsuario = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCrearUsuario = new System.Windows.Forms.Panel();
            this.buttonCancelarCrearPersona = new System.Windows.Forms.Button();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonAgregarPersona = new System.Windows.Forms.Button();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelCrearUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearPersona
            // 
            this.buttonCrearPersona.Location = new System.Drawing.Point(12, 12);
            this.buttonCrearPersona.Name = "buttonCrearPersona";
            this.buttonCrearPersona.Size = new System.Drawing.Size(130, 23);
            this.buttonCrearPersona.TabIndex = 0;
            this.buttonCrearPersona.Text = "Crear Persona";
            this.buttonCrearPersona.UseVisualStyleBackColor = true;
            this.buttonCrearPersona.Click += new System.EventHandler(this.ButtonCrearPersona_Click);
            // 
            // botonIniciarSV
            // 
            this.botonIniciarSV.Location = new System.Drawing.Point(12, 320);
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
            this.consola.Location = new System.Drawing.Point(12, 349);
            this.consola.Multiline = true;
            this.consola.Name = "consola";
            this.consola.ReadOnly = true;
            this.consola.Size = new System.Drawing.Size(266, 89);
            this.consola.TabIndex = 2;
            // 
            // botonEscuchar
            // 
            this.botonEscuchar.Location = new System.Drawing.Point(148, 12);
            this.botonEscuchar.Name = "botonEscuchar";
            this.botonEscuchar.Size = new System.Drawing.Size(130, 23);
            this.botonEscuchar.TabIndex = 3;
            this.botonEscuchar.Text = "Escuchar";
            this.botonEscuchar.UseVisualStyleBackColor = true;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(284, 12);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(130, 23);
            this.botonEnviar.TabIndex = 4;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.BotonEnviar_Click);
            // 
            // botonEncontrarUsuario
            // 
            this.botonEncontrarUsuario.Enabled = false;
            this.botonEncontrarUsuario.Location = new System.Drawing.Point(148, 320);
            this.botonEncontrarUsuario.Name = "botonEncontrarUsuario";
            this.botonEncontrarUsuario.Size = new System.Drawing.Size(130, 23);
            this.botonEncontrarUsuario.TabIndex = 5;
            this.botonEncontrarUsuario.Text = "Buscar Usuario";
            this.botonEncontrarUsuario.UseVisualStyleBackColor = true;
            this.botonEncontrarUsuario.Click += new System.EventHandler(this.BotonEncontrarUsuario_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Sexo});
            this.dataGridView1.Location = new System.Drawing.Point(432, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(356, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // panelCrearUsuario
            // 
            this.panelCrearUsuario.Controls.Add(this.buttonCancelarCrearPersona);
            this.panelCrearUsuario.Controls.Add(this.comboBoxSexo);
            this.panelCrearUsuario.Controls.Add(this.textBoxApellido);
            this.panelCrearUsuario.Controls.Add(this.textBoxNombre);
            this.panelCrearUsuario.Controls.Add(this.buttonAgregarPersona);
            this.panelCrearUsuario.Controls.Add(this.labelSexo);
            this.panelCrearUsuario.Controls.Add(this.labelApellido);
            this.panelCrearUsuario.Controls.Add(this.labelNombre);
            this.panelCrearUsuario.Location = new System.Drawing.Point(12, 41);
            this.panelCrearUsuario.Name = "panelCrearUsuario";
            this.panelCrearUsuario.Size = new System.Drawing.Size(130, 189);
            this.panelCrearUsuario.TabIndex = 7;
            this.panelCrearUsuario.Visible = false;
            // 
            // buttonCancelarCrearPersona
            // 
            this.buttonCancelarCrearPersona.Location = new System.Drawing.Point(16, 160);
            this.buttonCancelarCrearPersona.Name = "buttonCancelarCrearPersona";
            this.buttonCancelarCrearPersona.Size = new System.Drawing.Size(98, 23);
            this.buttonCancelarCrearPersona.TabIndex = 11;
            this.buttonCancelarCrearPersona.Text = "Cancelar";
            this.buttonCancelarCrearPersona.UseVisualStyleBackColor = true;
            this.buttonCancelarCrearPersona.Click += new System.EventHandler(this.ButtonCancelarCrearPersona_Click);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.comboBoxSexo.Location = new System.Drawing.Point(3, 104);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(124, 21);
            this.comboBoxSexo.TabIndex = 10;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(3, 65);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(124, 20);
            this.textBoxApellido.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(3, 26);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(124, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // buttonAgregarPersona
            // 
            this.buttonAgregarPersona.Location = new System.Drawing.Point(16, 131);
            this.buttonAgregarPersona.Name = "buttonAgregarPersona";
            this.buttonAgregarPersona.Size = new System.Drawing.Size(98, 23);
            this.buttonAgregarPersona.TabIndex = 8;
            this.buttonAgregarPersona.Text = "Agregar Persona";
            this.buttonAgregarPersona.UseVisualStyleBackColor = true;
            this.buttonAgregarPersona.Click += new System.EventHandler(this.ButtonAgregarPersona_Click);
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(3, 88);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 2;
            this.labelSexo.Text = "Sexo";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(3, 49);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 1;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(3, 10);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCrearUsuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonEncontrarUsuario);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.botonEscuchar);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.botonIniciarSV);
            this.Controls.Add(this.buttonCrearPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelCrearUsuario.ResumeLayout(false);
            this.panelCrearUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearPersona;
        private System.Windows.Forms.Button botonIniciarSV;
        private System.Windows.Forms.TextBox consola;
        private System.Windows.Forms.Button botonEscuchar;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.Button botonEncontrarUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.Panel panelCrearUsuario;
        private System.Windows.Forms.Label labelNombre;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button buttonCancelarCrearPersona;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonAgregarPersona;
    }
}

