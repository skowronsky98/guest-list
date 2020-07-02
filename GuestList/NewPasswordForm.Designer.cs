namespace GuestList
{
    partial class NewPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPasswordForm));
            this.GuestLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.btnDeny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuestLabel
            // 
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GuestLabel.Location = new System.Drawing.Point(12, 9);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.Size = new System.Drawing.Size(123, 25);
            this.GuestLabel.TabIndex = 81;
            this.GuestLabel.Text = "Nowe Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Podaj stare hasło:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(12, 67);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(205, 20);
            this.txtOldPassword.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(12, 106);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(205, 20);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtNewPassword2
            // 
            this.txtNewPassword2.Location = new System.Drawing.Point(12, 145);
            this.txtNewPassword2.Name = "txtNewPassword2";
            this.txtNewPassword2.PasswordChar = '*';
            this.txtNewPassword2.Size = new System.Drawing.Size(205, 20);
            this.txtNewPassword2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Podaj nowe hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Powtórz nowe hasło:";
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetPassword.Location = new System.Drawing.Point(142, 175);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSetPassword.TabIndex = 3;
            this.btnSetPassword.Text = "Zapisz";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(12, 175);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(75, 23);
            this.btnDeny.TabIndex = 4;
            this.btnDeny.Text = "Anuluj";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // NewPasswordForm
            // 
            this.AcceptButton = this.btnSetPassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 210);
            this.Controls.Add(this.btnDeny);
            this.Controls.Add(this.btnSetPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuestLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(249, 249);
            this.MinimumSize = new System.Drawing.Size(249, 249);
            this.Name = "NewPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GuestLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSetPassword;
        private System.Windows.Forms.Button btnDeny;
    }
}