namespace ArchivoFinalProgramación
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.btnvolver3 = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCursoNombre = new System.Windows.Forms.TextBox();
            this.cmbProfesor = new System.Windows.Forms.ComboBox();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblAgregarProfe = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCurso.Image = global::ArchivoFinalProgramación.Properties.Resources.Eliminar;
            this.btnEliminarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCurso.Location = new System.Drawing.Point(801, 341);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarCurso.TabIndex = 4;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCurso.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCurso.Image = global::ArchivoFinalProgramación.Properties.Resources.Modificar;
            this.btnModificarCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCurso.Location = new System.Drawing.Point(36, 341);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(84, 30);
            this.btnModificarCurso.TabIndex = 5;
            this.btnModificarCurso.Text = "Modificar";
            this.btnModificarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCurso.UseVisualStyleBackColor = false;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // btnvolver3
            // 
            this.btnvolver3.BackColor = System.Drawing.Color.GreenYellow;
            this.btnvolver3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnvolver3.Image = global::ArchivoFinalProgramación.Properties.Resources.Volver;
            this.btnvolver3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvolver3.Location = new System.Drawing.Point(855, 411);
            this.btnvolver3.Name = "btnvolver3";
            this.btnvolver3.Size = new System.Drawing.Size(68, 27);
            this.btnvolver3.TabIndex = 6;
            this.btnvolver3.Text = "Volver";
            this.btnvolver3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver3.UseVisualStyleBackColor = false;
            this.btnvolver3.Click += new System.EventHandler(this.btnvolver3_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.profesor,
            this.materia,
            this.alumnos});
            this.dgvCursos.Location = new System.Drawing.Point(36, 107);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(843, 228);
            this.dgvCursos.TabIndex = 7;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Curso";
            this.nombre.Name = "nombre";
            // 
            // profesor
            // 
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            // 
            // materia
            // 
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            // 
            // alumnos
            // 
            this.alumnos.HeaderText = "Alumnos";
            this.alumnos.Name = "alumnos";
            this.alumnos.Width = 2000;
            // 
            // txtCursoNombre
            // 
            this.txtCursoNombre.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursoNombre.Location = new System.Drawing.Point(423, 18);
            this.txtCursoNombre.Name = "txtCursoNombre";
            this.txtCursoNombre.Size = new System.Drawing.Size(111, 23);
            this.txtCursoNombre.TabIndex = 9;
            // 
            // cmbProfesor
            // 
            this.cmbProfesor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProfesor.FormattingEnabled = true;
            this.cmbProfesor.Location = new System.Drawing.Point(227, 68);
            this.cmbProfesor.Name = "cmbProfesor";
            this.cmbProfesor.Size = new System.Drawing.Size(121, 24);
            this.cmbProfesor.TabIndex = 10;
            // 
            // cmbMateria
            // 
            this.cmbMateria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(602, 68);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(121, 24);
            this.cmbMateria.TabIndex = 11;
            // 
            // lblAgregarProfe
            // 
            this.lblAgregarProfe.AutoSize = true;
            this.lblAgregarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarProfe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.lblAgregarProfe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAgregarProfe.Image = global::ArchivoFinalProgramación.Properties.Resources.Persona;
            this.lblAgregarProfe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgregarProfe.Location = new System.Drawing.Point(115, 68);
            this.lblAgregarProfe.Name = "lblAgregarProfe";
            this.lblAgregarProfe.Size = new System.Drawing.Size(106, 23);
            this.lblAgregarProfe.TabIndex = 21;
            this.lblAgregarProfe.Text = "      Profesor :";
            this.lblAgregarProfe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Image = global::ArchivoFinalProgramación.Properties.Resources.Materia1;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(505, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "     Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Image = global::ArchivoFinalProgramación.Properties.Resources.firma__1_;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(234, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "     Curso Seleccionado :";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAgregarProfe);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.cmbProfesor);
            this.Controls.Add(this.txtCursoNombre);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnvolver3);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.btnEliminarCurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver y Modificar Cursos Cargados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.Button btnvolver3;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtCursoNombre;
        private System.Windows.Forms.ComboBox cmbProfesor;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblAgregarProfe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnos;
    }
}