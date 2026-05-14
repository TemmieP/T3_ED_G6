namespace WindowsFormsApp1
{
    partial class RegistroAlumnos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblcant = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnModificarApell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnModificarNom = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNuevoApell = new System.Windows.Forms.TextBox();
            this.txtNuevoNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlfabInverso = new System.Windows.Forms.Button();
            this.btnOrdenAlfabetico = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVerAsistencia = new System.Windows.Forms.Button();
            this.listaasistencia = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnTardanza = new System.Windows.Forms.Button();
            this.btnFalta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDPI = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.listaasistencia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 500);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnAlfabInverso);
            this.tabPage1.Controls.Add(this.btnOrdenAlfabetico);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumnos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.listaasistencia);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asistencia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblcant);
            this.groupBox1.Controls.Add(this.btnContar);
            this.groupBox1.Controls.Add(this.btnModificarApell);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnModificarNom);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.txtNuevoApell);
            this.groupBox1.Controls.Add(this.txtNuevoNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 326);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro y modificación";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(164, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcant.Location = new System.Drawing.Point(64, 246);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(29, 20);
            this.lblcant.TabIndex = 12;
            this.lblcant.Text = "....";
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(44, 279);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 11;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnModificarApell
            // 
            this.btnModificarApell.Location = new System.Drawing.Point(18, 163);
            this.btnModificarApell.Name = "btnModificarApell";
            this.btnModificarApell.Size = new System.Drawing.Size(129, 23);
            this.btnModificarApell.TabIndex = 10;
            this.btnModificarApell.Text = "Modificar apellidos";
            this.btnModificarApell.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad de alumnos registrados:";
            // 
            // btnModificarNom
            // 
            this.btnModificarNom.Location = new System.Drawing.Point(18, 124);
            this.btnModificarNom.Name = "btnModificarNom";
            this.btnModificarNom.Size = new System.Drawing.Size(129, 23);
            this.btnModificarNom.TabIndex = 9;
            this.btnModificarNom.Text = "Modificar nombre";
            this.btnModificarNom.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 86);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtNuevoApell
            // 
            this.txtNuevoApell.Location = new System.Drawing.Point(164, 44);
            this.txtNuevoApell.Name = "txtNuevoApell";
            this.txtNuevoApell.Size = new System.Drawing.Size(147, 20);
            this.txtNuevoApell.TabIndex = 4;
            // 
            // txtNuevoNom
            // 
            this.txtNuevoNom.Location = new System.Drawing.Point(18, 44);
            this.txtNuevoNom.Name = "txtNuevoNom";
            this.txtNuevoNom.Size = new System.Drawing.Size(129, 20);
            this.txtNuevoNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(s):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-98, -161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de Alumnos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(449, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ordenar:";
            // 
            // btnAlfabInverso
            // 
            this.btnAlfabInverso.Location = new System.Drawing.Point(640, 416);
            this.btnAlfabInverso.Name = "btnAlfabInverso";
            this.btnAlfabInverso.Size = new System.Drawing.Size(75, 23);
            this.btnAlfabInverso.TabIndex = 17;
            this.btnAlfabInverso.Text = "Z-A";
            this.btnAlfabInverso.UseVisualStyleBackColor = true;
            // 
            // btnOrdenAlfabetico
            // 
            this.btnOrdenAlfabetico.Location = new System.Drawing.Point(452, 416);
            this.btnOrdenAlfabetico.Name = "btnOrdenAlfabetico";
            this.btnOrdenAlfabetico.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenAlfabetico.TabIndex = 16;
            this.btnOrdenAlfabetico.Text = "A-Z";
            this.btnOrdenAlfabetico.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombres,
            this.Apellidos});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(452, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 325);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombres
            // 
            this.Nombres.Text = "Nombre(s)";
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.Text = "Apellidos";
            this.Apellidos.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Registro de alumnos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registro de Asistencia";
            // 
            // btnVerAsistencia
            // 
            this.btnVerAsistencia.Location = new System.Drawing.Point(17, 38);
            this.btnVerAsistencia.Name = "btnVerAsistencia";
            this.btnVerAsistencia.Size = new System.Drawing.Size(92, 23);
            this.btnVerAsistencia.TabIndex = 1;
            this.btnVerAsistencia.Text = "Actualizar lista";
            this.btnVerAsistencia.UseVisualStyleBackColor = true;
            this.btnVerAsistencia.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listaasistencia
            // 
            this.listaasistencia.Controls.Add(this.listView2);
            this.listaasistencia.Controls.Add(this.btnVerAsistencia);
            this.listaasistencia.Location = new System.Drawing.Point(225, 46);
            this.listaasistencia.Name = "listaasistencia";
            this.listaasistencia.Size = new System.Drawing.Size(605, 396);
            this.listaasistencia.TabIndex = 2;
            this.listaasistencia.TabStop = false;
            this.listaasistencia.Text = "Lista de asistencia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFalta);
            this.groupBox2.Controls.Add(this.btnTardanza);
            this.groupBox2.Controls.Add(this.btnAsistencia);
            this.groupBox2.Location = new System.Drawing.Point(19, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro y modificación";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 65);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(582, 325);
            this.listView2.TabIndex = 16;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre(s)";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellidos";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asistencia";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tardanzas/Inasistencias";
            this.columnHeader4.Width = 132;
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Location = new System.Drawing.Point(23, 28);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(139, 23);
            this.btnAsistencia.TabIndex = 0;
            this.btnAsistencia.Text = "Marcar asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            // 
            // btnTardanza
            // 
            this.btnTardanza.Location = new System.Drawing.Point(23, 57);
            this.btnTardanza.Name = "btnTardanza";
            this.btnTardanza.Size = new System.Drawing.Size(139, 23);
            this.btnTardanza.TabIndex = 1;
            this.btnTardanza.Text = "Marcar Tardanza";
            this.btnTardanza.UseVisualStyleBackColor = true;
            // 
            // btnFalta
            // 
            this.btnFalta.Location = new System.Drawing.Point(23, 89);
            this.btnFalta.Name = "btnFalta";
            this.btnFalta.Size = new System.Drawing.Size(139, 23);
            this.btnFalta.TabIndex = 2;
            this.btnFalta.Text = "Marcar Falta";
            this.btnFalta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(10, 416);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 23);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Limpiar asistencia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estado:";
            this.columnHeader5.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReport);
            this.groupBox3.Controls.Add(this.btnDPI);
            this.groupBox3.Location = new System.Drawing.Point(19, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 98);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DPI";
            // 
            // btnDPI
            // 
            this.btnDPI.Location = new System.Drawing.Point(22, 19);
            this.btnDPI.Name = "btnDPI";
            this.btnDPI.Size = new System.Drawing.Size(140, 23);
            this.btnDPI.TabIndex = 0;
            this.btnDPI.Text = "Marcar como DPI";
            this.btnDPI.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(25, 58);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 23);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Reportar Tardanzas";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(19, 307);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Búsqueda";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Buscar por apellidos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // RegistroAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 524);
            this.Controls.Add(this.tabControl1);
            this.Name = "RegistroAlumnos";
            this.Text = "Registro de alumnos y asistencia offline";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.listaasistencia.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnModificarApell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnModificarNom;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNuevoApell;
        private System.Windows.Forms.TextBox txtNuevoNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlfabInverso;
        private System.Windows.Forms.Button btnOrdenAlfabetico;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombres;
        private System.Windows.Forms.ColumnHeader Apellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnVerAsistencia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox listaasistencia;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFalta;
        private System.Windows.Forms.Button btnTardanza;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDPI;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

