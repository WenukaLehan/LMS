namespace LMS.teacher
{
    partial class tDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tDashboard));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonSubMarks = new FontAwesome.Sharp.IconButton();
            this.iconButtonClzMarks = new FontAwesome.Sharp.IconButton();
            this.iconButtonAttendence = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.tID = new System.Windows.Forms.Label();
            this.tN = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.logout);
            this.panelMenu.Controls.Add(this.iconButtonSubMarks);
            this.panelMenu.Controls.Add(this.iconButtonClzMarks);
            this.panelMenu.Controls.Add(this.iconButtonAttendence);
            this.panelMenu.Controls.Add(this.iconButtonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 665);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonSubMarks
            // 
            this.iconButtonSubMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSubMarks.FlatAppearance.BorderSize = 0;
            this.iconButtonSubMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSubMarks.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSubMarks.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSubMarks.IconChar = FontAwesome.Sharp.IconChar.Markdown;
            this.iconButtonSubMarks.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSubMarks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSubMarks.IconSize = 32;
            this.iconButtonSubMarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSubMarks.Location = new System.Drawing.Point(0, 320);
            this.iconButtonSubMarks.Name = "iconButtonSubMarks";
            this.iconButtonSubMarks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonSubMarks.Size = new System.Drawing.Size(220, 60);
            this.iconButtonSubMarks.TabIndex = 4;
            this.iconButtonSubMarks.Text = "My Sublect Marks";
            this.iconButtonSubMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSubMarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSubMarks.UseVisualStyleBackColor = true;
            this.iconButtonSubMarks.Click += new System.EventHandler(this.iconButtonSubMarks_Click);
            // 
            // iconButtonClzMarks
            // 
            this.iconButtonClzMarks.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonClzMarks.FlatAppearance.BorderSize = 0;
            this.iconButtonClzMarks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClzMarks.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonClzMarks.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClzMarks.IconChar = FontAwesome.Sharp.IconChar.Marker;
            this.iconButtonClzMarks.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonClzMarks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClzMarks.IconSize = 32;
            this.iconButtonClzMarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClzMarks.Location = new System.Drawing.Point(0, 260);
            this.iconButtonClzMarks.Name = "iconButtonClzMarks";
            this.iconButtonClzMarks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonClzMarks.Size = new System.Drawing.Size(220, 60);
            this.iconButtonClzMarks.TabIndex = 3;
            this.iconButtonClzMarks.Text = "My Class Marks";
            this.iconButtonClzMarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonClzMarks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonClzMarks.UseVisualStyleBackColor = true;
            this.iconButtonClzMarks.Click += new System.EventHandler(this.iconButtonClzMarks_Click);
            // 
            // iconButtonAttendence
            // 
            this.iconButtonAttendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonAttendence.FlatAppearance.BorderSize = 0;
            this.iconButtonAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAttendence.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAttendence.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAttendence.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconButtonAttendence.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonAttendence.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAttendence.IconSize = 32;
            this.iconButtonAttendence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAttendence.Location = new System.Drawing.Point(0, 200);
            this.iconButtonAttendence.Name = "iconButtonAttendence";
            this.iconButtonAttendence.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonAttendence.Size = new System.Drawing.Size(220, 60);
            this.iconButtonAttendence.TabIndex = 2;
            this.iconButtonAttendence.Text = "My Class Attendence";
            this.iconButtonAttendence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAttendence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAttendence.UseVisualStyleBackColor = true;
            this.iconButtonAttendence.Click += new System.EventHandler(this.iconButtonAttendence_Click);
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.FlatAppearance.BorderSize = 0;
            this.iconButtonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDashboard.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.Dashboard;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 32;
            this.iconButtonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 140);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonDashboard.Size = new System.Drawing.Size(220, 60);
            this.iconButtonDashboard.TabIndex = 1;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = true;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(38, 22);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(131, 93);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.tID);
            this.panelTitleBar.Controls.Add(this.tN);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(905, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // tID
            // 
            this.tID.AutoSize = true;
            this.tID.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tID.Location = new System.Drawing.Point(527, 41);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(0, 22);
            this.tID.TabIndex = 10;
            // 
            // tN
            // 
            this.tN.AutoSize = true;
            this.tN.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tN.Location = new System.Drawing.Point(211, 41);
            this.tN.Name = "tN";
            this.tN.Size = new System.Drawing.Size(0, 22);
            this.tN.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(869, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(791, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 32);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 32;
            this.btnMaximize.Location = new System.Drawing.Point(830, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 32);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(58, 41);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(49, 16);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 31);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(905, 590);
            this.panelDesktop.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Gainsboro;
            this.logout.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.logout.IconColor = System.Drawing.Color.Gainsboro;
            this.logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout.IconSize = 26;
            this.logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.Location = new System.Drawing.Point(0, 632);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(220, 33);
            this.logout.TabIndex = 10;
            this.logout.Text = "LogOut";
            this.logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // tDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1125, 665);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "tDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Dashboard";
            this.Resize += new System.EventHandler(this.tDashboard_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonSubMarks;
        private FontAwesome.Sharp.IconButton iconButtonClzMarks;
        private FontAwesome.Sharp.IconButton iconButtonAttendence;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label tID;
        private System.Windows.Forms.Label tN;
        private FontAwesome.Sharp.IconButton logout;
    }
}