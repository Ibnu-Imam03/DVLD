namespace DVLD.People
{
    partial class frmViewPersonInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPersonInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.clsPersonCard1 = new DVLD.People.controls.clsPersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImageIndex = 5;
            this.btnClose.ImageList = this.imageList1;
            this.btnClose.Location = new System.Drawing.Point(565, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 34);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-user.png");
            this.imageList1.Images.SetKeyName(1, "add-user1.png");
            this.imageList1.Images.SetKeyName(2, "application.png");
            this.imageList1.Images.SetKeyName(3, "brush-pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "calendar.png");
            this.imageList1.Images.SetKeyName(5, "close.png");
            this.imageList1.Images.SetKeyName(6, "country.png");
            this.imageList1.Images.SetKeyName(7, "customer.png");
            this.imageList1.Images.SetKeyName(8, "customer1.png");
            this.imageList1.Images.SetKeyName(9, "diskette.png");
            this.imageList1.Images.SetKeyName(10, "email.png");
            this.imageList1.Images.SetKeyName(11, "female-worker.png");
            this.imageList1.Images.SetKeyName(12, "id-card.png");
            this.imageList1.Images.SetKeyName(13, "id-card1.png");
            this.imageList1.Images.SetKeyName(14, "id-proof-black-icon.png");
            this.imageList1.Images.SetKeyName(15, "list-square-bullet-icon.png");
            this.imageList1.Images.SetKeyName(16, "location.png");
            this.imageList1.Images.SetKeyName(17, "male.png");
            this.imageList1.Images.SetKeyName(18, "phone-call.png");
            this.imageList1.Images.SetKeyName(19, "phone-call-icon.png");
            this.imageList1.Images.SetKeyName(20, "profile (1).png");
            this.imageList1.Images.SetKeyName(21, "profile.png");
            this.imageList1.Images.SetKeyName(22, "send-icon.png");
            this.imageList1.Images.SetKeyName(23, "trash-can-black-icon.png");
            this.imageList1.Images.SetKeyName(24, "user (1).png");
            this.imageList1.Images.SetKeyName(25, "user.png");
            this.imageList1.Images.SetKeyName(26, "add-user.png");
            // 
            // clsPersonCard1
            // 
            this.clsPersonCard1.BackColor = System.Drawing.Color.Aquamarine;
            this.clsPersonCard1.Location = new System.Drawing.Point(15, 44);
            this.clsPersonCard1.Margin = new System.Windows.Forms.Padding(4);
            this.clsPersonCard1.Name = "clsPersonCard1";
            this.clsPersonCard1.Size = new System.Drawing.Size(716, 310);
            this.clsPersonCard1.TabIndex = 0;
            // 
            // frmViewPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 367);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clsPersonCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewPersonInfo";
            this.Text = "frmViewPersonInfo";
            this.Load += new System.EventHandler(this.frmViewPersonInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private controls.clsPersonCard clsPersonCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ImageList imageList1;
    }
}