
namespace ProductDb.Forms
{
    partial class CategoryActionsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCatList = new System.Windows.Forms.Button();
            this.buttonCatDelete = new System.Windows.Forms.Button();
            this.buttonCatUpdate = new System.Windows.Forms.Button();
            this.buttonCatAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCatInfo = new System.Windows.Forms.TextBox();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Category Actions screen. \r\nIn here, you can add, update and delete" +
    " \r\ncategories.\r\nYou can also see the current list of categories, \r\nby clicking \'" +
    "Category\r\n List\' button.\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCatList);
            this.groupBox1.Controls.Add(this.buttonCatDelete);
            this.groupBox1.Controls.Add(this.buttonCatUpdate);
            this.groupBox1.Controls.Add(this.buttonCatAdd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxCatInfo);
            this.groupBox1.Controls.Add(this.textBoxCatName);
            this.groupBox1.Controls.Add(this.comboBoxCategories);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 261);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Actions";
            // 
            // buttonCatList
            // 
            this.buttonCatList.Location = new System.Drawing.Point(9, 215);
            this.buttonCatList.Name = "buttonCatList";
            this.buttonCatList.Size = new System.Drawing.Size(117, 23);
            this.buttonCatList.TabIndex = 14;
            this.buttonCatList.Text = "Category List";
            this.buttonCatList.UseVisualStyleBackColor = true;
            this.buttonCatList.Click += new System.EventHandler(this.buttonCatList_Click);
            // 
            // buttonCatDelete
            // 
            this.buttonCatDelete.Enabled = false;
            this.buttonCatDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCatDelete.Location = new System.Drawing.Point(173, 167);
            this.buttonCatDelete.Name = "buttonCatDelete";
            this.buttonCatDelete.Size = new System.Drawing.Size(75, 42);
            this.buttonCatDelete.TabIndex = 13;
            this.buttonCatDelete.Text = "Delete Category";
            this.buttonCatDelete.UseVisualStyleBackColor = true;
            this.buttonCatDelete.Click += new System.EventHandler(this.buttonCatDelete_Click);
            // 
            // buttonCatUpdate
            // 
            this.buttonCatUpdate.Enabled = false;
            this.buttonCatUpdate.ForeColor = System.Drawing.Color.Teal;
            this.buttonCatUpdate.Location = new System.Drawing.Point(90, 167);
            this.buttonCatUpdate.Name = "buttonCatUpdate";
            this.buttonCatUpdate.Size = new System.Drawing.Size(75, 42);
            this.buttonCatUpdate.TabIndex = 12;
            this.buttonCatUpdate.Text = "Update Category";
            this.buttonCatUpdate.UseVisualStyleBackColor = true;
            this.buttonCatUpdate.Click += new System.EventHandler(this.buttonCatUpdate_Click);
            // 
            // buttonCatAdd
            // 
            this.buttonCatAdd.ForeColor = System.Drawing.Color.Green;
            this.buttonCatAdd.Location = new System.Drawing.Point(9, 167);
            this.buttonCatAdd.Name = "buttonCatAdd";
            this.buttonCatAdd.Size = new System.Drawing.Size(75, 42);
            this.buttonCatAdd.TabIndex = 11;
            this.buttonCatAdd.Text = "Add New Category";
            this.buttonCatAdd.UseVisualStyleBackColor = true;
            this.buttonCatAdd.Click += new System.EventHandler(this.buttonCatAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // textBoxCatInfo
            // 
            this.textBoxCatInfo.Location = new System.Drawing.Point(9, 131);
            this.textBoxCatInfo.Name = "textBoxCatInfo";
            this.textBoxCatInfo.Size = new System.Drawing.Size(248, 20);
            this.textBoxCatInfo.TabIndex = 3;
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(9, 92);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCatName.TabIndex = 1;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(9, 41);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(239, 24);
            this.comboBoxCategories.TabIndex = 0;
            this.comboBoxCategories.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCategories_SelectionChangeCommitted);
            // 
            // CategoryActionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(322, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategoryActionsForm";
            this.Text = "CategoryActions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCatList;
        private System.Windows.Forms.Button buttonCatDelete;
        private System.Windows.Forms.Button buttonCatUpdate;
        private System.Windows.Forms.Button buttonCatAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCatInfo;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.ComboBox comboBoxCategories;
    }
}