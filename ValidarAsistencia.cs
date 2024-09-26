using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ControlAsistencias.Form1;

namespace ControlAsistencias
{
    public partial class ValidarAsistencia : Form
    {
        public ValidarAsistencia()
        {
            InitializeComponent();
        }

        public class VdUser
        {
            public int ID_PRACTICANTE { get; set; }


        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var obJsonRespuesta = SharedData.ObJsonRespuesta;

            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var asistenciaUser = new HttpClient();
            asistenciaUser.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);

            // Crear el objeto para registrar asistencia y convertirlo a JSON
            VdUser obasist = new VdUser() { ID_PRACTICANTE = SharedData.obDNI };
            var content1 = new StringContent(JsonConvert.SerializeObject(obasist), Encoding.UTF8, "application/json");

            // Hacer la solicitud POST a la API de asistencia
            var response = await asistenciaUser.PostAsync("http://localhost:7266/api/MarcarAsistencia/MrcAsistencia", content1);

            // Leer el contenido de la respuesta
            var test = await response.Content.ReadAsStringAsync();

            // Verificar si el contenido de la respuesta es nulo o vacío
            if (string.IsNullOrEmpty(test))
            {
                MessageBox.Show("La respuesta de la API es nula o vacía.");
            }
            else
            {
                // Procesar la respuesta recibida
                MessageBox.Show($"Respuesta de la API recibida: {test}");
            }

        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario al que deseas redirigir
            Form1 frLogin = new Form1();
            this.Close();
            // Mostrar el login formulario
            frLogin.Show();

        }
    }
}
