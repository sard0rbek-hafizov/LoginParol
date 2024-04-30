namespace LoginParol.SuperAdminFolder
{
    partial class SuperAdminForma
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
            FaylYaratildi = new Label();
            SuperAdminFaylgaKirish = new Button();
            SuspendLayout();
            // 
            // FaylYaratildi
            // 
            FaylYaratildi.AutoSize = true;
            FaylYaratildi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FaylYaratildi.Location = new Point(247, 93);
            FaylYaratildi.Name = "FaylYaratildi";
            FaylYaratildi.Size = new Size(333, 31);
            FaylYaratildi.TabIndex = 0;
            FaylYaratildi.Text = "Muvaffaqqiyatli fayl yaratildi.";
            // 
            // SuperAdminFaylgaKirish
            // 
            SuperAdminFaylgaKirish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SuperAdminFaylgaKirish.Location = new Point(247, 157);
            SuperAdminFaylgaKirish.Name = "SuperAdminFaylgaKirish";
            SuperAdminFaylgaKirish.Size = new Size(333, 48);
            SuperAdminFaylgaKirish.TabIndex = 1;
            SuperAdminFaylgaKirish.Text = "Faylga kirish";
            SuperAdminFaylgaKirish.UseVisualStyleBackColor = true;
            SuperAdminFaylgaKirish.Click += SuperAdminFaylgaKirish_Click;
            // 
            // SuperAdminForma
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SuperAdminFaylgaKirish);
            Controls.Add(FaylYaratildi);
            Name = "SuperAdminForma";
            Text = "SuperAdminForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FaylYaratildi;
        private Button SuperAdminFaylgaKirish;
    }
}