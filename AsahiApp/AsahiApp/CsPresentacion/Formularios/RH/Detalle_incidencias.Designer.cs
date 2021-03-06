﻿namespace CsPresentacion
{
    partial class Detalle_incidencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_detalle = new System.Windows.Forms.DataGridView();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.txt_clave = new System.Windows.Forms.TextBox();
            this.dtm_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_depto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtm_inicia = new System.Windows.Forms.DateTimePicker();
            this.dtm_termina = new System.Windows.Forms.DateTimePicker();
            this.lbl_var = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.AllowUserToAddRows = false;
            this.dgv_detalle.AllowUserToDeleteRows = false;
            this.dgv_detalle.AllowUserToResizeColumns = false;
            this.dgv_detalle.AllowUserToResizeRows = false;
            this.dgv_detalle.BackgroundColor = System.Drawing.Color.White;
            this.dgv_detalle.CausesValidation = false;
            this.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalle.Location = new System.Drawing.Point(12, 3);
            this.dgv_detalle.MultiSelect = false;
            this.dgv_detalle.Name = "dgv_detalle";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_detalle.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgv_detalle.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalle.ShowCellErrors = false;
            this.dgv_detalle.Size = new System.Drawing.Size(908, 274);
            this.dgv_detalle.TabIndex = 1;
            this.dgv_detalle.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_detalle_RowEnter);
            // 
            // btn_exportar
            // 
            this.btn_exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exportar.FlatAppearance.BorderSize = 0;
            this.btn_exportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar.Image = global::CsPresentacion.Properties.Resources.Excel;
            this.btn_exportar.Location = new System.Drawing.Point(928, 240);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(40, 34);
            this.btn_exportar.TabIndex = 192;
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.Btn_exportar_Click);
            // 
            // txt_clave
            // 
            this.txt_clave.Location = new System.Drawing.Point(934, 150);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.Size = new System.Drawing.Size(130, 20);
            this.txt_clave.TabIndex = 213;
            this.txt_clave.Text = "00";
            this.txt_clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtm_fecha
            // 
            this.dtm_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_fecha.Location = new System.Drawing.Point(948, 173);
            this.dtm_fecha.Name = "dtm_fecha";
            this.dtm_fecha.Size = new System.Drawing.Size(100, 20);
            this.dtm_fecha.TabIndex = 214;
            // 
            // txt_depto
            // 
            this.txt_depto.Location = new System.Drawing.Point(948, 197);
            this.txt_depto.Name = "txt_depto";
            this.txt_depto.Size = new System.Drawing.Size(100, 20);
            this.txt_depto.TabIndex = 215;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(934, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 216;
            this.pictureBox1.TabStop = false;
            // 
            // dtm_inicia
            // 
            this.dtm_inicia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_inicia.Location = new System.Drawing.Point(344, 279);
            this.dtm_inicia.Name = "dtm_inicia";
            this.dtm_inicia.Size = new System.Drawing.Size(100, 20);
            this.dtm_inicia.TabIndex = 217;
            // 
            // dtm_termina
            // 
            this.dtm_termina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_termina.Location = new System.Drawing.Point(490, 279);
            this.dtm_termina.Name = "dtm_termina";
            this.dtm_termina.Size = new System.Drawing.Size(100, 20);
            this.dtm_termina.TabIndex = 218;
            // 
            // lbl_var
            // 
            this.lbl_var.AutoSize = true;
            this.lbl_var.Location = new System.Drawing.Point(133, 282);
            this.lbl_var.Name = "lbl_var";
            this.lbl_var.Size = new System.Drawing.Size(34, 13);
            this.lbl_var.TabIndex = 219;
            this.lbl_var.Text = "@Var";
            // 
            // Detalle_incidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 300);
            this.Controls.Add(this.lbl_var);
            this.Controls.Add(this.dtm_termina);
            this.Controls.Add(this.dtm_inicia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_depto);
            this.Controls.Add(this.dtm_fecha);
            this.Controls.Add(this.txt_clave);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.dgv_detalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detalle_incidencias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.Detalle_incidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_detalle;
        private System.Windows.Forms.Button btn_exportar;
        public System.Windows.Forms.TextBox txt_clave;
        public System.Windows.Forms.DateTimePicker dtm_fecha;
        public System.Windows.Forms.TextBox txt_depto;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dtm_inicia;
        public System.Windows.Forms.DateTimePicker dtm_termina;
        public System.Windows.Forms.Label lbl_var;
    }
}