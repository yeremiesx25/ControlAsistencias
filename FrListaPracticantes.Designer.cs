namespace ControlAsistencias
{
    partial class FrListaPracticantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrListaPracticantes));
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            txt_buscar = new TextBox();
            btn_buscar = new Button();
            dataGridView1 = new DataGridView();
            btn_EditPracticante = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_buscar
            // 
            txt_buscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_buscar.Location = new Point(49, 47);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(270, 29);
            txt_buscar.TabIndex = 1;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = Color.Transparent;
            btn_buscar.BackgroundImageLayout = ImageLayout.None;
            btn_buscar.FlatAppearance.BorderSize = 0;
            btn_buscar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_buscar.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_buscar.ForeColor = Color.White;
            btn_buscar.Image = (Image)resources.GetObject("btn_buscar.Image");
            btn_buscar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buscar.Location = new Point(342, 47);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.RightToLeft = RightToLeft.Yes;
            btn_buscar.Size = new Size(219, 29);
            btn_buscar.TabIndex = 33;
            btn_buscar.Text = "Buscar Practicante";
            btn_buscar.TextAlign = ContentAlignment.MiddleRight;
            btn_buscar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = Color.Purple;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.BackgroundColor = Color.Purple;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.Purple;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Purple;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MediumAquamarine;
            dataGridView1.Location = new Point(12, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Purple;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = Color.Purple;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(628, 260);
            dataGridView1.TabIndex = 34;
            // 
            // btn_EditPracticante
            // 
            btn_EditPracticante.BackColor = Color.Transparent;
            btn_EditPracticante.BackgroundImageLayout = ImageLayout.None;
            btn_EditPracticante.FlatAppearance.BorderSize = 0;
            btn_EditPracticante.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_EditPracticante.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            btn_EditPracticante.FlatStyle = FlatStyle.Flat;
            btn_EditPracticante.Font = new Font("Bernard MT Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_EditPracticante.ForeColor = Color.White;
            btn_EditPracticante.Image = (Image)resources.GetObject("btn_EditPracticante.Image");
            btn_EditPracticante.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditPracticante.Location = new Point(351, 398);
            btn_EditPracticante.Name = "btn_EditPracticante";
            btn_EditPracticante.RightToLeft = RightToLeft.Yes;
            btn_EditPracticante.Size = new Size(219, 29);
            btn_EditPracticante.TabIndex = 35;
            btn_EditPracticante.Text = "Editar Practicante";
            btn_EditPracticante.TextAlign = ContentAlignment.MiddleRight;
            btn_EditPracticante.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_EditPracticante.UseVisualStyleBackColor = false;
            btn_EditPracticante.Click += btn_EditPracticante_Click;
            // 
            // FrListaPracticantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logoInicio;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_EditPracticante);
            Controls.Add(dataGridView1);
            Controls.Add(btn_buscar);
            Controls.Add(txt_buscar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrListaPracticantes";
            Text = "FrListaPracticantes";
            Load += FrListaPracticantes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_buscar;
        private Button btn_buscar;
        private DataGridView dataGridView1;
        private Button btn_EditPracticante;
    }
}