namespace Vista
{
    partial class vistaAdministrador
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewAeronave = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            btnNuevo = new Button();
            btnEliminarAvion = new Button();
            btnModificarAvion = new Button();
            btnCrearAvion = new Button();
            cbInternet = new ComboBox();
            cbComida = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            numericUpDownAsientos = new NumericUpDown();
            numericUpDownBaños = new NumericUpDown();
            numericUpDownBodega = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridViewVuelos = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnNuevoVuelo = new Button();
            btnEliminarVuelo = new Button();
            btnModificarVuelo = new Button();
            btnCrearVuelo = new Button();
            cbOrigen = new ComboBox();
            cbAvion = new ComboBox();
            dateTimePickerFecha = new DateTimePicker();
            cbDestino = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            tabControl1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAeronave).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBaños).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBodega).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVuelos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(966, 58);
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(numericUpDownBodega);
            tabPage6.Controls.Add(numericUpDownBaños);
            tabPage6.Controls.Add(numericUpDownAsientos);
            tabPage6.Controls.Add(label6);
            tabPage6.Controls.Add(label5);
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(label3);
            tabPage6.Controls.Add(label2);
            tabPage6.Controls.Add(cbComida);
            tabPage6.Controls.Add(cbInternet);
            tabPage6.Controls.Add(groupBox2);
            tabPage6.Controls.Add(tableLayoutPanel1);
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(cbDestino);
            tabPage5.Controls.Add(dateTimePickerFecha);
            tabPage5.Controls.Add(cbAvion);
            tabPage5.Controls.Add(cbOrigen);
            tabPage5.Controls.Add(groupBox1);
            tabPage5.Controls.Add(tableLayoutPanel2);
            tabPage5.Size = new Size(958, 433);
            // 
            // tabPage1
            // 
            tabPage1.Size = new Size(958, 433);
            // 
            // tabControl1
            // 
            tabControl1.Size = new Size(966, 461);
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(dataGridViewAeronave, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(3, 223);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(969, 201);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewAeronave
            // 
            dataGridViewAeronave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAeronave.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewAeronave.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewAeronave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewAeronave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAeronave.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewAeronave.Dock = DockStyle.Fill;
            dataGridViewAeronave.EnableHeadersVisualStyles = false;
            dataGridViewAeronave.Location = new Point(3, 3);
            dataGridViewAeronave.Name = "dataGridViewAeronave";
            dataGridViewAeronave.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewAeronave.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewAeronave.RowTemplate.Height = 25;
            dataGridViewAeronave.Size = new Size(963, 195);
            dataGridViewAeronave.TabIndex = 0;
            dataGridViewAeronave.CellContentClick += dataGridViewAeronave_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Matricula";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad de asientos";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad de baños";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Internet";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Comida";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Capacidad bodega";
            Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(btnNuevo);
            groupBox2.Controls.Add(btnEliminarAvion);
            groupBox2.Controls.Add(btnModificarAvion);
            groupBox2.Controls.Add(btnCrearAvion);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 224);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Aeronave";
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(33, 172);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminarAvion
            // 
            btnEliminarAvion.FlatAppearance.BorderSize = 0;
            btnEliminarAvion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarAvion.FlatStyle = FlatStyle.Flat;
            btnEliminarAvion.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarAvion.ForeColor = Color.White;
            btnEliminarAvion.Location = new Point(33, 128);
            btnEliminarAvion.Name = "btnEliminarAvion";
            btnEliminarAvion.Size = new Size(75, 23);
            btnEliminarAvion.TabIndex = 2;
            btnEliminarAvion.Text = "Eliminar";
            btnEliminarAvion.UseVisualStyleBackColor = true;
            btnEliminarAvion.Click += btnEliminarAvion_Click;
            // 
            // btnModificarAvion
            // 
            btnModificarAvion.FlatAppearance.BorderSize = 0;
            btnModificarAvion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnModificarAvion.FlatStyle = FlatStyle.Flat;
            btnModificarAvion.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarAvion.ForeColor = Color.White;
            btnModificarAvion.Location = new Point(33, 86);
            btnModificarAvion.Name = "btnModificarAvion";
            btnModificarAvion.Size = new Size(76, 23);
            btnModificarAvion.TabIndex = 1;
            btnModificarAvion.Text = "Modificar";
            btnModificarAvion.UseVisualStyleBackColor = true;
            btnModificarAvion.Click += btnModificarAvion_Click;
            // 
            // btnCrearAvion
            // 
            btnCrearAvion.BackColor = Color.Silver;
            btnCrearAvion.FlatAppearance.BorderSize = 0;
            btnCrearAvion.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCrearAvion.FlatStyle = FlatStyle.Flat;
            btnCrearAvion.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearAvion.ForeColor = Color.White;
            btnCrearAvion.Location = new Point(33, 45);
            btnCrearAvion.Name = "btnCrearAvion";
            btnCrearAvion.Size = new Size(75, 23);
            btnCrearAvion.TabIndex = 0;
            btnCrearAvion.Text = "Crear";
            btnCrearAvion.UseVisualStyleBackColor = false;
            btnCrearAvion.Click += btnCrearAvion_Click;
            // 
            // cbInternet
            // 
            cbInternet.FormattingEnabled = true;
            cbInternet.Items.AddRange(new object[] { "True", "False" });
            cbInternet.Location = new Point(388, 49);
            cbInternet.Name = "cbInternet";
            cbInternet.Size = new Size(100, 23);
            cbInternet.TabIndex = 8;
            // 
            // cbComida
            // 
            cbComida.AutoCompleteCustomSource.AddRange(new string[] { "True", "False" });
            cbComida.FormattingEnabled = true;
            cbComida.Items.AddRange(new object[] { "True", "False" });
            cbComida.Location = new Point(388, 115);
            cbComida.Name = "cbComida";
            cbComida.Size = new Size(100, 23);
            cbComida.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 31);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 12;
            label2.Text = "Internet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 97);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Comida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 30);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 14;
            label4.Text = "Asientos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 97);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Baños";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 157);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 16;
            label6.Text = "Bodega";
            // 
            // numericUpDownAsientos
            // 
            numericUpDownAsientos.Location = new Point(237, 50);
            numericUpDownAsientos.Maximum = new decimal(new int[] { 850, 0, 0, 0 });
            numericUpDownAsientos.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownAsientos.Name = "numericUpDownAsientos";
            numericUpDownAsientos.Size = new Size(90, 23);
            numericUpDownAsientos.TabIndex = 17;
            numericUpDownAsientos.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericUpDownBaños
            // 
            numericUpDownBaños.Location = new Point(237, 116);
            numericUpDownBaños.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownBaños.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBaños.Name = "numericUpDownBaños";
            numericUpDownBaños.Size = new Size(90, 23);
            numericUpDownBaños.TabIndex = 18;
            numericUpDownBaños.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownBodega
            // 
            numericUpDownBodega.Location = new Point(311, 177);
            numericUpDownBodega.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            numericUpDownBodega.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownBodega.Name = "numericUpDownBodega";
            numericUpDownBodega.Size = new Size(90, 23);
            numericUpDownBodega.TabIndex = 19;
            numericUpDownBodega.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(dataGridViewVuelos, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(3, 226);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(952, 204);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridViewVuelos
            // 
            dataGridViewVuelos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVuelos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVuelos.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17 });
            dataGridViewVuelos.Dock = DockStyle.Fill;
            dataGridViewVuelos.EnableHeadersVisualStyles = false;
            dataGridViewVuelos.Location = new Point(3, 3);
            dataGridViewVuelos.Name = "dataGridViewVuelos";
            dataGridViewVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewVuelos.RowTemplate.Height = 25;
            dataGridViewVuelos.Size = new Size(946, 198);
            dataGridViewVuelos.TabIndex = 0;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Origen";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Partida";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "Fecha de vuelo";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "Avion al que pertenece";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Asientos Premium";
            Column12.Name = "Column12";
            // 
            // Column13
            // 
            Column13.HeaderText = "Asientos Turista";
            Column13.Name = "Column13";
            // 
            // Column14
            // 
            Column14.HeaderText = "Costo Turista";
            Column14.Name = "Column14";
            // 
            // Column15
            // 
            Column15.HeaderText = "Costo Premium";
            Column15.Name = "Column15";
            // 
            // Column16
            // 
            Column16.HeaderText = "Duracion";
            Column16.Name = "Column16";
            // 
            // Column17
            // 
            Column17.HeaderText = "Cantidad de pasajeros";
            Column17.Name = "Column17";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(btnNuevoVuelo);
            groupBox1.Controls.Add(btnEliminarVuelo);
            groupBox1.Controls.Add(btnModificarVuelo);
            groupBox1.Controls.Add(btnCrearVuelo);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 224);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vuelo";
            // 
            // btnNuevoVuelo
            // 
            btnNuevoVuelo.FlatAppearance.BorderSize = 0;
            btnNuevoVuelo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnNuevoVuelo.FlatStyle = FlatStyle.Flat;
            btnNuevoVuelo.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoVuelo.ForeColor = Color.White;
            btnNuevoVuelo.Location = new Point(33, 172);
            btnNuevoVuelo.Name = "btnNuevoVuelo";
            btnNuevoVuelo.Size = new Size(75, 23);
            btnNuevoVuelo.TabIndex = 3;
            btnNuevoVuelo.Text = "Nuevo";
            btnNuevoVuelo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarVuelo
            // 
            btnEliminarVuelo.FlatAppearance.BorderSize = 0;
            btnEliminarVuelo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnEliminarVuelo.FlatStyle = FlatStyle.Flat;
            btnEliminarVuelo.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarVuelo.ForeColor = Color.White;
            btnEliminarVuelo.Location = new Point(33, 128);
            btnEliminarVuelo.Name = "btnEliminarVuelo";
            btnEliminarVuelo.Size = new Size(75, 23);
            btnEliminarVuelo.TabIndex = 2;
            btnEliminarVuelo.Text = "Eliminar";
            btnEliminarVuelo.UseVisualStyleBackColor = true;
            // 
            // btnModificarVuelo
            // 
            btnModificarVuelo.FlatAppearance.BorderSize = 0;
            btnModificarVuelo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnModificarVuelo.FlatStyle = FlatStyle.Flat;
            btnModificarVuelo.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarVuelo.ForeColor = Color.White;
            btnModificarVuelo.Location = new Point(33, 86);
            btnModificarVuelo.Name = "btnModificarVuelo";
            btnModificarVuelo.Size = new Size(76, 23);
            btnModificarVuelo.TabIndex = 1;
            btnModificarVuelo.Text = "Modificar";
            btnModificarVuelo.UseVisualStyleBackColor = true;
            // 
            // btnCrearVuelo
            // 
            btnCrearVuelo.BackColor = Color.Silver;
            btnCrearVuelo.FlatAppearance.BorderSize = 0;
            btnCrearVuelo.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnCrearVuelo.FlatStyle = FlatStyle.Flat;
            btnCrearVuelo.Font = new Font("Modern No. 20", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearVuelo.ForeColor = Color.White;
            btnCrearVuelo.Location = new Point(33, 45);
            btnCrearVuelo.Name = "btnCrearVuelo";
            btnCrearVuelo.Size = new Size(75, 23);
            btnCrearVuelo.TabIndex = 0;
            btnCrearVuelo.Text = "Crear";
            btnCrearVuelo.UseVisualStyleBackColor = false;
            // 
            // cbOrigen
            // 
            cbOrigen.FormattingEnabled = true;
            cbOrigen.Location = new Point(203, 55);
            cbOrigen.Name = "cbOrigen";
            cbOrigen.Size = new Size(121, 23);
            cbOrigen.TabIndex = 6;
            // 
            // cbAvion
            // 
            cbAvion.FormattingEnabled = true;
            cbAvion.Location = new Point(778, 55);
            cbAvion.Name = "cbAvion";
            cbAvion.Size = new Size(121, 23);
            cbAvion.TabIndex = 7;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(517, 55);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(216, 23);
            dateTimePickerFecha.TabIndex = 9;
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Location = new Point(363, 55);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(121, 23);
            cbDestino.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 37);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 11;
            label7.Text = "Origen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(400, 37);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 12;
            label8.Text = "Destino";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(818, 37);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 13;
            label9.Text = "Avion";
            // 
            // vistaAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 519);
            Name = "vistaAdministrador";
            Text = "vistaAdministrador";
            Load += vistaAdministrador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabControl1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAeronave).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownAsientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBaños).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBodega).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVuelos).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewAeronave;
        private GroupBox groupBox2;
        private Button btnNuevo;
        private Button btnEliminarAvion;
        private Button btnModificarAvion;
        private Button btnCrearAvion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox cbComida;
        private ComboBox cbInternet;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown numericUpDownBodega;
        private NumericUpDown numericUpDownBaños;
        private NumericUpDown numericUpDownAsientos;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewVuelos;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private GroupBox groupBox1;
        private Button btnNuevoVuelo;
        private Button btnEliminarVuelo;
        private Button btnModificarVuelo;
        private Button btnCrearVuelo;
        private DateTimePicker dateTimePickerFecha;
        private ComboBox cbAvion;
        private ComboBox cbOrigen;
        private ComboBox cbDestino;
        private Label label7;
        private Label label9;
        private Label label8;
    }
}