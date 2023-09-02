namespace SnakeWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPuntos = new System.Windows.Forms.Label();
            this.labelPuntuacionNum = new System.Windows.Forms.Label();
            this.labelVidas = new System.Windows.Forms.Label();
            this.labelNumVidas = new System.Windows.Forms.Label();
            this.buttonVerRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(12, 322);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 38);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            this.buttonStart.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonStart_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.Location = new System.Drawing.Point(241, 325);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(52, 13);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "PUNTOS";
            // 
            // labelPuntuacionNum
            // 
            this.labelPuntuacionNum.AutoSize = true;
            this.labelPuntuacionNum.Location = new System.Drawing.Point(299, 325);
            this.labelPuntuacionNum.Name = "labelPuntuacionNum";
            this.labelPuntuacionNum.Size = new System.Drawing.Size(13, 13);
            this.labelPuntuacionNum.TabIndex = 3;
            this.labelPuntuacionNum.Text = "0";
            // 
            // labelVidas
            // 
            this.labelVidas.AutoSize = true;
            this.labelVidas.Location = new System.Drawing.Point(241, 347);
            this.labelVidas.Name = "labelVidas";
            this.labelVidas.Size = new System.Drawing.Size(39, 13);
            this.labelVidas.TabIndex = 4;
            this.labelVidas.Text = "VIDAS";
            // 
            // labelNumVidas
            // 
            this.labelNumVidas.AutoSize = true;
            this.labelNumVidas.Location = new System.Drawing.Point(299, 347);
            this.labelNumVidas.Name = "labelNumVidas";
            this.labelNumVidas.Size = new System.Drawing.Size(13, 13);
            this.labelNumVidas.TabIndex = 5;
            this.labelNumVidas.Text = "3";
            // 
            // buttonVerRecords
            // 
            this.buttonVerRecords.Location = new System.Drawing.Point(13, 373);
            this.buttonVerRecords.Name = "buttonVerRecords";
            this.buttonVerRecords.Size = new System.Drawing.Size(102, 23);
            this.buttonVerRecords.TabIndex = 6;
            this.buttonVerRecords.Text = "VER RECORDS";
            this.buttonVerRecords.UseVisualStyleBackColor = true;
            this.buttonVerRecords.Click += new System.EventHandler(this.buttonVerRecords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 411);
            this.Controls.Add(this.buttonVerRecords);
            this.Controls.Add(this.labelNumVidas);
            this.Controls.Add(this.labelVidas);
            this.Controls.Add(this.labelPuntuacionNum);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MITICAL NOKIA SNAKE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.Label labelPuntuacionNum;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelVidas;
        private System.Windows.Forms.Label labelNumVidas;
        private System.Windows.Forms.Button buttonVerRecords;
    }
}

