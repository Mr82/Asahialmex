﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Gastos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pct_Limpiar = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Rdb_Japones = New System.Windows.Forms.RadioButton()
        Me.Rdb_Español = New System.Windows.Forms.RadioButton()
        Me.Lbl_Año = New System.Windows.Forms.Label()
        Me.Cmb_Años = New System.Windows.Forms.ComboBox()
        Me.Lbl_Depto = New System.Windows.Forms.Label()
        Me.Lbl_Mes = New System.Windows.Forms.Label()
        Me.Cmb_Depto = New System.Windows.Forms.ComboBox()
        Me.Cmb_Meses = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Dgv_GastosDepto = New System.Windows.Forms.DataGridView()
        Me.noCta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cta2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masterP2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.real2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dif2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Dgv_GastosGlobal = New System.Windows.Forms.DataGridView()
        Me.noCta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.masterP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.real = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Lbl_CantDif = New System.Windows.Forms.Label()
        Me.Lbl_CantActualReal = New System.Windows.Forms.Label()
        Me.Lbl_CantPlan = New System.Windows.Forms.Label()
        Me.Lbl_CantMaster = New System.Windows.Forms.Label()
        Me.Lbl_CantFF2 = New System.Windows.Forms.Label()
        Me.Lbl_CantMF2 = New System.Windows.Forms.Label()
        Me.Lbl_CantFF1 = New System.Windows.Forms.Label()
        Me.Lbl_CantMF1 = New System.Windows.Forms.Label()
        Me.Lbl_MontoDif = New System.Windows.Forms.Label()
        Me.Lbl_MontoActualReal = New System.Windows.Forms.Label()
        Me.Lbl_MontoPlan = New System.Windows.Forms.Label()
        Me.Lbl_MontoMaster = New System.Windows.Forms.Label()
        Me.Lbl_MontoFF2 = New System.Windows.Forms.Label()
        Me.Lbl_MontoMF2 = New System.Windows.Forms.Label()
        Me.Lbl_MontoFF1 = New System.Windows.Forms.Label()
        Me.Lbl_MontoMF1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_Ventas = New System.Windows.Forms.Label()
        Me.Lbl_Actual = New System.Windows.Forms.Label()
        Me.Lbl_Real = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pct_Limpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Dgv_GastosDepto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.Dgv_GastosGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Pct_Limpiar)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Lbl_Año)
        Me.Panel1.Controls.Add(Me.Cmb_Años)
        Me.Panel1.Controls.Add(Me.Lbl_Depto)
        Me.Panel1.Controls.Add(Me.Lbl_Mes)
        Me.Panel1.Controls.Add(Me.Cmb_Depto)
        Me.Panel1.Controls.Add(Me.Cmb_Meses)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1256, 48)
        Me.Panel1.TabIndex = 0
        '
        'Pct_Limpiar
        '
        Me.Pct_Limpiar.Image = Global.Presentacion.My.Resources.Resources._New
        Me.Pct_Limpiar.Location = New System.Drawing.Point(477, 11)
        Me.Pct_Limpiar.Name = "Pct_Limpiar"
        Me.Pct_Limpiar.Size = New System.Drawing.Size(29, 30)
        Me.Pct_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pct_Limpiar.TabIndex = 8
        Me.Pct_Limpiar.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Rdb_Japones)
        Me.Panel10.Controls.Add(Me.Rdb_Español)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1121, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(135, 48)
        Me.Panel10.TabIndex = 6
        '
        'Rdb_Japones
        '
        Me.Rdb_Japones.AutoSize = True
        Me.Rdb_Japones.ForeColor = System.Drawing.Color.White
        Me.Rdb_Japones.Location = New System.Drawing.Point(20, 27)
        Me.Rdb_Japones.Name = "Rdb_Japones"
        Me.Rdb_Japones.Size = New System.Drawing.Size(61, 17)
        Me.Rdb_Japones.TabIndex = 1
        Me.Rdb_Japones.TabStop = True
        Me.Rdb_Japones.Text = "日本語"
        Me.Rdb_Japones.UseVisualStyleBackColor = True
        '
        'Rdb_Español
        '
        Me.Rdb_Español.AutoSize = True
        Me.Rdb_Español.ForeColor = System.Drawing.Color.White
        Me.Rdb_Español.Location = New System.Drawing.Point(20, 4)
        Me.Rdb_Español.Name = "Rdb_Español"
        Me.Rdb_Español.Size = New System.Drawing.Size(63, 17)
        Me.Rdb_Español.TabIndex = 0
        Me.Rdb_Español.TabStop = True
        Me.Rdb_Español.Text = "Español"
        Me.Rdb_Español.UseVisualStyleBackColor = True
        '
        'Lbl_Año
        '
        Me.Lbl_Año.AutoSize = True
        Me.Lbl_Año.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Año.Location = New System.Drawing.Point(155, 4)
        Me.Lbl_Año.Name = "Lbl_Año"
        Me.Lbl_Año.Size = New System.Drawing.Size(26, 13)
        Me.Lbl_Año.TabIndex = 5
        Me.Lbl_Año.Text = "Año"
        '
        'Cmb_Años
        '
        Me.Cmb_Años.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Años.FormattingEnabled = True
        Me.Cmb_Años.Location = New System.Drawing.Point(155, 22)
        Me.Cmb_Años.Name = "Cmb_Años"
        Me.Cmb_Años.Size = New System.Drawing.Size(82, 21)
        Me.Cmb_Años.TabIndex = 4
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Depto.Location = New System.Drawing.Point(260, 3)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 3
        Me.Lbl_Depto.Text = "Departamento"
        '
        'Lbl_Mes
        '
        Me.Lbl_Mes.AutoSize = True
        Me.Lbl_Mes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Lbl_Mes.Location = New System.Drawing.Point(19, 4)
        Me.Lbl_Mes.Name = "Lbl_Mes"
        Me.Lbl_Mes.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Mes.TabIndex = 2
        Me.Lbl_Mes.Text = "Mes"
        '
        'Cmb_Depto
        '
        Me.Cmb_Depto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Depto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Depto.FormattingEnabled = True
        Me.Cmb_Depto.Location = New System.Drawing.Point(263, 22)
        Me.Cmb_Depto.Name = "Cmb_Depto"
        Me.Cmb_Depto.Size = New System.Drawing.Size(182, 21)
        Me.Cmb_Depto.TabIndex = 1
        '
        'Cmb_Meses
        '
        Me.Cmb_Meses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Meses.FormattingEnabled = True
        Me.Cmb_Meses.Location = New System.Drawing.Point(19, 22)
        Me.Cmb_Meses.Name = "Cmb_Meses"
        Me.Cmb_Meses.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_Meses.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1256, 461)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 75)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1256, 386)
        Me.Panel4.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1256, 376)
        Me.Panel6.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(625, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(6, 376)
        Me.Panel9.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Dgv_GastosDepto)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(631, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(625, 376)
        Me.Panel8.TabIndex = 1
        '
        'Dgv_GastosDepto
        '
        Me.Dgv_GastosDepto.AllowUserToAddRows = False
        Me.Dgv_GastosDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_GastosDepto.ColumnHeadersVisible = False
        Me.Dgv_GastosDepto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noCta2, Me.cta2, Me.masterP2, Me.plan2, Me.real2, Me.actual2, Me.dif2})
        Me.Dgv_GastosDepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_GastosDepto.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_GastosDepto.Name = "Dgv_GastosDepto"
        Me.Dgv_GastosDepto.RowHeadersVisible = False
        Me.Dgv_GastosDepto.Size = New System.Drawing.Size(625, 376)
        Me.Dgv_GastosDepto.TabIndex = 1
        '
        'noCta2
        '
        Me.noCta2.HeaderText = "No. Cuenta"
        Me.noCta2.Name = "noCta2"
        Me.noCta2.ReadOnly = True
        Me.noCta2.Width = 80
        '
        'cta2
        '
        Me.cta2.HeaderText = "Cuenta"
        Me.cta2.Name = "cta2"
        Me.cta2.ReadOnly = True
        Me.cta2.Width = 140
        '
        'masterP2
        '
        Me.masterP2.HeaderText = "Master"
        Me.masterP2.Name = "masterP2"
        Me.masterP2.ReadOnly = True
        '
        'plan2
        '
        Me.plan2.HeaderText = "Plan"
        Me.plan2.Name = "plan2"
        Me.plan2.ReadOnly = True
        '
        'real2
        '
        Me.real2.HeaderText = "Real"
        Me.real2.Name = "real2"
        Me.real2.ReadOnly = True
        Me.real2.Visible = False
        '
        'actual2
        '
        Me.actual2.HeaderText = "Actual"
        Me.actual2.Name = "actual2"
        Me.actual2.ReadOnly = True
        '
        'dif2
        '
        Me.dif2.HeaderText = "Diferencia"
        Me.dif2.Name = "dif2"
        Me.dif2.ReadOnly = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Dgv_GastosGlobal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(625, 376)
        Me.Panel7.TabIndex = 0
        '
        'Dgv_GastosGlobal
        '
        Me.Dgv_GastosGlobal.AllowUserToAddRows = False
        Me.Dgv_GastosGlobal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_GastosGlobal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.noCta, Me.cta, Me.masterP, Me.plan, Me.actual, Me.real, Me.dif})
        Me.Dgv_GastosGlobal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_GastosGlobal.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_GastosGlobal.Name = "Dgv_GastosGlobal"
        Me.Dgv_GastosGlobal.RowHeadersVisible = False
        Me.Dgv_GastosGlobal.RowHeadersWidth = 37
        Me.Dgv_GastosGlobal.Size = New System.Drawing.Size(625, 376)
        Me.Dgv_GastosGlobal.TabIndex = 0
        '
        'noCta
        '
        Me.noCta.HeaderText = "No Cuenta"
        Me.noCta.Name = "noCta"
        Me.noCta.ReadOnly = True
        Me.noCta.Width = 70
        '
        'cta
        '
        Me.cta.HeaderText = "Cuenta"
        Me.cta.Name = "cta"
        Me.cta.ReadOnly = True
        Me.cta.Width = 140
        '
        'masterP
        '
        Me.masterP.HeaderText = "Master"
        Me.masterP.Name = "masterP"
        Me.masterP.ReadOnly = True
        Me.masterP.Width = 90
        '
        'plan
        '
        Me.plan.HeaderText = "Plan"
        Me.plan.Name = "plan"
        Me.plan.ReadOnly = True
        '
        'actual
        '
        Me.actual.HeaderText = "Actual"
        Me.actual.Name = "actual"
        Me.actual.ReadOnly = True
        '
        'real
        '
        Me.real.HeaderText = "Real"
        Me.real.Name = "real"
        Me.real.ReadOnly = True
        Me.real.Visible = False
        '
        'dif
        '
        Me.dif.HeaderText = "Diferencia"
        Me.dif.Name = "dif"
        Me.dif.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 376)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1256, 10)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Lbl_CantDif)
        Me.Panel3.Controls.Add(Me.Lbl_CantActualReal)
        Me.Panel3.Controls.Add(Me.Lbl_CantPlan)
        Me.Panel3.Controls.Add(Me.Lbl_CantMaster)
        Me.Panel3.Controls.Add(Me.Lbl_CantFF2)
        Me.Panel3.Controls.Add(Me.Lbl_CantMF2)
        Me.Panel3.Controls.Add(Me.Lbl_CantFF1)
        Me.Panel3.Controls.Add(Me.Lbl_CantMF1)
        Me.Panel3.Controls.Add(Me.Lbl_MontoDif)
        Me.Panel3.Controls.Add(Me.Lbl_MontoActualReal)
        Me.Panel3.Controls.Add(Me.Lbl_MontoPlan)
        Me.Panel3.Controls.Add(Me.Lbl_MontoMaster)
        Me.Panel3.Controls.Add(Me.Lbl_MontoFF2)
        Me.Panel3.Controls.Add(Me.Lbl_MontoMF2)
        Me.Panel3.Controls.Add(Me.Lbl_MontoFF1)
        Me.Panel3.Controls.Add(Me.Lbl_MontoMF1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Lbl_Ventas)
        Me.Panel3.Controls.Add(Me.Lbl_Actual)
        Me.Panel3.Controls.Add(Me.Lbl_Real)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1256, 75)
        Me.Panel3.TabIndex = 0
        '
        'Lbl_CantDif
        '
        Me.Lbl_CantDif.AutoSize = True
        Me.Lbl_CantDif.Location = New System.Drawing.Point(825, 50)
        Me.Lbl_CantDif.Name = "Lbl_CantDif"
        Me.Lbl_CantDif.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantDif.TabIndex = 27
        Me.Lbl_CantDif.Text = "Label18"
        '
        'Lbl_CantActualReal
        '
        Me.Lbl_CantActualReal.AutoSize = True
        Me.Lbl_CantActualReal.Location = New System.Drawing.Point(725, 50)
        Me.Lbl_CantActualReal.Name = "Lbl_CantActualReal"
        Me.Lbl_CantActualReal.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantActualReal.TabIndex = 26
        Me.Lbl_CantActualReal.Text = "Label19"
        '
        'Lbl_CantPlan
        '
        Me.Lbl_CantPlan.AutoSize = True
        Me.Lbl_CantPlan.Location = New System.Drawing.Point(625, 50)
        Me.Lbl_CantPlan.Name = "Lbl_CantPlan"
        Me.Lbl_CantPlan.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantPlan.TabIndex = 25
        Me.Lbl_CantPlan.Text = "Label20"
        '
        'Lbl_CantMaster
        '
        Me.Lbl_CantMaster.AutoSize = True
        Me.Lbl_CantMaster.Location = New System.Drawing.Point(525, 50)
        Me.Lbl_CantMaster.Name = "Lbl_CantMaster"
        Me.Lbl_CantMaster.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMaster.TabIndex = 24
        Me.Lbl_CantMaster.Text = "Label21"
        '
        'Lbl_CantFF2
        '
        Me.Lbl_CantFF2.AutoSize = True
        Me.Lbl_CantFF2.Location = New System.Drawing.Point(425, 50)
        Me.Lbl_CantFF2.Name = "Lbl_CantFF2"
        Me.Lbl_CantFF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantFF2.TabIndex = 23
        Me.Lbl_CantFF2.Text = "Label22"
        '
        'Lbl_CantMF2
        '
        Me.Lbl_CantMF2.AutoSize = True
        Me.Lbl_CantMF2.Location = New System.Drawing.Point(325, 50)
        Me.Lbl_CantMF2.Name = "Lbl_CantMF2"
        Me.Lbl_CantMF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMF2.TabIndex = 22
        Me.Lbl_CantMF2.Text = "Label23"
        '
        'Lbl_CantFF1
        '
        Me.Lbl_CantFF1.AutoSize = True
        Me.Lbl_CantFF1.Location = New System.Drawing.Point(225, 50)
        Me.Lbl_CantFF1.Name = "Lbl_CantFF1"
        Me.Lbl_CantFF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantFF1.TabIndex = 21
        Me.Lbl_CantFF1.Text = "Label24"
        '
        'Lbl_CantMF1
        '
        Me.Lbl_CantMF1.AutoSize = True
        Me.Lbl_CantMF1.Location = New System.Drawing.Point(125, 50)
        Me.Lbl_CantMF1.Name = "Lbl_CantMF1"
        Me.Lbl_CantMF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_CantMF1.TabIndex = 20
        Me.Lbl_CantMF1.Text = "Label25"
        '
        'Lbl_MontoDif
        '
        Me.Lbl_MontoDif.AutoSize = True
        Me.Lbl_MontoDif.Location = New System.Drawing.Point(825, 28)
        Me.Lbl_MontoDif.Name = "Lbl_MontoDif"
        Me.Lbl_MontoDif.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoDif.TabIndex = 19
        Me.Lbl_MontoDif.Text = "Label14"
        '
        'Lbl_MontoActualReal
        '
        Me.Lbl_MontoActualReal.AutoSize = True
        Me.Lbl_MontoActualReal.Location = New System.Drawing.Point(725, 28)
        Me.Lbl_MontoActualReal.Name = "Lbl_MontoActualReal"
        Me.Lbl_MontoActualReal.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoActualReal.TabIndex = 18
        Me.Lbl_MontoActualReal.Text = "Label15"
        '
        'Lbl_MontoPlan
        '
        Me.Lbl_MontoPlan.AutoSize = True
        Me.Lbl_MontoPlan.Location = New System.Drawing.Point(625, 28)
        Me.Lbl_MontoPlan.Name = "Lbl_MontoPlan"
        Me.Lbl_MontoPlan.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoPlan.TabIndex = 17
        Me.Lbl_MontoPlan.Text = "Label16"
        '
        'Lbl_MontoMaster
        '
        Me.Lbl_MontoMaster.AutoSize = True
        Me.Lbl_MontoMaster.Location = New System.Drawing.Point(525, 28)
        Me.Lbl_MontoMaster.Name = "Lbl_MontoMaster"
        Me.Lbl_MontoMaster.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoMaster.TabIndex = 16
        Me.Lbl_MontoMaster.Text = "Label17"
        '
        'Lbl_MontoFF2
        '
        Me.Lbl_MontoFF2.AutoSize = True
        Me.Lbl_MontoFF2.Location = New System.Drawing.Point(425, 28)
        Me.Lbl_MontoFF2.Name = "Lbl_MontoFF2"
        Me.Lbl_MontoFF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoFF2.TabIndex = 15
        Me.Lbl_MontoFF2.Text = "Label12"
        '
        'Lbl_MontoMF2
        '
        Me.Lbl_MontoMF2.AutoSize = True
        Me.Lbl_MontoMF2.Location = New System.Drawing.Point(325, 28)
        Me.Lbl_MontoMF2.Name = "Lbl_MontoMF2"
        Me.Lbl_MontoMF2.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoMF2.TabIndex = 14
        Me.Lbl_MontoMF2.Text = "Label13"
        '
        'Lbl_MontoFF1
        '
        Me.Lbl_MontoFF1.AutoSize = True
        Me.Lbl_MontoFF1.Location = New System.Drawing.Point(225, 28)
        Me.Lbl_MontoFF1.Name = "Lbl_MontoFF1"
        Me.Lbl_MontoFF1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_MontoFF1.TabIndex = 13
        Me.Lbl_MontoFF1.Text = "Label11"
        '
        'Lbl_MontoMF1
        '
        Me.Lbl_MontoMF1.AutoSize = True
        Me.Lbl_MontoMF1.Location = New System.Drawing.Point(125, 28)
        Me.Lbl_MontoMF1.Name = "Lbl_MontoMF1"
        Me.Lbl_MontoMF1.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_MontoMF1.TabIndex = 12
        Me.Lbl_MontoMF1.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(825, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Diferencia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(225, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fundición F1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Maquinado F2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(425, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Fundición F2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(525, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Master"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(625, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Plan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Maquinado F1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Monto"
        '
        'Lbl_Ventas
        '
        Me.Lbl_Ventas.AutoSize = True
        Me.Lbl_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Ventas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ventas.Location = New System.Drawing.Point(15, 3)
        Me.Lbl_Ventas.Name = "Lbl_Ventas"
        Me.Lbl_Ventas.Size = New System.Drawing.Size(75, 22)
        Me.Lbl_Ventas.TabIndex = 0
        Me.Lbl_Ventas.Text = "VENTAS"
        '
        'Lbl_Actual
        '
        Me.Lbl_Actual.AutoSize = True
        Me.Lbl_Actual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Actual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Actual.Location = New System.Drawing.Point(725, 5)
        Me.Lbl_Actual.Name = "Lbl_Actual"
        Me.Lbl_Actual.Size = New System.Drawing.Size(49, 19)
        Me.Lbl_Actual.TabIndex = 10
        Me.Lbl_Actual.Text = "Actual"
        '
        'Lbl_Real
        '
        Me.Lbl_Real.AutoSize = True
        Me.Lbl_Real.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Real.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Real.Location = New System.Drawing.Point(725, 5)
        Me.Lbl_Real.Name = "Lbl_Real"
        Me.Lbl_Real.Size = New System.Drawing.Size(39, 19)
        Me.Lbl_Real.TabIndex = 11
        Me.Lbl_Real.Text = "Real"
        '
        'Frm_Gastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 509)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Gastos"
        Me.ShowIcon = False
        Me.Text = "Gastos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pct_Limpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.Dgv_GastosDepto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.Dgv_GastosGlobal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_Depto As Label
    Friend WithEvents Lbl_Mes As Label
    Friend WithEvents Cmb_Depto As ComboBox
    Friend WithEvents Cmb_Meses As ComboBox
    Friend WithEvents Lbl_Año As Label
    Friend WithEvents Cmb_Años As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Dgv_GastosDepto As DataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Dgv_GastosGlobal As DataGridView
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Rdb_Japones As RadioButton
    Friend WithEvents Rdb_Español As RadioButton
    Friend WithEvents noCta2 As DataGridViewTextBoxColumn
    Friend WithEvents cta2 As DataGridViewTextBoxColumn
    Friend WithEvents masterP2 As DataGridViewTextBoxColumn
    Friend WithEvents plan2 As DataGridViewTextBoxColumn
    Friend WithEvents real2 As DataGridViewTextBoxColumn
    Friend WithEvents actual2 As DataGridViewTextBoxColumn
    Friend WithEvents dif2 As DataGridViewTextBoxColumn
    Friend WithEvents Lbl_Ventas As Label
    Friend WithEvents Pct_Limpiar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Lbl_Actual As Label
    Friend WithEvents Lbl_Real As Label
    Friend WithEvents Lbl_MontoMF1 As Label
    Friend WithEvents Lbl_MontoFF1 As Label
    Friend WithEvents Lbl_CantDif As Label
    Friend WithEvents Lbl_CantActualReal As Label
    Friend WithEvents Lbl_CantPlan As Label
    Friend WithEvents Lbl_CantMaster As Label
    Friend WithEvents Lbl_CantFF2 As Label
    Friend WithEvents Lbl_CantMF2 As Label
    Friend WithEvents Lbl_CantFF1 As Label
    Friend WithEvents Lbl_CantMF1 As Label
    Friend WithEvents Lbl_MontoDif As Label
    Friend WithEvents Lbl_MontoActualReal As Label
    Friend WithEvents Lbl_MontoPlan As Label
    Friend WithEvents Lbl_MontoMaster As Label
    Friend WithEvents Lbl_MontoFF2 As Label
    Friend WithEvents Lbl_MontoMF2 As Label
    Friend WithEvents noCta As DataGridViewTextBoxColumn
    Friend WithEvents cta As DataGridViewTextBoxColumn
    Friend WithEvents masterP As DataGridViewTextBoxColumn
    Friend WithEvents plan As DataGridViewTextBoxColumn
    Friend WithEvents actual As DataGridViewTextBoxColumn
    Friend WithEvents real As DataGridViewTextBoxColumn
    Friend WithEvents dif As DataGridViewTextBoxColumn
End Class
