namespace LMS.admin
{
    partial class aDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aDashboard));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.logout = new FontAwesome.Sharp.IconButton();
            this.regP = new FontAwesome.Sharp.IconButton();
            this.classes = new FontAwesome.Sharp.IconButton();
            this.subj = new FontAwesome.Sharp.IconButton();
            this.regS = new FontAwesome.Sharp.IconButton();
            this.regT = new FontAwesome.Sharp.IconButton();
            this.iconButtonClzMarks = new FontAwesome.Sharp.IconButton();
            this.iconButtonAttendence = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(65)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1050, 605);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1050, 75);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
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
            this.btnClose.Location = new System.Drawing.Point(1014, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
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
            this.btnMinimize.Location = new System.Drawing.Point(936, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 32);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
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
            this.btnMaximize.Location = new System.Drawing.Point(975, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(33, 32);
            this.btnMaximize.TabIndex = 5;
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click_1);
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
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.logout);
            this.panelMenu.Controls.Add(this.regP);
            this.panelMenu.Controls.Add(this.classes);
            this.panelMenu.Controls.Add(this.subj);
            this.panelMenu.Controls.Add(this.regS);
            this.panelMenu.Controls.Add(this.regT);
            this.panelMenu.Controls.Add(this.iconButtonClzMarks);
            this.panelMenu.Controls.Add(this.iconButtonAttendence);
            this.panelMenu.Controls.Add(this.iconButtonDashboard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 680);
            this.panelMenu.TabIndex = 3;
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
            this.logout.Location = new System.Drawing.Point(0, 647);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(220, 33);
            this.logout.TabIndex = 9;
            this.logout.Text = "LogOut";
            this.logout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // regP
            // 
            this.regP.Dock = System.Windows.Forms.DockStyle.Top;
            this.regP.FlatAppearance.BorderSize = 0;
            this.regP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regP.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regP.ForeColor = System.Drawing.Color.Gainsboro;
            this.regP.IconChar = FontAwesome.Sharp.IconChar.Snowman;
            this.regP.IconColor = System.Drawing.Color.Gainsboro;
            this.regP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.regP.IconSize = 32;
            this.regP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regP.Location = new System.Drawing.Point(0, 560);
            this.regP.Name = "regP";
            this.regP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.regP.Size = new System.Drawing.Size(220, 60);
            this.regP.TabIndex = 8;
            this.regP.Text = "Register Principle";
            this.regP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regP.UseVisualStyleBackColor = true;
            this.regP.Click += new System.EventHandler(this.regP_Click);
            // 
            // classes
            // 
            this.classes.Dock = System.Windows.Forms.DockStyle.Top;
            this.classes.FlatAppearance.BorderSize = 0;
            this.classes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classes.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classes.ForeColor = System.Drawing.Color.Gainsboro;
            this.classes.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.classes.IconColor = System.Drawing.Color.Gainsboro;
            this.classes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.classes.IconSize = 32;
            this.classes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes.Location = new System.Drawing.Point(0, 500);
            this.classes.Name = "classes";
            this.classes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.classes.Size = new System.Drawing.Size(220, 60);
            this.classes.TabIndex = 7;
            this.classes.Text = "Classes";
            this.classes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.classes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.classes.UseVisualStyleBackColor = true;
            this.classes.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // subj
            // 
            this.subj.Dock = System.Windows.Forms.DockStyle.Top;
            this.subj.FlatAppearance.BorderSize = 0;
            this.subj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subj.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subj.ForeColor = System.Drawing.Color.Gainsboro;
            this.subj.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.subj.IconColor = System.Drawing.Color.Gainsboro;
            this.subj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.subj.IconSize = 32;
            this.subj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subj.Location = new System.Drawing.Point(0, 440);
            this.subj.Name = "subj";
            this.subj.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.subj.Size = new System.Drawing.Size(220, 60);
            this.subj.TabIndex = 6;
            this.subj.Text = "Subjects";
            this.subj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.subj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.subj.UseVisualStyleBackColor = true;
            this.subj.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // regS
            // 
            this.regS.Dock = System.Windows.Forms.DockStyle.Top;
            this.regS.FlatAppearance.BorderSize = 0;
            this.regS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regS.ForeColor = System.Drawing.Color.Gainsboro;
            this.regS.IconChar = FontAwesome.Sharp.IconChar.Children;
            this.regS.IconColor = System.Drawing.Color.Gainsboro;
            this.regS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.regS.IconSize = 32;
            this.regS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regS.Location = new System.Drawing.Point(0, 380);
            this.regS.Name = "regS";
            this.regS.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.regS.Size = new System.Drawing.Size(220, 60);
            this.regS.TabIndex = 5;
            this.regS.Text = "Register New Student";
            this.regS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regS.UseVisualStyleBackColor = true;
            this.regS.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // regT
            // 
            this.regT.Dock = System.Windows.Forms.DockStyle.Top;
            this.regT.FlatAppearance.BorderSize = 0;
            this.regT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regT.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regT.ForeColor = System.Drawing.Color.Gainsboro;
            this.regT.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.regT.IconColor = System.Drawing.Color.Gainsboro;
            this.regT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.regT.IconSize = 32;
            this.regT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regT.Location = new System.Drawing.Point(0, 320);
            this.regT.Name = "regT";
            this.regT.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.regT.Size = new System.Drawing.Size(220, 60);
            this.regT.TabIndex = 4;
            this.regT.Text = "Register New Teacher";
            this.regT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.regT.UseVisualStyleBackColor = true;
            this.regT.Click += new System.EventHandler(this.iconButtonSubMarks_Click);
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
            this.iconButtonClzMarks.Text = "Marks";
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
            this.iconButtonAttendence.Text = " Attendence";
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
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // aDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 680);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "aDashboard";
            this.Text = "aDashboard";
            this.Resize += new System.EventHandler(this.aDashboard_Resize);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton regT;
        private FontAwesome.Sharp.IconButton iconButtonClzMarks;
        private FontAwesome.Sharp.IconButton iconButtonAttendence;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton subj;
        private FontAwesome.Sharp.IconButton regS;
        private FontAwesome.Sharp.IconButton classes;
        private FontAwesome.Sharp.IconButton regP;
        private FontAwesome.Sharp.IconButton logout;
    }
}