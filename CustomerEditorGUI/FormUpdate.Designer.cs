namespace CustomerEditorGUI
{
    partial class FormUpdate
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
            button1 = new Button();
            groupBox1 = new GroupBox();
            tb_phonenumberForm3 = new TextBox();
            tb_EmailForm3 = new TextBox();
            tb_lastnameForm3 = new TextBox();
            tb_firstnameForm3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 423);
            button1.Name = "button1";
            button1.Size = new Size(531, 118);
            button1.TabIndex = 5;
            button1.Text = "Update AND Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_phonenumberForm3);
            groupBox1.Controls.Add(tb_EmailForm3);
            groupBox1.Controls.Add(tb_lastnameForm3);
            groupBox1.Controls.Add(tb_firstnameForm3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(333, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 295);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // tb_phonenumberForm3
            // 
            tb_phonenumberForm3.Location = new Point(191, 225);
            tb_phonenumberForm3.Name = "tb_phonenumberForm3";
            tb_phonenumberForm3.Size = new Size(285, 35);
            tb_phonenumberForm3.TabIndex = 8;
            // 
            // tb_EmailForm3
            // 
            tb_EmailForm3.Location = new Point(106, 164);
            tb_EmailForm3.Name = "tb_EmailForm3";
            tb_EmailForm3.Size = new Size(370, 35);
            tb_EmailForm3.TabIndex = 7;
            // 
            // tb_lastnameForm3
            // 
            tb_lastnameForm3.Location = new Point(149, 105);
            tb_lastnameForm3.Name = "tb_lastnameForm3";
            tb_lastnameForm3.Size = new Size(327, 35);
            tb_lastnameForm3.TabIndex = 6;
            // 
            // tb_firstnameForm3
            // 
            tb_firstnameForm3.Location = new Point(149, 52);
            tb_firstnameForm3.Name = "tb_firstnameForm3";
            tb_firstnameForm3.Size = new Size(327, 35);
            tb_firstnameForm3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 225);
            label4.Name = "label4";
            label4.Size = new Size(159, 30);
            label4.TabIndex = 4;
            label4.Text = "PhoneNumber :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 167);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 3;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 108);
            label2.Name = "label2";
            label2.Size = new Size(117, 30);
            label2.TabIndex = 2;
            label2.Text = "LastName :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 52);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "FirstName :";
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 631);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "FormUpdate";
            Text = "FormUpdate";
            Load += FormUpdate_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private TextBox tb_phonenumberForm3;
        private TextBox tb_EmailForm3;
        private TextBox tb_lastnameForm3;
        private TextBox tb_firstnameForm3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}