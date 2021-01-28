
namespace ProductDb.Forms
{
    partial class ProductListForm
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
            this.dataGridViewProList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProList
            // 
            this.dataGridViewProList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProList.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProList.Name = "dataGridViewProList";
            this.dataGridViewProList.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewProList.TabIndex = 0;
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProList);
            this.Name = "ProductListForm";
            this.Text = "ProductListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProList;
    }
}