namespace ControlAsistencias
{
    partial class VistaAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdmin));
            PANEL_PRINCIPAL = new Panel();
            P_principal = new Panel();
            p_List = new Panel();
            btn_practicantes = new Button();
            btn_asistencia = new Button();
            btn_editarUsuario = new Button();
            button5 = new Button();
            panel5 = new Panel();
            btn_Salir = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            PANEL_PRINCIPAL.SuspendLayout();
            p_List.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // PANEL_PRINCIPAL
            // 
            PANEL_PRINCIPAL.BackColor = SystemColors.ControlLightLight;
            PANEL_PRINCIPAL.BackgroundImage = Properties.Resources.logoInicio;
            PANEL_PRINCIPAL.BackgroundImageLayout = ImageLayout.Stretch;
            PANEL_PRINCIPAL.Controls.Add(P_principal);
            PANEL_PRINCIPAL.Controls.Add(p_List);
            PANEL_PRINCIPAL.Dock = DockStyle.Fill;
            PANEL_PRINCIPAL.Location = new Point(0, 0);
            PANEL_PRINCIPAL.Name = "PANEL_PRINCIPAL";
            PANEL_PRINCIPAL.Size = new Size(800, 450);
            PANEL_PRINCIPAL.TabIndex = 3;
            // 
            // P_principal
            // 
            P_principal.BackColor = SystemColors.ControlLightLight;
            P_principal.BackgroundImage = Properties.Resources.logoInicio;
            P_principal.BackgroundImageLayout = ImageLayout.Stretch;
            P_principal.Dock = DockStyle.Fill;
            P_principal.Location = new Point(219, 0);
            P_principal.Name = "P_principal";
            P_principal.Size = new Size(581, 450);
            P_principal.TabIndex = 42;
            // 
            // p_List
            // 
            p_List.BackColor = Color.Purple;
            p_List.Controls.Add(btn_practicantes);
            p_List.Controls.Add(btn_asistencia);
            p_List.Controls.Add(btn_editarUsuario);
            p_List.Controls.Add(button5);
            p_List.Controls.Add(panel5);
            p_List.Dock = DockStyle.Left;
            p_List.Location = new Point(0, 0);
            p_List.Name = "p_List";
            p_List.Size = new Size(219, 450);
            p_List.TabIndex = 41;
            // 
            // btn_practicantes
            // 
            btn_practicantes.BackColor = Color.Transparent;
            btn_practicantes.BackgroundImageLayout = ImageLayout.None;
            btn_practicantes.FlatAppearance.BorderSize = 0;
            btn_practicantes.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_practicantes.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_practicantes.FlatStyle = FlatStyle.Flat;
            btn_practicantes.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_practicantes.ForeColor = Color.White;
            btn_practicantes.Image = (Image)resources.GetObject("btn_practicantes.Image");
            btn_practicantes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_practicantes.Location = new Point(0, 253);
            btn_practicantes.Name = "btn_practicantes";
            btn_practicantes.RightToLeft = RightToLeft.Yes;
            btn_practicantes.Size = new Size(219, 49);
            btn_practicantes.TabIndex = 35;
            btn_practicantes.Text = "PRACTICANTES";
            btn_practicantes.TextAlign = ContentAlignment.MiddleRight;
            btn_practicantes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_practicantes.UseVisualStyleBackColor = false;
            // 
            // btn_asistencia
            // 
            btn_asistencia.BackColor = Color.Transparent;
            btn_asistencia.BackgroundImageLayout = ImageLayout.None;
            btn_asistencia.FlatAppearance.BorderSize = 0;
            btn_asistencia.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_asistencia.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_asistencia.FlatStyle = FlatStyle.Flat;
            btn_asistencia.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_asistencia.ForeColor = Color.White;
            btn_asistencia.Image = (Image)resources.GetObject("btn_asistencia.Image");
            btn_asistencia.ImageAlign = ContentAlignment.MiddleLeft;
            btn_asistencia.Location = new Point(0, 201);
            btn_asistencia.Name = "btn_asistencia";
            btn_asistencia.RightToLeft = RightToLeft.Yes;
            btn_asistencia.Size = new Size(219, 49);
            btn_asistencia.TabIndex = 34;
            btn_asistencia.Text = "ASISTENCIA";
            btn_asistencia.TextAlign = ContentAlignment.MiddleRight;
            btn_asistencia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_asistencia.UseVisualStyleBackColor = false;
            // 
            // btn_editarUsuario
            // 
            btn_editarUsuario.BackColor = Color.Transparent;
            btn_editarUsuario.BackgroundImageLayout = ImageLayout.None;
            btn_editarUsuario.FlatAppearance.BorderSize = 0;
            btn_editarUsuario.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_editarUsuario.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_editarUsuario.FlatStyle = FlatStyle.Flat;
            btn_editarUsuario.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_editarUsuario.ForeColor = Color.White;
            btn_editarUsuario.Image = (Image)resources.GetObject("btn_editarUsuario.Image");
            btn_editarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editarUsuario.Location = new Point(0, 153);
            btn_editarUsuario.Name = "btn_editarUsuario";
            btn_editarUsuario.RightToLeft = RightToLeft.Yes;
            btn_editarUsuario.Size = new Size(219, 49);
            btn_editarUsuario.TabIndex = 33;
            btn_editarUsuario.Text = "EDITAR USUARIO";
            btn_editarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btn_editarUsuario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_editarUsuario.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 101);
            button5.Name = "button5";
            button5.RightToLeft = RightToLeft.Yes;
            button5.Size = new Size(219, 49);
            button5.TabIndex = 32;
            button5.Text = "CREAR USUARIO";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.TextBeforeImage;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_Salir);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 100);
            panel5.TabIndex = 2;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = Color.Transparent;
            btn_Salir.BackgroundImage = (Image)resources.GetObject("btn_Salir.BackgroundImage");
            btn_Salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Salir.FlatAppearance.BorderSize = 0;
            btn_Salir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_Salir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Salir.FlatStyle = FlatStyle.Flat;
            btn_Salir.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Salir.ForeColor = Color.White;
            btn_Salir.Location = new Point(3, 0);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.RightToLeft = RightToLeft.No;
            btn_Salir.Size = new Size(96, 100);
            btn_Salir.TabIndex = 48;
            btn_Salir.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(219, 49);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(247, 50);
            panel7.TabIndex = 2;
            // 
            // VistaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PANEL_PRINCIPAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaAdmin";
            Text = "VistaAdmin";
            PANEL_PRINCIPAL.ResumeLayout(false);
            p_List.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PANEL_PRINCIPAL;
        private Panel p_List;
        private Button btn_practicantes;
        private Button btn_asistencia;
        private Button btn_editarUsuario;
        private Button button5;
        private Panel P_principal;
        private Panel panel5;
        private Button btn_Salir;
        private Panel panel6;
        private Panel panel7;
    }
}