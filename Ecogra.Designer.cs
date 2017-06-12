namespace IGBJ_Programacion2
{
    partial class Ecogra
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dtgbuscador = new System.Windows.Forms.DateTimePicker();
            this.cmdTurno = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Ecografia1 = new IGBJ_Programacion2.Ecografia();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(382, 9);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dtgbuscador
            // 
            this.dtgbuscador.Location = new System.Drawing.Point(12, 12);
            this.dtgbuscador.Name = "dtgbuscador";
            this.dtgbuscador.Size = new System.Drawing.Size(200, 20);
            this.dtgbuscador.TabIndex = 6;
            // 
            // cmdTurno
            // 
            this.cmdTurno.FormattingEnabled = true;
            this.cmdTurno.Location = new System.Drawing.Point(229, 12);
            this.cmdTurno.Name = "cmdTurno";
            this.cmdTurno.Size = new System.Drawing.Size(121, 21);
            this.cmdTurno.TabIndex = 5;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.CachedPageNumberPerDoc = 10;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Ecografia1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(782, 396);
            this.crystalReportViewer1.TabIndex = 8;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Ecogra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 431);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dtgbuscador);
            this.Controls.Add(this.cmdTurno);
            this.Name = "Ecogra";
            this.Text = "Ecogra";
            this.Load += new System.EventHandler(this.Ecogra_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DateTimePicker dtgbuscador;
        private System.Windows.Forms.ComboBox cmdTurno;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Ecografia Ecografia1;
    }
}