
namespace ProductDb.Forms
{
    partial class ProductActionsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonProList = new System.Windows.Forms.Button();
            this.buttonProDelete = new System.Windows.Forms.Button();
            this.buttonProUpdate = new System.Windows.Forms.Button();
            this.buttonProAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProductInfo = new System.Windows.Forms.TextBox();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonProList);
            this.groupBox1.Controls.Add(this.buttonProDelete);
            this.groupBox1.Controls.Add(this.buttonProUpdate);
            this.groupBox1.Controls.Add(this.buttonProAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxProCat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxProductInfo);
            this.groupBox1.Controls.Add(this.textBoxProductPrice);
            this.groupBox1.Controls.Add(this.textBoxProductName);
            this.groupBox1.Controls.Add(this.comboBoxProduct);
            this.groupBox1.Location = new System.Drawing.Point(32, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Actions";
            // 
            // buttonProList
            // 
            this.buttonProList.Location = new System.Drawing.Point(9, 257);
            this.buttonProList.Name = "buttonProList";
            this.buttonProList.Size = new System.Drawing.Size(75, 23);
            this.buttonProList.TabIndex = 14;
            this.buttonProList.Text = "Product List";
            this.buttonProList.UseVisualStyleBackColor = true;
            this.buttonProList.Click += new System.EventHandler(this.buttonProList_Click);
            // 
            // buttonProDelete
            // 
            this.buttonProDelete.Enabled = false;
            this.buttonProDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonProDelete.Location = new System.Drawing.Point(173, 209);
            this.buttonProDelete.Name = "buttonProDelete";
            this.buttonProDelete.Size = new System.Drawing.Size(75, 42);
            this.buttonProDelete.TabIndex = 13;
            this.buttonProDelete.Text = "Delete Product";
            this.buttonProDelete.UseVisualStyleBackColor = true;
            this.buttonProDelete.Click += new System.EventHandler(this.buttonProDelete_Click);
            // 
            // buttonProUpdate
            // 
            this.buttonProUpdate.Enabled = false;
            this.buttonProUpdate.ForeColor = System.Drawing.Color.Teal;
            this.buttonProUpdate.Location = new System.Drawing.Point(90, 209);
            this.buttonProUpdate.Name = "buttonProUpdate";
            this.buttonProUpdate.Size = new System.Drawing.Size(75, 42);
            this.buttonProUpdate.TabIndex = 12;
            this.buttonProUpdate.Text = "Update Product";
            this.buttonProUpdate.UseVisualStyleBackColor = true;
            this.buttonProUpdate.Click += new System.EventHandler(this.buttonProUpdate_Click);
            // 
            // buttonProAdd
            // 
            this.buttonProAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonProAdd.Location = new System.Drawing.Point(9, 209);
            this.buttonProAdd.Name = "buttonProAdd";
            this.buttonProAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonProAdd.TabIndex = 11;
            this.buttonProAdd.Text = "Add New Product";
            this.buttonProAdd.UseVisualStyleBackColor = true;
            this.buttonProAdd.Click += new System.EventHandler(this.buttonProAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Products";
            // 
            // comboBoxProCat
            // 
            this.comboBoxProCat.FormattingEnabled = true;
            this.comboBoxProCat.Location = new System.Drawing.Point(151, 104);
            this.comboBoxProCat.Name = "comboBoxProCat";
            this.comboBoxProCat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProCat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // textBoxProductInfo
            // 
            this.textBoxProductInfo.Location = new System.Drawing.Point(148, 160);
            this.textBoxProductInfo.Name = "textBoxProductInfo";
            this.textBoxProductInfo.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductInfo.TabIndex = 3;
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(6, 160);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductPrice.TabIndex = 2;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(6, 105);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(9, 41);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(239, 21);
            this.comboBoxProduct.TabIndex = 0;
            this.comboBoxProduct.SelectionChangeCommitted += new System.EventHandler(this.comboBoxProduct_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Product Actions screen. \r\nIn here, you can add, update and delete " +
    "\r\nproducts.\r\nYou can also see the current list of products, \r\nby clicking \'Produ" +
    "ct List\' button.\r\n";
            // 
            // ProductActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(354, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductActionsForm";
            this.Text = "ProductActions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProList;
        private System.Windows.Forms.Button buttonProDelete;
        private System.Windows.Forms.Button buttonProUpdate;
        private System.Windows.Forms.Button buttonProAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductInfo;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.ComboBox comboBoxProduct;
    }
}