namespace LoginParol
{
    partial class Form1
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
            lbLoginn = new Label();
            lbParoll = new Label();
            linkRoyxatdanOtish = new LinkLabel();
            tbLoginn = new TextBox();
            tbParoll = new TextBox();
            btKirish = new Button();
            SuspendLayout();
            // 
            // lbLoginn
            // 
            lbLoginn.AutoSize = true;
            lbLoginn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbLoginn.Location = new Point(92, 44);
            lbLoginn.Name = "lbLoginn";
            lbLoginn.Size = new Size(182, 31);
            lbLoginn.TabIndex = 0;
            lbLoginn.Text = "Loginni kiriting";
            lbLoginn.Click += label1_Click_1;
            // 
            // lbParoll
            // 
            lbParoll.AutoSize = true;
            lbParoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbParoll.Location = new Point(92, 107);
            lbParoll.Name = "lbParoll";
            lbParoll.Size = new Size(176, 31);
            lbParoll.TabIndex = 1;
            lbParoll.Text = "Parolni kiriting";
            // 
            // linkRoyxatdanOtish
            // 
            linkRoyxatdanOtish.AutoSize = true;
            linkRoyxatdanOtish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            linkRoyxatdanOtish.Location = new Point(261, 259);
            linkRoyxatdanOtish.Name = "linkRoyxatdanOtish";
            linkRoyxatdanOtish.Size = new Size(198, 31);
            linkRoyxatdanOtish.TabIndex = 2;
            linkRoyxatdanOtish.TabStop = true;
            linkRoyxatdanOtish.Text = "Ro'yxatdan o'tish";
            linkRoyxatdanOtish.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbLoginn
            // 
            tbLoginn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbLoginn.Location = new Point(323, 44);
            tbLoginn.Name = "tbLoginn";
            tbLoginn.PlaceholderText = "azizov_aziz";
            tbLoginn.Size = new Size(344, 38);
            tbLoginn.TabIndex = 3;
            // 
            // tbParoll
            // 
            tbParoll.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbParoll.Location = new Point(323, 113);
            tbParoll.Name = "tbParoll";
            tbParoll.PasswordChar = '*';
            tbParoll.PlaceholderText = "****";
            tbParoll.Size = new Size(344, 38);
            tbParoll.TabIndex = 4;
            // 
            // btKirish
            // 
            btKirish.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btKirish.Location = new Point(92, 184);
            btKirish.Name = "btKirish";
            btKirish.Size = new Size(575, 45);
            btKirish.TabIndex = 5;
            btKirish.Text = "Kirish";
            btKirish.UseVisualStyleBackColor = true;
            btKirish.Click += btKirish_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btKirish);
            Controls.Add(tbParoll);
            Controls.Add(tbLoginn);
            Controls.Add(linkRoyxatdanOtish);
            Controls.Add(lbParoll);
            Controls.Add(lbLoginn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLoginn;
        private Label lbParoll;
        private LinkLabel linkRoyxatdanOtish;
        private TextBox tbLoginn;
        private TextBox tbParoll;
        private Button btKirish;
    }
}
