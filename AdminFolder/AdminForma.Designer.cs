namespace LoginParol.AdminFolder
{
    partial class AdminForma
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
            lbAdminFaylYaratildi = new Label();
            btAdminFaylgaKirish = new Button();
            SuspendLayout();
            // 
            // lbAdminFaylYaratildi
            // 
            lbAdminFaylYaratildi.AutoSize = true;
            lbAdminFaylYaratildi.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbAdminFaylYaratildi.Location = new Point(292, 112);
            lbAdminFaylYaratildi.Margin = new Padding(5, 0, 5, 0);
            lbAdminFaylYaratildi.Name = "lbAdminFaylYaratildi";
            lbAdminFaylYaratildi.Size = new Size(327, 31);
            lbAdminFaylYaratildi.TabIndex = 0;
            lbAdminFaylYaratildi.Text = "Muvaffaqqiyatli fayl yaratildi";
            // 
            // btAdminFaylgaKirish
            // 
            btAdminFaylgaKirish.Location = new Point(292, 188);
            btAdminFaylgaKirish.Margin = new Padding(5, 5, 5, 5);
            btAdminFaylgaKirish.Name = "btAdminFaylgaKirish";
            btAdminFaylgaKirish.Size = new Size(327, 54);
            btAdminFaylgaKirish.TabIndex = 1;
            btAdminFaylgaKirish.Text = "Faylga kirish";
            btAdminFaylgaKirish.UseVisualStyleBackColor = true;
            btAdminFaylgaKirish.Click += btAdminFaylgaKirish_Click;
            // 
            // AdminForma
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 698);
            Controls.Add(btAdminFaylgaKirish);
            Controls.Add(lbAdminFaylYaratildi);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AdminForma";
            Text = "AdminForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAdminFaylYaratildi;
        private Button btAdminFaylgaKirish;
    }
}