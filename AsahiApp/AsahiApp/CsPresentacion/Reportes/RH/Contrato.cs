﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsPresentacion
{
    public partial class Frm_Rep_Alta_empleado : Form
    {
        public Frm_Rep_Alta_empleado()
        {
            InitializeComponent();
        }
        public Int32 CLAVE;
        private void Frm_Rep_Alta_empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Contrato_empleado.Sp_Genera_Contrato' Puede moverla o quitarla según sea necesario.
            this.Sp_Genera_ContratoTableAdapter.Fill(this.DS_Contrato_empleado.Sp_Genera_Contrato, CLAVE);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
