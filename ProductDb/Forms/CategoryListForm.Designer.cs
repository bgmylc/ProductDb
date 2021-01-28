
namespace ProductDb.Forms
{
    partial class CategoryListForm
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
            this.dataGridViewCatList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatList
            // 
            this.dataGridViewCatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCatList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCatList.Name = "dataGridViewCatList";
            this.dataGridViewCatList.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewCatList.TabIndex = 1;
            // 
            // CategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCatList);
            this.Name = "CategoryListForm";
            this.Text = "CategoryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCatList;
    }
}