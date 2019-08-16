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
    public partial class Ausentismos : Form
    {
        public Ausentismos()
        {
            InitializeComponent();
        }
        public int Var;
        public int Tipo;
        public int Semana;
        public int Año;
        public DateTime Inicia { get; set; }
        public DateTime Termina { get; set; }
        public int Clave;
        public string Descripcion;

        private void Ausentismos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Ausentismos.SP_Reportes_Ausentismos_FM' Puede moverla o quitarla según sea necesario.
            this.SP_Reportes_Ausentismos_FMTableAdapter.Fill(this.DS_Ausentismos.SP_Reportes_Ausentismos_FM, Var, Tipo, Semana, Año, Inicia, Termina, Clave, Descripcion );
            this.reportViewer1.RefreshReport();
        }
    }
}