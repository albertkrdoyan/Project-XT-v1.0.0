namespace Project_XT_v1_0_0.Forms
{
    partial class EditOrganization
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
            decline_button = new Button();
            accept_button = new Button();
            bankAcc_label = new Label();
            bankAccNumber_label = new Label();
            tin_label = new Label();
            dist_name_label = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // decline_button
            // 
            decline_button.Location = new Point(654, 141);
            decline_button.Name = "decline_button";
            decline_button.Size = new Size(134, 29);
            decline_button.TabIndex = 20;
            decline_button.Text = "Հրաժարվել";
            decline_button.UseVisualStyleBackColor = true;
            decline_button.Click += Decline_button_Click;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(168, 141);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(182, 29);
            accept_button.TabIndex = 19;
            accept_button.Text = "Հաստատել";
            accept_button.UseVisualStyleBackColor = true;
            accept_button.Click += Accept_button_Click;
            // 
            // bankAcc_label
            // 
            bankAcc_label.AutoSize = true;
            bankAcc_label.Location = new Point(12, 108);
            bankAcc_label.Name = "bankAcc_label";
            bankAcc_label.Size = new Size(137, 20);
            bankAcc_label.TabIndex = 18;
            bankAcc_label.Text = "Բանկի անվանում";
            // 
            // bankAccNumber_label
            // 
            bankAccNumber_label.AutoSize = true;
            bankAccNumber_label.Location = new Point(12, 75);
            bankAccNumber_label.Name = "bankAccNumber_label";
            bankAccNumber_label.Size = new Size(107, 20);
            bankAccNumber_label.TabIndex = 17;
            bankAccNumber_label.Text = "Հաշվեհամար";
            // 
            // tin_label
            // 
            tin_label.AutoSize = true;
            tin_label.Location = new Point(12, 42);
            tin_label.Name = "tin_label";
            tin_label.Size = new Size(46, 20);
            tin_label.TabIndex = 16;
            tin_label.Text = "ՀՎՀՀ";
            // 
            // dist_name_label
            // 
            dist_name_label.AutoSize = true;
            dist_name_label.Location = new Point(12, 9);
            dist_name_label.Name = "dist_name_label";
            dist_name_label.Size = new Size(84, 20);
            dist_name_label.TabIndex = 11;
            dist_name_label.Text = "Անվանում";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 108);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(620, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(620, 27);
            textBox4.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 42);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(620, 27);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 27);
            textBox1.TabIndex = 12;
            // 
            // EditOrganization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 187);
            Controls.Add(decline_button);
            Controls.Add(accept_button);
            Controls.Add(bankAcc_label);
            Controls.Add(bankAccNumber_label);
            Controls.Add(tin_label);
            Controls.Add(dist_name_label);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EditOrganization";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditOrganizations";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button decline_button;
        private Button accept_button;
        private Label bankAcc_label;
        private Label bankAccNumber_label;
        private Label tin_label;
        private Label dist_name_label;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}