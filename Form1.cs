using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ControlAsistencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //enviar el cuerpo a validar el DNI y la CONTRASENA
        public class ValidateUsuario
        {
            public int DNI { get; set; }
            public string CONTRASENA { get; set; }
        }
        //RESPUESTA DEL TOKEN STRING
        public class RespuestaToken
        {
            public string token { get; set; }
        }

        public static class SharedData
        {
            public static RespuestaToken ObJsonRespuesta { get; set; }
            public static int obDNI { get; set; }
            public static ValidateUsuario obCONTRASENA { get; set; }
        }


        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var asistente = new HttpClient();

            // Obtener el texto de los TextBox
            string dniText = txt_user.Text;
            string passwordText = txt_password.Text;

            // Convertir el DNI a un entero
            int obtUsuario;
            if (!int.TryParse(dniText, out obtUsuario))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return;
            }

            ValidateUsuario ob_usuario = new ValidateUsuario
            {
                DNI = obtUsuario,
                CONTRASENA = passwordText
            };

            // Convertir en formato JSON
            var content = new StringContent(JsonConvert.SerializeObject(ob_usuario), Encoding.UTF8, "application/json");

            // Mandar a la URL el formato JSON
            var response = await asistente.PostAsync("http://localhost:5269/api/Autentication/Validar", content);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Error al validar usuario: {response.StatusCode}");
                return;
            }

            var json_response = await response.Content.ReadAsStringAsync();
            var ob_JsonRespuesta = JsonConvert.DeserializeObject<RespuestaToken>(json_response);

            if (ob_JsonRespuesta == null || string.IsNullOrEmpty(ob_JsonRespuesta.token))
            {
                MessageBox.Show("Token de autenticación no válido o no recibido.");
                return;
            }


            SharedData.ObJsonRespuesta = ob_JsonRespuesta;

            SharedData.obDNI = obtUsuario;

            if (ob_JsonRespuesta != null)
            {
                // Crear una instancia del nuevo formulario al que deseas redirigir
                ValidarAsistencia vAsistencia = new ValidarAsistencia();


                // Mostrar el nuevo formulario
                vAsistencia.Show();
                // Ocultar o cerrar el formulario actual, si es necesario
                this.Hide(); // O bien this.Close();
            }

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}