﻿namespace vistaWf
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUser = new TextBox();
            txtContra = new TextBox();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            btnRellenarVendedor = new Button();
            btnRellenarSupervisor = new Button();
            btnRellenarAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(145, 158);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(151, 23);
            txtUser.TabIndex = 0;
            txtUser.TabStop = false;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(145, 220);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.PlaceholderText = "Contraseña";
            txtContra.Size = new Size(151, 23);
            txtContra.TabIndex = 1;
            txtContra.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(205, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 37);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(64, 64, 64);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(155, 277);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(124, 31);
            btnIngresar.TabIndex = 3;
            btnIngresar.TabStop = false;
            btnIngresar.Text = "Ingresar al sistema";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRellenarVendedor
            // 
            btnRellenarVendedor.Location = new Point(64, 324);
            btnRellenarVendedor.Name = "btnRellenarVendedor";
            btnRellenarVendedor.Size = new Size(93, 23);
            btnRellenarVendedor.TabIndex = 4;
            btnRellenarVendedor.Text = "Vendedor";
            btnRellenarVendedor.UseVisualStyleBackColor = true;
            btnRellenarVendedor.Click += btnRellenarVendedor_Click;
            // 
            // btnRellenarSupervisor
            // 
            btnRellenarSupervisor.Location = new Point(173, 324);
            btnRellenarSupervisor.Name = "btnRellenarSupervisor";
            btnRellenarSupervisor.Size = new Size(93, 23);
            btnRellenarSupervisor.TabIndex = 5;
            btnRellenarSupervisor.Text = "Supervisor";
            btnRellenarSupervisor.UseVisualStyleBackColor = true;
            btnRellenarSupervisor.Click += btnRellenarSupervisor_Click;
            // 
            // btnRellenarAdmin
            // 
            btnRellenarAdmin.Location = new Point(282, 324);
            btnRellenarAdmin.Name = "btnRellenarAdmin";
            btnRellenarAdmin.Size = new Size(93, 23);
            btnRellenarAdmin.TabIndex = 6;
            btnRellenarAdmin.Text = "Administrador";
            btnRellenarAdmin.UseVisualStyleBackColor = true;
            btnRellenarAdmin.Click += btnRellenarAdmin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(466, 375);
            Controls.Add(btnRellenarAdmin);
            Controls.Add(btnRellenarSupervisor);
            Controls.Add(btnRellenarVendedor);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(txtContra);
            Controls.Add(txtUser);
            Name = "Login";
            Text = "Form1";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtContra;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Button btnRellenarVendedor;
        private Button btnRellenarSupervisor;
        private Button btnRellenarAdmin;
    }
}