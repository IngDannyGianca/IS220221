﻿
namespace CapaVistaRRHH
{
    partial class frmMDIRRHH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIRRHH));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDeNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaNóminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generaciónDeNóminaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liquidaciónEmpeladoIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSeciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSeciónToolStripMenuItem
            // 
            this.cerrarSeciónToolStripMenuItem.Name = "cerrarSeciónToolStripMenuItem";
            this.cerrarSeciónToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cerrarSeciónToolStripMenuItem.Text = "Cerrar Seción";
            this.cerrarSeciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeciónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptosToolStripMenuItem1,
            this.cuentasContablesToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // conceptosToolStripMenuItem1
            // 
            this.conceptosToolStripMenuItem1.Name = "conceptosToolStripMenuItem1";
            this.conceptosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.conceptosToolStripMenuItem1.Text = "Conceptos";
            this.conceptosToolStripMenuItem1.Click += new System.EventHandler(this.conceptosToolStripMenuItem1_Click);
            // 
            // cuentasContablesToolStripMenuItem
            // 
            this.cuentasContablesToolStripMenuItem.Name = "cuentasContablesToolStripMenuItem";
            this.cuentasContablesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuentasContablesToolStripMenuItem.Text = "Cuentas Contables";
            this.cuentasContablesToolStripMenuItem.Click += new System.EventHandler(this.cuentasContablesToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem,
            this.generaciónDeNóminaToolStripMenuItem,
            this.liquidacionesToolStripMenuItem,
            this.vacacionesToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // asignaciónDeEmpleadosAConceptosToolStripMenuItem
            // 
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem.Name = "asignaciónDeEmpleadosAConceptosToolStripMenuItem";
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem.Text = "Asignación de Empleados a Conceptos";
            this.asignaciónDeEmpleadosAConceptosToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeEmpleadosAConceptosToolStripMenuItem_Click);
            // 
            // generaciónDeNóminaToolStripMenuItem
            // 
            this.generaciónDeNóminaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaNóminaToolStripMenuItem,
            this.generaciónDeNóminaToolStripMenuItem1});
            this.generaciónDeNóminaToolStripMenuItem.Name = "generaciónDeNóminaToolStripMenuItem";
            this.generaciónDeNóminaToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.generaciónDeNóminaToolStripMenuItem.Text = "Generación de Nómina";
            this.generaciónDeNóminaToolStripMenuItem.Click += new System.EventHandler(this.generaciónDeNóminaToolStripMenuItem_Click);
            // 
            // consultaNóminaToolStripMenuItem
            // 
            this.consultaNóminaToolStripMenuItem.Name = "consultaNóminaToolStripMenuItem";
            this.consultaNóminaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.consultaNóminaToolStripMenuItem.Text = "Consulta Nómina";
            this.consultaNóminaToolStripMenuItem.Click += new System.EventHandler(this.consultaNóminaToolStripMenuItem_Click);
            // 
            // generaciónDeNóminaToolStripMenuItem1
            // 
            this.generaciónDeNóminaToolStripMenuItem1.Name = "generaciónDeNóminaToolStripMenuItem1";
            this.generaciónDeNóminaToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.generaciónDeNóminaToolStripMenuItem1.Text = "Generación de Nómina";
            this.generaciónDeNóminaToolStripMenuItem1.Click += new System.EventHandler(this.generaciónDeNóminaToolStripMenuItem1_Click);
            // 
            // liquidacionesToolStripMenuItem
            // 
            this.liquidacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liquidaciónEmpeladoIndividualToolStripMenuItem,
            this.consultarLiquidaciónToolStripMenuItem});
            this.liquidacionesToolStripMenuItem.Name = "liquidacionesToolStripMenuItem";
            this.liquidacionesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.liquidacionesToolStripMenuItem.Text = "Liquidaciones";
            // 
            // liquidaciónEmpeladoIndividualToolStripMenuItem
            // 
            this.liquidaciónEmpeladoIndividualToolStripMenuItem.Name = "liquidaciónEmpeladoIndividualToolStripMenuItem";
            this.liquidaciónEmpeladoIndividualToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.liquidaciónEmpeladoIndividualToolStripMenuItem.Text = "Liquidación Empelado Individual";
            this.liquidaciónEmpeladoIndividualToolStripMenuItem.Click += new System.EventHandler(this.liquidaciónEmpeladoIndividualToolStripMenuItem_Click);
            // 
            // consultarLiquidaciónToolStripMenuItem
            // 
            this.consultarLiquidaciónToolStripMenuItem.Name = "consultarLiquidaciónToolStripMenuItem";
            this.consultarLiquidaciónToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.consultarLiquidaciónToolStripMenuItem.Text = "Consultar Liquidación";
            this.consultarLiquidaciónToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidaciónToolStripMenuItem_Click);
            // 
            // vacacionesToolStripMenuItem
            // 
            this.vacacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.consultaDeVacacionesToolStripMenuItem});
            this.vacacionesToolStripMenuItem.Name = "vacacionesToolStripMenuItem";
            this.vacacionesToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.vacacionesToolStripMenuItem.Text = "Vacaciones";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gestiónToolStripMenuItem.Text = "Asignación de Vacaciones";
            this.gestiónToolStripMenuItem.Click += new System.EventHandler(this.gestiónToolStripMenuItem_Click);
            // 
            // consultaDeVacacionesToolStripMenuItem
            // 
            this.consultaDeVacacionesToolStripMenuItem.Name = "consultaDeVacacionesToolStripMenuItem";
            this.consultaDeVacacionesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.consultaDeVacacionesToolStripMenuItem.Text = "Gestor de Vacaciones";
            this.consultaDeVacacionesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeVacacionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polizaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.polizaToolStripMenuItem.Text = "Poliza Planilla";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // ayudasToolStripMenuItem
            // 
            this.ayudasToolStripMenuItem.Name = "ayudasToolStripMenuItem";
            this.ayudasToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ayudasToolStripMenuItem.Text = "Ayudas";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(700, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Visible = false;
            // 
            // frmMDIRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDIRRHH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2001 MDI 0901-18-18686 Danny Giancarlo Saldaña Salguero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMDIRRHH_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem cuentasContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generaciónDeNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaNóminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generaciónDeNóminaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeEmpleadosAConceptosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vacacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaDeVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liquidaciónEmpeladoIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidaciónToolStripMenuItem;
    }
}