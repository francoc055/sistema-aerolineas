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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnNuevoVuelo = new Button();
            btnEliminarVuelo = new Button();
            btnModificarVuelo = new Button();
            btnCrearVuelo = new Button();
            cbOrigenNacional = new ComboBox();
            cbAvion = new ComboBox();
            dateTimePickerFecha = new DateTimePicker();
            label9 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox3 = new GroupBox();
            cbOrigenInternacional = new ComboBox();
            cbDestino = new ComboBox();
            groupBox4 = new GroupBox();
            txtFiltrarMatricula = new TextBox();
            label7 = new Label();
            txtFiltrarVuelos = new TextBox();
            label10 = new Label();
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
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Size = new Size(966, 58);
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(label7);
            tabPage6.Controls.Add(txtFiltrarMatricula);
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
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(txtFiltrarVuelos);
            tabPage5.Controls.Add(groupBox4);
            tabPage5.Controls.Add(groupBox3);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(dateTimePickerFecha);
            tabPage5.Controls.Add(cbAvion);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAeronave.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAeronave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAeronave.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewAeronave.Dock = DockStyle.Fill;
            dataGridViewAeronave.EnableHeadersVisualStyles = false;
            dataGridViewAeronave.Location = new Point(3, 3);
            dataGridViewAeronave.Name = "dataGridViewAeronave";
            dataGridViewAeronave.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAeronave.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            cbInternet.Location = new Point(506, 77);
            cbInternet.Name = "cbInternet";
            cbInternet.Size = new Size(100, 23);
            cbInternet.TabIndex = 8;
            // 
            // cbComida
            // 
            cbComida.AutoCompleteCustomSource.AddRange(new string[] { "True", "False" });
            cbComida.FormattingEnabled = true;
            cbComida.Items.AddRange(new object[] { "True", "False" });
            cbComida.Location = new Point(644, 77);
            cbComida.Name = "cbComida";
            cbComida.Size = new Size(100, 23);
            cbComida.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 59);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 12;
            label2.Text = "Internet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(667, 59);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Comida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 60);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 14;
            label4.Text = "Asientos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(396, 60);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 15;
            label5.Text = "Baños";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(800, 59);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 16;
            label6.Text = "Bodega";
            // 
            // numericUpDownAsientos
            // 
            numericUpDownAsientos.Location = new Point(239, 78);
            numericUpDownAsientos.Maximum = new decimal(new int[] { 850, 0, 0, 0 });
            numericUpDownAsientos.Minimum = new decimal(new int[] { 150, 0, 0, 0 });
            numericUpDownAsientos.Name = "numericUpDownAsientos";
            numericUpDownAsientos.Size = new Size(90, 23);
            numericUpDownAsientos.TabIndex = 17;
            numericUpDownAsientos.Value = new decimal(new int[] { 150, 0, 0, 0 });
            // 
            // numericUpDownBaños
            // 
            numericUpDownBaños.Location = new Point(373, 78);
            numericUpDownBaños.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownBaños.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBaños.Name = "numericUpDownBaños";
            numericUpDownBaños.Size = new Size(90, 23);
            numericUpDownBaños.TabIndex = 18;
            numericUpDownBaños.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownBodega
            // 
            numericUpDownBodega.Location = new Point(785, 77);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVuelos.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12, Column14, Column15, Column16, Column17, Column13, Column18 });
            dataGridViewVuelos.Dock = DockStyle.Fill;
            dataGridViewVuelos.EnableHeadersVisualStyles = false;
            dataGridViewVuelos.Location = new Point(3, 3);
            dataGridViewVuelos.Name = "dataGridViewVuelos";
            dataGridViewVuelos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewVuelos.RowTemplate.Height = 25;
            dataGridViewVuelos.Size = new Size(946, 198);
            dataGridViewVuelos.TabIndex = 0;
            dataGridViewVuelos.CellContentClick += dataGridViewVuelos_CellContentClick;
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
            Column9.HeaderText = "Destino";
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
            Column12.HeaderText = "Asientos disponibles";
            Column12.Name = "Column12";
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
            // Column13
            // 
            Column13.HeaderText = "Costo Neto premium";
            Column13.Name = "Column13";
            // 
            // Column18
            // 
            Column18.HeaderText = "Costo Neto turista";
            Column18.Name = "Column18";
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
            btnNuevoVuelo.Click += btnNuevoVuelo_Click;
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
            btnEliminarVuelo.Click += btnEliminarVuelo_Click;
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
            btnModificarVuelo.Click += btnModificarVuelo_Click;
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
            btnCrearVuelo.Click += btnCrearVuelo_Click;
            // 
            // cbOrigenNacional
            // 
            cbOrigenNacional.FormattingEnabled = true;
            cbOrigenNacional.Location = new Point(122, 23);
            cbOrigenNacional.Name = "cbOrigenNacional";
            cbOrigenNacional.Size = new Size(101, 23);
            cbOrigenNacional.TabIndex = 6;
            // 
            // cbAvion
            // 
            cbAvion.FormattingEnabled = true;
            cbAvion.Location = new Point(157, 154);
            cbAvion.Name = "cbAvion";
            cbAvion.Size = new Size(121, 23);
            cbAvion.TabIndex = 7;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(352, 151);
            dateTimePickerFecha.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePickerFecha.MinDate = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(216, 23);
            dateTimePickerFecha.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(195, 136);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 13;
            label9.Text = "Avion";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(29, 23);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nacional";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Internacional";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbOrigenInternacional);
            groupBox3.Controls.Add(cbOrigenNacional);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Location = new Point(157, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(242, 100);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "Origen";
            // 
            // cbOrigenInternacional
            // 
            cbOrigenInternacional.FormattingEnabled = true;
            cbOrigenInternacional.Items.AddRange(new object[] { "Buenos Aires" });
            cbOrigenInternacional.Location = new Point(122, 61);
            cbOrigenInternacional.Name = "cbOrigenInternacional";
            cbOrigenInternacional.Size = new Size(101, 23);
            cbOrigenInternacional.TabIndex = 17;
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Location = new Point(30, 44);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(110, 23);
            cbDestino.TabIndex = 14;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbDestino);
            groupBox4.Location = new Point(428, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(166, 100);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Destino";
            // 
            // txtFiltrarMatricula
            // 
            txtFiltrarMatricula.Location = new Point(462, 185);
            txtFiltrarMatricula.Name = "txtFiltrarMatricula";
            txtFiltrarMatricula.Size = new Size(123, 23);
            txtFiltrarMatricula.TabIndex = 20;
            txtFiltrarMatricula.TextChanged += txtFiltrarMatricula_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(468, 167);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 21;
            label7.Text = "Filtrar por matricula";
            // 
            // txtFiltrarVuelos
            // 
            txtFiltrarVuelos.Location = new Point(741, 108);
            txtFiltrarVuelos.Name = "txtFiltrarVuelos";
            txtFiltrarVuelos.Size = new Size(115, 23);
            txtFiltrarVuelos.TabIndex = 20;
            txtFiltrarVuelos.TextChanged += txtFiltrarVuelos_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(770, 90);
            label10.Name = "label10";
            label10.Size = new Size(44, 15);
            label10.TabIndex = 21;
            label10.Text = "label10";
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private Button btnNuevoVuelo;
        private Button btnEliminarVuelo;
        private Button btnModificarVuelo;
        private Button btnCrearVuelo;
        private DateTimePicker dateTimePickerFecha;
        private ComboBox cbAvion;
        private ComboBox cbOrigenNacional;
        private Label label9;
        private Label label8;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private RadioButton radioButton2;
        private ComboBox cbOrigenInternacional;
        private GroupBox groupBox4;
        private ComboBox cbDestino;
        private Label label7;
        private TextBox txtFiltrarMatricula;
        private Label label10;
        private TextBox txtFiltrarVuelos;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column18;
    }
}