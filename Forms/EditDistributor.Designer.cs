namespace Project_XT_v1_0_0.Forms
{
    partial class EditDistributor
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
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // decline_button
            // 
            decline_button.Location = new Point(652, 109);
            decline_button.Name = "decline_button";
            decline_button.Size = new Size(134, 29);
            decline_button.TabIndex = 20;
            decline_button.Text = "Հրաժարվել";
            decline_button.UseVisualStyleBackColor = true;
            decline_button.Click += Decline_button_Click;
            // 
            // accept_button
            // 
            accept_button.Location = new Point(176, 109);
            accept_button.Name = "accept_button";
            accept_button.Size = new Size(182, 29);
            accept_button.TabIndex = 19;
            accept_button.Text = "Հաստատել";
            accept_button.UseVisualStyleBackColor = true;
            accept_button.Click += Accept_button_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(612, 28);
            comboBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(612, 27);
            textBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 27);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 15;
            label3.Text = "Հեռախոսի համար";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 14;
            label2.Text = "Կազմակերպություն";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 13;
            label1.Text = "Անվանում";
            // 
            // EditDistributor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 155);
            Controls.Add(decline_button);
            Controls.Add(accept_button);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditDistributor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditDistributor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button decline_button;
        private Button accept_button;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}