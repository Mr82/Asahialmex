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
    public partial class Frm_Rep_Retardos : Form
    {
        public Frm_Rep_Retardos()
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
        public int Usuario;
        private void Frm_Rep_Retardos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_Prenomina.SP_Reportes_Prenomina_FM' Puede moverla o quitarla según sea necesario.
            this.SP_Reportes_Prenomina_FMTableAdapter.Fill(this.DS_Prenomina.SP_Reportes_Prenomina_FM, Var, Tipo, Semana, Año, Inicia, Termina, Clave, Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
