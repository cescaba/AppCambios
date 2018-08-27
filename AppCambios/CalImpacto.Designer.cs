namespace AppCambios
{
    partial class CalImpacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalImpacto));
            this.label1 = new System.Windows.Forms.Label();
            this.cbousuafec = new System.Windows.Forms.ComboBox();
            this.cboempafec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboimp1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cboimp2 = new System.Windows.Forms.ComboBox();
            this.cboimp3 = new System.Windows.Forms.ComboBox();
            this.cboimp4 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro. Usuarios Impactados";
            // 
            // cbousuafec
            // 
            this.cbousuafec.FormattingEnabled = true;
            this.cbousuafec.Items.AddRange(new object[] {
            "Más de 150 usuarios.",
            "De 50 a 150 usuarios.",
            "de 2 a 49 usuarios.",
            "1 usuario.",
            "Ningún usuario."});
            this.cbousuafec.Location = new System.Drawing.Point(199, 65);
            this.cbousuafec.Name = "cbousuafec";
            this.cbousuafec.Size = new System.Drawing.Size(171, 21);
            this.cbousuafec.TabIndex = 1;
            // 
            // cboempafec
            // 
            this.cboempafec.FormattingEnabled = true;
            this.cboempafec.Items.AddRange(new object[] {
            "Corporativo.",
            "Más de una Empresa.",
            "Una Empresa.",
            "Sin impacto para  las Empresas."});
            this.cboempafec.Location = new System.Drawing.Point(199, 30);
            this.cboempafec.Name = "cboempafec";
            this.cboempafec.Size = new System.Drawing.Size(171, 21);
            this.cboempafec.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recursos Requeridos para Preparar/Implementación";
            // 
            // cboimp1
            // 
            this.cboimp1.FormattingEnabled = true;
            this.cboimp1.Items.AddRange(new object[] {
            "3 o más grupos solucionadores.",
            "2 grupos solucionadores.",
            "Más de una persona del mismo grupo solucionador.",
            "Una persona."});
            this.cboimp1.Location = new System.Drawing.Point(265, 28);
            this.cboimp1.Name = "cboimp1";
            this.cboimp1.Size = new System.Drawing.Size(282, 21);
            this.cboimp1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Esfuerzo de Preparación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duración de la Implementación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dificultad para revertir el cambio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "El Cambio requiere una gran cantidad de espacio en disco.",
            "El Cambio que tiene gran demanda de CPU",
            "El cambio reqerirán alto grado de ancho de banda."});
            this.checkedListBox1.Location = new System.Drawing.Point(98, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(366, 49);
            this.checkedListBox1.TabIndex = 10;
            // 
            // cboimp2
            // 
            this.cboimp2.FormattingEnabled = true;
            this.cboimp2.Items.AddRange(new object[] {
            "Más de 6 días.",
            "De 2 a 5 días.",
            "1 solo día.",
            "Menos de 1 día.",
            "1 hora o menos."});
            this.cboimp2.Location = new System.Drawing.Point(265, 55);
            this.cboimp2.Name = "cboimp2";
            this.cboimp2.Size = new System.Drawing.Size(151, 21);
            this.cboimp2.TabIndex = 11;
            // 
            // cboimp3
            // 
            this.cboimp3.FormattingEnabled = true;
            this.cboimp3.Items.AddRange(new object[] {
            "Más de 2 horas o requiere corte de servicio.",
            "De 1 a 2 horas con ventana.",
            "Menos de 1 hora con ventana.",
            "Menos de 1 sin ventana.",
            "Implementación inmediata."});
            this.cboimp3.Location = new System.Drawing.Point(265, 82);
            this.cboimp3.Name = "cboimp3";
            this.cboimp3.Size = new System.Drawing.Size(242, 21);
            this.cboimp3.TabIndex = 12;
            // 
            // cboimp4
            // 
            this.cboimp4.FormattingEnabled = true;
            this.cboimp4.Items.AddRange(new object[] {
            "Dificultad para Volver Atras ( > 2 horas).",
            "Mayor a 2 horas.",
            "De 1 a 2 horas.",
            "Razonalbe y menor a 1 hora.",
            "Fácil y menor a 1 hora.",
            "Puede ser vuelto atras inmediatamente."});
            this.cboimp4.Location = new System.Drawing.Point(265, 109);
            this.cboimp4.Name = "cboimp4";
            this.cboimp4.Size = new System.Drawing.Size(242, 21);
            this.cboimp4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboempafec);
            this.groupBox1.Controls.Add(this.cbousuafec);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impacto - Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nro. Empresas Afectadas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboimp1);
            this.groupBox2.Controls.Add(this.cboimp2);
            this.groupBox2.Controls.Add(this.cboimp3);
            this.groupBox2.Controls.Add(this.cboimp4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 145);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Impacto - Implementación";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(18, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Impacto - Recursos de TI";
            // 
            // CalImpacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 404);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalImpacto";
            this.Text = "Calculo de Impacto";
            this.Load += new System.EventHandler(this.CalImpacto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbousuafec;
        private System.Windows.Forms.ComboBox cboempafec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboimp1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox cboimp2;
        private System.Windows.Forms.ComboBox cboimp3;
        private System.Windows.Forms.ComboBox cboimp4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}