using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var obJsonRespuesta = SharedData.ObJsonRespuesta;
            var objDNI = SharedData.obDNI;

            var asistenciaUser = new HttpClient();
        }
    }
}
