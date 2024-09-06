using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAsistencias
{
    public partial class VistaAdmin : Form
    {
        public VistaAdmin()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.P_principal.Controls.Count > 0)
                this.P_principal.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.P_principal.Controls.Add(f);
            this.P_principal.Tag = f;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadForm(new CrearUsuario());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            VistaAdmin vsAd = new VistaAdmin();
            vsAd.Show();

        }

        private void btn_practicantes_Click(object sender, EventArgs e)
        {
            loadForm(new FrListaPracticantes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
