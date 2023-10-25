namespace CustomerEditorGUI
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
            components = new System.ComponentModel.Container();
            dGridV_CustomerList = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            tb_phonenumber = new TextBox();
            tb_Email = new TextBox();
            tb_lastname = new TextBox();
            tb_firstname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Button_Delete = new Button();
            CreateCustomerBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dGridV_CustomerList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dGridV_CustomerList
            // 
            dGridV_CustomerList.AutoGenerateColumns = false;
            dGridV_CustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridV_CustomerList.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, PhoneNumber, lastNameDataGridViewTextBoxColumn });
            dGridV_CustomerList.DataSource = customerBindingSource;
            dGridV_CustomerList.Location = new Point(12, 140);
            dGridV_CustomerList.Margin = new Padding(3, 4, 3, 4);
            dGridV_CustomerList.Name = "dGridV_CustomerList";
            dGridV_CustomerList.ReadOnly = true;
            dGridV_CustomerList.RowHeadersWidth = 72;
            dGridV_CustomerList.RowTemplate.Height = 37;
            dGridV_CustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGridV_CustomerList.Size = new Size(782, 412);
            dGridV_CustomerList.TabIndex = 0;
            dGridV_CustomerList.SelectionChanged += dGridV_CustomerList_SelectionChanged;
            dGridV_CustomerList.DoubleClick += dGridV_CustomerList_DoubleClick;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.MinimumWidth = 9;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 175;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 9;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Repositories.Models.Customer);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_phonenumber);
            groupBox1.Controls.Add(tb_Email);
            groupBox1.Controls.Add(tb_lastname);
            groupBox1.Controls.Add(tb_firstname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(850, 140);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(531, 296);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            // 
            // tb_phonenumber
            // 
            tb_phonenumber.Location = new Point(190, 224);
            tb_phonenumber.Margin = new Padding(3, 4, 3, 4);
            tb_phonenumber.Name = "tb_phonenumber";
            tb_phonenumber.Size = new Size(285, 35);
            tb_phonenumber.TabIndex = 8;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(106, 164);
            tb_Email.Margin = new Padding(3, 4, 3, 4);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(371, 35);
            tb_Email.TabIndex = 7;
            // 
            // tb_lastname
            // 
            tb_lastname.Location = new Point(149, 104);
            tb_lastname.Margin = new Padding(3, 4, 3, 4);
            tb_lastname.Name = "tb_lastname";
            tb_lastname.Size = new Size(326, 35);
            tb_lastname.TabIndex = 6;
            // 
            // tb_firstname
            // 
            tb_firstname.Location = new Point(149, 52);
            tb_firstname.Margin = new Padding(3, 4, 3, 4);
            tb_firstname.Name = "tb_firstname";
            tb_firstname.Size = new Size(326, 35);
            tb_firstname.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 224);
            label4.Name = "label4";
            label4.Size = new Size(159, 30);
            label4.TabIndex = 4;
            label4.Text = "PhoneNumber :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 168);
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
            label1.Location = new Point(26, 52);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 1;
            label1.Text = "FirstName :";
            // 
            // Button_Delete
            // 
            Button_Delete.Location = new Point(12, 580);
            Button_Delete.Margin = new Padding(3, 4, 3, 4);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(257, 72);
            Button_Delete.TabIndex = 2;
            Button_Delete.Text = "Delete Chosen";
            Button_Delete.UseVisualStyleBackColor = true;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // CreateCustomerBtn
            // 
            CreateCustomerBtn.Location = new Point(537, 580);
            CreateCustomerBtn.Margin = new Padding(5, 6, 5, 6);
            CreateCustomerBtn.Name = "CreateCustomerBtn";
            CreateCustomerBtn.Size = new Size(257, 72);
            CreateCustomerBtn.TabIndex = 3;
            CreateCustomerBtn.Text = "Create new Customer";
            CreateCustomerBtn.UseVisualStyleBackColor = true;
            CreateCustomerBtn.Click += CreateCustomerBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1106, 494);
            button1.Name = "button1";
            button1.Size = new Size(219, 58);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 684);
            Controls.Add(button1);
            Controls.Add(CreateCustomerBtn);
            Controls.Add(Button_Delete);
            Controls.Add(groupBox1);
            Controls.Add(dGridV_CustomerList);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dGridV_CustomerList).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dGridV_CustomerList;
        private BindingSource customerBindingSource;
        private GroupBox groupBox1;
        private TextBox tb_phonenumber;
        private TextBox tb_Email;
        private TextBox tb_lastname;
        private TextBox tb_firstname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private Button Button_Delete;
        private Button CreateCustomerBtn;
        private Button button1;
    }
}