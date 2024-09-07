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
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);
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

        public static class MandarUsuario
        {
            public static int DNI_e { get; set; }
            public static string CONTRASENA_e { get; set; }
            public static string Nombres_e { get; set; }
            public static string Apellidos_e { get; set; }
            public static string Email_e { get; set; }
            public static string Telefono_e { get; set; }
            public static DateTime InicioDePracticas_e { get; set; }
            public static string Universidad_e { get; set; }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                MandarUsuario.DNI_e = selectedRow.Cells["DNI"].Value != null ? Convert.ToInt32(selectedRow.Cells["DNI"].Value) : 0;
                MandarUsuario.CONTRASENA_e = selectedRow.Cells["CONTRASENA"].Value?.ToString() ?? string.Empty;
                MandarUsuario.Nombres_e = selectedRow.Cells["Nombres"].Value?.ToString() ?? string.Empty;
                MandarUsuario.Apellidos_e = selectedRow.Cells["Apellidos"].Value?.ToString() ?? string.Empty;
                MandarUsuario.Email_e = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
                MandarUsuario.Telefono_e = selectedRow.Cells["Telefono"].Value?.ToString() ?? string.Empty;
                MandarUsuario.Universidad_e = selectedRow.Cells["Universidad"].Value?.ToString() ?? string.Empty;
            }
        }


        private void btn_EditPracticante_Click(object sender, EventArgs e)
        {
            this.Close();
            FrEditarPracticante abrirEditarPracticante = new FrEditarPracticante();
            abrirEditarPracticante.Show();
        }
    }
}
