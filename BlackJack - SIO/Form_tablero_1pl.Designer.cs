namespace BlackJack___SIO
{
    partial class Form_tablero_1pl
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
            this.gboxRegistro = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.nupdDinero = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txboxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txboxNom = new System.Windows.Forms.TextBox();
            this.txboxPuntaje = new System.Windows.Forms.TextBox();
            this.txboxSaldo = new System.Windows.Forms.TextBox();
            this.gboxOpciones = new System.Windows.Forms.GroupBox();
            this.btnPedir = new System.Windows.Forms.Button();
            this.btnPasar = new System.Windows.Forms.Button();
            this.gboxSeguir = new System.Windows.Forms.GroupBox();
            this.btnNo = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.gboxApuesta = new System.Windows.Forms.GroupBox();
            this.lblPunt2 = new System.Windows.Forms.Label();
            this.lblPunt1 = new System.Windows.Forms.Label();
            this.prbarPunt1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.prbarPunt2 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.gboxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDinero)).BeginInit();
            this.gboxOpciones.SuspendLayout();
            this.gboxSeguir.SuspendLayout();
            this.gboxApuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRegistro
            // 
            this.gboxRegistro.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gboxRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.gboxRegistro.Controls.Add(this.btnRegistro);
            this.gboxRegistro.Controls.Add(this.nupdDinero);
            this.gboxRegistro.Controls.Add(this.label2);
            this.gboxRegistro.Controls.Add(this.txboxNombre);
            this.gboxRegistro.Controls.Add(this.label1);
            this.gboxRegistro.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxRegistro.ForeColor = System.Drawing.Color.Beige;
            this.gboxRegistro.Location = new System.Drawing.Point(19, 146);
            this.gboxRegistro.Name = "gboxRegistro";
            this.gboxRegistro.Size = new System.Drawing.Size(344, 139);
            this.gboxRegistro.TabIndex = 0;
            this.gboxRegistro.TabStop = false;
            this.gboxRegistro.Text = "Registro";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.btnRegistro.Location = new System.Drawing.Point(126, 170);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(87, 27);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Aceptar";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // nupdDinero
            // 
            this.nupdDinero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nupdDinero.Increment = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.nupdDinero.Location = new System.Drawing.Point(160, 92);
            this.nupdDinero.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupdDinero.Name = "nupdDinero";
            this.nupdDinero.Size = new System.Drawing.Size(120, 26);
            this.nupdDinero.TabIndex = 3;
            this.nupdDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dinero a apostar:";
            // 
            // txboxNombre
            // 
            this.txboxNombre.Location = new System.Drawing.Point(98, 42);
            this.txboxNombre.Name = "txboxNombre";
            this.txboxNombre.Size = new System.Drawing.Size(182, 26);
            this.txboxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txboxNom
            // 
            this.txboxNom.Enabled = false;
            this.txboxNom.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxNom.Location = new System.Drawing.Point(12, 12);
            this.txboxNom.Multiline = true;
            this.txboxNom.Name = "txboxNom";
            this.txboxNom.Size = new System.Drawing.Size(238, 31);
            this.txboxNom.TabIndex = 1;
            this.txboxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txboxPuntaje
            // 
            this.txboxPuntaje.Enabled = false;
            this.txboxPuntaje.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxPuntaje.Location = new System.Drawing.Point(799, 12);
            this.txboxPuntaje.Multiline = true;
            this.txboxPuntaje.Name = "txboxPuntaje";
            this.txboxPuntaje.Size = new System.Drawing.Size(178, 31);
            this.txboxPuntaje.TabIndex = 2;
            this.txboxPuntaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txboxSaldo
            // 
            this.txboxSaldo.Enabled = false;
            this.txboxSaldo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txboxSaldo.Location = new System.Drawing.Point(585, 12);
            this.txboxSaldo.Multiline = true;
            this.txboxSaldo.Name = "txboxSaldo";
            this.txboxSaldo.Size = new System.Drawing.Size(205, 31);
            this.txboxSaldo.TabIndex = 3;
            this.txboxSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboxOpciones
            // 
            this.gboxOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.gboxOpciones.Controls.Add(this.btnPedir);
            this.gboxOpciones.Controls.Add(this.btnPasar);
            this.gboxOpciones.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxOpciones.ForeColor = System.Drawing.Color.Beige;
            this.gboxOpciones.Location = new System.Drawing.Point(172, 266);
            this.gboxOpciones.Name = "gboxOpciones";
            this.gboxOpciones.Size = new System.Drawing.Size(177, 124);
            this.gboxOpciones.TabIndex = 5;
            this.gboxOpciones.TabStop = false;
            this.gboxOpciones.Text = "¿Qué desea hacer?";
            this.gboxOpciones.Visible = false;
            // 
            // btnPedir
            // 
            this.btnPedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.btnPedir.Location = new System.Drawing.Point(22, 88);
            this.btnPedir.Name = "btnPedir";
            this.btnPedir.Size = new System.Drawing.Size(141, 27);
            this.btnPedir.TabIndex = 5;
            this.btnPedir.Text = "Pedir otra carta";
            this.btnPedir.UseVisualStyleBackColor = false;
            this.btnPedir.Click += new System.EventHandler(this.btnPedir_Click);
            // 
            // btnPasar
            // 
            this.btnPasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.btnPasar.Location = new System.Drawing.Point(22, 43);
            this.btnPasar.Name = "btnPasar";
            this.btnPasar.Size = new System.Drawing.Size(141, 27);
            this.btnPasar.TabIndex = 4;
            this.btnPasar.Text = "Pasar Turno";
            this.btnPasar.UseVisualStyleBackColor = false;
            this.btnPasar.Click += new System.EventHandler(this.btnPasar_Click);
            // 
            // gboxSeguir
            // 
            this.gboxSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.gboxSeguir.Controls.Add(this.btnNo);
            this.gboxSeguir.Controls.Add(this.btnSi);
            this.gboxSeguir.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSeguir.ForeColor = System.Drawing.Color.Beige;
            this.gboxSeguir.Location = new System.Drawing.Point(422, 95);
            this.gboxSeguir.Name = "gboxSeguir";
            this.gboxSeguir.Size = new System.Drawing.Size(177, 127);
            this.gboxSeguir.TabIndex = 6;
            this.gboxSeguir.TabStop = false;
            this.gboxSeguir.Text = "¿Seguir jugando?";
            this.gboxSeguir.Visible = false;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.btnNo.Location = new System.Drawing.Point(22, 88);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(141, 27);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.btnSi.Location = new System.Drawing.Point(22, 43);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(141, 27);
            this.btnSi.TabIndex = 4;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // gboxApuesta
            // 
            this.gboxApuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(73)))), ((int)(((byte)(56)))));
            this.gboxApuesta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gboxApuesta.Controls.Add(this.lblPunt2);
            this.gboxApuesta.Controls.Add(this.lblPunt1);
            this.gboxApuesta.Controls.Add(this.prbarPunt1);
            this.gboxApuesta.Controls.Add(this.label3);
            this.gboxApuesta.Controls.Add(this.prbarPunt2);
            this.gboxApuesta.Controls.Add(this.label4);
            this.gboxApuesta.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxApuesta.ForeColor = System.Drawing.Color.Beige;
            this.gboxApuesta.Location = new System.Drawing.Point(799, 68);
            this.gboxApuesta.Name = "gboxApuesta";
            this.gboxApuesta.Size = new System.Drawing.Size(177, 322);
            this.gboxApuesta.TabIndex = 7;
            this.gboxApuesta.TabStop = false;
            this.gboxApuesta.Text = "Apuesta";
            this.gboxApuesta.Visible = false;
            // 
            // lblPunt2
            // 
            this.lblPunt2.AutoSize = true;
            this.lblPunt2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPunt2.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunt2.ForeColor = System.Drawing.Color.Orange;
            this.lblPunt2.Location = new System.Drawing.Point(79, 56);
            this.lblPunt2.Name = "lblPunt2";
            this.lblPunt2.Size = new System.Drawing.Size(21, 24);
            this.lblPunt2.TabIndex = 11;
            this.lblPunt2.Text = "0";
            this.lblPunt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPunt1
            // 
            this.lblPunt1.AutoSize = true;
            this.lblPunt1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPunt1.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunt1.ForeColor = System.Drawing.Color.Coral;
            this.lblPunt1.Location = new System.Drawing.Point(80, 232);
            this.lblPunt1.Name = "lblPunt1";
            this.lblPunt1.Size = new System.Drawing.Size(21, 24);
            this.lblPunt1.TabIndex = 10;
            this.lblPunt1.Text = "0";
            this.lblPunt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prbarPunt1
            // 
            this.prbarPunt1.Location = new System.Drawing.Point(40, 278);
            this.prbarPunt1.Maximum = 21;
            this.prbarPunt1.Name = "prbarPunt1";
            this.prbarPunt1.Size = new System.Drawing.Size(100, 23);
            this.prbarPunt1.TabIndex = 8;
            this.prbarPunt1.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(14, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Puntuación Jugador:";
            // 
            // prbarPunt2
            // 
            this.prbarPunt2.ForeColor = System.Drawing.SystemColors.Info;
            this.prbarPunt2.Location = new System.Drawing.Point(39, 103);
            this.prbarPunt2.Maximum = 21;
            this.prbarPunt2.Name = "prbarPunt2";
            this.prbarPunt2.Size = new System.Drawing.Size(100, 23);
            this.prbarPunt2.TabIndex = 9;
            this.prbarPunt2.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(14, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puntuación La Casa:";
            // 
            // Form_tablero_1pl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackJack___SIO.Properties.Resources.tablero_1_pl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 487);
            this.Controls.Add(this.gboxApuesta);
            this.Controls.Add(this.gboxSeguir);
            this.Controls.Add(this.gboxOpciones);
            this.Controls.Add(this.txboxSaldo);
            this.Controls.Add(this.txboxPuntaje);
            this.Controls.Add(this.txboxNom);
            this.Controls.Add(this.gboxRegistro);
            this.DoubleBuffered = true;
            this.Name = "Form_tablero_1pl";
            this.Text = "1 Jugador";
            this.Load += new System.EventHandler(this.Form_tablero_1pl_Load);
            this.gboxRegistro.ResumeLayout(false);
            this.gboxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdDinero)).EndInit();
            this.gboxOpciones.ResumeLayout(false);
            this.gboxSeguir.ResumeLayout(false);
            this.gboxApuesta.ResumeLayout(false);
            this.gboxApuesta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupdDinero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txboxNombre;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txboxNom;
        private System.Windows.Forms.TextBox txboxPuntaje;
        private System.Windows.Forms.TextBox txboxSaldo;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.Button btnPasar;
        private System.Windows.Forms.Button btnPedir;
        private System.Windows.Forms.GroupBox gboxSeguir;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.GroupBox gboxApuesta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar prbarPunt1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPunt1;
        private System.Windows.Forms.ProgressBar prbarPunt2;
        private System.Windows.Forms.Label lblPunt2;
    }
}