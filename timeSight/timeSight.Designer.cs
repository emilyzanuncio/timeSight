namespace timeSight
{
    partial class timeSight
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.navUser = new System.Windows.Forms.Button();
            this.navTimeline = new System.Windows.Forms.Button();
            this.navCalendar = new System.Windows.Forms.Button();
            this.navGallery = new System.Windows.Forms.Button();
            this.panelNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelNavbar.Controls.Add(this.navUser);
            this.panelNavbar.Controls.Add(this.navTimeline);
            this.panelNavbar.Controls.Add(this.navCalendar);
            this.panelNavbar.Controls.Add(this.navGallery);
            this.panelNavbar.Location = new System.Drawing.Point(330, 480);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(340, 90);
            this.panelNavbar.TabIndex = 0;
            this.panelNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavbar_MouseDown);
            this.panelNavbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelNavbar_MouseMove);
            this.panelNavbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelNavbar_MouseUp);
            // 
            // navUser
            // 
            this.navUser.Location = new System.Drawing.Point(260, 10);
            this.navUser.Name = "navUser";
            this.navUser.Size = new System.Drawing.Size(70, 70);
            this.navUser.TabIndex = 3;
            this.navUser.Text = "User";
            this.navUser.UseVisualStyleBackColor = true;
            // 
            // navTimeline
            // 
            this.navTimeline.Location = new System.Drawing.Point(170, 10);
            this.navTimeline.Name = "navTimeline";
            this.navTimeline.Size = new System.Drawing.Size(70, 70);
            this.navTimeline.TabIndex = 2;
            this.navTimeline.Text = "Timeline";
            this.navTimeline.UseVisualStyleBackColor = true;
            // 
            // navCalendar
            // 
            this.navCalendar.Location = new System.Drawing.Point(90, 10);
            this.navCalendar.Name = "navCalendar";
            this.navCalendar.Size = new System.Drawing.Size(70, 70);
            this.navCalendar.TabIndex = 1;
            this.navCalendar.Text = "Calendar";
            this.navCalendar.UseVisualStyleBackColor = true;
            // 
            // navGallery
            // 
            this.navGallery.Location = new System.Drawing.Point(10, 10);
            this.navGallery.Name = "navGallery";
            this.navGallery.Size = new System.Drawing.Size(70, 70);
            this.navGallery.TabIndex = 0;
            this.navGallery.Text = "Gallery";
            this.navGallery.UseVisualStyleBackColor = true;
            this.navGallery.Click += new System.EventHandler(this.button1_Click);
            // 
            // timeSight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "timeSight";
            this.Text = "timeSight";
            this.Load += new System.EventHandler(this.timeSight_Load);
            this.panelNavbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Button navGallery;
        private System.Windows.Forms.Button navUser;
        private System.Windows.Forms.Button navTimeline;
        private System.Windows.Forms.Button navCalendar;
    }
}

