namespace SnakeWF
{
    partial class FormPuntuacionAGuardar
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelPuntuacion = new System.Windows.Forms.Label();
            this.labelPuntuacionPartida = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(26, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(90, 26);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelPuntuacion
            // 
            this.labelPuntuacion.AutoSize = true;
            this.labelPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuacion.Location = new System.Drawing.Point(26, 99);
            this.labelPuntuacion.Name = "labelPuntuacion";
            this.labelPuntuacion.Size = new System.Drawing.Size(121, 26);
            this.labelPuntuacion.TabIndex = 1;
            this.labelPuntuacion.Text = "Puntuacion";
            // 
            // labelPuntuacionPartida
            // 
            this.labelPuntuacionPartida.AutoSize = true;
            this.labelPuntuacionPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuacionPartida.Location = new System.Drawing.Point(174, 93);
            this.labelPuntuacionPartida.Name = "labelPuntuacionPartida";
            this.labelPuntuacionPartida.Size = new System.Drawing.Size(29, 31);
            this.labelPuntuacionPartida.TabIndex = 2;
            this.labelPuntuacionPartida.Text = "0";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(171, 39);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(180, 26);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.Text = "Escribe tu nombre aquí";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.Black;
            this.buttonGuardar.Location = new System.Drawing.Point(105, 157);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(177, 53);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // FormPuntuacionAGuardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(385, 231);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelPuntuacionPartida);
            this.Controls.Add(this.labelPuntuacion);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPuntuacionAGuardar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPuntuacionAGuardar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelPuntuacion;
        private System.Windows.Forms.Label labelPuntuacionPartida;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonGuardar;
    }
}