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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(89, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 321);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(89, 461);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(116, 50);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
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
            this.labelPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.Location = new System.Drawing.Point(106, 19);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(74, 20);
            this.labelPuntos.TabIndex = 2;
            this.labelPuntos.Text = "PUNTOS";
            // 
            // labelPuntuacionNum
            // 
            this.labelPuntuacionNum.AutoSize = true;
            this.labelPuntuacionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPuntuacionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntuacionNum.Location = new System.Drawing.Point(199, 19);
            this.labelPuntuacionNum.Name = "labelPuntuacionNum";
            this.labelPuntuacionNum.Size = new System.Drawing.Size(18, 20);
            this.labelPuntuacionNum.TabIndex = 3;
            this.labelPuntuacionNum.Text = "0";
            // 
            // labelVidas
            // 
            this.labelVidas.AutoSize = true;
            this.labelVidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVidas.Location = new System.Drawing.Point(428, 19);
            this.labelVidas.Name = "labelVidas";
            this.labelVidas.Size = new System.Drawing.Size(59, 20);
            this.labelVidas.TabIndex = 4;
            this.labelVidas.Text = "VIDAS";
            // 
            // labelNumVidas
            // 
            this.labelNumVidas.AutoSize = true;
            this.labelNumVidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelNumVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumVidas.Location = new System.Drawing.Point(493, 19);
            this.labelNumVidas.Name = "labelNumVidas";
            this.labelNumVidas.Size = new System.Drawing.Size(18, 20);
            this.labelNumVidas.TabIndex = 5;
            this.labelNumVidas.Text = "3";
            // 
            // buttonVerRecords
            // 
            this.buttonVerRecords.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonVerRecords.Location = new System.Drawing.Point(441, 464);
            this.buttonVerRecords.Name = "buttonVerRecords";
            this.buttonVerRecords.Size = new System.Drawing.Size(109, 35);
            this.buttonVerRecords.TabIndex = 6;
            this.buttonVerRecords.Text = "VER RECORDS";
            this.buttonVerRecords.UseVisualStyleBackColor = false;
            this.buttonVerRecords.Click += new System.EventHandler(this.buttonVerRecords_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SnakeWF.Properties.Resources.Nokia;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(634, 511);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.labelVidas);
            this.Controls.Add(this.labelPuntuacionNum);
            this.Controls.Add(this.labelPuntos);
            this.Controls.Add(this.labelNumVidas);
            this.Controls.Add(this.buttonVerRecords);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MITICAL NOKIA SNAKE";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

