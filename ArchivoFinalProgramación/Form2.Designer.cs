namespace ArchivoFinalProgramación
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtMaterias = new System.Windows.Forms.TextBox();
            this.txtProfeNombre = new System.Windows.Forms.TextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProfeApellido = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgregarProfe = new System.Windows.Forms.Label();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarProfe = new System.Windows.Forms.Button();
            this.btnModificarProfe = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaterias
            // 
            this.txtMaterias.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtMaterias.Location = new System.Drawing.Point(461, 73);
            this.txtMaterias.Name = "txtMaterias";
            this.txtMaterias.Size = new System.Drawing.Size(100, 23);
            this.txtMaterias.TabIndex = 0;
            // 
            // txtProfeNombre
            // 
            this.txtProfeNombre.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfeNombre.Location = new System.Drawing.Point(41, 74);
            this.txtProfeNombre.Name = "txtProfeNombre";
            this.txtProfeNombre.Size = new System.Drawing.Size(100, 23);
            this.txtProfeNombre.TabIndex = 1;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materia});
            this.dgvMaterias.Location = new System.Drawing.Point(461, 125);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.Size = new System.Drawing.Size(295, 191);
            this.dgvMaterias.TabIndex = 5;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            // 
            // materia
            // 
            this.materia.HeaderText = "Materia";
            this.materia.MinimumWidth = 10;
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 252;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfesores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido});
            this.dgvProfesores.Location = new System.Drawing.Point(41, 125);
            this.dgvProfesores.MultiSelect = false;
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.Size = new System.Drawing.Size(295, 191);
            this.dgvProfesores.TabIndex = 6;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 127;
            // 
            // txtProfeApellido
            // 
            this.txtProfeApellido.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.txtProfeApellido.Location = new System.Drawing.Point(166, 74);
            this.txtProfeApellido.Name = "txtProfeApellido";
            this.txtProfeApellido.Size = new System.Drawing.Size(100, 23);
            this.txtProfeApellido.TabIndex = 14;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(65, 58);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 16);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.lblApellido.Location = new System.Drawing.Point(196, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 16);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(288, 109);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::ArchivoFinalProgramación.Properties.Resources.Materia1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(457, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "     Materia :";
            // 
            // lblAgregarProfe
            // 
            this.lblAgregarProfe.AutoSize = true;
            this.lblAgregarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAgregarProfe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProfe.ForeColor = System.Drawing.Color.White;
            this.lblAgregarProfe.Image = global::ArchivoFinalProgramación.Properties.Resources.Persona;
            this.lblAgregarProfe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAgregarProfe.Location = new System.Drawing.Point(37, 22);
            this.lblAgregarProfe.Name = "lblAgregarProfe";
            this.lblAgregarProfe.Size = new System.Drawing.Size(106, 23);
            this.lblAgregarProfe.TabIndex = 12;
            this.lblAgregarProfe.Text = "      Profesor :";
            this.lblAgregarProfe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMateria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnModificarMateria.Image = global::ArchivoFinalProgramación.Properties.Resources.Modificar;
            this.btnModificarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMateria.Location = new System.Drawing.Point(461, 322);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(84, 30);
            this.btnModificarMateria.TabIndex = 11;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMateria.UseVisualStyleBackColor = false;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterias.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnEliminarMaterias.Image = global::ArchivoFinalProgramación.Properties.Resources.Eliminar;
            this.btnEliminarMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarMaterias.Location = new System.Drawing.Point(678, 322);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarMaterias.TabIndex = 10;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarMaterias.UseVisualStyleBackColor = false;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMaterias_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVolver.Image = global::ArchivoFinalProgramación.Properties.Resources.Volver;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(720, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 27);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = " Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarProfe
            // 
            this.btnEliminarProfe.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProfe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnEliminarProfe.Image = global::ArchivoFinalProgramación.Properties.Resources.Eliminar;
            this.btnEliminarProfe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProfe.Location = new System.Drawing.Point(258, 322);
            this.btnEliminarProfe.Name = "btnEliminarProfe";
            this.btnEliminarProfe.Size = new System.Drawing.Size(78, 30);
            this.btnEliminarProfe.TabIndex = 8;
            this.btnEliminarProfe.Text = "Eliminar";
            this.btnEliminarProfe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProfe.UseVisualStyleBackColor = false;
            this.btnEliminarProfe.Click += new System.EventHandler(this.btnEliminarProfe_Click);
            // 
            // btnModificarProfe
            // 
            this.btnModificarProfe.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnModificarProfe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProfe.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F);
            this.btnModificarProfe.Image = global::ArchivoFinalProgramación.Properties.Resources.Modificar;
            this.btnModificarProfe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarProfe.Location = new System.Drawing.Point(41, 322);
            this.btnModificarProfe.Name = "btnModificarProfe";
            this.btnModificarProfe.Size = new System.Drawing.Size(84, 30);
            this.btnModificarProfe.TabIndex = 7;
            this.btnModificarProfe.Text = "Modificar";
            this.btnModificarProfe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProfe.UseVisualStyleBackColor = false;
            this.btnModificarProfe.Click += new System.EventHandler(this.btnModificarProfe_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAgregarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMateria.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMateria.Image = global::ArchivoFinalProgramación.Properties.Resources.Agregar;
            this.btnAgregarMateria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarMateria.Location = new System.Drawing.Point(576, 66);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(78, 30);
            this.btnAgregarMateria.TabIndex = 4;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarMateria.UseVisualStyleBackColor = false;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAgregarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProfesor.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Image = global::ArchivoFinalProgramación.Properties.Resources.Agregar;
            this.btnAgregarProfesor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProfesor.Location = new System.Drawing.Point(291, 74);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(78, 30);
            this.btnAgregarProfesor.TabIndex = 3;
            this.btnAgregarProfesor.Text = "Agregar";
            this.btnAgregarProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProfesor.UseVisualStyleBackColor = false;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfeApellido);
            this.Controls.Add(this.lblAgregarProfe);
            this.Controls.Add(this.btnModificarMateria);
            this.Controls.Add(this.btnEliminarMaterias);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarProfe);
            this.Controls.Add(this.btnModificarProfe);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.txtProfeNombre);
            this.Controls.Add(this.txtMaterias);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Profesores y Materias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterias;
        private System.Windows.Forms.TextBox txtProfeNombre;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnModificarProfe;
        private System.Windows.Forms.Button btnEliminarProfe;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.Label lblAgregarProfe;
        private System.Windows.Forms.TextBox txtProfeApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}