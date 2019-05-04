namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ap1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ap2 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.bt_sql = new System.Windows.Forms.Button();
            this.bt_csv = new System.Windows.Forms.Button();
            this.bt_excel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bjson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnredondo2 = new WindowsFormsApp1.btnredondo();
            this.btnredondo1 = new WindowsFormsApp1.btnredondo();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 646);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido 1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "32545";
            // 
            // ap1
            // 
            this.ap1.Location = new System.Drawing.Point(114, 65);
            this.ap1.Name = "ap1";
            this.ap1.Size = new System.Drawing.Size(100, 20);
            this.ap1.TabIndex = 5;
            this.ap1.Text = "Monge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telefono";
            // 
            // ap2
            // 
            this.ap2.Location = new System.Drawing.Point(114, 112);
            this.ap2.Name = "ap2";
            this.ap2.Size = new System.Drawing.Size(100, 20);
            this.ap2.TabIndex = 11;
            this.ap2.Text = "Duarte";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(114, 159);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 12;
            this.name.Text = "Eduardo";
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(103, 253);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 14;
            this.correo.Text = "edmonge@correo.com";
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(103, 300);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(100, 20);
            this.tel.TabIndex = 15;
            this.tel.Text = "621930325";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // bt_pdf
            // 
            this.bt_pdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_pdf.BackgroundImage")));
            this.bt_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_pdf.FlatAppearance.BorderSize = 0;
            this.bt_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pdf.Location = new System.Drawing.Point(93, 349);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(65, 70);
            this.bt_pdf.TabIndex = 19;
            this.bt_pdf.UseVisualStyleBackColor = true;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // bt_sql
            // 
            this.bt_sql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_sql.BackgroundImage")));
            this.bt_sql.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_sql.FlatAppearance.BorderSize = 0;
            this.bt_sql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sql.Location = new System.Drawing.Point(17, 349);
            this.bt_sql.Name = "bt_sql";
            this.bt_sql.Size = new System.Drawing.Size(65, 70);
            this.bt_sql.TabIndex = 21;
            this.bt_sql.UseVisualStyleBackColor = true;
            this.bt_sql.Click += new System.EventHandler(this.bt_sql_Click);
            // 
            // bt_csv
            // 
            this.bt_csv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_csv.BackgroundImage")));
            this.bt_csv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_csv.FlatAppearance.BorderSize = 0;
            this.bt_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_csv.Location = new System.Drawing.Point(169, 349);
            this.bt_csv.Name = "bt_csv";
            this.bt_csv.Size = new System.Drawing.Size(65, 70);
            this.bt_csv.TabIndex = 22;
            this.bt_csv.UseVisualStyleBackColor = true;
            this.bt_csv.Click += new System.EventHandler(this.bt_csv_Click);
            // 
            // bt_excel
            // 
            this.bt_excel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_excel.BackgroundImage")));
            this.bt_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_excel.FlatAppearance.BorderSize = 0;
            this.bt_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_excel.Location = new System.Drawing.Point(321, 349);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(65, 70);
            this.bt_excel.TabIndex = 23;
            this.bt_excel.UseVisualStyleBackColor = true;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // bjson
            // 
            this.bjson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bjson.BackgroundImage")));
            this.bjson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bjson.FlatAppearance.BorderSize = 0;
            this.bjson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bjson.Location = new System.Drawing.Point(245, 349);
            this.bjson.Name = "bjson";
            this.bjson.Size = new System.Drawing.Size(65, 70);
            this.bjson.TabIndex = 26;
            this.bjson.UseVisualStyleBackColor = true;
            this.bjson.Click += new System.EventHandler(this.bjson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 32);
            this.panel1.TabIndex = 27;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1086, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1118, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bjson);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bt_pdf);
            this.panel2.Controls.Add(this.btnredondo2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnredondo1);
            this.panel2.Controls.Add(this.bt_sql);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.tel);
            this.panel2.Controls.Add(this.bt_excel);
            this.panel2.Controls.Add(this.bt_csv);
            this.panel2.Controls.Add(this.correo);
            this.panel2.Controls.Add(this.ap2);
            this.panel2.Controls.Add(this.ap1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(723, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 703);
            this.panel2.TabIndex = 28;
            // 
            // btnredondo2
            // 
            this.btnredondo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnredondo2.BackgroundImage")));
            this.btnredondo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnredondo2.FlatAppearance.BorderSize = 0;
            this.btnredondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnredondo2.Location = new System.Drawing.Point(323, 254);
            this.btnredondo2.Name = "btnredondo2";
            this.btnredondo2.Size = new System.Drawing.Size(65, 70);
            this.btnredondo2.TabIndex = 25;
            this.btnredondo2.UseVisualStyleBackColor = true;
            this.btnredondo2.Click += new System.EventHandler(this.btnredondo2_Click);
            // 
            // btnredondo1
            // 
            this.btnredondo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnredondo1.BackgroundImage")));
            this.btnredondo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnredondo1.FlatAppearance.BorderSize = 0;
            this.btnredondo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnredondo1.Location = new System.Drawing.Point(241, 254);
            this.btnredondo1.Name = "btnredondo1";
            this.btnredondo1.Size = new System.Drawing.Size(65, 70);
            this.btnredondo1.TabIndex = 24;
            this.btnredondo1.UseVisualStyleBackColor = true;
            this.btnredondo1.Click += new System.EventHandler(this.btnredondo1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(141)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1153, 735);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ap1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ap2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.Button bt_sql;
        private System.Windows.Forms.Button bt_csv;
        private System.Windows.Forms.Button bt_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private btnredondo btnredondo1;
        private btnredondo btnredondo2;
        private System.Windows.Forms.Button bjson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

