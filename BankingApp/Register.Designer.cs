namespace BankingApp
{
    partial class Register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            txtnic = new TextBox();
            button1 = new Button();
            dtpdob = new DateTimePicker();
            label6 = new Label();
            cmbacctype = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Register Yourself!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 144);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "DOB";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 184);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 4;
            label5.Text = "NIC";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(138, 72);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(264, 27);
            txtuser.TabIndex = 5;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(138, 109);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(264, 27);
            txtpass.TabIndex = 6;
            // 
            // txtnic
            // 
            txtnic.Location = new Point(138, 184);
            txtnic.Name = "txtnic";
            txtnic.Size = new Size(264, 27);
            txtnic.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(308, 270);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtpdob
            // 
            dtpdob.Location = new Point(138, 144);
            dtpdob.Name = "dtpdob";
            dtpdob.Size = new Size(264, 27);
            dtpdob.TabIndex = 10;
            dtpdob.Value = new DateTime(2023, 5, 21, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 230);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 11;
            label6.Text = "Account Type";
            // 
            // cmbacctype
            // 
            cmbacctype.FormattingEnabled = true;
            cmbacctype.Items.AddRange(new object[] { "Savings", "Current" });
            cmbacctype.Location = new Point(138, 227);
            cmbacctype.Name = "cmbacctype";
            cmbacctype.Size = new Size(264, 28);
            cmbacctype.TabIndex = 12;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 450);
            Controls.Add(cmbacctype);
            Controls.Add(label6);
            Controls.Add(dtpdob);
            Controls.Add(button1);
            Controls.Add(txtnic);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtuser;
        private TextBox txtpass;
        private TextBox txtnic;
        private Button button1;
        private DateTimePicker dtpdob;
        private Label label6;
        private ComboBox cmbacctype;
    }
}