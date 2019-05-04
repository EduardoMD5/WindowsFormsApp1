using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using ClosedXML.Excel;
using System.Runtime.InteropServices;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection mySqlConnecion;
        MySqlCommand mySqlCommand;
        //MySqlDataReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargadatos()
        {
            try
            {
                dataGridView1.Rows.Clear();
                mySqlConnecion = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar;"); // String de connexion
                mySqlConnecion.Open();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT matricula as 'Expediente', UPPER(ap1) as 'Apellido P', UPPER(ap2) as 'Apellido M', UPPER(nombre) as 'Primer Nombre', fechadenacimento, correo, telefono FROM alumnos", mySqlConnecion);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargadatos();
            bt_style();
            Vista();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            ap1.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            ap2.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            name.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse (dataGridView1[4, e.RowIndex].Value.ToString());
            correo.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            tel.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void bt_sql_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "npi"; // nombre de la ventana
            saveFileDialog1.FileName = "*.sql"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo sql |*.sql"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);

            StreamWriter writer = new StreamWriter(archivo);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                writer.WriteLine("INSERT INTO alumnos (matricula,ap1,ap2,nombre,fechadenacimento,correo,telefono) VALUES ("+( dataGridView1[0,i].Value.ToString() +",'"+ dataGridView1[1,i].Value.ToString() + "','" + dataGridView1[2, i].Value.ToString() + "','" + dataGridView1[3, i].Value.ToString() + "','" + Convert.ToDateTime(dataGridView1[4,i].Value.ToString()).Year +"-"+ Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "','" + dataGridView1[5, i].Value.ToString() + "'," + dataGridView1[6, i].Value.ToString() +");"));
            }
            writer.Close();
        }

        private void bt_csv_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "npi"; // nombre de la ventana
            saveFileDialog1.FileName = "*.csv"; // nombre del archivo
            saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
            saveFileDialog1.Filter = "archivo sql |*.csv"; // tipo de archivo(formato)
            saveFileDialog1.ShowDialog();

            string archivo;
            archivo = saveFileDialog1.FileName;
            MessageBox.Show(archivo);

            StreamWriter writer = new StreamWriter(archivo);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if ((i+1) == dataGridView1.ColumnCount)
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText +'\n');
                }

                else
                {
                    writer.Write(dataGridView1.Columns[i].HeaderText + ";");
                }

            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                writer.WriteLine((dataGridView1[0, i].Value.ToString() + ";" + dataGridView1[1, i].Value.ToString() + ";" + dataGridView1[2, i].Value.ToString() + ";" + dataGridView1[3, i].Value.ToString() + ";" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + ";" + dataGridView1[5, i].Value.ToString() + ";" + dataGridView1[6, i].Value.ToString()));
            }
            writer.Close();
        }

        private void btnredondo1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO alumnos (matricula,ap1,ap2,nombre,fechadenacimento,correo,telefono) VALUES (" + textBox1.Text + ",'" + ap1.Text + "','" + ap2.Text + "','" + name.Text + "','" + dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day + "','" + correo.Text + "'," + tel.Text + ")";
            //MessageBox.Show(query);

            try
            {
                mySqlConnecion = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar;"); // String de connexion
                mySqlConnecion.Open();
                mySqlCommand = new MySqlCommand(query, mySqlConnecion);
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Agregado con Exito");

                cargadatos();
                mySqlConnecion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnredondo2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM alumnos WHERE matricula=" + textBox1.Text;

            try
            {
                mySqlConnecion = new MySqlConnection("host=localhost;user=root;password=1234;database=sistema_escolar;"); // String de connexion
                mySqlConnecion.Open();
                mySqlCommand = new MySqlCommand(query, mySqlConnecion);
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Eliminado con Exito");

                cargadatos();
                mySqlConnecion.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vista()
        {
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                if (i % 2 == 1)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.SteelBlue;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                }
            }

        }

        private void bt_style()
        {
            bordes.BorderRedondoButton(bt_csv);
            bordes.BorderRedondoButton(bt_pdf);
            bordes.BorderRedondoButton(bt_excel);
            bordes.BorderRedondoButton(bt_word);
            bordes.BorderRedondoButton(bt_sql);
            bordes.BorderRedondoButton(bjson);
        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Title = "Guardar"; // nombre de la ventana
                saveFileDialog1.FileName = "prueba.xlsx"; // nombre del archivo
                saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
                saveFileDialog1.Filter = "archivo excel |prueba.xlsx"; // tipo de archivo(formato)
                saveFileDialog1.ShowDialog();

                string archivo;
                archivo = saveFileDialog1.FileName;
                MessageBox.Show(archivo);

                var workbook = new XLWorkbook();
                var hoja = workbook.Worksheets.Add("Alumnos");
                hoja.Cell(1, 1).Value = "Matricula";
                hoja.Cell(1, 1).Style.Font.Bold = true;
                hoja.Cell(1, 2).Value = "Apellido P";
                hoja.Cell(1, 2).Style.Font.Bold = true;
                hoja.Cell(1, 3).Value = "Apellido M";
                hoja.Cell(1, 3).Style.Font.Bold = true;
                hoja.Cell(1, 4).Value = "Nombre";
                hoja.Cell(1, 4).Style.Font.Bold = true;
                hoja.Cell(1, 5).Value = "fechadenacimento";
                hoja.Cell(1, 5).Style.Font.Bold = true;
                hoja.Cell(1, 6).Value = "Correo";
                hoja.Cell(1, 6).Style.Font.Bold = true;
                hoja.Cell(1, 7).Value = "Telefono";
                hoja.Cell(1, 7).Style.Font.Bold = true;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        hoja.Cell((i+2), (k+1)).Value = dataGridView1.Rows[i].Cells[k].Value.ToString();
                    }
                }
                //hoja.Cell(1, 1).Value="lo que tu quieras";
                workbook.SaveAs(archivo);
            }
        }

        private void bjson_Click(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Title = "Guardar"; // nombre de la ventana
                saveFileDialog1.FileName = "prueba.json"; // nombre del archivo
                saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
                saveFileDialog1.Filter = "archivo json |prueba.json"; // tipo de archivo(formato)
                saveFileDialog1.ShowDialog();

                string archivo;
                archivo = saveFileDialog1.FileName;
                MessageBox.Show(archivo);

                StreamWriter writer = new StreamWriter(archivo);
                writer.WriteLine ("{ \"sistema_escolar\" :");
                writer.WriteLine("\t{");
                writer.WriteLine("\t\t\"alumnos\": [");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((i+1) == dataGridView1.Rows.Count)
                    {
                        writer.WriteLine("\t\t{\n" + ("\t\t\t\"Matricula\":" + dataGridView1[0, i].Value.ToString() + ","
                            + "\n\t\t\t\"Apellido P\":" +"\"" + dataGridView1[1, i].Value.ToString()+ "\"," 
                            + "\n\t\t\t\"Apellido M\":" + "\""+ dataGridView1[2, i].Value.ToString() + "\","
                            + "\n\t\t\t\"Nombre\":" + "\""+dataGridView1[3, i].Value.ToString()+ "\","
                            +  "\n\t\t\t\"Fecha de nacmiento\":" + "\"" 
                            + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\"," 
                            + "\n\t\t\t\"Correo\":" + "\"" +dataGridView1[5, i].Value.ToString() + "\"," 
                            + "\n\t\t\t\"Telefono\":" + dataGridView1[6, i].Value.ToString() + "," + "\n\t\t}"));

                    }
                    else
                    {
                        writer.WriteLine("\t\t{\n" + ("\t\t\t\"Matricula\":" + dataGridView1[0, i].Value.ToString() + "," 
                            + "\n\t\t\t\"Apellido P\":" + "\""+ dataGridView1[1, i].Value.ToString() + "\"," 
                            + "\n\t\t\t\"Apellido M\":" + "\""+dataGridView1[2, i].Value.ToString() + "\","
                            + "\n\t\t\t\"Nombre\":" + "\""+dataGridView1[3, i].Value.ToString()+ "\"," 
                            + "\n\t\t\t\"Fecha de nacmiento\":" + "\"" 
                            + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Year + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Month + "-" + Convert.ToDateTime(dataGridView1[4, i].Value.ToString()).Day + "\"," 
                            + "\n\t\t\t\"Correo\":" + "\""+ dataGridView1[5, i].Value.ToString() + "\"," 
                            + "\n\t\t\t\"Telefono\":" + dataGridView1[6, i].Value.ToString() + "," + "\n\t\t},"));

                    }
                }
                writer.WriteLine("\t\t\t\t ]");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
                writer.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    saveFileDialog1.Title = "Guardar"; // nombre de la ventana
                    saveFileDialog1.FileName = "prueba.pdf"; // nombre del archivo
                    saveFileDialog1.InitialDirectory = @"C:\Users\Monge\source\repos\WindowsFormsApp1\prueba"; // direccion inicial
                    saveFileDialog1.Filter = "archivo pdf |prueba.pdf"; // tipo de archivo(formato)
                    saveFileDialog1.ShowDialog();

                    string archivo;
                    archivo = saveFileDialog1.FileName;
                    MessageBox.Show(archivo);

                    Document lol = new Document(iTextSharp.text.PageSize.LETTER.Rotate());
                    PdfWriter.GetInstance(lol, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                    lol.Open();
                    PdfPTable tablepdf = new PdfPTable(7);
                    PdfPCell titulo = new PdfPCell(new Phrase("Alumnos"));
                    titulo.Colspan = 7;
                    tablepdf.AddCell(titulo);
                    

                    tablepdf.AddCell("Matricula");
                    tablepdf.AddCell("Apellido Paterno");
                    tablepdf.AddCell("Apellido Materno");
                    tablepdf.AddCell("Nombre");
                    tablepdf.AddCell("Fecha de nacimiento");
                    tablepdf.AddCell("Correo");
                    tablepdf.AddCell("Telefono");
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        tablepdf.AddCell(dataGridView1[0,i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[1, i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[2, i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[3, i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[4, i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[5, i].Value.ToString());
                        tablepdf.AddCell(dataGridView1[6, i].Value.ToString());
                    }

                    lol.Add(tablepdf);
                    lol.Close();
                }

                catch (Exception error)
                {
                    MessageBox.Show(error+"");
                }
            }
        }
    }
}
