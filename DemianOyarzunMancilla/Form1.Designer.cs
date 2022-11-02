namespace DemianOyarzunMancilla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRutExistente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailExistente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCelularExistente = new System.Windows.Forms.TextBox();
            this.txtNombreExistente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHora = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.calendarioDate = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBarba = new System.Windows.Forms.CheckBox();
            this.chkCabello = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lstReservas = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 562);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.cboHora);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.calendarioDate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.chkBarba);
            this.tabPage1.Controls.Add(this.chkCabello);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Reserva";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboRutExistente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmailExistente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCelularExistente);
            this.groupBox2.Controls.Add(this.txtNombreExistente);
            this.groupBox2.Location = new System.Drawing.Point(379, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 221);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente Existente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "E-mail";
            // 
            // cboRutExistente
            // 
            this.cboRutExistente.FormattingEnabled = true;
            this.cboRutExistente.Location = new System.Drawing.Point(77, 31);
            this.cboRutExistente.Name = "cboRutExistente";
            this.cboRutExistente.Size = new System.Drawing.Size(121, 23);
            this.cboRutExistente.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Celular";
            // 
            // txtEmailExistente
            // 
            this.txtEmailExistente.Location = new System.Drawing.Point(77, 151);
            this.txtEmailExistente.Name = "txtEmailExistente";
            this.txtEmailExistente.Size = new System.Drawing.Size(178, 23);
            this.txtEmailExistente.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nombre";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "RUT";
            // 
            // txtCelularExistente
            // 
            this.txtCelularExistente.Location = new System.Drawing.Point(77, 112);
            this.txtCelularExistente.Name = "txtCelularExistente";
            this.txtCelularExistente.Size = new System.Drawing.Size(91, 23);
            this.txtCelularExistente.TabIndex = 26;
            // 
            // txtNombreExistente
            // 
            this.txtNombreExistente.Location = new System.Drawing.Point(77, 70);
            this.txtNombreExistente.Name = "txtNombreExistente";
            this.txtNombreExistente.Size = new System.Drawing.Size(178, 23);
            this.txtNombreExistente.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 221);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ClienteNuevo";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 159);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(68, 114);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 23);
            this.txtCelular.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 23);
            this.txtNombre.TabIndex = 17;
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(68, 36);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(97, 23);
            this.txtRut.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "RUT";
            // 
            // cboHora
            // 
            this.cboHora.FormattingEnabled = true;
            this.cboHora.Items.AddRange(new object[] {
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.cboHora.Location = new System.Drawing.Point(418, 100);
            this.cboHora.Name = "cboHora";
            this.cboHora.Size = new System.Drawing.Size(121, 23);
            this.cboHora.TabIndex = 8;
            this.cboHora.Text = "HORA:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(545, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(132, 28);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(418, 203);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 28);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar Formulario";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(418, 144);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(259, 38);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar Reserva";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // calendarioDate
            // 
            this.calendarioDate.Location = new System.Drawing.Point(112, 90);
            this.calendarioDate.Name = "calendarioDate";
            this.calendarioDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha y Hora:";
            // 
            // chkBarba
            // 
            this.chkBarba.AutoSize = true;
            this.chkBarba.Location = new System.Drawing.Point(418, 25);
            this.chkBarba.Name = "chkBarba";
            this.chkBarba.Size = new System.Drawing.Size(56, 19);
            this.chkBarba.TabIndex = 2;
            this.chkBarba.Text = "Barba";
            this.chkBarba.UseVisualStyleBackColor = true;
            // 
            // chkCabello
            // 
            this.chkCabello.AutoSize = true;
            this.chkCabello.Location = new System.Drawing.Point(321, 25);
            this.chkCabello.Name = "chkCabello";
            this.chkCabello.Size = new System.Drawing.Size(66, 19);
            this.chkCabello.TabIndex = 1;
            this.chkCabello.Text = "Cabello";
            this.chkCabello.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de atención:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalir2);
            this.tabPage2.Controls.Add(this.lstReservas);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mostrar Reserva";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalir2
            // 
            this.btnSalir2.Location = new System.Drawing.Point(354, 485);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(75, 23);
            this.btnSalir2.TabIndex = 1;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // lstReservas
            // 
            this.lstReservas.Location = new System.Drawing.Point(21, 18);
            this.lstReservas.Name = "lstReservas";
            this.lstReservas.Size = new System.Drawing.Size(729, 443);
            this.lstReservas.TabIndex = 0;
            this.lstReservas.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Barberia";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox2;
        private ComboBox cboRutExistente;
        private TextBox txtEmailExistente;
        private Button btnBuscar;
        private TextBox txtCelularExistente;
        private TextBox txtNombreExistente;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtCelular;
        private TextBox txtNombre;
        private TextBox txtRut;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboHora;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnIngresar;
        private MonthCalendar calendarioDate;
        private Label label2;
        private CheckBox chkBarba;
        private CheckBox chkCabello;
        private Label label1;
        private TabPage tabPage2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnSalir2;
        private ListView lstReservas;
    }
}