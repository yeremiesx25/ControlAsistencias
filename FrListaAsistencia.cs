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

namespace ControlAsistencias
{
    public partial class FrListaAsistencia : Form
    {
        public FrListaAsistencia()
        {
            InitializeComponent();
        }

        public class Asistencia
        {
            public int Contador { get; set; }
            public int ID_PRACTICANTE { get; set; }
            public string NOMBRES { get; set; }
            public string APELLIDOS { get; set; }
            public DateTime FECHA { get; set; }
            public DateTime ENTRADA { get; set; }
            public DateTime SALIDA { get; set; }


            public string DIAS => Contador.ToString();
            public string DNI => ID_PRACTICANTE.ToString();
            public string HoraEntrada => ENTRADA.ToString("HH:mm tt");
            public string HoraSalida => SALIDA.ToString("HH:mm tt");
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
            var response = await ListaPracticantes.GetAsync("http://localhost:5269/api/MarcarAsistencia/MsAsistencia");

            var jsonResponse = await response.Content.ReadAsStringAsync();

            // Verificar si el contenido de la respuesta es nulo o vacío
            if (string.IsNullOrEmpty(jsonResponse))
            {
                MessageBox.Show("La respuesta de la API es nula o vacía.");
            }
            else
            {
                // Deserializar la respuesta en un objeto
                var resultado = JsonConvert.DeserializeObject<ResponseModel<List<Asistencia>>>(jsonResponse);

                if (resultado != null && resultado.response != null)
                {
                    // Asignar la lista al DataGridView
                    dataGridView1.DataSource = resultado.response.Select(a => new
                    {
                        a.DIAS,
                        a.DNI,
                        a.NOMBRES,
                        a.APELLIDOS,
                        a.FECHA,
                        HoraEntrada = a.HoraEntrada,
                        HoraSalida = a.HoraSalida
                    }).ToList();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de usuarios.");
                }
            }
        }


        private async void btn_buscar_Click(object sender, EventArgs e)
        {
            //obtner el JSON
            var obJsonRespuesta = SharedData.ObJsonRespuesta;
            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var BusquedaListaPracticante = new HttpClient();
            BusquedaListaPracticante.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);
            string dniText = txt_buscar.Text;
            int obtUsuario;
            if (!int.TryParse(dniText, out obtUsuario))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return;
            }
            else
            {
                Asistencia objNewPracticante = new Asistencia()
                {
                    ID_PRACTICANTE = obtUsuario
                };
                var content2 = new StringContent(JsonConvert.SerializeObject(objNewPracticante), Encoding.UTF8, "application/json");

                // Hacer la solicitud POST a la API de asistencia
                var response = await BusquedaListaPracticante.PostAsync("http://localhost:5269/api/MarcarAsistencia/FilterAsistencia", content2);

                // Leer la respuesta
                var test = await response.Content.ReadAsStringAsync();
                if (string.IsNullOrEmpty(test))
                {
                    MessageBox.Show("La respuesta de la API es nula o vacía.");
                }
                else
                {
                    // Deserializar la respuesta en un objeto
                    var resultado = JsonConvert.DeserializeObject<ResponseModel<List<Asistencia>>>(test);

                    if (resultado != null && resultado.response != null)
                    {
                        // Asignar la lista al DataGridView
                        dataGridView1.DataSource = resultado.response.Select(a => new
                        {
                            a.DIAS,
                            a.DNI,
                            a.NOMBRES,
                            a.APELLIDOS,
                            a.FECHA,
                            HoraEntrada = a.HoraEntrada,
                            HoraSalida = a.HoraSalida
                        }).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener la lista de usuarios.");
                    }
                }
            }
        }

        private void FrListaAsistencia_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
