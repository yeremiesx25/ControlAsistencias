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
using static ControlAsistencias.CrearUsuario;
using static ControlAsistencias.Form1;

namespace ControlAsistencias
{
    public partial class FrListaPracticantes : Form
    {
        public FrListaPracticantes()
        {
            InitializeComponent();
        }

        public class usuario
        {
            public int DNI { get; set; }
            public string CONTRASENA { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Email { get; set; }
            public string Telefono { get; set; }
            public DateTime InicioDePracticas { get; set; }
            public string Universidad { get; set; }
        }

        public class ResponseModel<T>
        {
            public string mensaje { get; set; }
            public T response { get; set; }
        }


        private async void CargarDatos()
        {
            var obJsonRespuesta = SharedData.ObJsonRespuesta;

            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var ListaPracticantes = new HttpClient();
            ListaPracticantes.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);

            // Hacer la solicitud GET a la API de usuarios
            var response = await ListaPracticantes.GetAsync("http://localhost:5269/api/Usuario/MostrarUsuario");

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Verificar si el contenido de la respuesta es nulo o vacío
            if (string.IsNullOrEmpty(jsonResponse))
            {
                MessageBox.Show("La respuesta de la API es nula o vacía.");
            }
            else
            {
                // Deserializar la respuesta en un objeto
                var resultado = JsonConvert.DeserializeObject<ResponseModel<List<usuario>>>(jsonResponse);

                if (resultado != null && resultado.response != null)
                {
                    // Asignar la lista al DataGridView
                    dataGridView1.DataSource = resultado.response;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de usuarios.");
                }
            }
        }


        private void FrListaPracticantes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            //obtner el JSON
            var obJsonRespuesta = SharedData.ObJsonRespuesta;
            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var BusquedaPracticante = new HttpClient();
            BusquedaPracticante.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);
            string dniText = txt_buscar.Text;
            string apellidosText = txt_buscar.Text;
            int obtUsuario;
            if (!int.TryParse(dniText, out obtUsuario))
            {
                
                usuario objNewPracticante = new usuario()
                {
                    DNI = 0,
                    Apellidos = apellidosText,
                };
                var content2 = new StringContent(JsonConvert.SerializeObject(objNewPracticante), Encoding.UTF8, "application/json");

                // Hacer la solicitud POST a la API de asistencia
                var response = await BusquedaPracticante.PostAsync("http://localhost:5269/api/Usuario/FilterUsuario", content2);

                // Leer la respuesta
                var test = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(test))
                {
                    MessageBox.Show("La respuesta de la API es nula o vacía.");
                }
                else
                {
                    // Deserializar la respuesta en un objeto
                    var resultado = JsonConvert.DeserializeObject<ResponseModel<List<usuario>>>(test);

                    if (resultado != null && resultado.response != null)
                    {
                        // Asignar la lista al DataGridView
                        dataGridView1.DataSource = resultado.response;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener la lista de usuarios.");
                    }
                }
            }
            else 
            {
                usuario objNewPracticante = new usuario()
                {
                    DNI = obtUsuario,
                    Apellidos = "",
                };
                var content2 = new StringContent(JsonConvert.SerializeObject(objNewPracticante), Encoding.UTF8, "application/json");

                // Hacer la solicitud POST a la API de asistencia
                var response = await BusquedaPracticante.PostAsync("http://localhost:5269/api/Usuario/FilterUsuario", content2);

                // Leer la respuesta
                var test = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(test))
                {
                    MessageBox.Show("La respuesta de la API es nula o vacía.");
                }
                else
                {
                    // Deserializar la respuesta en un objeto
                    var resultado = JsonConvert.DeserializeObject<ResponseModel<List<usuario>>>(test);

                    if (resultado != null && resultado.response != null)
                    {
                        // Asignar la lista al DataGridView
                        dataGridView1.DataSource = resultado.response;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener la lista de usuarios.");
                    }
                }
            }
            
        }
    }
}
