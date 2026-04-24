using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoFinalProgramación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Codigo simple de menu para mostrar los diferentes Forms 

        private void btnAgregarProfeYMateria_Click(object sender, EventArgs e) 
        {
            // Minimizo el menu y muestro el Form correspondiete
            this.Hide(); 
            Form2 frm = new Form2();
            frm.Show(); 
        }

        private void btnAgregarCursos_Click(object sender, EventArgs e) 
        {
            // Minimizo el menu y muestro el Form correspondiete
            this.Hide(); 
            Form3 frm = new Form3();
            frm.Show();  
        }

        private void btnVerYModificarCursosCargados_Click(object sender, EventArgs e) 
        {
            // Minimizo el menu y muestro el Form correspondiete
            this.Hide(); 
            Form4 frm = new Form4();
            frm.Show(); 
        }

        private void btnSalir_Click(object sender, EventArgs e) 
        {
            // Cierro la aplicacion 
            Application.Exit(); 
        }
    }
}
