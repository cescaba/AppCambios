namespace AppCambios
{
    partial class cac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cac));
            this.groupBoxEmergencia = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorraporemer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtincidente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerAprobacion = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAprobador = new System.Windows.Forms.ComboBox();
            this.groupBoxMedioMayor = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcorreocomite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerCAC = new System.Windows.Forms.DateTimePicker();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.groupBoxExcepcion = new System.Windows.Forms.GroupBox();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcorraporexce = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAprobadorExc = new System.Windows.Forms.ComboBox();
            this.groupBoxEmergencia.SuspendLayout();
            this.groupBoxMedioMayor.SuspendLayout();
            this.groupBoxExcepcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmergencia
            // 
            this.groupBoxEmergencia.Controls.Add(this.label5);
            this.groupBoxEmergencia.Controls.Add(this.txtcorraporemer);
            this.groupBoxEmergencia.Controls.Add(this.label4);
            this.groupBoxEmergencia.Controls.Add(this.txtincidente);
            this.groupBoxEmergencia.Controls.Add(this.label3);
            this.groupBoxEmergencia.Controls.Add(this.label1);
            this.groupBoxEmergencia.Controls.Add(this.dateTimePickerAprobacion);
            this.groupBoxEmergencia.Controls.Add(this.comboBoxAprobador);
            this.groupBoxEmergencia.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEmergencia.Name = "groupBoxEmergencia";
            this.groupBoxEmergencia.Size = new System.Drawing.Size(423, 165);
            this.groupBoxEmergencia.TabIndex = 0;
            this.groupBoxEmergencia.TabStop = false;
            this.groupBoxEmergencia.Text = "Aprobación de Emergencia:";
            this.groupBoxEmergencia.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo de Aprobación";
            // 
            // txtcorraporemer
            // 
            this.txtcorraporemer.Location = new System.Drawing.Point(124, 130);
            this.txtcorraporemer.Name = "txtcorraporemer";
            this.txtcorraporemer.Size = new System.Drawing.Size(252, 20);
            this.txtcorraporemer.TabIndex = 7;
            this.txtcorraporemer.TextChanged += new System.EventHandler(this.txtcorraporemer_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Incidente/Problema:";
            // 
            // txtincidente
            // 
            this.txtincidente.Location = new System.Drawing.Point(124, 101);
            this.txtincidente.Name = "txtincidente";
            this.txtincidente.Size = new System.Drawing.Size(252, 20);
            this.txtincidente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aprobado Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Aprobación:";
            // 
            // dateTimePickerAprobacion
            // 
            this.dateTimePickerAprobacion.CustomFormat = "ddd , dd \'de\' MMMM \'de\' yyyy \'a las\' hh\':\'mm\':\'ss tt ";
            this.dateTimePickerAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAprobacion.Location = new System.Drawing.Point(124, 32);
            this.dateTimePickerAprobacion.Name = "dateTimePickerAprobacion";
            this.dateTimePickerAprobacion.Size = new System.Drawing.Size(288, 20);
            this.dateTimePickerAprobacion.TabIndex = 2;
            // 
            // comboBoxAprobador
            // 
            this.comboBoxAprobador.FormattingEnabled = true;
            this.comboBoxAprobador.Items.AddRange(new object[] {
            "Benjamin Yarleque",
            "Raul Guerrero",
            "Ruth Novoa",
            "Tamara Caplan",
            "Liliana Alvarez"});
            this.comboBoxAprobador.Location = new System.Drawing.Point(124, 68);
            this.comboBoxAprobador.Name = "comboBoxAprobador";
            this.comboBoxAprobador.Size = new System.Drawing.Size(252, 21);
            this.comboBoxAprobador.TabIndex = 0;
            // 
            // groupBoxMedioMayor
            // 
            this.groupBoxMedioMayor.Controls.Add(this.label8);
            this.groupBoxMedioMayor.Controls.Add(this.txtcorreocomite);
            this.groupBoxMedioMayor.Controls.Add(this.label2);
            this.groupBoxMedioMayor.Controls.Add(this.dateTimePickerCAC);
            this.groupBoxMedioMayor.Location = new System.Drawing.Point(12, 212);
            this.groupBoxMedioMayor.Name = "groupBoxMedioMayor";
            this.groupBoxMedioMayor.Size = new System.Drawing.Size(423, 165);
            this.groupBoxMedioMayor.TabIndex = 1;
            this.groupBoxMedioMayor.TabStop = false;
            this.groupBoxMedioMayor.Text = "Comite de Cambios:";
            this.groupBoxMedioMayor.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Acta de Comite";
            // 
            // txtcorreocomite
            // 
            this.txtcorreocomite.Location = new System.Drawing.Point(122, 95);
            this.txtcorreocomite.Name = "txtcorreocomite";
            this.txtcorreocomite.Size = new System.Drawing.Size(252, 20);
            this.txtcorreocomite.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Comite";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerCAC
            // 
            this.dateTimePickerCAC.CustomFormat = "ddd , dd \'de\' MMMM \'de\' yyyy \'a las\' hh\':\'mm\':\'ss tt ";
            this.dateTimePickerCAC.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCAC.Location = new System.Drawing.Point(124, 51);
            this.dateTimePickerCAC.Name = "dateTimePickerCAC";
            this.dateTimePickerCAC.Size = new System.Drawing.Size(288, 20);
            this.dateTimePickerCAC.TabIndex = 4;
            this.dateTimePickerCAC.ValueChanged += new System.EventHandler(this.dateTimePickerCAC_ValueChanged);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(177, 183);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 23);
            this.btnAprobar.TabIndex = 2;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // groupBoxExcepcion
            // 
            this.groupBoxExcepcion.Controls.Add(this.cboMotivo);
            this.groupBoxExcepcion.Controls.Add(this.label10);
            this.groupBoxExcepcion.Controls.Add(this.label9);
            this.groupBoxExcepcion.Controls.Add(this.txtcorraporexce);
            this.groupBoxExcepcion.Controls.Add(this.label6);
            this.groupBoxExcepcion.Controls.Add(this.label7);
            this.groupBoxExcepcion.Controls.Add(this.dateTimePicker1);
            this.groupBoxExcepcion.Controls.Add(this.comboBoxAprobadorExc);
            this.groupBoxExcepcion.Location = new System.Drawing.Point(12, 383);
            this.groupBoxExcepcion.Name = "groupBoxExcepcion";
            this.groupBoxExcepcion.Size = new System.Drawing.Size(423, 165);
            this.groupBoxExcepcion.TabIndex = 3;
            this.groupBoxExcepcion.TabStop = false;
            this.groupBoxExcepcion.Text = "Aprobación de Excepción";
            this.groupBoxExcepcion.Visible = false;
            this.groupBoxExcepcion.Enter += new System.EventHandler(this.groupBoxExcepcion_Enter);
            // 
            // cboMotivo
            // 
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Items.AddRange(new object[] {
            "CSGR - Auditoria",
            "CSGR - Compromiso con Negocio",
            "CSGR - Mala Planeación",
            "CSGR - Posible Fallo en Servicio",
            "CSGR - Proyecto Externo Altero",
            "Negocio - Mantenimiento",
            "Negocio - Ventana Ultimo Momento",
            "Negocio - Requerimiento Urgente",
            "Proveedor - Entrega a Destiempo",
            "Proveedor - Mala Planeación"});
            this.cboMotivo.Location = new System.Drawing.Point(122, 119);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(252, 21);
            this.cboMotivo.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Motivo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Correo de Aprobación";
            // 
            // txtcorraporexce
            // 
            this.txtcorraporexce.Location = new System.Drawing.Point(122, 89);
            this.txtcorraporexce.Name = "txtcorraporexce";
            this.txtcorraporexce.Size = new System.Drawing.Size(252, 20);
            this.txtcorraporexce.TabIndex = 11;
            this.txtcorraporexce.TextChanged += new System.EventHandler(this.txtcorraporexce_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Aprobado Por:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Fecha Aprobación:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "ddd , dd \'de\' MMMM \'de\' yyyy \'a las\' hh\':\'mm\':\'ss tt ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(288, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxAprobadorExc
            // 
            this.comboBoxAprobadorExc.FormattingEnabled = true;
            this.comboBoxAprobadorExc.Items.AddRange(new object[] {
            "Liliana Alvarez",
            "Tamara Caplan",
            "Patricia Wissar"});
            this.comboBoxAprobadorExc.Location = new System.Drawing.Point(122, 59);
            this.comboBoxAprobadorExc.Name = "comboBoxAprobadorExc";
            this.comboBoxAprobadorExc.Size = new System.Drawing.Size(252, 21);
            this.comboBoxAprobadorExc.TabIndex = 0;
            // 
            // cac
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 212);
            this.Controls.Add(this.groupBoxExcepcion);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.groupBoxMedioMayor);
            this.Controls.Add(this.groupBoxEmergencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cac";
            this.Text = "cac";
            this.Load += new System.EventHandler(this.cac_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.cac_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.cac_DragEnter);
            this.groupBoxEmergencia.ResumeLayout(false);
            this.groupBoxEmergencia.PerformLayout();
            this.groupBoxMedioMayor.ResumeLayout(false);
            this.groupBoxMedioMayor.PerformLayout();
            this.groupBoxExcepcion.ResumeLayout(false);
            this.groupBoxExcepcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmergencia;
        private System.Windows.Forms.GroupBox groupBoxMedioMayor;
        private System.Windows.Forms.ComboBox comboBoxAprobador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAprobacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCAC;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtincidente;
        private System.Windows.Forms.GroupBox groupBoxExcepcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxAprobadorExc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorraporemer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcorreocomite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcorraporexce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMotivo;
    }
}