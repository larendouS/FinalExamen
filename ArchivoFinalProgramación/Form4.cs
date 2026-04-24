using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoFinalProgramación
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CargarProfesores();
            CargarMaterias(); 

            // Inicializacion de las variables
            string nombre;
            string profesor;
            string materia;
            string alumnos;
            int n;

            // COMIENZO Carga de variables de Alumnos

            // Abrimos el archivo en modo lectura
            FileStream fs = new FileStream("Curso.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leemos linea por línea y, por cada linea, cargamos en el datagridview
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    // Reconstruyo el objeto a partir de los datos levantados del archivo
                    string[] datos = linea.Split(',');

                    // Adicionamos nuevo renglon
                    n = dgvCursos.Rows.Add(); // Aumenta una fila y regresa su indice

                    nombre = datos[0];
                    profesor = datos[1];
                    materia = datos[2];
                    alumnos = datos[3];

                    // Colocamos la informacion
                    dgvCursos.Rows[n].Cells[0].Value = nombre;

                    dgvCursos.Rows[n].Cells[1].Value = profesor;

                    dgvCursos.Rows[n].Cells[2].Value = materia;

                    dgvCursos.Rows[n].Cells[3].Value = alumnos;

                    linea = reader.ReadLine();
                }
            }
            // Cerramos el arcivo
            fs.Close();
            // FIN Carga de variables de Alumnos
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvCursos.SelectedRows.Count == 1)
            {
                // Cargo los datos que hay actualmente en los txt a el datagridview
                int fila_seleccionada = dgvCursos.CurrentRow.Index;
                dgvCursos.Rows[fila_seleccionada].Cells[0].Value = txtCursoNombre.Text;
                dgvCursos.Rows[fila_seleccionada].Cells[1].Value = cmbProfesor.Text;
                dgvCursos.Rows[fila_seleccionada].Cells[2].Value = cmbMateria.Text;
                txtCursoNombre.Text = "";
                cmbProfesor.Text = "";
                cmbMateria.Text = "";
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            // Verifico que haya una celda seleccionada 
            if (dgvCursos.CurrentRow.Index > -1)
            {
                dgvCursos.Rows.RemoveAt(dgvCursos.CurrentRow.Index); // RemoveAt borra la seleccionada en base al index
            }
        }

        private void btnvolver3_Click(object sender, EventArgs e) 
        {
            Guardar();

            // Vuelvo al menu 
            this.Hide(); 
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // Verifico que haya una celda seleccionada
            if (this.dgvCursos.SelectedRows.Count == 1)
            {
                // Defino el índice de la fila 
                int fila_seleccionada = dgvCursos.CurrentRow.Index;
                // Cargo los textbox con los datos de la fila seleccionada y en las celdas correspondientes
                txtCursoNombre.Text = dgvCursos.Rows[fila_seleccionada].Cells[0].Value.ToString();
                cmbProfesor.Text = dgvCursos.Rows[fila_seleccionada].Cells[1].Value.ToString();
                cmbMateria.Text = dgvCursos.Rows[fila_seleccionada].Cells[2].Value.ToString();
            }
        }

        private void Guardar()
        {
            // COMIENZO Guardar Curso
            FileStream fs1 = new FileStream("Curso.txt", FileMode.Create, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs1))
            {
                // Recorro todas las filas del datagridview
                foreach (DataGridViewRow row in dgvCursos.Rows)
                {
                    writer.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}, {row.Cells[3].Value}"); // Escribo en el archivo el contenido de cada celda
                }
            }
            fs1.Close();
            // FIN Guardar Curso 
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Guardar();
        }

        private void CargarProfesores() // Metodo para cargar el contenido del archivo al cmb 
        {
            // COMIENZO Lectura del archivo Profesores
            // Abrimos el archivo en modo lectura
            FileStream fs3 = new FileStream("Profesores.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leemos linea por línea y, por cada linea, cargamos en el datagridview
            using (StreamReader reader = new StreamReader(fs3))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    // Reconstruyo el objeto a partir de los datos levantados del archivo
                    string datos = linea;

                    // Este metodo crea una nueva string para mostrar en el cmb sin el . de los profesores
                    datos = string.Join("", datos.Split('.'));

                    cmbProfesor.Items.Add(datos); // Agrego al ComboBox cada linea

                    linea = reader.ReadLine();
                }
            }
            // Cerramos el archivo
            fs3.Close();
            // FIN Lectura del archivo Profesores
        }
        private void CargarMaterias() // Metodo para cargar el contenido del archivo al cmb
        {
            // COMIENZO Lectura del archivo Materias
            // Abrimos el archivo en modo lectura
            FileStream fs4 = new FileStream("Materias.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leemos linea por línea y, por cada linea, cargamos en el datagridview
            using (StreamReader reader = new StreamReader(fs4))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    // Reconstruyo el objeto a partir de los datos levantados del archivo
                    string datos = linea;

                    cmbMateria.Items.Add(datos); // Agrego al ComboBox cada linea

                    linea = reader.ReadLine();
                }
            }
            // Cerramos el arcivo
            fs4.Close();
            // FIN Lectura del archivo Materias
        }
    }
}
