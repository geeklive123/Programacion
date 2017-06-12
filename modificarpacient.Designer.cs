namespace IGBJ_Programacion2
{
    partial class modificarpacient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarpacient));
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cmdpaciente = new System.Windows.Forms.ComboBox();
            this.cmdpaciente2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.liscodigo = new System.Windows.Forms.ListBox();
            this.lisprocedimiento = new System.Windows.Forms.ListBox();
            this.txtbuscar2 = new System.Windows.Forms.TextBox();
            this.cmdprocedimiento = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.cmdturno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtturno = new System.Windows.Forms.TextBox();
            this.cmdid = new System.Windows.Forms.ComboBox();
            this.txtidprg = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.Location = new System.Drawing.Point(127, 15);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(129, 26);
            this.btnbuscar1.TabIndex = 0;
            this.btnbuscar1.Text = "Buscar Paciente";
            this.btnbuscar1.UseVisualStyleBackColor = true;
            this.btnbuscar1.Click += new System.EventHandler(this.btnbuscar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(9, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 3;
            // 
            // cmdpaciente
            // 
            this.cmdpaciente.FormattingEnabled = true;
            this.cmdpaciente.Location = new System.Drawing.Point(50, 16);
            this.cmdpaciente.Name = "cmdpaciente";
            this.cmdpaciente.Size = new System.Drawing.Size(121, 21);
            this.cmdpaciente.TabIndex = 4;
            // 
            // cmdpaciente2
            // 
            this.cmdpaciente2.FormattingEnabled = true;
            this.cmdpaciente2.Location = new System.Drawing.Point(6, 38);
            this.cmdpaciente2.Name = "cmdpaciente2";
            this.cmdpaciente2.Size = new System.Drawing.Size(58, 21);
            this.cmdpaciente2.TabIndex = 5;
            this.cmdpaciente2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Procedimiento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // liscodigo
            // 
            this.liscodigo.FormattingEnabled = true;
            this.liscodigo.Location = new System.Drawing.Point(12, 42);
            this.liscodigo.Name = "liscodigo";
            this.liscodigo.Size = new System.Drawing.Size(53, 95);
            this.liscodigo.TabIndex = 9;
            this.liscodigo.Visible = false;
            // 
            // lisprocedimiento
            // 
            this.lisprocedimiento.FormattingEnabled = true;
            this.lisprocedimiento.Location = new System.Drawing.Point(86, 42);
            this.lisprocedimiento.Name = "lisprocedimiento";
            this.lisprocedimiento.Size = new System.Drawing.Size(148, 95);
            this.lisprocedimiento.TabIndex = 10;
            this.lisprocedimiento.SelectedIndexChanged += new System.EventHandler(this.lisprocedimiento_SelectedIndexChanged);
            // 
            // txtbuscar2
            // 
            this.txtbuscar2.Location = new System.Drawing.Point(268, 15);
            this.txtbuscar2.Name = "txtbuscar2";
            this.txtbuscar2.Size = new System.Drawing.Size(51, 20);
            this.txtbuscar2.TabIndex = 11;
            this.txtbuscar2.Visible = false;
            // 
            // cmdprocedimiento
            // 
            this.cmdprocedimiento.Location = new System.Drawing.Point(86, 16);
            this.cmdprocedimiento.Name = "cmdprocedimiento";
            this.cmdprocedimiento.Size = new System.Drawing.Size(100, 20);
            this.cmdprocedimiento.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(65, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Observacion";
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(71, 256);
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(194, 20);
            this.txtobs.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(533, 211);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(70, 38);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 18;
            this.textBox5.Visible = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(114, 284);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 19;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // cmdturno
            // 
            this.cmdturno.FormattingEnabled = true;
            this.cmdturno.Location = new System.Drawing.Point(47, 16);
            this.cmdturno.Name = "cmdturno";
            this.cmdturno.Size = new System.Drawing.Size(121, 21);
            this.cmdturno.TabIndex = 20;
            this.cmdturno.SelectedIndexChanged += new System.EventHandler(this.cmdturno_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Turno";
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(70, 40);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(47, 20);
            this.txtturno.TabIndex = 22;
            this.txtturno.Visible = false;
            // 
            // cmdid
            // 
            this.cmdid.FormattingEnabled = true;
            this.cmdid.Location = new System.Drawing.Point(6, 39);
            this.cmdid.Name = "cmdid";
            this.cmdid.Size = new System.Drawing.Size(58, 21);
            this.cmdid.TabIndex = 23;
            this.cmdid.Visible = false;
            // 
            // txtidprg
            // 
            this.txtidprg.Location = new System.Drawing.Point(338, 116);
            this.txtidprg.Name = "txtidprg";
            this.txtidprg.Size = new System.Drawing.Size(55, 20);
            this.txtidprg.TabIndex = 24;
            this.txtidprg.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdpaciente);
            this.groupBox1.Controls.Add(this.cmdpaciente2);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 65);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Paciente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmdprocedimiento);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.liscodigo);
            this.groupBox2.Controls.Add(this.lisprocedimiento);
            this.groupBox2.Controls.Add(this.txtbuscar2);
            this.groupBox2.Location = new System.Drawing.Point(3, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 148);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Procedimiento";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmdturno);
            this.groupBox3.Controls.Add(this.cmdid);
            this.groupBox3.Controls.Add(this.txtturno);
            this.groupBox3.Location = new System.Drawing.Point(209, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 66);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del turno";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.txtbuscar);
            this.groupBox4.Controls.Add(this.btnbuscar1);
            this.groupBox4.Location = new System.Drawing.Point(445, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(563, 283);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Buscar Paciente";
            // 
            // modificarpacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IGBJ_Programacion2.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 344);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtidprg);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modificarpacient";
            this.Text = "Modificar Paciente";
            this.Load += new System.EventHandler(this.modificarpacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cmdpaciente;
        private System.Windows.Forms.ComboBox cmdpaciente2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox liscodigo;
        private System.Windows.Forms.ListBox lisprocedimiento;
        private System.Windows.Forms.TextBox txtbuscar2;
        private System.Windows.Forms.TextBox cmdprocedimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.ComboBox cmdturno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtturno;
        private System.Windows.Forms.ComboBox cmdid;
        private System.Windows.Forms.TextBox txtidprg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}