namespace Vista
{
    partial class CerrarSesion
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
            label1 = new Label();
            btnSi = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 0;
            label1.Text = "Seguro desea cerrar sesion?";
            // 
            // btnSi
            // 
            btnSi.BackColor = SystemColors.ActiveCaption;
            btnSi.FlatAppearance.BorderSize = 0;
            btnSi.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            btnSi.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Location = new Point(90, 79);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(63, 23);
            btnSi.TabIndex = 1;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = SystemColors.ActiveCaption;
            btnNo.FlatAppearance.BorderSize = 0;
            btnNo.FlatAppearance.MouseDownBackColor = SystemColors.ButtonFace;
            btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Location = new Point(182, 79);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(63, 23);
            btnNo.TabIndex = 2;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // CerrarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 131);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(label1);
            Name = "CerrarSesion";
            Text = "CerrarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSi;
        private Button btnNo;
    }
}