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
            p_List = new Panel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            P_principal = new Panel();
            PANEL_PRINCIPAL.SuspendLayout();
            p_List.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // p_List
            // 
            p_List.BackColor = Color.Purple;
            p_List.Controls.Add(button2);
            p_List.Controls.Add(button3);
            p_List.Controls.Add(button4);
            p_List.Controls.Add(button5);
            p_List.Controls.Add(panel5);
            p_List.Dock = DockStyle.Left;
            p_List.Location = new Point(0, 0);
            p_List.Name = "p_List";
            p_List.Size = new Size(219, 450);
            p_List.TabIndex = 41;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 253);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(219, 49);
            button2.TabIndex = 35;
            button2.Text = "PRACTICANTES";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 201);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(219, 49);
            button3.TabIndex = 34;
            button3.Text = "ASISTENCIA";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 153);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.Yes;
            button4.Size = new Size(219, 49);
            button4.TabIndex = 33;
            button4.Text = "EDITAR USUARIO";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
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
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(pictureBox2);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 100);
            panel5.TabIndex = 2;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, -11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 111);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PANEL_PRINCIPAL;
        private Panel p_List;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox2;
        private Panel P_principal;
    }
}