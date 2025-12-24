namespace Project_XT_v1_0_0
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
            show_orgs = new Button();
            show_dists = new Button();
            dataGridView1 = new DataGridView();
            add_button = new Button();
            edit_button = new Button();
            show_goods_button = new Button();
            remove_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // show_orgs
            // 
            show_orgs.Location = new Point(12, 12);
            show_orgs.Name = "show_orgs";
            show_orgs.Size = new Size(196, 76);
            show_orgs.TabIndex = 0;
            show_orgs.Text = "Ցուցադրել կազմակերպութունները";
            show_orgs.UseVisualStyleBackColor = true;
            show_orgs.Click += Show_orgs_Click;
            // 
            // show_dists
            // 
            show_dists.Location = new Point(214, 12);
            show_dists.Name = "show_dists";
            show_dists.Size = new Size(196, 76);
            show_dists.TabIndex = 1;
            show_dists.Text = "Ցուցադրել դիստրիբյուտորներին";
            show_dists.UseVisualStyleBackColor = true;
            show_dists.Click += Show_dists_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(124, 107);
            dataGridView1.TabIndex = 2;
            // 
            // add_button
            // 
            add_button.Location = new Point(561, 12);
            add_button.Name = "add_button";
            add_button.Size = new Size(107, 76);
            add_button.TabIndex = 4;
            add_button.Text = "Ավելացնել";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += Add_button_Click;
            // 
            // edit_button
            // 
            edit_button.Location = new Point(674, 12);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(107, 76);
            edit_button.TabIndex = 5;
            edit_button.Text = "Խմբագրել";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += Edit_button_Click;
            // 
            // show_goods_button
            // 
            show_goods_button.Location = new Point(416, 12);
            show_goods_button.Name = "show_goods_button";
            show_goods_button.Size = new Size(139, 76);
            show_goods_button.TabIndex = 6;
            show_goods_button.Text = "Ցուցադրել ապրանքները";
            show_goods_button.UseVisualStyleBackColor = true;
            show_goods_button.Click += Show_goods_button_Click;
            // 
            // remove_button
            // 
            remove_button.Location = new Point(787, 12);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(107, 76);
            remove_button.TabIndex = 7;
            remove_button.Text = "Հեռացնել";
            remove_button.UseVisualStyleBackColor = true;
            remove_button.Click += Remove_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1417, 450);
            Controls.Add(remove_button);
            Controls.Add(show_goods_button);
            Controls.Add(edit_button);
            Controls.Add(add_button);
            Controls.Add(dataGridView1);
            Controls.Add(show_dists);
            Controls.Add(show_orgs);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button show_orgs;
        private Button show_dists;
        private DataGridView dataGridView1;
        private Button add_button;
        private Button edit_button;
        private Button show_goods_button;
        private Button remove_button;
    }
}
