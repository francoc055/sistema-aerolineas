namespace Vista
{
    partial class VistaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUsuario));
            panel1 = new Panel();
            btnCerrarSesion = new Button();
            labelCambiar = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabPage6 = new TabPage();
            tabPage5 = new TabPage();
            tabPage4 = new TabPage();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(labelCambiar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 58);
            panel1.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.LightGray;
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(918, 16);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(33, 31);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // labelCambiar
            // 
            labelCambiar.AutoSize = true;
            labelCambiar.Font = new Font("Times New Roman", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelCambiar.Location = new Point(190, 21);
            labelCambiar.Name = "labelCambiar";
            labelCambiar.Size = new Size(73, 20);
            labelCambiar.TabIndex = 2;
            labelCambiar.Text = "operador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 18);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 58);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(975, 427);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Aeronaves";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(975, 427);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Vuelos";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(975, 427);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Pasajeros";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(975, 427);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Estadisticas Historicas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de viajes";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 58);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 455);
            tabControl1.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(975, 427);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vender viaje";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // VistaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 513);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "VistaUsuario";
            Text = "VistaUsuario";
            FormClosed += VistaUsuario_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        protected Label labelCambiar;
        protected Panel panel1;
        protected TabPage tabPage6;
        protected TabPage tabPage5;
        protected TabPage tabPage4;
        protected TabPage tabPage2;
        protected TabPage tabPage1;
        protected TabControl tabControl1;
        protected TabPage tabPage3;
        protected Button btnCerrarSesion;
    }
}