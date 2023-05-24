namespace BankingApp
{
    partial class UserDash
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
            btncurrent = new Button();
            btnsavings = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnopen = new Button();
            label4 = new Label();
            lbluser = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            txtaccnos = new TextBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btncurrent
            // 
            btncurrent.Location = new Point(342, 122);
            btncurrent.Name = "btncurrent";
            btncurrent.Size = new Size(94, 29);
            btncurrent.TabIndex = 0;
            btncurrent.Text = "Current";
            btncurrent.UseVisualStyleBackColor = true;
            btncurrent.Click += btncurrent_Click;
            // 
            // btnsavings
            // 
            btnsavings.Location = new Point(342, 168);
            btnsavings.Name = "btnsavings";
            btnsavings.Size = new Size(94, 29);
            btnsavings.TabIndex = 1;
            btnsavings.Text = "Savings";
            btnsavings.UseVisualStyleBackColor = true;
            btnsavings.Click += btnsavings_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 72);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Account Type to Continue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 250);
            label2.Name = "label2";
            label2.Size = new Size(260, 20);
            label2.TabIndex = 3;
            label2.Text = "Open a new account under your name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 207);
            label3.Name = "label3";
            label3.Size = new Size(23, 20);
            label3.TabIndex = 4;
            label3.Text = "or";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Savings", "Current" });
            comboBox1.Location = new Point(156, 300);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 28);
            comboBox1.TabIndex = 5;
            // 
            // btnopen
            // 
            btnopen.Location = new Point(352, 300);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(64, 29);
            btnopen.TabIndex = 6;
            btnopen.Text = "Open";
            btnopen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 21);
            label4.Name = "label4";
            label4.Size = new Size(78, 31);
            label4.TabIndex = 7;
            label4.Text = "Hello, ";
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbluser.Location = new Point(102, 22);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(75, 31);
            lbluser.TabIndex = 8;
            lbluser.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 126);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 9;
            label5.Text = "Account No.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 177);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 10;
            label6.Text = "Account No.";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // txtaccnos
            // 
            txtaccnos.Location = new Point(213, 170);
            txtaccnos.Name = "txtaccnos";
            txtaccnos.Size = new Size(125, 27);
            txtaccnos.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(267, 69);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 28);
            comboBox2.TabIndex = 13;
            comboBox2.Text = "List of accounts under your name";
            // 
            // button1
            // 
            button1.Location = new Point(272, 364);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 14;
            button1.Text = "Back to login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UserDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 450);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(txtaccnos);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbluser);
            Controls.Add(label4);
            Controls.Add(btnopen);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsavings);
            Controls.Add(btncurrent);
            Name = "UserDash";
            Text = "UserDash";
            Load += UserDash_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncurrent;
        private Button btnsavings;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnopen;
        private Label label4;
        private Label lbluser;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox txtaccnos;
        private ComboBox comboBox2;
        private Button button1;
    }
}