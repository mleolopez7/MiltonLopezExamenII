namespace ExamenII_Vista
{
    partial class NuevoTicketForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.ImpuestoTextBox = new System.Windows.Forms.TextBox();
            this.SolicitudTextBox = new System.Windows.Forms.TextBox();
            this.RespuestaTextBox = new System.Windows.Forms.TextBox();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.SoporteComboBox = new System.Windows.Forms.ComboBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Soporte :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripción de la Solicitud :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descuento: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Impuesto :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Descripción de la Respuesta :";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Enabled = false;
            this.UsuarioTextBox.Location = new System.Drawing.Point(230, 67);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(243, 24);
            this.UsuarioTextBox.TabIndex = 11;
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Enabled = false;
            this.ClienteTextBox.Location = new System.Drawing.Point(230, 114);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(243, 24);
            this.ClienteTextBox.TabIndex = 12;
            // 
            // ImpuestoTextBox
            // 
            this.ImpuestoTextBox.Enabled = false;
            this.ImpuestoTextBox.Location = new System.Drawing.Point(230, 311);
            this.ImpuestoTextBox.Name = "ImpuestoTextBox";
            this.ImpuestoTextBox.Size = new System.Drawing.Size(243, 24);
            this.ImpuestoTextBox.TabIndex = 13;
            // 
            // SolicitudTextBox
            // 
            this.SolicitudTextBox.Enabled = false;
            this.SolicitudTextBox.Location = new System.Drawing.Point(230, 192);
            this.SolicitudTextBox.Name = "SolicitudTextBox";
            this.SolicitudTextBox.Size = new System.Drawing.Size(243, 24);
            this.SolicitudTextBox.TabIndex = 14;
            // 
            // RespuestaTextBox
            // 
            this.RespuestaTextBox.Enabled = false;
            this.RespuestaTextBox.Location = new System.Drawing.Point(230, 231);
            this.RespuestaTextBox.Name = "RespuestaTextBox";
            this.RespuestaTextBox.Size = new System.Drawing.Size(243, 24);
            this.RespuestaTextBox.TabIndex = 15;
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Location = new System.Drawing.Point(230, 272);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(243, 24);
            this.PrecioTextBox.TabIndex = 16;
            // 
            // DescuentoTextBox
            // 
            this.DescuentoTextBox.Enabled = false;
            this.DescuentoTextBox.Location = new System.Drawing.Point(230, 349);
            this.DescuentoTextBox.Name = "DescuentoTextBox";
            this.DescuentoTextBox.Size = new System.Drawing.Size(243, 24);
            this.DescuentoTextBox.TabIndex = 17;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(230, 390);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(243, 24);
            this.TotalTextBox.TabIndex = 18;
            // 
            // SoporteComboBox
            // 
            this.SoporteComboBox.Enabled = false;
            this.SoporteComboBox.FormattingEnabled = true;
            this.SoporteComboBox.Items.AddRange(new object[] {
            "Celulares",
            "Equipo de Computo"});
            this.SoporteComboBox.Location = new System.Drawing.Point(230, 152);
            this.SoporteComboBox.Name = "SoporteComboBox";
            this.SoporteComboBox.Size = new System.Drawing.Size(243, 26);
            this.SoporteComboBox.TabIndex = 19;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(125, 439);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(99, 41);
            this.NuevoButton.TabIndex = 20;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Enabled = false;
            this.CalcularButton.Location = new System.Drawing.Point(230, 439);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(99, 41);
            this.CalcularButton.TabIndex = 21;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Enabled = false;
            this.SalirButton.Location = new System.Drawing.Point(285, 486);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(99, 41);
            this.SalirButton.TabIndex = 22;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Enabled = false;
            this.CancelarButton.Location = new System.Drawing.Point(180, 486);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(99, 41);
            this.CancelarButton.TabIndex = 25;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Enabled = false;
            this.AgregarButton.Location = new System.Drawing.Point(335, 439);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(99, 41);
            this.AgregarButton.TabIndex = 24;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.Enabled = false;
            this.FechaTimePicker.Location = new System.Drawing.Point(230, 25);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(243, 24);
            this.FechaTimePicker.TabIndex = 26;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NuevoTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 550);
            this.Controls.Add(this.FechaTimePicker);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.SoporteComboBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.DescuentoTextBox);
            this.Controls.Add(this.PrecioTextBox);
            this.Controls.Add(this.RespuestaTextBox);
            this.Controls.Add(this.SolicitudTextBox);
            this.Controls.Add(this.ImpuestoTextBox);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NuevoTicketForm";
            this.Text = "Nuevo Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.TextBox ImpuestoTextBox;
        private System.Windows.Forms.TextBox SolicitudTextBox;
        private System.Windows.Forms.TextBox RespuestaTextBox;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.TextBox DescuentoTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.ComboBox SoporteComboBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}