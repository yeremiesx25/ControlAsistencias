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
        public class ValidateUsuario {
            public int DNI { get; set; }
            public string CONTRASENA { get; set; }
        }
        //RESPUESTA DEL TOKEN STRING
        public class RespuestaToken {
            public string token { get; set; }
        }


        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var asistente = new HttpClient();//llamado para almacenar en asistente el ingreso del http

            // Obtener el texto de los TextBox
            string dniText = txt_user.Text; // Obtener el DNI desde el TextBox txt_user
            string passwordText = txt_password.Text; // Obtener la contraseña desde el TextBox txt_password

            // Convertir el DNI a un entero
            int obtUsuario;
            if (!int.TryParse(dniText, out obtUsuario))
            {
                // Mostrar un mensaje de error si el DNI no es un número válido
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return; // Salir del método si hay un error
            }

            // Crear una instancia de ValidateUsuario con los valores obtenidos de los TextBox
            ValidateUsuario ob_usuario = new ValidateUsuario
            {
                DNI = obtUsuario, // Asignar el DNI convertido
                CONTRASENA = passwordText // Asignar la contraseña desde el TextBox
            };

            //convertir en formato json
            var content = new StringContent(JsonConvert.SerializeObject(ob_usuario),Encoding.UTF8,"application/json");
            //manda a la URL el formato JSON
            var response = await asistente.PostAsync("http://localhost:5269/api/Autentication/Validar", content);
            //obtener el key
            var json_response = await response.Content.ReadAsStringAsync();
            //convertir JSON a una clase
            var ob_JsonRespuesta = JsonConvert.DeserializeObject<RespuestaToken>(json_response);
        }
    }
}