namespace IGBJ_Programacion2
{
    partial class modificarPaciente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtpaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txthistorial = new System.Windows.Forms.TextBox();
            this.txtnro = new System.Windows.Forms.TextBox();
            this.txtapellidoM = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txthospital = new System.Windows.Forms.TextBox();
            this.cmdcategoria = new System.Windows.Forms.ComboBox();
            this.cmdpaciente = new System.Windows.Forms.ComboBox();
            this.cmdcat = new System.Windows.Forms.ComboBox();
            this.cmdidtipo = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.txtsexo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(431, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(112, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtpaciente
            // 
            this.txtpaciente.Location = new System.Drawing.Point(6, 19);
            this.txtpaciente.Name = "txtpaciente";
            this.txtpaciente.Size = new System.Drawing.Size(100, 20);
            this.txtpaciente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(485, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nro de historial clinico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nro Cedula";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sexo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Telefono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(485, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Hospital de Procedimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 267);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Tipo de Paciente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(485, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nombre de categoria";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(596, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 16;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(596, 150);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 17;
            // 
            // txthistorial
            // 
            this.txthistorial.Location = new System.Drawing.Point(596, 5);
            this.txthistorial.Name = "txthistorial";
            this.txthistorial.Size = new System.Drawing.Size(125, 20);
            this.txthistorial.TabIndex = 18;
            // 
            // txtnro
            // 
            this.txtnro.Location = new System.Drawing.Point(596, 29);
            this.txtnro.Name = "txtnro";
            this.txtnro.Size = new System.Drawing.Size(100, 20);
            this.txtnro.TabIndex = 19;
            // 
            // txtapellidoM
            // 
            this.txtapellidoM.Location = new System.Drawing.Point(596, 106);
            this.txtapellidoM.Name = "txtapellidoM";
            this.txtapellidoM.Size = new System.Drawing.Size(100, 20);
            this.txtapellidoM.TabIndex = 20;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(596, 80);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(596, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(596, 195);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 25;
            // 
            // txthospital
            // 
            this.txthospital.Location = new System.Drawing.Point(621, 226);
            this.txthospital.Name = "txthospital";
            this.txthospital.Size = new System.Drawing.Size(100, 20);
            this.txthospital.TabIndex = 26;
            // 
            // cmdcategoria
            // 
            this.cmdcategoria.FormattingEnabled = true;
            this.cmdcategoria.Location = new System.Drawing.Point(613, 287);
            this.cmdcategoria.Name = "cmdcategoria";
            this.cmdcategoria.Size = new System.Drawing.Size(121, 21);
            this.cmdcategoria.TabIndex = 27;
            this.cmdcategoria.SelectedIndexChanged += new System.EventHandler(this.cmdcategoria_SelectedIndexChanged);
            // 
            // cmdpaciente
            // 
            this.cmdpaciente.FormattingEnabled = true;
            this.cmdpaciente.Location = new System.Drawing.Point(613, 259);
            this.cmdpaciente.Name = "cmdpaciente";
            this.cmdpaciente.Size = new System.Drawing.Size(121, 21);
            this.cmdpaciente.TabIndex = 28;
            this.cmdpaciente.SelectedIndexChanged += new System.EventHandler(this.cmdpaciente_SelectedIndexChanged);
            // 
            // cmdcat
            // 
            this.cmdcat.FormattingEnabled = true;
            this.cmdcat.Location = new System.Drawing.Point(749, 286);
            this.cmdcat.Name = "cmdcat";
            this.cmdcat.Size = new System.Drawing.Size(121, 21);
            this.cmdcat.TabIndex = 29;
            // 
            // cmdidtipo
            // 
            this.cmdidtipo.FormattingEnabled = true;
            this.cmdidtipo.Location = new System.Drawing.Point(749, 259);
            this.cmdidtipo.Name = "cmdidtipo";
            this.cmdidtipo.Size = new System.Drawing.Size(121, 21);
            this.cmdidtipo.TabIndex = 30;
            this.cmdidtipo.SelectedIndexChanged += new System.EventHandler(this.cmdidtipo_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(729, 7);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(37, 20);
            this.txtid.TabIndex = 31;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(596, 325);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtid2
            // 
            this.txtid2.Location = new System.Drawing.Point(900, 292);
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(100, 20);
            this.txtid2.TabIndex = 33;
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(900, 259);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(100, 20);
            this.txtid1.TabIndex = 34;
            // 
            // txtsexo
            // 
            this.txtsexo.Location = new System.Drawing.Point(596, 172);
            this.txtsexo.Name = "txtsexo";
            this.txtsexo.Size = new System.Drawing.Size(100, 20);
            this.txtsexo.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtpaciente);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 302);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Paciente";
            // 
            // modificarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGBJ_Programacion2.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtsexo);
            this.Controls.Add(this.txtid1);
            this.Controls.Add(this.txtid2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmdidtipo);
            this.Controls.Add(this.cmdcat);
            this.Controls.Add(this.cmdpaciente);
            this.Controls.Add(this.cmdcategoria);
            this.Controls.Add(this.txthospital);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtapellidoM);
            this.Controls.Add(this.txtnro);
            this.Controls.Add(this.txthistorial);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "modificarPaciente";
            this.Text = "modificarPaciente";
            this.Load += new System.EventHandler(this.modificarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtpaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txthistorial;
        private System.Windows.Forms.TextBox txtnro;
        private System.Windows.Forms.TextBox txtapellidoM;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txthospital;
        private System.Windows.Forms.ComboBox cmdcategoria;
        private System.Windows.Forms.ComboBox cmdpaciente;
        private System.Windows.Forms.ComboBox cmdcat;
        private System.Windows.Forms.ComboBox cmdidtipo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.TextBox txtsexo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}