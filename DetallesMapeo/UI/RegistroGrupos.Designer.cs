namespace DetallesMapeo.UI
{
    partial class RegistroGrupos
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
            this.CrearGrupobutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupoIdmaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombreGtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupo Id";
            // 
            // CrearGrupobutton
            // 
            this.CrearGrupobutton.Location = new System.Drawing.Point(207, 105);
            this.CrearGrupobutton.Name = "CrearGrupobutton";
            this.CrearGrupobutton.Size = new System.Drawing.Size(75, 23);
            this.CrearGrupobutton.TabIndex = 3;
            this.CrearGrupobutton.Text = "Crear Grupo";
            this.CrearGrupobutton.UseVisualStyleBackColor = true;
            this.CrearGrupobutton.Click += new System.EventHandler(this.CrearGrupobutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Grupo";
            // 
            // GrupoIdmaskedTextBox
            // 
            this.GrupoIdmaskedTextBox.Location = new System.Drawing.Point(15, 25);
            this.GrupoIdmaskedTextBox.Name = "GrupoIdmaskedTextBox";
            this.GrupoIdmaskedTextBox.Size = new System.Drawing.Size(267, 20);
            this.GrupoIdmaskedTextBox.TabIndex = 5;
            // 
            // NombreGtextBox
            // 
            this.NombreGtextBox.Location = new System.Drawing.Point(15, 65);
            this.NombreGtextBox.Name = "NombreGtextBox";
            this.NombreGtextBox.Size = new System.Drawing.Size(267, 20);
            this.NombreGtextBox.TabIndex = 6;
            // 
            // RegistroGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 156);
            this.Controls.Add(this.NombreGtextBox);
            this.Controls.Add(this.GrupoIdmaskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrearGrupobutton);
            this.Controls.Add(this.label1);
            this.Name = "RegistroGrupos";
            this.Text = "RegistroGrupos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CrearGrupobutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox GrupoIdmaskedTextBox;
        private System.Windows.Forms.TextBox NombreGtextBox;
    }
}