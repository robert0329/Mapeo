namespace DetallesMapeo.UI
{
    partial class RegistroEstudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudianteIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombreEsttextBox = new System.Windows.Forms.TextBox();
            this.Registrarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EstudiantesdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estudiante Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Estudiante";
            // 
            // EstudianteIdmaskedTextBox
            // 
            this.EstudianteIdmaskedTextBox.Location = new System.Drawing.Point(15, 26);
            this.EstudianteIdmaskedTextBox.Name = "EstudianteIdmaskedTextBox";
            this.EstudianteIdmaskedTextBox.Size = new System.Drawing.Size(261, 20);
            this.EstudianteIdmaskedTextBox.TabIndex = 2;
            // 
            // NombreEsttextBox
            // 
            this.NombreEsttextBox.Location = new System.Drawing.Point(15, 72);
            this.NombreEsttextBox.Name = "NombreEsttextBox";
            this.NombreEsttextBox.Size = new System.Drawing.Size(487, 20);
            this.NombreEsttextBox.TabIndex = 3;
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(229, 270);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Registrarbutton.TabIndex = 4;
            this.Registrarbutton.Text = "Guardar";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            this.Registrarbutton.Click += new System.EventHandler(this.Registrarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(298, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EstudiantesdataGridView
            // 
            this.EstudiantesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstudiantesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesdataGridView.Location = new System.Drawing.Point(15, 114);
            this.EstudiantesdataGridView.Name = "EstudiantesdataGridView";
            this.EstudiantesdataGridView.Size = new System.Drawing.Size(487, 150);
            this.EstudiantesdataGridView.TabIndex = 8;
            this.EstudiantesdataGridView.Visible = false;
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 314);
            this.Controls.Add(this.EstudiantesdataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.NombreEsttextBox);
            this.Controls.Add(this.EstudianteIdmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEstudiantes";
            this.Text = "RegistroEstudiantes";
            this.Load += new System.EventHandler(this.RegistroEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox EstudianteIdmaskedTextBox;
        private System.Windows.Forms.TextBox NombreEsttextBox;
        private System.Windows.Forms.Button Registrarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView EstudiantesdataGridView;
    }
}