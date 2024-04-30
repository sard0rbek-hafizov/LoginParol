namespace LoginParol
{
    partial class RoyxatdanOtish
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
            lbFIO = new Label();
            lbLogin = new Label();
            lbParol = new Label();
            tbFIO = new TextBox();
            tbLogin = new TextBox();
            tbParol = new TextBox();
            btRoyxatdanOtish = new Button();
            SuspendLayout();
            // 
            // lbFIO
            // 
            lbFIO.AutoSize = true;
            lbFIO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbFIO.Location = new Point(68, 54);
            lbFIO.Name = "lbFIO";
            lbFIO.Size = new Size(308, 31);
            lbFIO.TabIndex = 0;
            lbFIO.Text = "Familiya Ism Otasining Ismi";
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbLogin.Location = new Point(68, 106);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(182, 31);
            lbLogin.TabIndex = 1;
            lbLogin.Text = "Loginni kiriting";
            // 
            // lbParol
            // 
            lbParol.AutoSize = true;
            lbParol.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbParol.Location = new Point(68, 162);
            lbParol.Name = "lbParol";
            lbParol.Size = new Size(176, 31);
            lbParol.TabIndex = 2;
            lbParol.Text = "Parolni kiriting";
            // 
            // tbFIO
            // 
            tbFIO.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbFIO.Location = new Point(399, 47);
            tbFIO.Name = "tbFIO";
            tbFIO.PlaceholderText = "Azizov Aziz Aziz o'g'li";
            tbFIO.Size = new Size(389, 38);
            tbFIO.TabIndex = 3;
            tbFIO.TextChanged += tbFIO_TextChanged;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbLogin.Location = new Point(399, 106);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "azizov_aziz";
            tbLogin.Size = new Size(389, 38);
            tbLogin.TabIndex = 4;
            // 
            // tbParol
            // 
            tbParol.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbParol.Location = new Point(399, 162);
            tbParol.Name = "tbParol";
            tbParol.PasswordChar = '*';
            tbParol.PlaceholderText = "****";
            tbParol.Size = new Size(389, 38);
            tbParol.TabIndex = 5;
            // 
            // btRoyxatdanOtish
            // 
            btRoyxatdanOtish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btRoyxatdanOtish.Location = new Point(68, 218);
            btRoyxatdanOtish.Name = "btRoyxatdanOtish";
            btRoyxatdanOtish.Size = new Size(720, 42);
            btRoyxatdanOtish.TabIndex = 6;
            btRoyxatdanOtish.Text = "Ro'yxatdan o'tish";
            btRoyxatdanOtish.UseVisualStyleBackColor = true;
            btRoyxatdanOtish.Click += button1_Click;
            // 
            // RoyxatdanOtish
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btRoyxatdanOtish);
            Controls.Add(tbParol);
            Controls.Add(tbLogin);
            Controls.Add(tbFIO);
            Controls.Add(lbParol);
            Controls.Add(lbLogin);
            Controls.Add(lbFIO);
            Name = "RoyxatdanOtish";
            Text = "RoyxatdanOtish";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFIO;
        private Label lbLogin;
        private Label lbParol;
        private TextBox tbFIO;
        private TextBox tbLogin;
        private TextBox tbParol;
        private Button btRoyxatdanOtish;
    }
}