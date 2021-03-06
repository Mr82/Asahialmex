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
    public partial class Frm_Rotacion : Form
    {
        public Frm_Rotacion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=GIRO\\SQL2008;Initial Catalog=asahi16;Persist Security Info=True;User ID=sa;Password=Pa55word");

        int Var;

        private void Frm_Rotacion_Load(object sender, EventArgs e)
        {
            Var = 0;
            Llenar_dgv(dgv_total);
            Diseño_dgv(dgv_total);
            dgv_total.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_total.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv_ant.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_ant.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dgv_ant2.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgv_ant2.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            Calcula_Total();
            lbl_desde.Visible = false;
            lbl_hasta.Visible = false;
            lbl_desde2.Visible = false;
            lbl_hasta2.Visible = false;
        }

        private void Calcula_Total()
        {
            double Altas = 0;
            double Bajas = 0;
            double Total = 0;
          
            foreach (DataGridViewRow row in dgv_total.Rows)
            {
                Altas += Convert.ToDouble(row.Cells["ALTAS"].Value);
                Bajas += Convert.ToDouble(row.Cells["BAJAS"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lbl_altas.Text = Convert.ToString(Altas);
            lbl_bajas.Text = Convert.ToString(Bajas);
            lbl_total.Text = Convert.ToString(Total);
            txt_bc.Text = Convert.ToString(Bajas * 100 / Total);
            txt_ba.Text = Convert.ToString(Bajas * 100 / Altas);
        }
        private void Calcula_Total2()
        {
            double Altas = 0;
            double Bajas = 0;
            double Total = 0;

            foreach (DataGridViewRow row in dgv_ant.Rows)
            {
                Altas += Convert.ToDouble(row.Cells["ALTAS"].Value);
                Bajas += Convert.ToDouble(row.Cells["BAJAS"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lbl_altas2.Text = Convert.ToString(Altas);
            lbl_bajas2.Text = Convert.ToString(Bajas);
            lbl_total2.Text = Convert.ToString(Total);
            txt_bc2.Text = Convert.ToString(Bajas * 100 / Total);
            txt_ba2.Text = Convert.ToString(Bajas * 100 / Altas);
        }


        private void Calcula_Total3()
        {
            double Altas = 0;
            double Bajas = 0;
            double Total = 0;

            foreach (DataGridViewRow row in dgv_ant2.Rows)
            {
                Altas += Convert.ToDouble(row.Cells["ALTAS"].Value);
                Bajas += Convert.ToDouble(row.Cells["BAJAS"].Value);
                Total += Convert.ToDouble(row.Cells["TOTAL"].Value);
            }
            lbl_altas3.Text = Convert.ToString(Altas);
            lbl_bajas3.Text = Convert.ToString(Bajas);
            lbl_total3.Text = Convert.ToString(Total);
            txt_bc3.Text = Convert.ToString(Bajas * 100 / Total);
            txt_ba3.Text = Convert.ToString(Bajas * 100 / Altas);
        }

        public void Llenar_dgv(DataGridView dgv)// Método para llenar DatagridView Total
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_rotacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Desde", lbl_desde.Text);
                cmd.Parameters.AddWithValue("@Hasta", lbl_hasta.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_total.DataSource = dt;    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Llenar_dgv_ant(DataGridView dgv)// Método para llenar DatagridView antigüedad 1
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_rotacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Desde", lbl_desde.Text);
                cmd.Parameters.AddWithValue("@Hasta", lbl_hasta.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_ant.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Llenar_dgv_ant2(DataGridView dgv)// Método para llenar DatagridView antigüedad 2
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("[dbo].[SP_rotacion]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Var", Var);
                cmd.Parameters.AddWithValue("@Fecha", dtm_fecha.Text);
                cmd.Parameters.AddWithValue("@Desde", lbl_desde2.Text);
                cmd.Parameters.AddWithValue("@Hasta", lbl_hasta2.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Close();
                adapter.Fill(dt);
                dgv_ant2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Diseño_dgv(DataGridView dgv)
        {
            dgv.Columns[0].Width = 160;//departamento
            dgv.Columns[1].Width = 43;//altas
            dgv.Columns[2].Width = 43;//bajas
            dgv.Columns[3].Width = 43;//total
            dgv.Columns[4].Width = 43;//=a/c
            dgv.Columns[5].Width = 43;//=a/b
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
                for (int i = -1; i < dgv_total.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j <dgv_total.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_total.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_total.Rows[i].Cells[j].Value.ToString();
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

        private void Exportara_Exel_ant()// Método para exportar a excel.
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
                for (int i = -1; i < dgv_ant.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_ant.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ant.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ant.Rows[i].Cells[j].Value.ToString();
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

        private void Exportara_Exel_ant2()// Método para exportar a excel.
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
                for (int i = -1; i < dgv_ant2.Rows.Count - 0; i++)//Primera y ultima fila
                {
                    for (int j = 0; j < dgv_ant2.Columns.Count - 0; j++)//Columnas lado izquierdo y derecho
                    {
                        // El índice de Excel comienza desde 1,1. Como first Row tendría los encabezados de Columna, agregando una verificación de condición.
                        if (cellRowIndex == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ant2.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dgv_ant2.Rows[i].Cells[j].Value.ToString();
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

        private void nuevo()
        {
           dtm_fecha.Text = "";
           cmb_ant.Text = "";
           cmb_ant2.Text = "";
            lbl_desde.Text = "0";
            lbl_hasta.Text = "0";
            lbl_desde2.Text = "0";
            lbl_hasta2.Text = "0";
            lbl_altas2.Text = "";
            lbl_bajas2.Text = "";
            lbl_total2.Text = "";
            txt_bc2.Text = "";
            txt_ba2.Text = "";
            lbl_altas3.Text = "";
            lbl_bajas3.Text = "";
            lbl_total3.Text = "";
            txt_bc3.Text = "";
            txt_ba3.Text = "";
        }
        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            Var = 3;
            Llenar_dgv_ant(dgv_ant);
            Var = 3;
            Llenar_dgv_ant2(dgv_ant2);
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Btn_exportar_total_Click(object sender, EventArgs e)
        {
            Exportara_Exel();
        }

        private void Cmb_ant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ant.Text == "MENOS DE DOS SEMANAS")
            {
                Var = 2;
                lbl_desde.Text = "0";
                lbl_hasta.Text = "15";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "DOS SEMANAS A UN MES")
            {
                Var = 2;
                lbl_desde.Text = "16";
                lbl_hasta.Text = "30";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "UN MES A TRES MESES")
            {
                Var = 2;
                lbl_desde.Text = "31";
                lbl_hasta.Text = "90";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "TRES MESES A SEIS MESES")
            {
                Var = 2;
                lbl_desde.Text = "91";
                lbl_hasta.Text = "180";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "MENOS DE TRES MESES")
            {
                Var = 2;
                lbl_desde.Text = "0";
                lbl_hasta.Text = "90";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "MAS DE TRES MESES")
            {
                Var = 2;
                lbl_desde.Text = "90";
                lbl_hasta.Text = "1000000000";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "SEIS MESES A UN AÑO")
            {
                Var = 2;
                lbl_desde.Text = "181";
                lbl_hasta.Text = "365";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "UN AÑO A DOS AÑOS")
            {
                Var = 2;
                lbl_desde.Text = "366";
                lbl_hasta.Text = "732";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
            else if (cmb_ant.Text == "MAS DE DOS AÑOS")
            {
                Var = 2;
                lbl_desde.Text = "733";
                lbl_hasta.Text = "1000000000";
                Llenar_dgv_ant(dgv_ant);
                Diseño_dgv(dgv_ant);
                Calcula_Total2();
            }
        }
        private void Lbl_desde_Click(object sender, EventArgs e)
        {
        }
        private void Cmb_ant2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ant2.Text == "MENOS DE DOS SEMANAS")
            {
                Var = 2;
                lbl_desde2.Text = "0";
                lbl_hasta2.Text = "15";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "DOS SEMANAS A UN MES")
            {
                Var = 2;
                lbl_desde2.Text = "16";
                lbl_hasta2.Text = "30";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "UN MES A TRES MESES")
            {
                Var = 2;
                lbl_desde2.Text = "31";
                lbl_hasta2.Text = "90";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == " ")
            {
                Var = 2;
                lbl_desde2.Text = "91";
                lbl_hasta2.Text = "180";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "MENOS DE TRES MESES")
            {
                Var = 2;
                lbl_desde2.Text = "0";
                lbl_hasta2.Text = "90";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "MAS DE TRES MESES")
            {
                Var = 2;
                lbl_desde2.Text = "90";
                lbl_hasta2.Text = "1000000000";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "SEIS MESES A UN AÑO")
            {
                Var = 2;
                lbl_desde2.Text = "181";
                lbl_hasta2.Text = "365";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "UN AÑO A DOS AÑOS")
            {
                Var = 2;
                lbl_desde2.Text = "366";
                lbl_hasta2.Text = "732";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
            else if (cmb_ant2.Text == "MAS DE DOS AÑOS")
            {
                Var = 2;
                lbl_desde2.Text = "733";
                lbl_hasta2.Text = "1000000000";
                Llenar_dgv_ant2(dgv_ant2);
                Diseño_dgv(dgv_ant2);
                Calcula_Total3();
            }
        }

        private void Btn_exportar_ant_Click(object sender, EventArgs e)
        {
            if (cmb_ant.Text == "")
            {
                MessageBox.Show("Es necesario filtrar la información.", "Aviso");
                cmb_ant.Focus();
            }
            else
            {
                Exportara_Exel_ant();
            }  
        }

        private void Btn_exportar_ant2_Click(object sender, EventArgs e)
        {
            if (cmb_ant2.Text == "")
            {
                MessageBox.Show("Es necesario filtrar la información.", "Aviso");
                cmb_ant2.Focus();
            }
            else
            {
                Exportara_Exel_ant2();
            }     
        }

        private void Dtm_fecha_ValueChanged(object sender, EventArgs e)
        {
            Var = 1;
            Llenar_dgv(dgv_total);
            Calcula_Total();
        }

        private void Btn_reporte_Click(object sender, EventArgs e)
        {
            Rotacion rot = new Rotacion();
            rot.Var = Convert.ToInt32("3");
            rot.Fecha = dtm_fecha.Value;
            rot.Desde = Convert.ToInt32(lbl_desde.Text);
            rot.Hasta = Convert.ToInt32(lbl_hasta.Text);
            rot.Filtro = cmb_ant.Text;
            rot.Show();

            if (cmb_ant.Text == "")
            {
            }
            else
            {
                Rotacion_Filtro f1 = new Rotacion_Filtro();
                f1.Var = Convert.ToInt32("4");
                f1.Fecha = dtm_fecha.Value;
                f1.Desde = Convert.ToInt32(lbl_desde.Text);
                f1.Hasta = Convert.ToInt32(lbl_hasta.Text);
                f1.Filtro = cmb_ant.Text;
                f1.Show();
            }
            if (cmb_ant2.Text == "")
            {
            }
            else
            {
                Rotacion_Filtro2 f2 = new Rotacion_Filtro2();
                f2.Var = Convert.ToInt32("4");
                f2.Fecha = dtm_fecha.Value;
                f2.Desde = Convert.ToInt32(lbl_desde2.Text);
                f2.Hasta = Convert.ToInt32(lbl_hasta2.Text);
                f2.Filtro = cmb_ant2.Text;
                f2.Show();
            }   

            Rotacion_Grafico gr = new Rotacion_Grafico();
            gr.Var = Convert.ToInt32("1");
            gr.Fecha = dtm_fecha.Value;
            gr.Show();
        }
    }
}
