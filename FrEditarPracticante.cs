using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControlAsistencias.Form1;
using static ControlAsistencias.FrListaPracticantes;

namespace ControlAsistencias
{
    public partial class FrEditarPracticante : Form
    {
        public FrEditarPracticante()
        {
            InitializeComponent();
        }

        public class EditUser
        {
            public int DNI { get; set; }
            public string CONTRASENA { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public int DepartmentID { get; set; }
            public int TipoDeUsuario { get; set; }
            public string Universidad { get; set; }
        }

        private async void CargarDatos()
        {
            var cargarDNI = MandarUsuario.DNI_e;
            var cargarContrasena = MandarUsuario.CONTRASENA_e;
            var cargarNombres = MandarUsuario.Nombres_e;
            var cargarApellidos = MandarUsuario.Apellidos_e;
            var cargarEmail = MandarUsuario.Email_e;
            var cargarTelefono = MandarUsuario.Telefono_e;
            var cargarUniversidad = MandarUsuario.Universidad_e;

            txt_DNI.Text = cargarDNI.ToString();
            txt_password.Text = cargarContrasena.ToString();
            txt_name.Text = cargarNombres.ToString();
            txt_lastname.Text = cargarApellidos.ToString();
            txt_email.Text = cargarEmail.ToString();
            txt_phone.Text = cargarTelefono.ToString();
            txt_Universidad.Text = cargarUniversidad.ToString();
        }

        private void FrEditarPracticante_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void btn_EditUser_Click(object sender, EventArgs e)
        {
            var obJsonRespuesta = SharedData.ObJsonRespuesta;

            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var EditUser = new HttpClient();
            EditUser.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);

            // Obtener el texto de los TextBox
            string dniText = txt_DNI.Text;
            string passwordText = txt_password.Text;
            string nombresText = txt_name.Text;
            string apellidosText = txt_lastname.Text;
            string emailText = txt_email.Text;
            string telefonoText = txt_phone.Text;
            string universidadText = txt_Universidad.Text;

            // Convertir el DNI a un entero
            int obtUsuario;
            if (!int.TryParse(dniText, out obtUsuario))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return;
            }

            //Crear el objeto para registrar asistencia y convertirlo a JSON 
            EditUser objNewPracticante = new EditUser()
            {
                DNI = obtUsuario,
                CONTRASENA = passwordText,
                Nombres = nombresText,
                Apellidos = apellidosText,
                Email = emailText,
                Telefono = telefonoText,
                DepartmentID = 1,
                TipoDeUsuario = 2,
                Universidad = universidadText
            };

            var content2 = new StringContent(JsonConvert.SerializeObject(objNewPracticante), Encoding.UTF8, "application/json");
            //Hacer la solicitud POST a la API de asistencia
            var response = await EditUser.PutAsync("http://localhost:7266/api/Usuario/EditarUsuario", content2);

            var test = await response.Content.ReadAsStringAsync();

            //Verificar si el contenido de la respuesta es nulo o vacío
            if (string.IsNullOrEmpty(test))
            {
                MessageBox.Show("La respuesta de la API es nula");
            }
            else
            {
                // Procesar la respuesta recibida
                MessageBox.Show($"Usuario: {test}");
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
