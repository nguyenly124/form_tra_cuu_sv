﻿namespace form_tra_cuu_diem
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
            buttontimkiem = new Button();
            label1 = new Label();
            txtmasv = new TextBox();
            lable_hienthi = new Label();
            SuspendLayout();
            // 
            // buttontimkiem
            // 
            buttontimkiem.Location = new Point(213, 146);
            buttontimkiem.Name = "buttontimkiem";
            buttontimkiem.Size = new Size(94, 29);
            buttontimkiem.TabIndex = 0;
            buttontimkiem.Text = "Tìm kiếm ";
            buttontimkiem.UseVisualStyleBackColor = true;
            buttontimkiem.Click += buttontimkiem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 95);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sinh viên ";
            // 
            // txtmasv
            // 
            txtmasv.Location = new Point(213, 88);
            txtmasv.Name = "txtmasv";
            txtmasv.Size = new Size(383, 27);
            txtmasv.TabIndex = 2;
            // 
            // lable_hienthi
            // 
            lable_hienthi.Location = new Point(71, 209);
            lable_hienthi.Name = "lable_hienthi";
            lable_hienthi.Size = new Size(664, 200);
            lable_hienthi.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lable_hienthi);
            Controls.Add(txtmasv);
            Controls.Add(label1);
            Controls.Add(buttontimkiem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttontimkiem;
        private Label label1;
        private TextBox txtmasv;
        private Label lable_hienthi;
    }
}
