
namespace CS499DatabaseApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            button1 = new Button();
            panel1 = new Panel();
            button5 = new Button();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            OrderID = new Label();
            CustomerID = new Label();
            SKU = new Label();
            Description = new Label();
            txt_customerid = new TextBox();
            txt_orderid = new TextBox();
            txt_sku = new TextBox();
            txt_description = new TextBox();
            button4 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(18, 39);
            button1.Name = "button1";
            button1.Size = new Size(146, 23);
            button1.TabIndex = 0;
            button1.Text = "Load Customers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1211, 806);
            panel1.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(996, 70);
            button5.Name = "button5";
            button5.Size = new Size(123, 23);
            button5.TabIndex = 8;
            button5.Text = "Search Orders";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(830, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(OrderID);
            groupBox1.Controls.Add(CustomerID);
            groupBox1.Controls.Add(SKU);
            groupBox1.Controls.Add(Description);
            groupBox1.Controls.Add(txt_customerid);
            groupBox1.Controls.Add(txt_orderid);
            groupBox1.Controls.Add(txt_sku);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Location = new Point(12, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 207);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Order";
            // 
            // button3
            // 
            button3.Location = new Point(86, 182);
            button3.Name = "button3";
            button3.Size = new Size(80, 25);
            button3.TabIndex = 11;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // OrderID
            // 
            OrderID.AutoSize = true;
            OrderID.Location = new Point(6, 39);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(51, 15);
            OrderID.TabIndex = 7;
            OrderID.Text = "Order ID";
            // 
            // CustomerID
            // 
            CustomerID.AutoSize = true;
            CustomerID.Location = new Point(6, 67);
            CustomerID.Name = "CustomerID";
            CustomerID.Size = new Size(73, 15);
            CustomerID.TabIndex = 8;
            CustomerID.Text = "Customer ID";
            // 
            // SKU
            // 
            SKU.AutoSize = true;
            SKU.Location = new Point(6, 95);
            SKU.Name = "SKU";
            SKU.Size = new Size(28, 15);
            SKU.TabIndex = 9;
            SKU.Text = "SKU";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(6, 123);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 10;
            Description.Text = "Description";
            // 
            // txt_customerid
            // 
            txt_customerid.Location = new Point(124, 59);
            txt_customerid.Name = "txt_customerid";
            txt_customerid.Size = new Size(139, 23);
            txt_customerid.TabIndex = 6;
            // 
            // txt_orderid
            // 
            txt_orderid.Location = new Point(124, 31);
            txt_orderid.Name = "txt_orderid";
            txt_orderid.Size = new Size(139, 23);
            txt_orderid.TabIndex = 5;
            // 
            // txt_sku
            // 
            txt_sku.Location = new Point(124, 87);
            txt_sku.Name = "txt_sku";
            txt_sku.Size = new Size(139, 23);
            txt_sku.TabIndex = 4;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(124, 115);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(139, 23);
            txt_description.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(16, 72);
            button4.Name = "button4";
            button4.Size = new Size(148, 22);
            button4.TabIndex = 5;
            button4.Text = "Load Orders";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(830, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(996, 39);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 2;
            button2.Text = "Search Customers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(331, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(868, 634);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1211, 806);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private Button button4;
        private GroupBox groupBox1;
        private Label Description;
        private Label SKU;
        private Label CustomerID;
        private Label OrderID;
        private TextBox txt_customerid;
        private TextBox txt_orderid;
        private TextBox txt_sku;
        private TextBox txt_description;
        private Button button3;
        private Button button5;
        private TextBox textBox2;
    }
}
