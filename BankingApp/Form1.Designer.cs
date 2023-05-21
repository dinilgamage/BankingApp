namespace BankingApp
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label3 = new Label();
            btnlogin = new Button();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label4 = new Label();
            btnregister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 123);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 72);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(233, 214);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 29);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(202, 65);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(125, 27);
            txtuser.TabIndex = 4;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(202, 132);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(125, 27);
            txtpass.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 280);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 6;
            label4.Text = "Dont have an account?";
            // 
            // btnregister
            // 
            btnregister.Location = new Point(233, 271);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(94, 29);
            btnregister.TabIndex = 7;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(btnregister);
            Controls.Add(label4);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(btnlogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label3;
        private Button btnlogin;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label4;
        private Button btnregister;
    }
}