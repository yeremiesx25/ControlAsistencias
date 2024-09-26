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

//using de questPDF
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using static ControlAsistencias.FrListaPracticantes;
using static ControlAsistencias.FrListaAsistencia;

namespace ControlAsistencias
{
    public partial class FrListaAsistencia : Form
    {
        public FrListaAsistencia()
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
            public string universidad { get; set; }
            public string departamento { get; set; }
        }
        public class ApiResponse
        {
            public string Mensaje { get; set; }
            public List<usuario> Response { get; set; }
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
            var response = await ListaPracticantes.GetAsync("http://localhost:7266/api/MarcarAsistencia/MsAsistencia");

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
                var response = await BusquedaListaPracticante.PostAsync("http://localhost:7266/api/MarcarAsistencia/FilterAsistencia", content2);

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

        private async void button1_Click(object sender, EventArgs e)
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
                var response = await BusquedaListaPracticante.PostAsync("http://localhost:7266/api/MarcarAsistencia/FilterAsistencia", content2);

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
                        // Asignar la lista al DataGridView2
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

            // Configurar HttpClient y añadir la autorización antes de hacer la solicitud
            var BusquedaPracticante = new HttpClient();
            BusquedaPracticante.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", obJsonRespuesta.token);

            usuario objBusqueda = new usuario()
            {
                DNI = obtUsuario,
                Apellidos = ""
            };

            var contentBs = new StringContent(JsonConvert.SerializeObject(objBusqueda), Encoding.UTF8, "application/json");

            // Hacer la solicitud POST a la API de asistencia
            var responseBus = await BusquedaPracticante.PostAsync("http://localhost:7266/api/Usuario/FilterUsuario", contentBs);

            // Leer la respuesta
            var jsonResponse = await responseBus.Content.ReadAsStringAsync();

            // Deserializar el JSON a un objeto de tipo UsuarioResponse
            ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

            string universidad = apiResponse.Response[0].universidad;
            string departamento = apiResponse.Response[0].departamento;



            var document = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);

                    //cabezara de Pagina
                    page.Header().Row(row =>
                    {

                        row.ConstantItem(100).Height(100).Image("C:/Users/YEREMIES/source/repos/ControlAsistencias/Images/LogoParaPdf.PNG");

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text("HOSPITAL").Bold().FontSize(25);
                            col.Item().AlignCenter().Text("REGIONAL DE ICA").Bold().FontSize(25);
                        });

                        row.ConstantItem(100).Height(100).Image("C:/Users/YEREMIES/source/repos/ControlAsistencias/Images/LogoParaPdf.PNG");
                    });

                    page.Content().Column(col1 => 
                    {
                        usuario exUser = new usuario();
                        col1.Item().Text("");
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                        string dni = selectedRow.Cells["DNI"].Value.ToString();
                        string nombre = selectedRow.Cells["NOMBRES"].Value.ToString();
                        string apellidos = selectedRow.Cells["APELLIDOS"].Value.ToString();
                        col1.Item().Text($"DNI: {dni}").Bold().FontSize(12);
                        col1.Item().Text($"NOMBRES Y APELLIDOS: {nombre.ToUpper()} {apellidos.ToUpper()}").Bold().FontSize(12);
                        col1.Item().Text($"UNIVERSIDAD: {universidad.ToUpper()}").Bold().FontSize(12);
                        col1.Item().Text($"UNIDAD: {departamento.ToUpper()}").Bold().FontSize(12);
                        col1.Spacing(3);
                        col1.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                                columns.RelativeColumn(2);
                            });//cerrar tabla columns
                            tabla.Header(header =>
                            {
                                header.Cell().Border(1).Background("#4A2364").Padding(2).AlignCenter().Text("DIAS").FontColor(Colors.White);
                                header.Cell().Border(1).Background("#4A2364").Padding(2).AlignCenter().Text("FECHA").FontColor(Colors.White);
                                header.Cell().Border(1).Background("#4A2364").Padding(2).AlignCenter().Text("HORA DE ENTRADA").FontColor(Colors.White);
                                header.Cell().Border(1).Background("#4A2364").Padding(2).AlignCenter().Text("HORA DE SALIDA").FontColor(Colors.White);
                            });//cerrar tabla header

                            foreach (DataGridViewRow row in dataGridView1.Rows) 
                            {
                                string dias = row.Cells["DIAS"].Value.ToString();
                                //concertir la fecha
                                string fechaOriginal = row.Cells["FECHA"].Value.ToString();
                                DateTime fechaConvertida = DateTime.Parse(fechaOriginal);
                                string fechaFormateada = fechaConvertida.ToString("dd/MM/yyyy");
                                //mostrar los horarios
                                string entrada = row.Cells["HoraEntrada"].Value.ToString();
                                string salida = row.Cells["HoraSalida"].Value.ToString();
                                tabla.Cell().Border(1).Padding(2).AlignCenter().Text(dias).FontSize(12);
                                tabla.Cell().Border(1).Padding(2).AlignCenter().Text(fechaFormateada).FontSize(12);
                                tabla.Cell().Border(1).Padding(2).AlignCenter().Text(entrada).FontSize(12);
                                tabla.Cell().Border(1).Padding(2).AlignCenter().Text(salida).FontSize(12);
                            }//cierra el foreach

                            //dar un espaciado
                            col1.Item().Height(100);

                            //mostrar las firmas
                            col1.Item().Row(rowFirma =>
                            {
                                rowFirma.RelativeItem(100).Height(100).Padding(10).Column(colFirma =>
                                {
                                    colFirma.Item().LineHorizontal(0.5f);
                                    colFirma.Item().AlignCenter().Text("LIC. MARIN AYBAR VALENCIA ").Bold().FontSize(12);
                                });//cerrar colFirma
                                rowFirma.RelativeItem(100).Height(100).Padding(10).Column(colFirma =>
                                {
                                    colFirma.Item().LineHorizontal(0.5f);
                                    colFirma.Item().AlignCenter().Text("ING. ROMMY MUÑOZ DE LA CRUZ").Bold().FontSize(12);
                                });//cerrar colFirma
                                rowFirma.RelativeItem(100).Height(100).Padding(10).Column(colFirma =>
                                {
                                    colFirma.Item().LineHorizontal(0.5f);
                                    colFirma.Item().AlignCenter().Text($"PRAC. {nombre} {apellidos}").Bold().FontSize(12);
                                });//cerrar colFirma
                            });//cerrar rowFirma
                        });//cerrar col1
                    });//cerrar page intermedio

                    //page.Content().Element(CreateContent);

                    page.Footer().AlignRight().Text(x =>
                    {
                        x.Span("Pagina ");
                        x.CurrentPageNumber();
                        x.Span(" de ");
                        x.TotalPages();

                    });
                });
            });

            // Guarda el PDF
            document.GeneratePdf("practicantes_report.pdf");
            // Obtener la ruta de la carpeta Descargas del usuario
            string rutaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            // Definir el nombre del archivo PDF
            //llamar el data para el nombre
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string nombre = selectedRow.Cells["NOMBRES"].Value.ToString();//columnas
            string apellidos = selectedRow.Cells["APELLIDOS"].Value.ToString();//columnas
            //almacenar el nombre
            string nombreArchivo = $"Practicas {nombre} {apellidos}.pdf";
            //path combine es para la ruta
            string rutaArchivo2 = Path.Combine(rutaDescargas, nombreArchivo);
            //genera el archivo
            document.GeneratePdf(rutaArchivo2);
            // Abrir el PDF automáticamente
            string rutaArchivo = "practicantes_report.pdf";
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = rutaArchivo2,
                UseShellExecute = true // Esto asegura que se utilice el programa predeterminado para abrir el PDF
            });
        }

        void CreateContent(QuestPDF.Infrastructure.IContainer container )
        {
            container.Padding(10).Column(column =>
            {
                column.Spacing(5);

                column.Item().Text("Listado de Practicantes:");

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string dni = row.Cells["DNI"].Value.ToString();
                    string nombre = row.Cells["NOMBRES"].Value.ToString();
                    column.Item().Text($": {dni} - : {nombre}");
                }
            });
        }
    }
}
