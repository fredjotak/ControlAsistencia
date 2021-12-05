namespace CapaPresentacion
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarioEliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtUsuarioCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioNivel = new System.Windows.Forms.TextBox();
            this.txtUsuarioApe = new System.Windows.Forms.TextBox();
            this.txtUsuarioNom = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarEstudiante = new System.Windows.Forms.Button();
            this.btnModifcarEstudiante = new System.Windows.Forms.Button();
            this.dataGridEstudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstudianteCI = new System.Windows.Forms.TextBox();
            this.txtEstudianteGestion = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCrearEstudiante = new System.Windows.Forms.Button();
            this.txtEstudianteTelef = new System.Windows.Forms.TextBox();
            this.txtEstudianteApe = new System.Windows.Forms.TextBox();
            this.txtEstudianteNom = new System.Windows.Forms.TextBox();
            this.txtEstudienteCod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dataGridUsuarios);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(399, 49);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsuarios.Size = new System.Drawing.Size(472, 168);
            this.dataGridUsuarios.TabIndex = 18;
            this.dataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Lista de Usuarios";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarUsuario.Image")));
            this.btnModificarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarUsuario.Location = new System.Drawing.Point(167, 175);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(151, 44);
            this.btnModificarUsuario.TabIndex = 16;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnUsuarioEliminar
            // 
            this.btnUsuarioEliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUsuarioEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarioEliminar.Image")));
            this.btnUsuarioEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarioEliminar.Location = new System.Drawing.Point(91, 245);
            this.btnUsuarioEliminar.Name = "btnUsuarioEliminar";
            this.btnUsuarioEliminar.Size = new System.Drawing.Size(137, 51);
            this.btnUsuarioEliminar.TabIndex = 15;
            this.btnUsuarioEliminar.Text = "Eliminar Usuario";
            this.btnUsuarioEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarioEliminar.UseVisualStyleBackColor = false;
            this.btnUsuarioEliminar.Click += new System.EventHandler(this.btnUsuarioEliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCrearUsuario);
            this.groupBox3.Controls.Add(this.txtUsuarioCod);
            this.groupBox3.Controls.Add(this.btnUsuarioEliminar);
            this.groupBox3.Controls.Add(this.btnModificarUsuario);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtUsuarioNivel);
            this.groupBox3.Controls.Add(this.txtUsuarioApe);
            this.groupBox3.Controls.Add(this.txtUsuarioNom);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(27, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 302);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Usuario";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearUsuario.Image")));
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.Location = new System.Drawing.Point(6, 175);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(135, 44);
            this.btnCrearUsuario.TabIndex = 19;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtUsuarioCod
            // 
            this.txtUsuarioCod.Enabled = false;
            this.txtUsuarioCod.Location = new System.Drawing.Point(111, 27);
            this.txtUsuarioCod.Name = "txtUsuarioCod";
            this.txtUsuarioCod.Size = new System.Drawing.Size(185, 20);
            this.txtUsuarioCod.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo Usuario: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuarioNivel
            // 
            this.txtUsuarioNivel.Location = new System.Drawing.Point(111, 139);
            this.txtUsuarioNivel.Name = "txtUsuarioNivel";
            this.txtUsuarioNivel.Size = new System.Drawing.Size(185, 20);
            this.txtUsuarioNivel.TabIndex = 8;
            // 
            // txtUsuarioApe
            // 
            this.txtUsuarioApe.Location = new System.Drawing.Point(111, 101);
            this.txtUsuarioApe.Name = "txtUsuarioApe";
            this.txtUsuarioApe.Size = new System.Drawing.Size(185, 20);
            this.txtUsuarioApe.TabIndex = 7;
            // 
            // txtUsuarioNom
            // 
            this.txtUsuarioNom.Location = new System.Drawing.Point(111, 63);
            this.txtUsuarioNom.Name = "txtUsuarioNom";
            this.txtUsuarioNom.Size = new System.Drawing.Size(185, 20);
            this.txtUsuarioNom.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 142);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Nivel: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Apellidos:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 66);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 2;
            this.label23.Text = "Nombres:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 584);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminarEstudiante);
            this.tabPage2.Controls.Add(this.dataGridEstudiantes);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Estudiantes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEstudiante
            // 
            this.btnEliminarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEstudiante.Image")));
            this.btnEliminarEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEstudiante.Location = new System.Drawing.Point(103, 333);
            this.btnEliminarEstudiante.Name = "btnEliminarEstudiante";
            this.btnEliminarEstudiante.Size = new System.Drawing.Size(177, 45);
            this.btnEliminarEstudiante.TabIndex = 18;
            this.btnEliminarEstudiante.Text = "Eliminar Estudiante: ";
            this.btnEliminarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEstudiante.UseVisualStyleBackColor = true;
            this.btnEliminarEstudiante.Click += new System.EventHandler(this.btnEliminarEstudiante_Click);
            // 
            // btnModifcarEstudiante
            // 
            this.btnModifcarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifcarEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnModifcarEstudiante.Image")));
            this.btnModifcarEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifcarEstudiante.Location = new System.Drawing.Point(168, 248);
            this.btnModifcarEstudiante.Name = "btnModifcarEstudiante";
            this.btnModifcarEstudiante.Size = new System.Drawing.Size(171, 42);
            this.btnModifcarEstudiante.TabIndex = 17;
            this.btnModifcarEstudiante.Text = "Modificar Estudiante: ";
            this.btnModifcarEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifcarEstudiante.UseVisualStyleBackColor = true;
            this.btnModifcarEstudiante.Click += new System.EventHandler(this.btnModifcarEstudiante_Click);
            // 
            // dataGridEstudiantes
            // 
            this.dataGridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstudiantes.Location = new System.Drawing.Point(384, 51);
            this.dataGridEstudiantes.Name = "dataGridEstudiantes";
            this.dataGridEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEstudiantes.Size = new System.Drawing.Size(486, 263);
            this.dataGridEstudiantes.TabIndex = 9;
            this.dataGridEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEstudiantes_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstudianteCI);
            this.groupBox1.Controls.Add(this.btnModifcarEstudiante);
            this.groupBox1.Controls.Add(this.txtEstudianteGestion);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.btnCrearEstudiante);
            this.groupBox1.Controls.Add(this.txtEstudianteTelef);
            this.groupBox1.Controls.Add(this.txtEstudianteApe);
            this.groupBox1.Controls.Add(this.txtEstudianteNom);
            this.groupBox1.Controls.Add(this.txtEstudienteCod);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 303);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Estudiante";
            // 
            // txtEstudianteCI
            // 
            this.txtEstudianteCI.Location = new System.Drawing.Point(117, 66);
            this.txtEstudianteCI.Name = "txtEstudianteCI";
            this.txtEstudianteCI.Size = new System.Drawing.Size(185, 20);
            this.txtEstudianteCI.TabIndex = 19;
            // 
            // txtEstudianteGestion
            // 
            this.txtEstudianteGestion.Location = new System.Drawing.Point(117, 213);
            this.txtEstudianteGestion.Name = "txtEstudianteGestion";
            this.txtEstudianteGestion.Size = new System.Drawing.Size(185, 20);
            this.txtEstudianteGestion.TabIndex = 18;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Gestion: ";
            // 
            // btnCrearEstudiante
            // 
            this.btnCrearEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEstudiante.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearEstudiante.Image")));
            this.btnCrearEstudiante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearEstudiante.Location = new System.Drawing.Point(6, 248);
            this.btnCrearEstudiante.Name = "btnCrearEstudiante";
            this.btnCrearEstudiante.Size = new System.Drawing.Size(154, 42);
            this.btnCrearEstudiante.TabIndex = 10;
            this.btnCrearEstudiante.Text = "Crear Estudiante: ";
            this.btnCrearEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearEstudiante.UseVisualStyleBackColor = true;
            this.btnCrearEstudiante.Click += new System.EventHandler(this.btnCrearEstudiante_Click);
            // 
            // txtEstudianteTelef
            // 
            this.txtEstudianteTelef.Location = new System.Drawing.Point(117, 177);
            this.txtEstudianteTelef.Name = "txtEstudianteTelef";
            this.txtEstudianteTelef.Size = new System.Drawing.Size(185, 20);
            this.txtEstudianteTelef.TabIndex = 16;
            // 
            // txtEstudianteApe
            // 
            this.txtEstudianteApe.Location = new System.Drawing.Point(117, 139);
            this.txtEstudianteApe.Name = "txtEstudianteApe";
            this.txtEstudianteApe.Size = new System.Drawing.Size(185, 20);
            this.txtEstudianteApe.TabIndex = 15;
            // 
            // txtEstudianteNom
            // 
            this.txtEstudianteNom.Location = new System.Drawing.Point(117, 101);
            this.txtEstudianteNom.Name = "txtEstudianteNom";
            this.txtEstudianteNom.Size = new System.Drawing.Size(185, 20);
            this.txtEstudianteNom.TabIndex = 14;
            // 
            // txtEstudienteCod
            // 
            this.txtEstudienteCod.Enabled = false;
            this.txtEstudienteCod.Location = new System.Drawing.Point(119, 27);
            this.txtEstudienteCod.Name = "txtEstudienteCod";
            this.txtEstudienteCod.Size = new System.Drawing.Size(185, 20);
            this.txtEstudienteCod.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cod Estudiante: ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Apellidos: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombres: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "C.I. :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lista de Estudiantes";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(765, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Notas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstudiantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnUsuarioEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox txtUsuarioCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioNivel;
        private System.Windows.Forms.TextBox txtUsuarioApe;
        private System.Windows.Forms.TextBox txtUsuarioNom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminarEstudiante;
        private System.Windows.Forms.Button btnModifcarEstudiante;
        private System.Windows.Forms.DataGridView dataGridEstudiantes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstudianteCI;
        private System.Windows.Forms.TextBox txtEstudianteGestion;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnCrearEstudiante;
        private System.Windows.Forms.TextBox txtEstudianteTelef;
        private System.Windows.Forms.TextBox txtEstudianteApe;
        private System.Windows.Forms.TextBox txtEstudianteNom;
        private System.Windows.Forms.TextBox txtEstudienteCod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalir;
    }
}