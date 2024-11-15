namespace GoogleBooks
{
    partial class Form1
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnCreateBookshelf = new System.Windows.Forms.Button();
            this.txtBookshelfTitle = new System.Windows.Forms.TextBox();
            this.txtBookshelfDescription = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(679, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(391, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1076, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tim kiem";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(12, 151);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(1177, 374);
            this.dgvBooks.TabIndex = 2;
            // 
            // btnCreateBookshelf
            // 
            this.btnCreateBookshelf.Location = new System.Drawing.Point(417, 41);
            this.btnCreateBookshelf.Name = "btnCreateBookshelf";
            this.btnCreateBookshelf.Size = new System.Drawing.Size(131, 50);
            this.btnCreateBookshelf.TabIndex = 3;
            this.btnCreateBookshelf.Text = "Tao ke sach";
            this.btnCreateBookshelf.UseVisualStyleBackColor = true;
            // 
            // txtBookshelfTitle
            // 
            this.txtBookshelfTitle.Location = new System.Drawing.Point(169, 41);
            this.txtBookshelfTitle.Name = "txtBookshelfTitle";
            this.txtBookshelfTitle.Size = new System.Drawing.Size(230, 22);
            this.txtBookshelfTitle.TabIndex = 4;
            // 
            // txtBookshelfDescription
            // 
            this.txtBookshelfDescription.Location = new System.Drawing.Point(169, 69);
            this.txtBookshelfDescription.Name = "txtBookshelfDescription";
            this.txtBookshelfDescription.Size = new System.Drawing.Size(230, 22);
            this.txtBookshelfDescription.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 531);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(989, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtBookshelfDescription);
            this.Controls.Add(this.txtBookshelfTitle);
            this.Controls.Add(this.btnCreateBookshelf);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "Form1";
            this.Text = "Google Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnCreateBookshelf;
        private System.Windows.Forms.TextBox txtBookshelfTitle;
        private System.Windows.Forms.TextBox txtBookshelfDescription;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

