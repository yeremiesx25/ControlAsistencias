﻿using Newtonsoft.Json;
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
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        public class NewUser
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

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            var obJsonRespuesta = SharedData.ObJsonRespuesta;

            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var newUser = new HttpClient();
            newUser.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);

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
            NewUser objNewPracticante = new NewUser()
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
            var response = await newUser.PostAsync("http://localhost:7266/api/Usuario/CrearUsuario", content2);

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
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
