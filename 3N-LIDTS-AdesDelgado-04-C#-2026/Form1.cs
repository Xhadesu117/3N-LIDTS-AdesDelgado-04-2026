using System;
using System.IO;
using System.Windows.Forms;

namespace _3N_LIDTS_AdesDelgado_04_C__2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellidos = txbApellidos.Text;
            string telefono = txbTelefono.Text;
            string edad = txbEdad.Text;
            string estatura = txbEstatura.Text;
            string genero = "";
            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbOtro.Checked)
            {
                genero = "Otro";
            }
            string mensaje = $" Nombre: {nombre}\n\r Apellidos: {apellidos}\n\r Telefono: {telefono}\n\r Edad: {edad}\n\r Estatura: {estatura}\n\r Genero: {genero}";
            // ruta de almacenamiento
            string rutaArchivo = "C:\\Users\\Shadow\\source\\repos\\3N-LIDTS-AdesDelgado-04-C#-2026\\3N-LIDTS-AdesDelgado-04-C#-2026\\3N-Formulario.txt";
            bool ArchivoExiste = File.Exists(rutaArchivo);
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    escritor.WriteLine();
                }
                escritor.WriteLine(mensaje);

            }
            MessageBox.Show(mensaje, "Confirmación de resgistro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbNombre.Clear();
            txbApellidos.Clear();
            txbTelefono.Clear();
            txbEstatura.Clear();
            txbEdad.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtro.Checked = false;
        }
    }
}