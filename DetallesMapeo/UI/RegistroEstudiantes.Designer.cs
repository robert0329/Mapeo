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
            this.NombreEsttextBox.Size = new System.Drawing.Size(261, 20);
            this.NombreEsttextBox.TabIndex = 3;
            // 
            // Registrarbutton
            // 
            this.Registrarbutton.Location = new System.Drawing.Point(201, 121);
            this.Registrarbutton.Name = "Registrarbutton";
            this.Registrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Registrarbutton.TabIndex = 4;
            this.Registrarbutton.Text = "Registrar";
            this.Registrarbutton.UseVisualStyleBackColor = true;
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 162);
            this.Controls.Add(this.Registrarbutton);
            this.Controls.Add(this.NombreEsttextBox);
            this.Controls.Add(this.EstudianteIdmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEstudiantes";
            this.Text = "RegistroEstudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox EstudianteIdmaskedTextBox;
        private System.Windows.Forms.TextBox NombreEsttextBox;
        private System.Windows.Forms.Button Registrarbutton;
    }
}