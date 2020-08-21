namespace Proyecto_Grupo_5
{
    partial class IntContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntContrato));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textidTipoDeContrato = new System.Windows.Forms.ComboBox();
            this.textFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.textFechafin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDatosPersonales = new System.Windows.Forms.Panel();
            this.textIdContrato = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.Label();
            this.textDNI = new System.Windows.Forms.Label();
            this.textSegundoApellido = new System.Windows.Forms.Label();
            this.textPrimerApellido = new System.Windows.Forms.Label();
            this.textEmpleadoid = new System.Windows.Forms.Label();
            this.textSegundoNombre = new System.Windows.Forms.Label();
            this.textPrimerNombre = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.textidEmpleado = new System.Windows.Forms.ComboBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(113, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CODIGO";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "CONTRATO NUEVO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(205, 316);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "RENOVAR CONTRATO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(194, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "TIPO DE CONTRATO";
            // 
            // textidTipoDeContrato
            // 
            this.textidTipoDeContrato.FormattingEnabled = true;
            this.textidTipoDeContrato.Location = new System.Drawing.Point(131, 118);
            this.textidTipoDeContrato.Name = "textidTipoDeContrato";
            this.textidTipoDeContrato.Size = new System.Drawing.Size(121, 21);
            this.textidTipoDeContrato.TabIndex = 10;
            this.textidTipoDeContrato.SelectedIndexChanged += new System.EventHandler(this.textidTipoDeContrato_SelectedIndexChanged);
            // 
            // textFechaInicio
            // 
            this.textFechaInicio.Location = new System.Drawing.Point(101, 176);
            this.textFechaInicio.Name = "textFechaInicio";
            this.textFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.textFechaInicio.TabIndex = 11;
            // 
            // textFechafin
            // 
            this.textFechafin.Location = new System.Drawing.Point(101, 226);
            this.textFechafin.Name = "textFechafin";
            this.textFechafin.Size = new System.Drawing.Size(200, 20);
            this.textFechafin.TabIndex = 12;
            this.textFechafin.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "INICIO DEL CONTRATO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FIN DEL CONTRATO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.label14);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(831, 33);
            this.panel5.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 30);
            this.label14.TabIndex = 6;
            this.label14.Text = "CONTRATOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(330, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 400);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelDatosPersonales
            // 
            this.panelDatosPersonales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelDatosPersonales.Controls.Add(this.textIdContrato);
            this.panelDatosPersonales.Controls.Add(this.textEstado);
            this.panelDatosPersonales.Controls.Add(this.textDNI);
            this.panelDatosPersonales.Controls.Add(this.textSegundoApellido);
            this.panelDatosPersonales.Controls.Add(this.textPrimerApellido);
            this.panelDatosPersonales.Controls.Add(this.textEmpleadoid);
            this.panelDatosPersonales.Controls.Add(this.textSegundoNombre);
            this.panelDatosPersonales.Controls.Add(this.textPrimerNombre);
            this.panelDatosPersonales.Controls.Add(this.label17);
            this.panelDatosPersonales.Controls.Add(this.label16);
            this.panelDatosPersonales.Controls.Add(this.label15);
            this.panelDatosPersonales.Controls.Add(this.label13);
            this.panelDatosPersonales.Controls.Add(this.label12);
            this.panelDatosPersonales.Controls.Add(this.label11);
            this.panelDatosPersonales.Controls.Add(this.label10);
            this.panelDatosPersonales.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDatosPersonales.Enabled = false;
            this.panelDatosPersonales.Location = new System.Drawing.Point(580, 33);
            this.panelDatosPersonales.Name = "panelDatosPersonales";
            this.panelDatosPersonales.Size = new System.Drawing.Size(251, 417);
            this.panelDatosPersonales.TabIndex = 28;
            // 
            // textIdContrato
            // 
            this.textIdContrato.Location = new System.Drawing.Point(9, 398);
            this.textIdContrato.Name = "textIdContrato";
            this.textIdContrato.Size = new System.Drawing.Size(35, 13);
            this.textIdContrato.TabIndex = 63;
            this.textIdContrato.Text = " ";
            this.textIdContrato.Click += new System.EventHandler(this.label5_Click);
            // 
            // textEstado
            // 
            this.textEstado.BackColor = System.Drawing.SystemColors.Window;
            this.textEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textEstado.Location = new System.Drawing.Point(99, 319);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(134, 20);
            this.textEstado.TabIndex = 62;
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.SystemColors.Window;
            this.textDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textDNI.Location = new System.Drawing.Point(99, 266);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(134, 20);
            this.textDNI.TabIndex = 61;
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.BackColor = System.Drawing.SystemColors.Window;
            this.textSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textSegundoApellido.Location = new System.Drawing.Point(99, 224);
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Size = new System.Drawing.Size(134, 20);
            this.textSegundoApellido.TabIndex = 60;
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.BackColor = System.Drawing.SystemColors.Window;
            this.textPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textPrimerApellido.Location = new System.Drawing.Point(99, 194);
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Size = new System.Drawing.Size(134, 20);
            this.textPrimerApellido.TabIndex = 59;
            // 
            // textEmpleadoid
            // 
            this.textEmpleadoid.BackColor = System.Drawing.SystemColors.Window;
            this.textEmpleadoid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textEmpleadoid.Location = new System.Drawing.Point(99, 81);
            this.textEmpleadoid.Name = "textEmpleadoid";
            this.textEmpleadoid.Size = new System.Drawing.Size(134, 20);
            this.textEmpleadoid.TabIndex = 58;
            // 
            // textSegundoNombre
            // 
            this.textSegundoNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textSegundoNombre.Location = new System.Drawing.Point(99, 150);
            this.textSegundoNombre.Name = "textSegundoNombre";
            this.textSegundoNombre.Size = new System.Drawing.Size(134, 20);
            this.textSegundoNombre.TabIndex = 57;
            // 
            // textPrimerNombre
            // 
            this.textPrimerNombre.BackColor = System.Drawing.SystemColors.Window;
            this.textPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textPrimerNombre.Location = new System.Drawing.Point(99, 121);
            this.textPrimerNombre.Name = "textPrimerNombre";
            this.textPrimerNombre.Size = new System.Drawing.Size(134, 20);
            this.textPrimerNombre.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "ESTADO DEL EMPLEADO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label16.Location = new System.Drawing.Point(74, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 30);
            this.label16.TabIndex = 54;
            this.label16.Text = "PERSONALES";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Permanent Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label15.Location = new System.Drawing.Point(14, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 30);
            this.label15.TabIndex = 7;
            this.label15.Text = "DATOS ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "DNI";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "APELLIDOS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "NOMBRE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "CODIGO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel3.Location = new System.Drawing.Point(18, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(295, 5);
            this.panel3.TabIndex = 30;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel6.Location = new System.Drawing.Point(18, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(295, 5);
            this.panel6.TabIndex = 32;
            // 
            // dgvContratos
            // 
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Location = new System.Drawing.Point(351, 46);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.Size = new System.Drawing.Size(460, 390);
            this.dgvContratos.TabIndex = 33;
            // 
            // textidEmpleado
            // 
            this.textidEmpleado.FormattingEnabled = true;
            this.textidEmpleado.Location = new System.Drawing.Point(67, 54);
            this.textidEmpleado.Name = "textidEmpleado";
            this.textidEmpleado.Size = new System.Drawing.Size(121, 21);
            this.textidEmpleado.TabIndex = 27;
            // 
            // IntContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.textidEmpleado);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDatosPersonales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textFechafin);
            this.Controls.Add(this.textFechaInicio);
            this.Controls.Add(this.textidTipoDeContrato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvContratos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntContrato";
            this.Load += new System.EventHandler(this.IntContrato_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDatosPersonales.ResumeLayout(false);
            this.panelDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox textidTipoDeContrato;
        private System.Windows.Forms.DateTimePicker textFechaInicio;
        private System.Windows.Forms.DateTimePicker textFechafin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDatosPersonales;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.ComboBox textidEmpleado;
        private System.Windows.Forms.Label textEstado;
        private System.Windows.Forms.Label textDNI;
        private System.Windows.Forms.Label textSegundoApellido;
        private System.Windows.Forms.Label textPrimerApellido;
        private System.Windows.Forms.Label textEmpleadoid;
        private System.Windows.Forms.Label textSegundoNombre;
        private System.Windows.Forms.Label textPrimerNombre;
        private System.Windows.Forms.Label textIdContrato;
    }
}