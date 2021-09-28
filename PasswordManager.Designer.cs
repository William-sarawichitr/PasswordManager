
namespace Password_Manager
{
    partial class PasswordManager
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
            this.listCredentials = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listCredentials
            // 
            this.listCredentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listCredentials.FullRowSelect = true;
            this.listCredentials.HideSelection = false;
            this.listCredentials.Location = new System.Drawing.Point(12, 12);
            this.listCredentials.MultiSelect = false;
            this.listCredentials.Name = "listCredentials";
            this.listCredentials.Size = new System.Drawing.Size(356, 250);
            this.listCredentials.TabIndex = 0;
            this.listCredentials.UseCompatibleStateImageBehavior = false;
            this.listCredentials.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service/Website";
            this.columnHeader1.Width = 141;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Username";
            this.columnHeader2.Width = 197;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 555);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(190, 30);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add New Credentials";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Location = new System.Drawing.Point(12, 268);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(190, 28);
            this.buttonShowPassword.TabIndex = 1;
            this.buttonShowPassword.Text = "Show Password";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(12, 437);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(12, 482);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(190, 22);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxService
            // 
            this.textBoxService.Location = new System.Drawing.Point(12, 388);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.Size = new System.Drawing.Size(190, 22);
            this.textBoxService.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service/Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Re-type Password:";
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(12, 527);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.PasswordChar = '●';
            this.textBoxPassword2.Size = new System.Drawing.Size(190, 22);
            this.textBoxPassword2.TabIndex = 9;
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 648);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxService);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listCredentials);
            this.Name = "PasswordManager";
            this.Text = "Password Manager";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCredentials;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPassword2;
    }
}