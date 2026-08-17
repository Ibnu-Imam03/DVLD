namespace DVLD
{
    partial class Add_EditForm
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
            this.usPersonInfo1 = new DVLD.usPersonInfo();
            this.SuspendLayout();
            // 
            // usPersonInfo1
            // 
            this.usPersonInfo1.Location = new System.Drawing.Point(53, 77);
            this.usPersonInfo1.Name = "usPersonInfo1";
            this.usPersonInfo1.Size = new System.Drawing.Size(808, 361);
            this.usPersonInfo1.TabIndex = 0;
            // 
            // Add_EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.usPersonInfo1);
            this.Name = "Add_EditForm";
            this.Text = "Add_EditForm";
            this.Load += new System.EventHandler(this.Add_EditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usPersonInfo usPersonInfo1;
    }
}