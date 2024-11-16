namespace GoogleBooks
{
    partial class BookDetail
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
            this.rtbBookDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddToShelf = new System.Windows.Forms.Button();
            this.btnRemoveFromShelf = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // rtbBookDetails
            // 
            this.rtbBookDetails.Location = new System.Drawing.Point(12, 12);
            this.rtbBookDetails.Name = "rtbBookDetails";
            this.rtbBookDetails.Size = new System.Drawing.Size(980, 355);
            this.rtbBookDetails.TabIndex = 0;
            this.rtbBookDetails.Text = "";
            // 
            // btnAddToShelf
            // 
            this.btnAddToShelf.Location = new System.Drawing.Point(12, 389);
            this.btnAddToShelf.Name = "btnAddToShelf";
            this.btnAddToShelf.Size = new System.Drawing.Size(163, 50);
            this.btnAddToShelf.TabIndex = 1;
            this.btnAddToShelf.Text = "Them vao ke sach";
            this.btnAddToShelf.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFromShelf
            // 
            this.btnRemoveFromShelf.Location = new System.Drawing.Point(218, 389);
            this.btnRemoveFromShelf.Name = "btnRemoveFromShelf";
            this.btnRemoveFromShelf.Size = new System.Drawing.Size(170, 50);
            this.btnRemoveFromShelf.TabIndex = 2;
            this.btnRemoveFromShelf.Text = "Xoa khoi ke sach";
            this.btnRemoveFromShelf.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(428, 456);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 33);
            this.progressBar.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 537);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRemoveFromShelf);
            this.Controls.Add(this.btnAddToShelf);
            this.Controls.Add(this.rtbBookDetails);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBookDetails;
        private System.Windows.Forms.Button btnAddToShelf;
        private System.Windows.Forms.Button btnRemoveFromShelf;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}