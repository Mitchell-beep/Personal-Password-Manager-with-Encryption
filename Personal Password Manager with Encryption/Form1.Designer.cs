namespace Personal_Password_Manager_with_Encryption
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
            btnAddSite = new Button();
            lblSite = new Label();
            txtSite = new TextBox();
            txtUsername = new TextBox();
            lblUsername = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnAddSite
            // 
            btnAddSite.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddSite.Location = new Point(12, 207);
            btnAddSite.Name = "btnAddSite";
            btnAddSite.Size = new Size(100, 30);
            btnAddSite.TabIndex = 0;
            btnAddSite.Text = "Add Site";
            btnAddSite.UseVisualStyleBackColor = true;
            btnAddSite.Click += btnAdd_Click;
            // 
            // lblSite
            // 
            lblSite.AutoSize = true;
            lblSite.Location = new Point(12, 9);
            lblSite.Name = "lblSite";
            lblSite.Size = new Size(26, 15);
            lblSite.TabIndex = 1;
            lblSite.Text = "Site";
            // 
            // txtSite
            // 
            txtSite.Location = new Point(12, 27);
            txtSite.Name = "txtSite";
            txtSite.Size = new Size(300, 23);
            txtSite.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 23);
            txtUsername.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(12, 68);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(30, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "User";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(300, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 136);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(940, 486);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(txtSite);
            Controls.Add(lblSite);
            Controls.Add(btnAddSite);
            Name = "Form1";
            Text = "My App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddSite;
        private Label lblSite;
        private TextBox txtSite;
        private TextBox txtUsername;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}
