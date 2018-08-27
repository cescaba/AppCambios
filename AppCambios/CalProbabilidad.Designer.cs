namespace AppCambios
{
    partial class CalProbabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalProbabilidad));
            this.cboimp3 = new System.Windows.Forms.ComboBox();
            this.cboimp4 = new System.Windows.Forms.ComboBox();
            this.cboimp5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboimp6 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboimp1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cboimp2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboimp3
            // 
            this.cboimp3.FormattingEnabled = true;
            this.cboimp3.Items.AddRange(new object[] {
            "Una persona.",
            "Más de una persona del mismo grupo solucionador.",
            "2 grupos solucionadores.",
            "3 o más grupos solucionadores."});
            this.cboimp3.Location = new System.Drawing.Point(292, 230);
            this.cboimp3.Name = "cboimp3";
            this.cboimp3.Size = new System.Drawing.Size(282, 21);
            this.cboimp3.TabIndex = 5;
            // 
            // cboimp4
            // 
            this.cboimp4.FormattingEnabled = true;
            this.cboimp4.Items.AddRange(new object[] {
            "Implementación inmediata.",
            "Menos de 1 sin ventana.",
            "Menos de 1 hora con ventana.",
            "De 1 a 2 horas con ventana.",
            "Más de 2 horas o requiere corte de servicio."});
            this.cboimp4.Location = new System.Drawing.Point(292, 260);
            this.cboimp4.Name = "cboimp4";
            this.cboimp4.Size = new System.Drawing.Size(242, 21);
            this.cboimp4.TabIndex = 12;
            // 
            // cboimp5
            // 
            this.cboimp5.FormattingEnabled = true;
            this.cboimp5.Items.AddRange(new object[] {
            "Puede ser vuelto atras inmediatamente.",
            "Fácil y menor a 1 hora.",
            "De 1 a 2 horas.",
            "Mayor a 2 horas."});
            this.cboimp5.Location = new System.Drawing.Point(292, 297);
            this.cboimp5.Name = "cboimp5";
            this.cboimp5.Size = new System.Drawing.Size(242, 21);
            this.cboimp5.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recursos Requeridos para Preparar/Implementación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dificultad para revertir el cambio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duración de la Implementación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboimp6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboimp1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cboimp2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 176);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuestionario";
            // 
            // cboimp6
            // 
            this.cboimp6.FormattingEnabled = true;
            this.cboimp6.Items.AddRange(new object[] {
            "Primera vez que se realiza",
            "Anteriormente se ha realizado 1 ó 2 veces",
            "Se realiza mensualmente",
            "Se realiza constantemente (semanal)"});
            this.cboimp6.Location = new System.Drawing.Point(223, 96);
            this.cboimp6.Name = "cboimp6";
            this.cboimp6.Size = new System.Drawing.Size(228, 21);
            this.cboimp6.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recurrencia de Ejecución";
            // 
            // cboimp1
            // 
            this.cboimp1.FormattingEnabled = true;
            this.cboimp1.Items.AddRange(new object[] {
            "2 o más reuniones.",
            "1 reunión.",
            "Ninguna reunión."});
            this.cboimp1.Location = new System.Drawing.Point(223, 27);
            this.cboimp1.Name = "cboimp1";
            this.cboimp1.Size = new System.Drawing.Size(228, 21);
            this.cboimp1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboimp2
            // 
            this.cboimp2.FormattingEnabled = true;
            this.cboimp2.Items.AddRange(new object[] {
            "Más de 7 días previos al CAB.",
            "Entre 3 y 6 días antes del CAB.",
            "Entre 1 y 2 días antes del CAB.",
            "El mismo día del CAB."});
            this.cboimp2.Location = new System.Drawing.Point(223, 62);
            this.cboimp2.Name = "cboimp2";
            this.cboimp2.Size = new System.Drawing.Size(228, 21);
            this.cboimp2.TabIndex = 1;
            this.cboimp2.SelectedIndexChanged += new System.EventHandler(this.cboimp2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Reunión de Coordinación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo previo elaboración Plan";
            // 
            // CalProbabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 188);
            this.Controls.Add(this.cboimp3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboimp4);
            this.Controls.Add(this.cboimp5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalProbabilidad";
            this.Text = "CalProbabilidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboimp3;
        private System.Windows.Forms.ComboBox cboimp4;
        private System.Windows.Forms.ComboBox cboimp5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboimp1;
        private System.Windows.Forms.ComboBox cboimp2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboimp6;
        private System.Windows.Forms.Label label2;

    }
}