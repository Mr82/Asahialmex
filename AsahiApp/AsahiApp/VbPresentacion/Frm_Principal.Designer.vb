﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Men_Principal = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecursosHumanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaListadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreNominaGlobalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChecadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaEmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDePruducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiniquitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Men_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Men_Principal
        '
        Me.Men_Principal.BackColor = System.Drawing.Color.SteelBlue
        Me.Men_Principal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.Men_Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.RecursosHumanosToolStripMenuItem, Me.ControlDePruducciónToolStripMenuItem, Me.CalidadToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.Men_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Men_Principal.Name = "Men_Principal"
        Me.Men_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Men_Principal.Size = New System.Drawing.Size(743, 24)
        Me.Men_Principal.TabIndex = 2
        Me.Men_Principal.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'RecursosHumanosToolStripMenuItem
        '
        Me.RecursosHumanosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreNominaToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.RecursosHumanosToolStripMenuItem.Name = "RecursosHumanosToolStripMenuItem"
        Me.RecursosHumanosToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.RecursosHumanosToolStripMenuItem.Text = "Recursos Humanos"
        '
        'PreNominaToolStripMenuItem
        '
        Me.PreNominaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreNominaListadoToolStripMenuItem, Me.PreNominaGlobalToolStripMenuItem, Me.ChecadasToolStripMenuItem, Me.ComidasToolStripMenuItem})
        Me.PreNominaToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.prenomina
        Me.PreNominaToolStripMenuItem.Name = "PreNominaToolStripMenuItem"
        Me.PreNominaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaToolStripMenuItem.Text = "Pre nomina"
        '
        'PreNominaListadoToolStripMenuItem
        '
        Me.PreNominaListadoToolStripMenuItem.Name = "PreNominaListadoToolStripMenuItem"
        Me.PreNominaListadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaListadoToolStripMenuItem.Text = "Pre nomina Listado"
        '
        'PreNominaGlobalToolStripMenuItem
        '
        Me.PreNominaGlobalToolStripMenuItem.Name = "PreNominaGlobalToolStripMenuItem"
        Me.PreNominaGlobalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreNominaGlobalToolStripMenuItem.Text = "Pre nomina Global"
        '
        'ChecadasToolStripMenuItem
        '
        Me.ChecadasToolStripMenuItem.Name = "ChecadasToolStripMenuItem"
        Me.ChecadasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChecadasToolStripMenuItem.Text = "Checadas"
        '
        'ComidasToolStripMenuItem
        '
        Me.ComidasToolStripMenuItem.Name = "ComidasToolStripMenuItem"
        Me.ComidasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ComidasToolStripMenuItem.Text = "Comedor"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaEmpleadosToolStripMenuItem, Me.BajaEmpleadosToolStripMenuItem1})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'BajaEmpleadosToolStripMenuItem
        '
        Me.BajaEmpleadosToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Alta2
        Me.BajaEmpleadosToolStripMenuItem.Name = "BajaEmpleadosToolStripMenuItem"
        Me.BajaEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BajaEmpleadosToolStripMenuItem.Text = "Alta Empleados"
        '
        'BajaEmpleadosToolStripMenuItem1
        '
        Me.BajaEmpleadosToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.Baja2
        Me.BajaEmpleadosToolStripMenuItem1.Name = "BajaEmpleadosToolStripMenuItem1"
        Me.BajaEmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BajaEmpleadosToolStripMenuItem1.Text = "Baja Empleados"
        '
        'ControlDePruducciónToolStripMenuItem
        '
        Me.ControlDePruducciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlDeProducciónToolStripMenuItem})
        Me.ControlDePruducciónToolStripMenuItem.Name = "ControlDePruducciónToolStripMenuItem"
        Me.ControlDePruducciónToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.ControlDePruducciónToolStripMenuItem.Text = "Control de Producción"
        '
        'ControlDeProducciónToolStripMenuItem
        '
        Me.ControlDeProducciónToolStripMenuItem.Name = "ControlDeProducciónToolStripMenuItem"
        Me.ControlDeProducciónToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ControlDeProducciónToolStripMenuItem.Text = "Control de Producción"
        '
        'CalidadToolStripMenuItem
        '
        Me.CalidadToolStripMenuItem.Name = "CalidadToolStripMenuItem"
        Me.CalidadToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.CalidadToolStripMenuItem.Text = "Calidad"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACercaDeToolStripMenuItem, Me.AcercaDeToolStripMenuItem1})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ACercaDeToolStripMenuItem
        '
        Me.ACercaDeToolStripMenuItem.Name = "ACercaDeToolStripMenuItem"
        Me.ACercaDeToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ACercaDeToolStripMenuItem.Text = "Soporte Técnico"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(159, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformaciónToolStripMenuItem, Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'InformaciónToolStripMenuItem
        '
        Me.InformaciónToolStripMenuItem.Name = "InformaciónToolStripMenuItem"
        Me.InformaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformaciónToolStripMenuItem.Text = "Detalle"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FiniquitoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'FiniquitoToolStripMenuItem
        '
        Me.FiniquitoToolStripMenuItem.Name = "FiniquitoToolStripMenuItem"
        Me.FiniquitoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FiniquitoToolStripMenuItem.Text = "Finiquito"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(743, 440)
        Me.Controls.Add(Me.Men_Principal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Men_Principal
        Me.ClientSize = New System.Drawing.Size(751, 450)
        Me.Controls.Add(Me.Men_Principal)
        Me.MainMenuStrip = Me.Men_Principal
        Me.Name = "Frm_Principal"
        Me.Text = "SAMM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Men_Principal.ResumeLayout(False)
        Me.Men_Principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Men_Principal As MenuStrip
    Friend WithEvents RecursosHumanosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDePruducciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaListadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreNominaGlobalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChecadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlDeProducciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaEmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CalidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FiniquitoToolStripMenuItem As ToolStripMenuItem
End Class