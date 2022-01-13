namespace PictureViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImagePreview = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Location = new System.Drawing.Point(85, 21);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(462, 22);
            this.textBoxDirectory.TabIndex = 1;
            this.textBoxDirectory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(587, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.listBoxImages);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 411);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Images";
            // 
            // listBoxImages
            // 
            this.listBoxImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 16;
            this.listBoxImages.Location = new System.Drawing.Point(3, 23);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(185, 388);
            this.listBoxImages.TabIndex = 1;
            this.listBoxImages.SelectedIndexChanged += new System.EventHandler(this.listBoxImages_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBoxImagePreview);
            this.groupBox2.Location = new System.Drawing.Point(206, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 419);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // pictureBoxImagePreview
            // 
            this.pictureBoxImagePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagePreview.Location = new System.Drawing.Point(3, 18);
            this.pictureBoxImagePreview.Name = "pictureBoxImagePreview";
            this.pictureBoxImagePreview.Size = new System.Drawing.Size(632, 380);
            this.pictureBoxImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagePreview.TabIndex = 0;
            this.pictureBoxImagePreview.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot (1).png");
            this.imageList1.Images.SetKeyName(1, "Screenshot (2).png");
            this.imageList1.Images.SetKeyName(2, "Screenshot (3).png");
            this.imageList1.Images.SetKeyName(3, "Screenshot (4).png");
            this.imageList1.Images.SetKeyName(4, "Screenshot (5).png");
            this.imageList1.Images.SetKeyName(5, "Screenshot (6).png");
            this.imageList1.Images.SetKeyName(6, "Screenshot (7).png");
            this.imageList1.Images.SetKeyName(7, "Screenshot (8).png");
            this.imageList1.Images.SetKeyName(8, "Screenshot (9).png");
            this.imageList1.Images.SetKeyName(9, "Screenshot (10).png");
            this.imageList1.Images.SetKeyName(10, "Screenshot (11).png");
            this.imageList1.Images.SetKeyName(11, "Screenshot (12).png");
            this.imageList1.Images.SetKeyName(12, "Screenshot (13).png");
            this.imageList1.Images.SetKeyName(13, "Screenshot (14).png");
            this.imageList1.Images.SetKeyName(14, "Screenshot (15).png");
            this.imageList1.Images.SetKeyName(15, "Screenshot (16).png");
            this.imageList1.Images.SetKeyName(16, "Screenshot (17).png");
            this.imageList1.Images.SetKeyName(17, "Screenshot (18).png");
            this.imageList1.Images.SetKeyName(18, "Screenshot (19).png");
            this.imageList1.Images.SetKeyName(19, "Screenshot (20).png");
            this.imageList1.Images.SetKeyName(20, "Screenshot (21).png");
            this.imageList1.Images.SetKeyName(21, "Screenshot (22).png");
            this.imageList1.Images.SetKeyName(22, "Screenshot (23).png");
            this.imageList1.Images.SetKeyName(23, "Screenshot (24).png");
            this.imageList1.Images.SetKeyName(24, "Screenshot (25).png");
            this.imageList1.Images.SetKeyName(25, "Screenshot (26).png");
            this.imageList1.Images.SetKeyName(26, "Screenshot (27).png");
            this.imageList1.Images.SetKeyName(27, "Screenshot (28).png");
            this.imageList1.Images.SetKeyName(28, "Screenshot (29).png");
            this.imageList1.Images.SetKeyName(29, "Screenshot (30).png");
            this.imageList1.Images.SetKeyName(30, "Screenshot (31).png");
            this.imageList1.Images.SetKeyName(31, "Screenshot (32).png");
            this.imageList1.Images.SetKeyName(32, "Screenshot (33).png");
            this.imageList1.Images.SetKeyName(33, "Screenshot (34).png");
            this.imageList1.Images.SetKeyName(34, "Screenshot (35).png");
            this.imageList1.Images.SetKeyName(35, "Screenshot (36).png");
            this.imageList1.Images.SetKeyName(36, "Screenshot (37).png");
            this.imageList1.Images.SetKeyName(37, "Screenshot (38).png");
            this.imageList1.Images.SetKeyName(38, "Screenshot (39).png");
            this.imageList1.Images.SetKeyName(39, "Screenshot (40).png");
            this.imageList1.Images.SetKeyName(40, "Screenshot (41).png");
            this.imageList1.Images.SetKeyName(41, "Screenshot (42).png");
            this.imageList1.Images.SetKeyName(42, "Screenshot (43).png");
            this.imageList1.Images.SetKeyName(43, "Screenshot (44).png");
            this.imageList1.Images.SetKeyName(44, "Screenshot (45).png");
            this.imageList1.Images.SetKeyName(45, "Screenshot (46).png");
            this.imageList1.Images.SetKeyName(46, "Screenshot (47).png");
            this.imageList1.Images.SetKeyName(47, "Screenshot (48).png");
            this.imageList1.Images.SetKeyName(48, "Screenshot (49).png");
            this.imageList1.Images.SetKeyName(49, "Screenshot (50).png");
            this.imageList1.Images.SetKeyName(50, "Screenshot (51).png");
            this.imageList1.Images.SetKeyName(51, "Screenshot (52).png");
            this.imageList1.Images.SetKeyName(52, "Screenshot (53).png");
            this.imageList1.Images.SetKeyName(53, "Screenshot (54).png");
            this.imageList1.Images.SetKeyName(54, "Screenshot (55).png");
            this.imageList1.Images.SetKeyName(55, "Screenshot (56).png");
            this.imageList1.Images.SetKeyName(56, "Screenshot (57).png");
            this.imageList1.Images.SetKeyName(57, "Screenshot (58).png");
            this.imageList1.Images.SetKeyName(58, "Screenshot (59).png");
            this.imageList1.Images.SetKeyName(59, "Screenshot (60).png");
            this.imageList1.Images.SetKeyName(60, "Screenshot (61).png");
            this.imageList1.Images.SetKeyName(61, "Screenshot (62).png");
            this.imageList1.Images.SetKeyName(62, "Screenshot (63).png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxImagePreview;
        private System.Windows.Forms.ImageList imageList1;
    }
}

