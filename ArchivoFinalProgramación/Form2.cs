using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Libreria para el manejo de archivos

namespace ArchivoFinalProgramación
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            // Inicializacion de las variables
            string nombre;
            string apellido;
            string materias;
            int n;

            // COMIENZO Carga variables Profesores

            // Abrimos el archivo en modo lectura
            FileStream fs1 = new FileStream("Profesores.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leeemos linea por línea y, por cada linea, cargamos en el datagridview
            using (StreamReader reader = new StreamReader(fs1))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    // Spliteo los profesores con un punto para por diferenciarlos a la hora de pasarlo al datagridview
                    string[] datos = linea.Split('.');

                    // Adicionamos nuevo renglon
                    n = dgvProfesores.Rows.Add(); // Aumenta una fila y regresa su indice

                    nombre = datos[0];
                    apellido = datos[1];

                    // Colocamos la informacion
                    dgvProfesores.Rows[n].Cells[0].Value = nombre; 
                                                                                                                                        
                    dgvProfesores.Rows[n].Cells[1].Value = apellido;
                                                                            
                    linea = reader.ReadLine();
                }
            }
            // Cerramos el arcivo
            fs1.Close();
            // FIN Carga variables Profesores

            // COMIENZO Carga variables Materias

            // Abrimos el archivo en modo lectura
            FileStream fs2 = new FileStream("Materias.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leeemos linea por línea y, por cada linea, cargamos en el data grind view
            using (StreamReader reader = new StreamReader(fs2))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    materias = linea;

                    // Adicionamos nuevo renglon
                    n = dgvMaterias.Rows.Add(); // Aumenta una fila y regresa su indice

                    // Colocamos la informacion
                    dgvMaterias.Rows[n].Cells[0].Value = materias; 
                                                                                                                                                                                                             
                    linea = reader.ReadLine();
                }
            }
            // Cerramos el arcivo
            fs2.Close();
           // FIN Carga de variables Materias
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e) 
        {
            // Valido que ninguna cadena este vacia
            if (txtProfeNombre.Text == "" || txtProfeApellido.Text== "" )
            {
                lblError.Text = "Error: Uno o varios espacios estan vacios";

            }
            else
            {
                int l;

                // Adicionamos nuevo renglon
                l = dgvProfesores.Rows.Add();

                // Colocamos la informacion en el DataGridView
                dgvProfesores.Rows[l].Cells[0].Value = txtProfeNombre.Text; 

                dgvProfesores.Rows[l].Cells[1].Value = txtProfeApellido.Text;
               
                lblError.Text = "";
                txtProfeNombre.Text = ""; 
                txtProfeApellido.Text = "";
            }
        }

        private void btnModificarProfe_Click(object sender, EventArgs e) 
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvProfesores.SelectedRows.Count == 1)
            {
                // Cargo los datos que hay actualmente en los txt a el datagridview
                int fila_seleccionada = dgvProfesores.CurrentRow.Index;
                dgvProfesores.Rows[fila_seleccionada].Cells[0].Value = txtProfeNombre.Text;
                dgvProfesores.Rows[fila_seleccionada].Cells[1].Value = txtProfeApellido.Text;
                txtProfeNombre.Text = ""; 
                txtProfeApellido.Text = "";
            }
        }

        private void btnEliminarProfe_Click(object sender, EventArgs e) 
        {
            // Verifico que haya una celda seleccionada 
            if (dgvProfesores.CurrentRow.Index > -1) 
            {
                dgvProfesores.Rows.RemoveAt(dgvProfesores.CurrentRow.Index); // RemoveAt borra la seleccionada en base al index
            }
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvProfesores.SelectedRows.Count == 1)
            {
                // Defino el índice de la fila 
                int fila_seleccionada = dgvProfesores.CurrentRow.Index;
                // Cargo los textbox con los datos de la fila seleccionada y en las celdas correspondientes
                txtProfeNombre.Text = dgvProfesores.Rows[fila_seleccionada].Cells[0].Value.ToString();
                txtProfeApellido.Text = dgvProfesores.Rows[fila_seleccionada].Cells[1].Value.ToString();
            }

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e) 
        {
            // Valido que ninguna cadena este vacia
            if (txtMaterias.Text == "")
            {
                lblError.Text = "Error: Uno o varios espacios estan vacios";
            }
            else
            {
                int f;

                // Adicionamos nuevo renglon
                f = dgvMaterias.Rows.Add();

                // Colocamos la informacion
                dgvMaterias.Rows[f].Cells[0].Value = txtMaterias.Text;

                lblError.Text = "";
                txtMaterias.Text = "";
            }
        }
        
        private void btnModificarMateria_Click(object sender, EventArgs e) 
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvMaterias.SelectedRows.Count == 1)
            {
                // Cargo en una variable el índice de la fila
                int fila_seleccionada = dgvMaterias.CurrentRow.Index;
                // Cargo en dicha fila y en la primera celda lo que se encuentra en el textbox de materia
                dgvMaterias.Rows[fila_seleccionada].Cells[0].Value = txtMaterias.Text;
            }
            txtMaterias.Text = "";
        }

        private void btnEliminarMaterias_Click(object sender, EventArgs e) 
        {
            // Verifico que haya una celda seleccionada
            if (dgvMaterias.CurrentRow.Index > -1)
            {
                dgvMaterias.Rows.RemoveAt(dgvMaterias.CurrentRow.Index); // RemoveAt borra la seleccionada en base al index
            }
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvMaterias.SelectedRows.Count == 1)
            {
                // Defino el índice de la fila 
                int fila_seleccionada = dgvMaterias.CurrentRow.Index;
                // Cargo los textbox con los datos de la fila seleccionada y en las celdas correspondientes
                txtMaterias.Text = dgvMaterias.Rows[fila_seleccionada].Cells[0].Value.ToString();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e) // Vuelvo al menu y cargo los respectivos archivos 
        {
            this.Hide(); 
            Form1 frm = new Form1();
            frm.Show();

            // Invoco el metodo de guardar
            Guardar();           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) 
        {
            // Invoco el metodo de guardar
            Guardar();     
        }

        // Metodo guardar
        private void Guardar() {

            // COMIENZO Guardar Profesores
            FileStream fs1 = new FileStream("Profesores.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs1))
            {
                // Recorro todas las filas del datagridview
                foreach (DataGridViewRow row in dgvProfesores.Rows) 
                {
                    writer.WriteLine($"{row.Cells[0].Value}. {row.Cells[1].Value}"); // Escribo en el archivo el contenido de cada celda
                }
            }
            fs1.Close();
            // FIN Guardar Profesores

            // COMIENZO Guardar Materias
            FileStream fs2 = new FileStream("Materias.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs2))
            {
                foreach (DataGridViewRow row in dgvMaterias.Rows)
                {
                    // Mismo codigo que para guardar profesores
                    writer.WriteLine($"{row.Cells[0].Value}");
                }
            }
            fs2.Close();
            //FIN Guardar Profesores
        }
    }
}