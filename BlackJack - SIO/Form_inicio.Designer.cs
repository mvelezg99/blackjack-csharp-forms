namespace BlackJack___SIO
{
    partial class Form_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_inicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_1plyr = new System.Windows.Forms.Button();
            this.btn_2plyr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_1plyr
            // 
            this.btn_1plyr.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_1plyr.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1plyr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(193)))), ((int)(((byte)(91)))));
            this.btn_1plyr.Image = ((System.Drawing.Image)(resources.GetObject("btn_1plyr.Image")));
            this.btn_1plyr.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_1plyr.Location = new System.Drawing.Point(51, 284);
            this.btn_1plyr.Name = "btn_1plyr";
            this.btn_1plyr.Size = new System.Drawing.Size(339, 77);
            this.btn_1plyr.TabIndex = 1;
            this.btn_1plyr.Text = "1 Jugador";
            this.btn_1plyr.UseVisualStyleBackColor = true;
            this.btn_1plyr.Click += new System.EventHandler(this.btn_1plyr_Click);
            // 
            // btn_2plyr
            // 
            this.btn_2plyr.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2plyr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(193)))), ((int)(((byte)(91)))));
            this.btn_2plyr.Image = ((System.Drawing.Image)(resources.GetObject("btn_2plyr.Image")));
            this.btn_2plyr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_2plyr.Location = new System.Drawing.Point(474, 284);
            this.btn_2plyr.Name = "btn_2plyr";
            this.btn_2plyr.Size = new System.Drawing.Size(339, 77);
            this.btn_2plyr.TabIndex = 2;
            this.btn_2plyr.Text = "2 Jugadores";
            this.btn_2plyr.UseVisualStyleBackColor = true;
            this.btn_2plyr.Click += new System.EventHandler(this.btn_2plyr_Click);
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 434);
            this.Controls.Add(this.btn_2plyr);
            this.Controls.Add(this.btn_1plyr);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_inicio";
            this.Text = "BlackJack - SIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_1plyr;
        private System.Windows.Forms.Button btn_2plyr;
    }
}

