namespace SAV_E_commerce
{
    partial class AccueilForm
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
            Message = new Button();
            Historic = new Button();
            Quit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 76);
            label1.Name = "label1";
            label1.Size = new Size(279, 25);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue au SAV de Liquor Store";
            // 
            // Message
            // 
            Message.Location = new Point(55, 213);
            Message.Name = "Message";
            Message.Size = new Size(172, 62);
            Message.TabIndex = 1;
            Message.Text = "Signaler un produit";
            Message.UseVisualStyleBackColor = true;
            Message.Click += Message_Click;
            // 
            // Historic
            // 
            Historic.Location = new Point(301, 217);
            Historic.Name = "Historic";
            Historic.Size = new Size(143, 58);
            Historic.TabIndex = 2;
            Historic.Text = "Historique";
            Historic.UseVisualStyleBackColor = true;
            Historic.Click += Historic_Click;
            // 
            // Quit
            // 
            Quit.Location = new Point(526, 213);
            Quit.Name = "Quit";
            Quit.Size = new Size(158, 62);
            Quit.TabIndex = 3;
            Quit.Text = "Quitter";
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += Quit_Click;
            // 
            // AccueilForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Quit);
            Controls.Add(Historic);
            Controls.Add(Message);
            Controls.Add(label1);
            Name = "AccueilForm";
            Text = "AccueilForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Message;
        private Button Historic;
        private Button Quit;
    }
}