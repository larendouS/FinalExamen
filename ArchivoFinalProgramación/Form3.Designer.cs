namespace ArchivoFinalProgramación
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.btnvolver2 = new System.Windows.Forms.Button();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAgregarProfe = new System.Windows.Forms.Label();
            this.cmbCargados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorrarCmb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurso
            // 
            this.txtCurso.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(273, 12);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(108, 23);
            this.txtCurso.TabIndex = 0;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(273, 48);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(108, 24);
            this.cmbProfesor.TabIndex = 1;
            // 
            // cmbMateria
            // 
            this.cmbMateria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(273, 84);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(108, 24);
            this.cmbMateria.TabIndex = 2;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAlumno.Location = new System.Drawing.Point(147, 149);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(108, 23);
            this.txtNombreAlumno.TabIndex = 3;
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnAgregarAlumno.Image = global::ArchivoFinalProgramación.Properties.Resources.Agregar;
            this.btnAgregarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarAlumno.Location = new System.Drawing.Point(484, 158);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(81, 50);
            this.btnAgregarAlumno.TabIndex = 4;
            this.btnAgregarAlumno.Text = "Agregar";
            this.btnAgregarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAlumno.UseVisualStyleBackColor = false;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.dni});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.Location = new System.Drawing.Point(110, 236);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(368, 179);
            this.dgvAlumnos.TabIndex = 5;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 110;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 110;
            // 
            // dni
            // 
            this.dni.HeaderText = "Dni";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 105;
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCurso.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCurso.Image = global::ArchivoFinalProgramación.Properties.Resources.Agregar;
            this.btnCrearCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCurso.Location = new System.Drawing.Point(484, 295);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(103, 58);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCurso.UseVisualStyleBackColor = false;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // btnvolver2
            // 
            this.btnvolver2.BackColor = System.Drawing.Color.GreenYellow;
            this.btnvolver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver2.Image = global::ArchivoFinalProgramación.Properties.Resources.Volver;
            this.btnvolver2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver2.Location = new System.Drawing.Point(629, 426);
            this.btnvolver2.Name = "btnvolver2";
            this.btnvolver2.Size = new System.Drawing.Size(68, 27);
            this.btnvolver2.TabIndex = 7;
            this.btnvolver2.Text = "Volver";
            this.btnvolver2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver2.UseVisualStyleBackColor = false;
            this.btnvolver2.Click += new System.EventHandler(this.btnvolver2_Click);
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDniAlumno.Location = new System.Drawing.Point(368, 149);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(100, 23);
            this.txtDniAlumno.TabIndex = 8;
            this.txtDniAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniAlumno_KeyPress);
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoAlumno.Location = new System.Drawing.Point(261, 149);
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.Size = new System.Drawing.Size(100, 23);
            this.txtApellidoAlumno.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label1.Location = new System.Drawing.Point(403, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label2.Location = new System.Drawing.Point(290, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label3.Location = new System.Drawing.Point(177, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Location = new System.Drawing.Point(204, 261);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 13);
            this.lblError1.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::ArchivoFinalProgramación.Properties.Resources.Eliminar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(110, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificarAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAlumnos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAlumnos.Image = global::ArchivoFinalProgramación.Properties.Resources.Modificar;
            this.btnModificarAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarAlumnos.Location = new System.Drawing.Point(394, 421);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(84, 30);
            this.btnModificarAlumnos.TabIndex = 16;
            this.btnModificarAlumnos.Text = "Modificar";
            this.btnModificarAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarAlumnos.UseVisualStyleBackColor = false;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Image = global::ArchivoFinalProgramación.Properties.Resources.firma__1_;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(96, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "     Nombre del Curso :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Image = global::ArchivoFinalProgramación.Properties.Resources.icons8_schoolboy_at_a_desk_48__1_;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(39, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "     Alumnos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Image = global::ArchivoFinalProgramación.Properties.Resources.Materia1;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(176, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "     Materia:";
            // 
            // lblAgregarProfe
            // 
            this.lblAgregarProfe.AutoSize = true;
            this.lblAgregarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarProfe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.lblAgregarProfe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgregarProfe.Image = global::ArchivoFinalProgramación.Properties.Resources.Persona;
            this.lblAgregarProfe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgregarProfe.Location = new System.Drawing.Point(161, 48);
            this.lblAgregarProfe.Name = "lblAgregarProfe";
            this.lblAgregarProfe.Size = new System.Drawing.Size(106, 23);
            this.lblAgregarProfe.TabIndex = 20;
            this.lblAgregarProfe.Text = "      Profesor :";
            this.lblAgregarProfe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbCargados
            // 
            this.cmbCargados.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargados.FormattingEnabled = true;
            this.cmbCargados.Location = new System.Drawing.Point(142, 194);
            this.cmbCargados.Name = "cmbCargados";
            this.cmbCargados.Size = new System.Drawing.Size(235, 24);
            this.cmbCargados.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.label7.Location = new System.Drawing.Point(219, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Alumno cargado";
            // 
            // btnBorrarCmb
            // 
            this.btnBorrarCmb.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBorrarCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarCmb.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnBorrarCmb.Image = global::ArchivoFinalProgramación.Properties.Resources.Eliminar;
            this.btnBorrarCmb.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarCmb.Location = new System.Drawing.Point(383, 186);
            this.btnBorrarCmb.Name = "btnBorrarCmb";
            this.btnBorrarCmb.Size = new System.Drawing.Size(67, 32);
            this.btnBorrarCmb.TabIndex = 26;
            this.btnBorrarCmb.Text = "Borrar";
            this.btnBorrarCmb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarCmb.UseVisualStyleBackColor = false;
            this.btnBorrarCmb.Click += new System.EventHandler(this.btnBorrarCmb_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(709, 465);
            this.Controls.Add(this.btnBorrarCmb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCargados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAgregarProfe);
            this.Controls.Add(this.btnModificarAlumnos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidoAlumno);
            this.Controls.Add(this.txtDniAlumno);
            this.Controls.Add(this.btnvolver2);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.txtCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.Button btnvolver2;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private System.Windows.Forms.TextBox txtApellidoAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private System.Windows.Forms.Label lblAgregarProfe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.ComboBox cmbCargados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrarCmb;
    }
}