namespace Test_PTUDCSDL
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 214);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 15);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã hàng hoá";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên hàng hoá";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(339, 15);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Số lượng";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(339, 33);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 23);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(339, 92);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 1;
            label4.Text = "Loại hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(614, 15);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 1;
            label5.Text = "Nhà sản xuất";
            // 
            // button1
            // 
            button1.Location = new Point(12, 180);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(113, 180);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(214, 180);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(318, 180);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(604, 109);
            button5.Name = "button5";
            button5.Size = new Size(131, 23);
            button5.TabIndex = 3;
            button5.Text = "Làm trống textbox";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(614, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 62);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(122, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Tìm kiếm theo mã";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(28, 139);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(122, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Tìm kiếm theo tên";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(339, 62);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(151, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Tìm kiếm theo só lượng";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(339, 139);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(154, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Tìm kiếm theo loại hàng";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(614, 62);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(172, 19);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "Tìm kiếm theo nhà sản xuất";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(604, 139);
            button6.Name = "button6";
            button6.Size = new Size(131, 23);
            button6.TabIndex = 3;
            button6.Text = "Làm trống checkbox";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ErrorProvider errorProvider1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button6;
    }
}