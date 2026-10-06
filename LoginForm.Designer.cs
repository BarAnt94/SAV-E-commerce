namespace SAV_E_commerce
{
    partial class LoginForm
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
            lbl_username = new Label();
            lbl_password = new Label();
            lbl_no_account = new Label();
            Inscription_button = new Button();
            Connect_button = new Button();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(264, 80);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(86, 25);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "Utlisateur";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(264, 201);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(120, 25);
            lbl_password.TabIndex = 1;
            lbl_password.Text = "Mot de passe";
            // 
            // lbl_no_account
            // 
            lbl_no_account.AutoSize = true;
            lbl_no_account.Location = new Point(588, 280);
            lbl_no_account.Name = "lbl_no_account";
            lbl_no_account.Size = new Size(142, 25);
            lbl_no_account.TabIndex = 2;
            lbl_no_account.Text = "Pas de compte ?";
            // 
            // Inscription_button
            // 
            Inscription_button.Location = new Point(605, 318);
            Inscription_button.Name = "Inscription_button";
            Inscription_button.Size = new Size(112, 34);
            Inscription_button.TabIndex = 3;
            Inscription_button.Text = "S'inscrir";
            Inscription_button.UseVisualStyleBackColor = true;
            Inscription_button.Click += Inscription_button_Click;
            // 
            // Connect_button
            // 
            Connect_button.Location = new Point(255, 318);
            Connect_button.Name = "Connect_button";
            Connect_button.Size = new Size(216, 50);
            Connect_button.TabIndex = 4;
            Connect_button.Text = "Se connecter";
            Connect_button.UseVisualStyleBackColor = true;
            Connect_button.Click += Connect_button_Click;
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(264, 122);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(150, 31);
            username_textBox.TabIndex = 5;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(264, 229);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(150, 31);
            password_textBox.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password_textBox);
            Controls.Add(username_textBox);
            Controls.Add(Connect_button);
            Controls.Add(Inscription_button);
            Controls.Add(lbl_no_account);
            Controls.Add(lbl_password);
            Controls.Add(lbl_username);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_no_account;
        private Button Inscription_button;
        private Button Connect_button;
        private TextBox username_textBox;
        private TextBox password_textBox;
    }
}
