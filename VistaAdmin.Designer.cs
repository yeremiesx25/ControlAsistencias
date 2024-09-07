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
            p_List = new Panel();
            button1 = new Button();
            btn_practicantes = new Button();
            btn_asistencia = new Button();
            button5 = new Button();
            panel5 = new Panel();
            btn_Salir = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            P_principal = new Panel();
            PANEL_PRINCIPAL = new Panel();
            p_List.SuspendLayout();
            panel5.SuspendLayout();
            PANEL_PRINCIPAL.SuspendLayout();
            SuspendLayout();
            // 
            // p_List
            // 
            p_List.BackColor = Color.Purple;
            p_List.Controls.Add(button1);
            p_List.Controls.Add(btn_practicantes);
            p_List.Controls.Add(btn_asistencia);
            p_List.Controls.Add(button5);
            p_List.Controls.Add(panel5);
            p_List.Dock = DockStyle.Left;
            p_List.Location = new Point(0, 0);
            p_List.Name = "p_List";
            p_List.Size = new Size(219, 450);
            p_List.TabIndex = 41;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 401);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(219, 49);
            button1.TabIndex = 36;
            button1.Text = "SALIR";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            btn_practicantes.Location = new Point(0, 208);
            btn_practicantes.Name = "btn_practicantes";
            btn_practicantes.RightToLeft = RightToLeft.Yes;
            btn_practicantes.Size = new Size(219, 49);
            btn_practicantes.TabIndex = 35;
            btn_practicantes.Text = "PRACTICANTES";
            btn_practicantes.TextAlign = ContentAlignment.MiddleRight;
            btn_practicantes.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_practicantes.UseVisualStyleBackColor = false;
            btn_practicantes.Click += btn_practicantes_Click;
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
            btn_asistencia.Location = new Point(0, 156);
            btn_asistencia.Name = "btn_asistencia";
            btn_asistencia.RightToLeft = RightToLeft.Yes;
            btn_asistencia.Size = new Size(219, 49);
            btn_asistencia.TabIndex = 34;
            btn_asistencia.Text = "ASISTENCIA";
            btn_asistencia.TextAlign = ContentAlignment.MiddleRight;
            btn_asistencia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_asistencia.UseVisualStyleBackColor = false;
            btn_asistencia.Click += btn_asistencia_Click;
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
            // P_principal
            // 
            P_principal.BackColor = SystemColors.ControlLightLight;
            P_principal.BackgroundImage = Properties.Resources.logoInicio;
            P_principal.BackgroundImageLayout = ImageLayout.Stretch;
            P_principal.Dock = DockStyle.Fill;
            P_principal.Location = new Point(219, 0);
            P_principal.Name = "P_principal";
            P_principal.Size = new Size(692, 450);
            P_principal.TabIndex = 42;
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
            PANEL_PRINCIPAL.Size = new Size(911, 450);
            PANEL_PRINCIPAL.TabIndex = 3;
            // 
            // VistaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 450);
            Controls.Add(PANEL_PRINCIPAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VistaAdmin";
            Text = "VistaAdmin";
            p_List.ResumeLayout(false);
            panel5.ResumeLayout(false);
            PANEL_PRINCIPAL.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel p_List;
        private Button button1;
        private Button btn_practicantes;
        private Button btn_asistencia;
        private Button button5;
        private Panel panel5;
        private Button btn_Salir;
        private Panel panel6;
        private Panel panel7;
        private Panel P_principal;
        private Panel PANEL_PRINCIPAL;
    }
}