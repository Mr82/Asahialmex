﻿namespace CsPresentacion
{
    partial class Frm_Aussentismos_Retardos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.tp_permisos = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_tipo_falta = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_inc_caso = new System.Windows.Forms.Label();
            this.lbl_inc_tipo = new System.Windows.Forms.Label();
            this.txt_certificado = new System.Windows.Forms.MaskedTextBox();
            this.cmb_caso = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtm_aplicacion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtm_termina = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_incapacidades = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txt_clave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Location = new System.Drawing.Point(-2, -19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 69);
            this.panel1.TabIndex = 144;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(17, 42);
            this.txt_clave.MaxLength = 8;
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(100, 20);
            this.txt_clave.TabIndex = 28;
            this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_clave_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "CLAVE";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::CsPresentacion.Properties.Resources.Action_file_new_icon;
            this.btn_nuevo.Location = new System.Drawing.Point(118, 39);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(27, 27);
            this.btn_nuevo.TabIndex = 27;
            this.btn_nuevo.UseVisualStyleBackColor = false;
            this.btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(633, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl_estado);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 73);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "NOMBRE:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(9, 52);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(57, 13);
            this.lbl_estado.TabIndex = 147;
            this.lbl_estado.Text = "ESTADO";
            this.lbl_estado.TextChanged += new System.EventHandler(this.Lbl_estado_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(9, 27);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(457, 20);
            this.txt_nombre.TabIndex = 145;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            this.txt_nombre.Leave += new System.EventHandler(this.Txt_nombre_Leave);
            // 
            // tp_permisos
            // 
            this.tp_permisos.Location = new System.Drawing.Point(4, 22);
            this.tp_permisos.Name = "tp_permisos";
            this.tp_permisos.Padding = new System.Windows.Forms.Padding(3);
            this.tp_permisos.Size = new System.Drawing.Size(796, 410);
            this.tp_permisos.TabIndex = 0;
            this.tp_permisos.Text = "1. Faltas";
            this.tp_permisos.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tp_permisos);
            this.tabControl1.Location = new System.Drawing.Point(11, 168);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 436);
            this.tabControl1.TabIndex = 159;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_tipo_falta);
            this.tabPage1.Controls.Add(this.lbl_id);
            this.tabPage1.Controls.Add(this.lbl_inc_caso);
            this.tabPage1.Controls.Add(this.lbl_inc_tipo);
            this.tabPage1.Controls.Add(this.txt_certificado);
            this.tabPage1.Controls.Add(this.cmb_caso);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtm_aplicacion);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.dtm_termina);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmb_tipo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_duracion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dtm_fecha);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_incapacidades);
            this.tabPage1.Controls.Add(this.btn_exportar);
            this.tabPage1.Controls.Add(this.btn_primero);
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_anterior);
            this.tabPage1.Controls.Add(this.btn_guardar);
            this.tabPage1.Controls.Add(this.btn_siguiente);
            this.tabPage1.Controls.Add(this.btn_eliminar);
            this.tabPage1.Controls.Add(this.btn_ultimo);
            this.tabPage1.Controls.Add(this.btn_insertar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 410);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "2. Incapacidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_tipo_falta
            // 
            this.lbl_tipo_falta.AutoSize = true;
            this.lbl_tipo_falta.Location = new System.Drawing.Point(505, 141);
            this.lbl_tipo_falta.Name = "lbl_tipo_falta";
            this.lbl_tipo_falta.Size = new System.Drawing.Size(24, 13);
            this.lbl_tipo_falta.TabIndex = 193;
            this.lbl_tipo_falta.Text = "@F";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(447, 140);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 202;
            this.lbl_id.Text = "0";
            // 
            // lbl_inc_caso
            // 
            this.lbl_inc_caso.AutoSize = true;
            this.lbl_inc_caso.Location = new System.Drawing.Point(614, 142);
            this.lbl_inc_caso.Name = "lbl_inc_caso";
            this.lbl_inc_caso.Size = new System.Drawing.Size(42, 13);
            this.lbl_inc_caso.TabIndex = 201;
            this.lbl_inc_caso.Text = "@Caso";
            // 
            // lbl_inc_tipo
            // 
            this.lbl_inc_tipo.AutoSize = true;
            this.lbl_inc_tipo.Location = new System.Drawing.Point(235, 143);
            this.lbl_inc_tipo.Name = "lbl_inc_tipo";
            this.lbl_inc_tipo.Size = new System.Drawing.Size(39, 13);
            this.lbl_inc_tipo.TabIndex = 200;
            this.lbl_inc_tipo.Text = "@Tipo";
            // 
            // txt_certificado
            // 
            this.txt_certificado.Location = new System.Drawing.Point(19, 119);
            this.txt_certificado.Name = "txt_certificado";
            this.txt_certificado.Size = new System.Drawing.Size(135, 20);
            this.txt_certificado.TabIndex = 178;
            this.txt_certificado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_certificado_KeyPress);
            this.txt_certificado.Leave += new System.EventHandler(this.Txt_certificado_Leave);
            // 
            // cmb_caso
            // 
            this.cmb_caso.FormattingEnabled = true;
            this.cmb_caso.Items.AddRange(new object[] {
            "Unica",
            "Inicial",
            "Subsecuente",
            "Alta Médica ST2"});
            this.cmb_caso.Location = new System.Drawing.Point(612, 118);
            this.cmb_caso.Name = "cmb_caso";
            this.cmb_caso.Size = new System.Drawing.Size(135, 21);
            this.cmb_caso.TabIndex = 181;
            this.cmb_caso.TextChanged += new System.EventHandler(this.Cmb_caso_TextChanged);
            this.cmb_caso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_caso_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(610, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 199;
            this.label9.Text = "CASO";
            // 
            // dtm_aplicacion
            // 
            this.dtm_aplicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_aplicacion.Location = new System.Drawing.Point(612, 75);
            this.dtm_aplicacion.Name = "dtm_aplicacion";
            this.dtm_aplicacion.Size = new System.Drawing.Size(135, 20);
            this.dtm_aplicacion.TabIndex = 179;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 13);
            this.label8.TabIndex = 198;
            this.label8.Text = "FECHA APLICACION NOMINA";
            // 
            // dtm_termina
            // 
            this.dtm_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_termina.Location = new System.Drawing.Point(411, 75);
            this.dtm_termina.Name = "dtm_termina";
            this.dtm_termina.Size = new System.Drawing.Size(135, 20);
            this.dtm_termina.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 197;
            this.label7.Text = "TERMINA";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Enfermermedad General",
            "Accidente de Trabajo",
            "Accidente de Trayecto",
            "Enfermedad Profesional",
            "Pre Maternidad",
            "Maternidad Enlace",
            "Post Maternidad"});
            this.cmb_tipo.Location = new System.Drawing.Point(234, 118);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(135, 21);
            this.cmb_tipo.TabIndex = 180;
            this.cmb_tipo.TextChanged += new System.EventHandler(this.Cmb_tipo_TextChanged);
            this.cmb_tipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_tipo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 196;
            this.label6.Text = "TIPO";
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(234, 75);
            this.txt_duracion.MaxLength = 6;
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(81, 20);
            this.txt_duracion.TabIndex = 176;
            this.txt_duracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_duracion_KeyPress);
            this.txt_duracion.Leave += new System.EventHandler(this.Txt_duracion_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 195;
            this.label5.Text = "DURACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 194;
            this.label4.Text = "CERTIFICADO";
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(19, 75);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(135, 20);
            this.dtm_fecha.TabIndex = 175;
            this.dtm_fecha.ValueChanged += new System.EventHandler(this.Dtm_fecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 192;
            this.label3.Text = "INICIA";
            // 
            // dgv_incapacidades
            // 
            this.dgv_incapacidades.AllowUserToAddRows = false;
            this.dgv_incapacidades.AllowUserToDeleteRows = false;
            this.dgv_incapacidades.AllowUserToResizeColumns = false;
            this.dgv_incapacidades.AllowUserToResizeRows = false;
            this.dgv_incapacidades.BackgroundColor = System.Drawing.Color.White;
            this.dgv_incapacidades.CausesValidation = false;
            this.dgv_incapacidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incapacidades.Location = new System.Drawing.Point(8, 159);
            this.dgv_incapacidades.MultiSelect = false;
            this.dgv_incapacidades.Name = "dgv_incapacidades";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_incapacidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_incapacidades.RowHeadersVisible = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.dgv_incapacidades.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_incapacidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_incapacidades.ShowCellErrors = false;
            this.dgv_incapacidades.Size = new System.Drawing.Size(780, 245);
            this.dgv_incapacidades.TabIndex = 183;
            this.dgv_incapacidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_incapacidades_CellContentClick_1);
            this.dgv_incapacidades.CurrentCellChanged += new System.EventHandler(this.Dgv_incapacidades_CurrentCellChanged_1);
            this.dgv_incapacidades.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_incapacidades_RowEnter_1);
            this.dgv_incapacidades.DoubleClick += new System.EventHandler(this.Dgv_incapacidades_DoubleClick_1);
            // 
            // btn_exportar
            // 
            this.btn_exportar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(348, 6);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(40, 30);
            this.btn_exportar.TabIndex = 185;
            this.btn_exportar.UseVisualStyleBackColor = false;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // btn_primero
            // 
            this.btn_primero.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.Image = global::CsPresentacion.Properties.Resources.Hide_left_icon;
            this.btn_primero.Location = new System.Drawing.Point(20, 6);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(40, 30);
            this.btn_primero.TabIndex = 191;
            this.btn_primero.UseVisualStyleBackColor = false;
            this.btn_primero.Click += new System.EventHandler(this.Btn_primero_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.Image = global::CsPresentacion.Properties.Resources.delete_icon;
            this.btn_cancelar.Location = new System.Drawing.Point(306, 6);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(40, 30);
            this.btn_cancelar.TabIndex = 184;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.Image = global::CsPresentacion.Properties.Resources.Navigate_left_icon;
            this.btn_anterior.Location = new System.Drawing.Point(61, 6);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(40, 30);
            this.btn_anterior.TabIndex = 190;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.Btn_anterior_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.Image = global::CsPresentacion.Properties.Resources.Actions_dialog_ok_apply_icon;
            this.btn_guardar.Location = new System.Drawing.Point(265, 6);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 30);
            this.btn_guardar.TabIndex = 182;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.Image = global::CsPresentacion.Properties.Resources.Next;
            this.btn_siguiente.Location = new System.Drawing.Point(102, 6);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(40, 30);
            this.btn_siguiente.TabIndex = 189;
            this.btn_siguiente.UseVisualStyleBackColor = false;
            this.btn_siguiente.Click += new System.EventHandler(this.Btn_siguiente_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.Image = global::CsPresentacion.Properties.Resources.math_minus_icon;
            this.btn_eliminar.Location = new System.Drawing.Point(224, 6);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(40, 30);
            this.btn_eliminar.TabIndex = 186;
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.Image = global::CsPresentacion.Properties.Resources.Hide_right_icon;
            this.btn_ultimo.Location = new System.Drawing.Point(143, 6);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(40, 30);
            this.btn_ultimo.TabIndex = 188;
            this.btn_ultimo.UseVisualStyleBackColor = false;
            this.btn_ultimo.Click += new System.EventHandler(this.Btn_ultimo_Click);
            // 
            // btn_insertar
            // 
            this.btn_insertar.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.FlatAppearance.BorderSize = 0;
            this.btn_insertar.Image = global::CsPresentacion.Properties.Resources.math_add_icon2;
            this.btn_insertar.Location = new System.Drawing.Point(183, 6);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(40, 30);
            this.btn_insertar.TabIndex = 187;
            this.btn_insertar.UseVisualStyleBackColor = false;
            this.btn_insertar.Click += new System.EventHandler(this.Btn_insertar_Click);
            // 
            // Frm_Aussentismos_Retardos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Aussentismos_Retardos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ausentismos";
            this.Load += new System.EventHandler(this.Ausentismo_retardos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incapacidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevo;
        public System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TabPage tp_permisos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_tipo_falta;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_inc_caso;
        private System.Windows.Forms.Label lbl_inc_tipo;
        private System.Windows.Forms.MaskedTextBox txt_certificado;
        private System.Windows.Forms.ComboBox cmb_caso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtm_aplicacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtm_termina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtm_fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_incapacidades;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_insertar;
    }
}