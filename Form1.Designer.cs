namespace ControlAsistencias
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_user = new TextBox();
            txt_password = new TextBox();
            btnIngresar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            BTN_SALIR = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_user.Location = new Point(63, 105);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(182, 29);
            txt_user.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(62, 165);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(183, 29);
            txt_password.TabIndex = 1;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIngresar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.Location = new Point(213, 221);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.RightToLeft = RightToLeft.No;
            btnIngresar.Size = new Size(137, 47);
            btnIngresar.TabIndex = 30;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bernard MT Condensed", 26.25F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 20);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(231, 41);
            label4.TabIndex = 31;
            label4.Text = "INICIO DE SESION";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(28, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.passwordIS;
            pictureBox2.Location = new Point(28, 166);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // BTN_SALIR
            // 
            BTN_SALIR.BackColor = Color.Transparent;
            BTN_SALIR.FlatAppearance.BorderSize = 0;
            BTN_SALIR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BTN_SALIR.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            BTN_SALIR.FlatStyle = FlatStyle.Flat;
            BTN_SALIR.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BTN_SALIR.ForeColor = Color.White;
            BTN_SALIR.ImageAlign = ContentAlignment.MiddleLeft;
            BTN_SALIR.Location = new Point(374, 12);
            BTN_SALIR.Name = "BTN_SALIR";
            BTN_SALIR.RightToLeft = RightToLeft.No;
            BTN_SALIR.Size = new Size(137, 47);
            BTN_SALIR.TabIndex = 35;
            BTN_SALIR.Text = "SALIR";
            BTN_SALIR.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_SALIR.UseVisualStyleBackColor = false;
            BTN_SALIR.Click += BTN_SALIR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.logoInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(523, 280);
            Controls.Add(BTN_SALIR);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnIngresar);
            Controls.Add(txt_password);
            Controls.Add(txt_user);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "ad";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user;
        private TextBox txt_password;
        private Button btnIngresar;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BTN_SALIR;
    }
}