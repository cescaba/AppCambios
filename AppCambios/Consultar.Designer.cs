namespace AppCambios
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtcodbuscar);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por:";
            // 
            // txtcodbuscar
            // 
            this.txtcodbuscar.Location = new System.Drawing.Point(144, 30);
            this.txtcodbuscar.Name = "txtcodbuscar";
            this.txtcodbuscar.Size = new System.Drawing.Size(105, 20);
            this.txtcodbuscar.TabIndex = 1;
            this.txtcodbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodbuscar_KeyDown);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(264, 28);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(60, 23);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Código",
            "Ticket Asociado",
            "Ticket Tercero"});
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 93);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Consultar_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Consultar_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Consultar_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}