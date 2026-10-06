namespace SAV_E_commerce
{
    partial class InscriptionForm
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
            phone_textBox = new TextBox();
            username_textBox = new TextBox();
            lbl_number_phone = new Label();
            lbl_username = new Label();
            confirm_password_textBox = new TextBox();
            password_textBox = new TextBox();
            lbl_confirm_password = new Label();
            lbl_password = new Label();
            Confirm_inscription_button = new Button();
            email_textBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new Point(238, 183);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new Size(150, 31);
            phone_textBox.TabIndex = 10;
            // 
            // username_textBox
            // 
            username_textBox.Location = new Point(238, 49);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(150, 31);
            username_textBox.TabIndex = 9;
            // 
            // lbl_number_phone
            // 
            lbl_number_phone.AutoSize = true;
            lbl_number_phone.Location = new Point(238, 155);
            lbl_number_phone.Name = "lbl_number_phone";
            lbl_number_phone.Size = new Size(186, 25);
            lbl_number_phone.TabIndex = 8;
            lbl_number_phone.Text = "Numéro de téléphone";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(238, 7);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(144, 25);
            lbl_username.TabIndex = 7;
            lbl_username.Text = "Nom d'utlisateur";
            // 
            // confirm_password_textBox
            // 
            confirm_password_textBox.Location = new Point(238, 333);
            confirm_password_textBox.Name = "confirm_password_textBox";
            confirm_password_textBox.Size = new Size(150, 31);
            confirm_password_textBox.TabIndex = 14;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(238, 259);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(150, 31);
            password_textBox.TabIndex = 13;
            // 
            // lbl_confirm_password
            // 
            lbl_confirm_password.AutoSize = true;
            lbl_confirm_password.Location = new Point(238, 305);
            lbl_confirm_password.Name = "lbl_confirm_password";
            lbl_confirm_password.Size = new Size(222, 25);
            lbl_confirm_password.TabIndex = 12;
            lbl_confirm_password.Text = "Confirmer le mot de passe";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(238, 217);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(120, 25);
            lbl_password.TabIndex = 11;
            lbl_password.Text = "Mot de passe";
            // 
            // Confirm_inscription_button
            // 
            Confirm_inscription_button.Location = new Point(238, 382);
            Confirm_inscription_button.Name = "Confirm_inscription_button";
            Confirm_inscription_button.Size = new Size(112, 34);
            Confirm_inscription_button.TabIndex = 15;
            Confirm_inscription_button.Text = "Confirmer l'inscription";
            Confirm_inscription_button.UseVisualStyleBackColor = true;
            Confirm_inscription_button.Click += Confirm_inscription_button_Click;
            // 
            // email_textBox
            // 
            email_textBox.Location = new Point(238, 111);
            email_textBox.Name = "email_textBox";
            email_textBox.Size = new Size(150, 31);
            email_textBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 83);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 16;
            label1.Text = "Email";
            // 
            // InscriptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(email_textBox);
            Controls.Add(label1);
            Controls.Add(Confirm_inscription_button);
            Controls.Add(confirm_password_textBox);
            Controls.Add(password_textBox);
            Controls.Add(lbl_confirm_password);
            Controls.Add(lbl_password);
            Controls.Add(phone_textBox);
            Controls.Add(username_textBox);
            Controls.Add(lbl_number_phone);
            Controls.Add(lbl_username);
            Name = "InscriptionForm";
            Text = "Inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phone_textBox;
        private TextBox username_textBox;
        private Label lbl_number_phone;
        private Label lbl_username;
        private TextBox confirm_password_textBox;
        private TextBox password_textBox;
        private Label lbl_confirm_password;
        private Label lbl_password;
        private Button Confirm_inscription_button;
        private TextBox email_textBox;
        private Label label1;
    }
}