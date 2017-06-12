namespace IGBJ_Programacion2
{
    partial class Form2
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
            this.cmdEstudio = new System.Windows.Forms.ComboBox();
            this.cmdTurno = new System.Windows.Forms.ComboBox();
            this.dtgbuscador = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Programacion11 = new IGBJ_Programacion2.Programacion1();
            this.SuspendLayout();
            // 
            // cmdEstudio
            // 
            this.cmdEstudio.FormattingEnabled = true;
            this.cmdEstudio.Location = new System.Drawing.Point(232, 8);
            this.cmdEstudio.Name = "cmdEstudio";
            this.cmdEstudio.Size = new System.Drawing.Size(121, 21);
            this.cmdEstudio.TabIndex = 0;
            this.cmdEstudio.SelectedIndexChanged += new System.EventHandler(this.cmdEstudio_SelectedIndexChanged);
            // 
            // cmdTurno
            // 
            this.cmdTurno.FormattingEnabled = true;
            this.cmdTurno.Location = new System.Drawing.Point(394, 6);
            this.cmdTurno.Name = "cmdTurno";
            this.cmdTurno.Size = new System.Drawing.Size(121, 21);
            this.cmdTurno.TabIndex = 1;
            this.cmdTurno.SelectedIndexChanged += new System.EventHandler(this.cmdTurno_SelectedIndexChanged);
            // 
            // dtgbuscador
            // 
            this.dtgbuscador.Location = new System.Drawing.Point(12, 9);
            this.dtgbuscador.Name = "dtgbuscador";
            this.dtgbuscador.Size = new System.Drawing.Size(200, 20);
            this.dtgbuscador.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(555, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.CachedPageNumberPerDoc = 10;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 35);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Programacion11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(915, 448);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 378);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dtgbuscador);
            this.Controls.Add(this.cmdTurno);
            this.Controls.Add(this.cmdEstudio);
            this.Name = "Form2";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdEstudio;
        private System.Windows.Forms.ComboBox cmdTurno;
        private System.Windows.Forms.DateTimePicker dtgbuscador;
        private System.Windows.Forms.Button btnbuscar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Programacion1 Programacion11;
    }
}