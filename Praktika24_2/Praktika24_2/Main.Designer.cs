namespace Praktika24_2
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textStockTitle = new System.Windows.Forms.TextBox();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dateTimeFind = new System.Windows.Forms.DateTimePicker();
            this.TimeFindStock = new System.Windows.Forms.Button();
            this.btnShowAllStock = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textStockDeleteId = new System.Windows.Forms.TextBox();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FindProductByTitle = new System.Windows.Forms.TextBox();
            this.btnFindProductByTitle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textProductDeleteId = new System.Windows.Forms.TextBox();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.textProductPrice = new System.Windows.Forms.TextBox();
            this.textProductTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.dataGridStock = new System.Windows.Forms.DataGridView();
            this.IdStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeAdd);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.textStockTitle);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddStock);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimeFind);
            this.splitContainer1.Panel1.Controls.Add(this.TimeFindStock);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowAllStock);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textStockDeleteId);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteStock);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.FindProductByTitle);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindProductByTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textProductDeleteId);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteProduct);
            this.splitContainer1.Panel1.Controls.Add(this.textProductPrice);
            this.splitContainer1.Panel1.Controls.Add(this.textProductTitle);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddProduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowAllProduct);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridStock);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridProduct);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(620, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Дата";
            // 
            // dateTimeAdd
            // 
            this.dateTimeAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAdd.Location = new System.Drawing.Point(656, 116);
            this.dateTimeAdd.Name = "dateTimeAdd";
            this.dateTimeAdd.Size = new System.Drawing.Size(122, 20);
            this.dateTimeAdd.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Название";
            // 
            // textStockTitle
            // 
            this.textStockTitle.Location = new System.Drawing.Point(656, 90);
            this.textStockTitle.Name = "textStockTitle";
            this.textStockTitle.Size = new System.Drawing.Size(122, 20);
            this.textStockTitle.TabIndex = 22;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(656, 61);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(122, 23);
            this.btnAddStock.TabIndex = 21;
            this.btnAddStock.Text = "Добавить акцию";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // dateTimeFind
            // 
            this.dateTimeFind.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFind.Location = new System.Drawing.Point(554, 5);
            this.dateTimeFind.Name = "dateTimeFind";
            this.dateTimeFind.Size = new System.Drawing.Size(96, 20);
            this.dateTimeFind.TabIndex = 20;
            // 
            // TimeFindStock
            // 
            this.TimeFindStock.Location = new System.Drawing.Point(656, 3);
            this.TimeFindStock.Name = "TimeFindStock";
            this.TimeFindStock.Size = new System.Drawing.Size(122, 23);
            this.TimeFindStock.TabIndex = 19;
            this.TimeFindStock.Text = "Найти акции по дате";
            this.TimeFindStock.UseVisualStyleBackColor = true;
            this.TimeFindStock.Click += new System.EventHandler(this.TimeFindStock_Click);
            // 
            // btnShowAllStock
            // 
            this.btnShowAllStock.Location = new System.Drawing.Point(340, 102);
            this.btnShowAllStock.Name = "btnShowAllStock";
            this.btnShowAllStock.Size = new System.Drawing.Size(122, 23);
            this.btnShowAllStock.TabIndex = 15;
            this.btnShowAllStock.Text = "Посмотреть акции";
            this.btnShowAllStock.UseVisualStyleBackColor = true;
            this.btnShowAllStock.Click += new System.EventHandler(this.btnShowAllStock_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id";
            // 
            // textStockDeleteId
            // 
            this.textStockDeleteId.Location = new System.Drawing.Point(623, 35);
            this.textStockDeleteId.Name = "textStockDeleteId";
            this.textStockDeleteId.Size = new System.Drawing.Size(27, 20);
            this.textStockDeleteId.TabIndex = 17;
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Location = new System.Drawing.Point(656, 32);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteStock.TabIndex = 16;
            this.btnDeleteStock.Text = "Удалить акцию";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Название";
            // 
            // FindProductByTitle
            // 
            this.FindProductByTitle.Location = new System.Drawing.Point(179, 5);
            this.FindProductByTitle.Name = "FindProductByTitle";
            this.FindProductByTitle.Size = new System.Drawing.Size(122, 20);
            this.FindProductByTitle.TabIndex = 13;
            // 
            // btnFindProductByTitle
            // 
            this.btnFindProductByTitle.Location = new System.Drawing.Point(24, 3);
            this.btnFindProductByTitle.Name = "btnFindProductByTitle";
            this.btnFindProductByTitle.Size = new System.Drawing.Size(149, 23);
            this.btnFindProductByTitle.TabIndex = 12;
            this.btnFindProductByTitle.Text = "Найти товар по названию";
            this.btnFindProductByTitle.UseVisualStyleBackColor = true;
            this.btnFindProductByTitle.Click += new System.EventHandler(this.btnFindProductByTitle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Id";
            // 
            // textProductDeleteId
            // 
            this.textProductDeleteId.Location = new System.Drawing.Point(155, 32);
            this.textProductDeleteId.Name = "textProductDeleteId";
            this.textProductDeleteId.Size = new System.Drawing.Size(27, 20);
            this.textProductDeleteId.TabIndex = 10;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(24, 32);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteProduct.TabIndex = 9;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // textProductPrice
            // 
            this.textProductPrice.Location = new System.Drawing.Point(24, 116);
            this.textProductPrice.Name = "textProductPrice";
            this.textProductPrice.Size = new System.Drawing.Size(122, 20);
            this.textProductPrice.TabIndex = 8;
            // 
            // textProductTitle
            // 
            this.textProductTitle.Location = new System.Drawing.Point(24, 90);
            this.textProductTitle.Name = "textProductTitle";
            this.textProductTitle.Size = new System.Drawing.Size(122, 20);
            this.textProductTitle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(24, 61);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(122, 23);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Location = new System.Drawing.Point(340, 73);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(122, 23);
            this.btnShowAllProduct.TabIndex = 0;
            this.btnShowAllProduct.Text = "Посмотреть товары";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // dataGridStock
            // 
            this.dataGridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStock,
            this.Название,
            this.Date});
            this.dataGridStock.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridStock.Location = new System.Drawing.Point(454, 0);
            this.dataGridStock.Name = "dataGridStock";
            this.dataGridStock.Size = new System.Drawing.Size(346, 308);
            this.dataGridStock.TabIndex = 1;
            // 
            // IdStock
            // 
            this.IdStock.HeaderText = "Id";
            this.IdStock.Name = "IdStock";
            // 
            // Название
            // 
            this.Название.HeaderText = "Названиие";
            this.Название.Name = "Название";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProduct,
            this.TitleProduct,
            this.Price});
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.Size = new System.Drawing.Size(343, 308);
            this.dataGridProduct.TabIndex = 0;
            // 
            // IDProduct
            // 
            this.IDProduct.HeaderText = "Id";
            this.IDProduct.Name = "IDProduct";
            // 
            // TitleProduct
            // 
            this.TitleProduct.HeaderText = "Название";
            this.TitleProduct.Name = "TitleProduct";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindProductByTitle;
        private System.Windows.Forms.Button btnFindProductByTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textProductDeleteId;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.TextBox textProductPrice;
        private System.Windows.Forms.TextBox textProductTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.DataGridView dataGridStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimeAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textStockTitle;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.DateTimePicker dateTimeFind;
        private System.Windows.Forms.Button TimeFindStock;
        private System.Windows.Forms.Button btnShowAllStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textStockDeleteId;
        private System.Windows.Forms.Button btnDeleteStock;
    }
}