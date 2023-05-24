namespace BankingApp
{
    partial class Savings
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
            textBox2 = new TextBox();
            label2 = new Label();
            lblaccno = new Label();
            label1 = new Label();
            lblbalance = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(174, 27);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 34);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Account No: ";
            // 
            // lblaccno
            // 
            lblaccno.AutoSize = true;
            lblaccno.Location = new Point(160, 34);
            lblaccno.Name = "lblaccno";
            lblaccno.Size = new Size(90, 20);
            lblaccno.TabIndex = 4;
            lblaccno.Text = "Account No.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 66);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Balance:";
            // 
            // lblbalance
            // 
            lblbalance.AutoSize = true;
            lblbalance.Location = new Point(160, 66);
            lblbalance.Name = "lblbalance";
            lblbalance.Size = new Size(61, 20);
            lblbalance.TabIndex = 6;
            lblbalance.Text = "Balance";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(290, 129);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Deposit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(290, 176);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "Withdraw";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(224, 299);
            button3.Name = "button3";
            button3.Size = new Size(160, 29);
            button3.TabIndex = 10;
            button3.Text = "Back to dashboard";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Savings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(lblbalance);
            Controls.Add(label1);
            Controls.Add(lblaccno);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Name = "Savings";
            Text = "Savings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label2;
        private Label lblaccno;
        private Label label1;
        private Label lblbalance;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}