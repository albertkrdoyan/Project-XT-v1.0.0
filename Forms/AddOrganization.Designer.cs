namespace Project_XT_v1_0_0.Forms
{
    partial class AddOrganization
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dist_name_label = new Label();
            tin_label = new Label();
            bankAccNumber_label = new Label();
            bankAcc_label = new Label();
            accept_button = new Button();
            decline_button = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(620, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(620, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(168, 118);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(620, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 151);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(620, 27);
            textBox5.TabIndex = 4;
            // 
            // dist_name_label
            // 
            dist_name_label.AutoSize = true;
            dist_name_label.Location = new Point(12, 52);
            dist_name_label.Name = "dist_name_label";
            dist_name_label.Size = new Size(84, 20);
            dist_name_label.TabIndex = 0;
            dist_name_label.Text = "Անվանում";
            // 
            // tin_label
            // 
            tin_label.AutoSize = true;
            tin_label.Location = new Point(12, 85);
            tin_label.Name = "tin_label";
            tin_label.Size = new Size(46, 20);
            tin_label.TabIndex = 5;
            tin_label.Text = "ՀՎՀՀ";
            // 
            // bankAccNumber_label
            // 
            bankAccNumber_label.AutoSize = true;
            bankAccNumber_label.Location = new Point(12, 118);
            bankAccNumber_label.Name = "bankAccNumber_label";
            bankAccNumber_label.Size = new Size(107, 20);
            bankAccNumber_label.TabIndex = 7;
            bankAccNumber_label.Text = "Հաշվեհամար";
            // 
            // bankAcc_label
            // 
            bankAcc_label.AutoSize = true;
            bankAcc_label.Location = new Point(12, 151);
            bankAcc_label.Name = "bankAcc_label";
            bankAcc_label.Size = new Size(137, 20);
            bankAcc_label.TabIndex = 8;
            bankAcc_label.Text = "Բանկի անվանում";
            // 
            // accept_button
            // 
            accept_button.Location = new Point(168, 184);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(182, 29);
            accept_button.TabIndex = 9;
            accept_button.Text = "Հաստատել";
            accept_button.UseVisualStyleBackColor = true;
            accept_button.Click += Accept_button_Click;
            // 
            // decline_button
            // 
            decline_button.Location = new Point(654, 184);
            decline_button.Name = "decline_button";
            decline_button.Size = new Size(134, 29);
            decline_button.TabIndex = 10;
            decline_button.Text = "Հրաժարվել";
            decline_button.UseVisualStyleBackColor = true;
            decline_button.Click += Decline_Click;
            // 
            // AddOrganization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 246);
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
            Name = "AddOrganization";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddOrganization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label dist_name_label;
        private Label tin_label;
        private Label bankAccNumber_label;
        private Label bankAcc_label;
        private Button accept_button;
        private Button decline_button;
    }
}