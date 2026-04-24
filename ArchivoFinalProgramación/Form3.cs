using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ArchivoFinalProgramación
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            cargarProfes(); // Funcion para llenar el ComboBox con los datos del archivo 
            CargaMaterias(); // Función para llenar el ComboBox con los datos del archivo
            cargarAlumnos();//Funcion para llenar el ComboBox con los datos del archivo

            // Abrimos el archivo en modo lectura
            FileStream fs1 = new FileStream("Alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);
            fs1.Close();
           
            // Abrimos el archivo en modo lectura
            FileStream fs5 = new FileStream("Curso.txt", FileMode.OpenOrCreate, FileAccess.Read);
            fs5.Close();

        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            //entero para el numero de filas en el gridview
            int l;

            // Valido que ninguna cadena este vacia
            if (cmbCargados.Text != "")
            {
                
                //incializo las variables
                string nombre;
                string apellido;
                string DNI;

                // Spliteo los profesores con un punto para por diferenciarlos a la hora de pasarlo al datagridview
                string[] datos = cmbCargados.Text.Split(',');

                nombre = datos[0];
                apellido = datos[1];
                DNI = datos[2];

                // Adicionamos nuevo renglon
                l = dgvAlumnos.Rows.Add();


                // Colocamos la informacion en el datagridview
                dgvAlumnos.Rows[l].Cells[0].Value = nombre;

                dgvAlumnos.Rows[l].Cells[1].Value = apellido;

                dgvAlumnos.Rows[l].Cells[2].Value = DNI;

                lblError1.Text = "";
                txtNombreAlumno.Text = "";
                txtApellidoAlumno.Text = "";
                txtDniAlumno.Text = "";
                cmbCargados.Text = "";
            }
            else if (txtNombreAlumno.Text == "" || txtApellidoAlumno.Text == "" || txtDniAlumno.Text == "")
            {
                lblError1.Text = "Error: Uno o varios espacios estan vacios";
            }
            else
            {
                // Adicionamos nuevo renglon
                l = dgvAlumnos.Rows.Add();

                // Colocamos la informacion que se encuentra actualmente en el datagridview
                dgvAlumnos.Rows[l].Cells[0].Value = txtNombreAlumno.Text;

                dgvAlumnos.Rows[l].Cells[1].Value = txtApellidoAlumno.Text;

                dgvAlumnos.Rows[l].Cells[2].Value = txtDniAlumno.Text;

                lblError1.Text = "";
                txtNombreAlumno.Text = "";
                txtApellidoAlumno.Text = "";
                txtDniAlumno.Text = "";
                cmbCargados.Text = "";
            }
        }

        private void btnvolver2_Click(object sender, EventArgs e) // Vuelvo al menu y cargo el archivo
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvAlumnos.SelectedRows.Count == 1)
            {
                // Defino el índice de la fila 
                int fila_seleccionada = dgvAlumnos.CurrentRow.Index;
                // Cargo los textbox con los datos de la fila seleccionada y en las celdas correspondientes
                txtNombreAlumno.Text = dgvAlumnos.Rows[fila_seleccionada].Cells[0].Value.ToString();
                txtApellidoAlumno.Text = dgvAlumnos.Rows[fila_seleccionada].Cells[1].Value.ToString();
                txtDniAlumno.Text = dgvAlumnos.Rows[fila_seleccionada].Cells[2].Value.ToString();
            }
        }
        private void btnModificarAlumnos_Click(object sender, EventArgs e)
        {
            // Verifico que haya una celda seleccionada
            if (this.dgvAlumnos.SelectedRows.Count == 1)
            {
                // Cargo los datos que hay actualmente en los txt a el datagridview
                int fila_seleccionada = dgvAlumnos.CurrentRow.Index;
                dgvAlumnos.Rows[fila_seleccionada].Cells[0].Value = txtNombreAlumno.Text;
                dgvAlumnos.Rows[fila_seleccionada].Cells[1].Value = txtApellidoAlumno.Text;
                dgvAlumnos.Rows[fila_seleccionada].Cells[2].Value = txtDniAlumno.Text;
                txtNombreAlumno.Text = "";
                txtApellidoAlumno.Text = "";
                txtDniAlumno.Text = "";
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifico que haya una celda seleccionada
            if (dgvAlumnos.CurrentRow.Index > -1)
            {
                dgvAlumnos.Rows.RemoveAt(dgvAlumnos.CurrentRow.Index); // RemoveAt borra la seleccionada en base al index
                txtNombreAlumno.Text = "";
                txtApellidoAlumno.Text = "";
                txtDniAlumno.Text = "";
            }
        }

        private void btnBorrarCmb_Click(object sender, EventArgs e)
        {
            cmbCargados.Text = "";
        }


        // Metodo guardar
        private void Guardar2()
        {
            // COMIENZO Guardar Alumnos
            FileStream fs1 = new FileStream("Alumnos.txt", FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs1))
            {
                foreach (DataGridViewRow row in dgvAlumnos.Rows) // Recorro todas las filas del datagridview
                {
                    writer.WriteLine($"{row.Cells[0].Value}, {row.Cells[1].Value}, {row.Cells[2].Value}"); // Escribo en el archivo el contenido de cada celda
                }
            }
            fs1.Close();
            // FIN Guardar Alumnos
        }

        private void cargarProfes() // Metodo cargar profesores al ComboBox
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
            // Cerramos el arcivo
            fs3.Close();
            // FIN Lectura del archivo Profesores
        }
        private void CargaMaterias() // Metodo cargar materias al ComboBox
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
        private void cargarAlumnos() // Metodo cargar materias al ComboBox
        {
            // COMIENZO Lectura del archivo Materias
            // Abrimos el archivo en modo lectura
            FileStream fs1 = new FileStream("Alumnos.txt", FileMode.OpenOrCreate, FileAccess.Read);

            // Leemos linea por línea y, por cada linea, cargamos en el datagridview
            using (StreamReader reader = new StreamReader(fs1))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    // Reconstruyo el objeto a partir de los datos levantados del archivo
                    string datos = linea;

                    cmbCargados.Items.Add(datos); // Agrego al ComboBox cada linea

                    linea = reader.ReadLine();
                }
            }
            // Cerramos el arcivo
            fs1.Close();
            // FIN Lectura del archivo Materias
        }
        private void txtDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solamente se permite el ingreso de números
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        { 
            // COMIENZO Carga Curso 
            // Chequeo que todas las casillas estén completas, para cargar correctamente los datos en el archivo
            if(txtCurso.Text == ""||cmbMateria.Text == "" || cmbProfesor.Text == ""||dgvAlumnos.Rows.Count == 0)
            {
                lblError1.Text = ("Lo sentimos faltan datos por cargar");
            }
            else
            {
                // Abrimos el archivo en modo escritura al final del archivo (Append para escribir al final)
                FileStream fs5 = new FileStream("Curso.txt", FileMode.Append, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(fs5))
                {
                    // Agregamos al archivo cursos la siguiente cadena
                    writer.Write($"{txtCurso.Text}, {cmbProfesor.Text}, {cmbMateria.Text},");

                    foreach (DataGridViewRow row in dgvAlumnos.Rows) // Recorro todas las filas del datagridview
                    {
                        // Concatenamos con la cadena anterior todos los alumnos correspondientes a cada curso
                        writer.Write($" {row.Cells[0].Value} {row.Cells[1].Value} DNI:{row.Cells[2].Value} -"); // Escribo en el archivo el contenido de cada celda
                    }

                    writer.Write(Environment.NewLine);

                }
                fs5.Close();
                // FIN Carga Curso

                // Invocamos función para guardar los alumnos totales
                Guardar2();
                dgvAlumnos.Rows.Clear();
                txtCurso.Text = "";
                cmbMateria.Text = "";
                cmbProfesor.Text = "";
                lblError1.Text = "";
            }
        }

    }
}