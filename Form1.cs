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
                MessageBox.Show($"Error al validar usuario: Verificar DNI o Contraseña esten correctamente escritos");
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

            var Ingreso_User = new HttpClient();

            Ingreso_User.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ob_JsonRespuesta.token);
            var response2 = await Ingreso_User.PostAsync("http://localhost:5269/api/Usuario/ValUser", content);
            var test_User = await response2.Content.ReadAsStringAsync();

            // Verificar si la respuesta de la API es nula o vacía
            if (string.IsNullOrEmpty(test_User))
            {
                MessageBox.Show("La respuesta de la API es nula o vacía.");
            }
            else
            {
                try
                {
                    // Deserializar el JSON si es necesario para convertirlo en el mensaje 
                    var jsonResponse = JsonConvert.DeserializeObject<dynamic>(test_User);

                    // va a mostrar lo del mensaje 
                    if (jsonResponse.mensaje != null)
                    {
                        int testUserInt;
                        // Intenta convertir el valor de "mensaje" a un número entero
                        if (int.TryParse(jsonResponse.mensaje.ToString(), out testUserInt))
                        {
                            switch (testUserInt)//switch para las condificones al deserializar el mensaje
                            {
                                case 0:
                                    if (ob_JsonRespuesta != null)
                                    {
                                        ValidarAsistencia vAsistencia = new ValidarAsistencia();
                                        // Mostrar el nuevo formulario
                                        vAsistencia.Show();
                                        this.Hide(); // O bien this.Close();
                                    }
                                    break;
                                case 1:
                                    if (ob_JsonRespuesta != null)
                                    {
                                        // Crear una instancia del nuevo formulario al que deseas redirigir
                                        VistaAdmin vAsistencia = new VistaAdmin();


                                        // Mostrar el nuevo formulario
                                        vAsistencia.Show();
                                        // Ocultar o cerrar el formulario actual, si es necesario
                                        this.Hide(); // O bien this.Close();
                                    }
                                    break;
                                default:
                                    MessageBox.Show($"Respuesta inesperada: {testUserInt}");
                                    break;

                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor de test_User no se puede convertir a un número.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Respuesta inesperada del servidor.");
                    }
                }
                catch (Exception ex)
                {
                    // Maneja cualquier otro error inesperado
                    MessageBox.Show($"Ocurrió un error al procesar la respuesta: {ex.Message}");
                }
            }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}