﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CsPresentacion
{
    public partial class Frm_Listado_Bajas : Form
    {
        public Frm_Listado_Bajas()
        {
            InitializeComponent();
            var tt = new ToolTip();
            tt.SetToolTip(btn_nuevo,    "NUEVA CONSULTA");
            tt.SetToolTip(btn_buscar,   "FILTRAR INFORMACION");
            tt.SetToolTip(btn_exportar, "EXPORTAR EXCEL");
            tt.SetToolTip(btn_reporte,  "GENERAR INFORME");
            tt.SetToolTip(btn_contabilidad, "GENERAR INFORME DE CONTABILIDAD");
            timer1.Enabled = true;
        }
        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        int Var;
        private void Frm_Listado_Bajas_Load(object sender, EventArgs e)
        {
            Var = 0;
            Llenar_dgv();
            cargar_año(cmb_año);
            cargar_departemento(cmb_departamento);
            cargar_puesto(cmb_puesto);
            dgv_bajas.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_bajas.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            Diseño_dgv(dgv_bajas);
            cmb_año.DropDownStyle = ComboBoxStyle.DropDownList;
            btn_buscar.Enabled = false;
            cmb_departamento.Enabled = false;
            cmb_puesto.Enabled = false;
            txt_semana.Enabled = false;
            cmb_mes.Enabled = false;
            lbl_filtro.Text = "Total:";
            lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            lbl_fecha.Visible = false;
        }

        private void Exportara_Exel()// Método para exportar a excel.
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Libro1";
                int cellRowIndex = 2;//ok
                int cellColumnIndex = 1;//ok
                //Pasa por cada fila y lee el valor de cada columna.
                for (int i = -1; i < dgv_bajas.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_bajas.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_bajas.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_bajas.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;//ok
                    cellRowIndex++;
                }
                excel.Visible = true;
            }
            catch (Exception error)
            {
                //MessageBox.Show("No se exportó correctamente" + error.Message);
            }
        }

        private void Nuevo()// Limpiar form
        {
            
            cmb_año.Text = "";
            cmb_mes.Text = "";
            txt_semana.Text = "";
            cmb_departamento.Text = "";
            cmb_puesto.Text = "";
            cmb_año.Enabled = true;
            btn_buscar.Enabled = false;
            cmb_departamento.Enabled = false;
            cmb_puesto.Enabled = false;
            txt_semana.Enabled = false;
            cmb_mes.Enabled = false;
            cmb_año.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;//No. Empleado
            dgv.Columns[1].Width = 200;//Nombre empleado
            dgv.Columns[2].Width = 130;
            dgv.Columns[3].Width = 120;//Puesto
            dgv.Columns[4].Width = 80;//Fecha Alta
            dgv.Columns[5].Width = 80;//Fecha baja
            dgv.Columns[6].Width = 40;//dias
            dgv.Columns[7].Width = 40;//Días laborados
            dgv.Columns[8].Width = 50;//Meses baja
            dgv.Columns[9].Width = 40;//Años baja
            dgv.Columns[10].Width = 140;//Antiguedad
            dgv.Columns[11].Width = 60;//semana baja
            dgv.Columns[12].Width = 60;//Mes baja
            dgv.Columns[13].Width = 40;//año baja
            dgv.Columns[14].Width = 150;
            dgv.Columns[15].Width = 70;//Municipio
            dgv.Columns[16].Width = 50;//Estado civil
            dgv.Columns[17].Width = 40;//Genero
        }

        private void Llenar_dgv()// Método para llenar DatagridView
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[FM_LISTADO_BAJAS]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Año", cmb_año.Text);
                cmd.Parameters.AddWithValue("@Mes", cmb_mes.Text);
                cmd.Parameters.AddWithValue("@Semana", txt_semana.Text);
                cmd.Parameters.AddWithValue("@Departamento", cmb_departamento.Text);
                cmd.Parameters.AddWithValue("@Puesto", cmb_puesto.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_bajas.DataSource = dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        public void cargar_puesto(ComboBox inte)//Cargar puesto CMB
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select distinct DESCRIPCION_PUESTO from [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto] order by DESCRIPCION_PUESTO", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DESCRIPCION_PUESTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }

        public void cargar_departemento(ComboBox inte)//Cargar departamento en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RTRIM(DESCRIPCION)as 'DEPARTAMENTO' FROM  [asahi16].[Supervisor_giro].[DEPTO] WHERE CENTRO_COSTO <>16 and RTRIM(DESCRIPCION) <> 'PRESIDENCIA' ORDER BY DEPARTAMENTO ASC ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["DEPARTAMENTO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo departamento" + Error.ToString());
            }
        }

        public void cargar_año(ComboBox inte)//Cargar año en cmb
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT  DATEPART (YEAR, (SELECT TOP 1 FECHA FROM [asahi16].[Supervisor_giro].[Empsdo] WHERE TIPO = 'B' AND V.CLAVE = CLAVE AND V.VIGENCIA = 'BAJA' AND FECHA IS NOT NULL AND TIPO IS NOT NULL  ORDER BY FECHA DESC )) AS 'AÑO'   FROM [asahi16].[Supervisor_giro].[VistaEmpleadosVigenciaYPuesto]v  ORDER BY AÑO DESC", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    inte.Items.Add(dr["AÑO"].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se llenó información de campo año" + Error.ToString());
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año 3");
                Var = 3;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y mes 1");
                Var = 1;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y semana 2");
                Var = 2;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y departamento 4");
                Var = 4;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año y puesto 5");
                Var = 5;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año mes y departamento 6");
                Var = 6;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, mes y puesto 7");
                Var = 7;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, semana y departamento 8");
                Var = 8;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                // MessageBox.Show("Filtro  por año, semana y puesto 9");
                Var = 9;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, departamento y puesto 10");
                Var = 10;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro  por año, mes, departamento y puesto 11");
                Var = 11;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, semana, departamento  y puesto  12");
                Var = 12;
                Llenar_dgv();
                lbl_filtro.Visible = true;
                lbl_total.Visible = true;
                lbl_filtro.Text = "Total:";
                lbl_total.Text = dgv_bajas.Rows.Count.ToString();
            }
        }

        private void Dgv_bajas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv_bajas.Columns[e.ColumnIndex].Name == "DIAS")
            {
                if (e.Value.GetType() != typeof(System.DBNull))
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                }
            }
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)//cmb_mes
        {
            if (string.IsNullOrEmpty(cmb_mes.Text))
            {
            }
            else
            {
                txt_semana.Enabled = false;
                txt_semana.Text = "";
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)//cmb_año
        {
            if (string.IsNullOrEmpty(cmb_año.Text))
            {
            }
            else
            {
                btn_buscar.Enabled = true;
                cmb_mes.Enabled = true;
                txt_semana.Enabled = true;
                cmb_departamento.Enabled = true;
                cmb_puesto.Enabled = true;
            }
        }

        private void Txt_semana2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Btn_exportar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Exportara_Exel();
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            timer1.Start();
            Nuevo();
           Var = 0;
            Llenar_dgv();
            lbl_total.Text = dgv_bajas.Rows.Count.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer1.Start();
            Cursor = Cursors.Default;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_año.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //Todo el reporte
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(0);
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año 3");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(3);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.ShowDialog();
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y mes 1");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(1);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y semana 2");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(2);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y departamento 4");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(4);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año y puesto 5");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(5);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año mes y departamento 6");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(6);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, mes y puesto 7");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(7);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, semana y departamento 8");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(8);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                // MessageBox.Show("Filtro  por año, semana y puesto 9");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(9);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, departamento y puesto 10");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(10);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro  por año, mes, departamento y puesto 11");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(11);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, semana, departamento  y puesto  12");
                Frm_Reporte_Bajas rep = new Frm_Reporte_Bajas();
                rep.Var = Convert.ToInt32(12);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
        }

        private void Txt_semana_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_contabilidad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_año.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //Todo el reporte
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(0);
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año 3");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(3);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.ShowDialog();
            }

            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y mes 1");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(1);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y semana 2");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(2);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro por año y departamento 4");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(4);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año y puesto 5");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(5);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año mes y departamento 6");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(6);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, mes y puesto 7");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(7);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_puesto.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro por año, semana y departamento 8");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(8);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Departamento = cmb_departamento.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(cmb_departamento.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                // MessageBox.Show("Filtro  por año, semana y puesto 9");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(9);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text); ;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text) && string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, departamento y puesto 10");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(10);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(txt_semana.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //  MessageBox.Show("Filtro  por año, mes, departamento y puesto 11");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(11);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Mes = cmb_mes.Text;
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
            else if (string.IsNullOrEmpty(cmb_mes.Text))
            {
                Cursor = Cursors.WaitCursor;
                timer1.Start();
                //MessageBox.Show("Filtro  por año, semana, departamento  y puesto  12");
                Bajas_Contabilidad rep = new Bajas_Contabilidad();
                rep.Var = Convert.ToInt32(12);
                rep.Año = Convert.ToInt32(cmb_año.Text);
                rep.Semana = Convert.ToInt32(txt_semana.Text);
                rep.Departamento = cmb_departamento.Text;
                rep.Puesto = cmb_puesto.Text;
                rep.ShowDialog();
            }
        }
    }
}
