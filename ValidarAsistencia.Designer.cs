namespace ControlAsistencias
{
    partial class ValidarAsistencia
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
            btnIngresar = new Button();
            SuspendLayout();
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
            btnIngresar.Location = new Point(186, 185);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.RightToLeft = RightToLeft.No;
            btnIngresar.Size = new Size(165, 62);
            btnIngresar.TabIndex = 31;
            btnIngresar.Text = "MARCAR ASISTENCIA";
            btnIngresar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // ValidarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logoInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 277);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ValidarAsistencia";
            Text = "ValidarAsistencia";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
    }
}