namespace LoginParol.MijozFolder
{
    partial class MijozForma
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
            lbMijozFaylYaratish = new Label();
            btMijozKirish = new Button();
            SuspendLayout();
            // 
            // lbMijozFaylYaratish
            // 
            lbMijozFaylYaratish.AutoSize = true;
            lbMijozFaylYaratish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbMijozFaylYaratish.Location = new Point(221, 81);
            lbMijozFaylYaratish.Name = "lbMijozFaylYaratish";
            lbMijozFaylYaratish.Size = new Size(327, 31);
            lbMijozFaylYaratish.TabIndex = 0;
            lbMijozFaylYaratish.Text = "Muvaffaqqiyatli fayl yaratildi";
            // 
            // btMijozKirish
            // 
            btMijozKirish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btMijozKirish.Location = new Point(221, 151);
            btMijozKirish.Name = "btMijozKirish";
            btMijozKirish.Size = new Size(327, 48);
            btMijozKirish.TabIndex = 1;
            btMijozKirish.Text = "Faylga kirish";
            btMijozKirish.UseVisualStyleBackColor = true;
            btMijozKirish.Click += btMijozKirish_Click;
            // 
            // MijozForma
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btMijozKirish);
            Controls.Add(lbMijozFaylYaratish);
            Name = "MijozForma";
            Text = "MijozForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMijozFaylYaratish;
        private Button btMijozKirish;
    }
}