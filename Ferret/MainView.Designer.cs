namespace Ferret
{
    partial class MainView
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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.TabController = new System.Windows.Forms.TabControl();
            this.currentlyWatchingTabPage = new System.Windows.Forms.TabPage();
            this.onHoldTabPage = new System.Windows.Forms.TabPage();
            this.currentlyWatchingList = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.onHoldList = new System.Windows.Forms.ListView();
            this.planToWatchTabPage = new System.Windows.Forms.TabPage();
            this.completedTabPage = new System.Windows.Forms.TabPage();
            this.droppedTabPage = new System.Windows.Forms.TabPage();
            this.planToWatchList = new System.Windows.Forms.ListView();
            this.completedList = new System.Windows.Forms.ListView();
            this.droppedList = new System.Windows.Forms.ListView();
            this.TabController.SuspendLayout();
            this.currentlyWatchingTabPage.SuspendLayout();
            this.onHoldTabPage.SuspendLayout();
            this.planToWatchTabPage.SuspendLayout();
            this.completedTabPage.SuspendLayout();
            this.droppedTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabController
            // 
            this.TabController.Controls.Add(this.currentlyWatchingTabPage);
            this.TabController.Controls.Add(this.onHoldTabPage);
            this.TabController.Controls.Add(this.planToWatchTabPage);
            this.TabController.Controls.Add(this.completedTabPage);
            this.TabController.Controls.Add(this.droppedTabPage);
            this.TabController.ItemSize = new System.Drawing.Size(58, 25);
            this.TabController.Location = new System.Drawing.Point(160, 12);
            this.TabController.Name = "TabController";
            this.TabController.SelectedIndex = 0;
            this.TabController.Size = new System.Drawing.Size(925, 662);
            this.TabController.TabIndex = 2;
            // 
            // currentlyWatchingTabPage
            // 
            this.currentlyWatchingTabPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentlyWatchingTabPage.Controls.Add(this.currentlyWatchingList);
            this.currentlyWatchingTabPage.Location = new System.Drawing.Point(4, 29);
            this.currentlyWatchingTabPage.Name = "currentlyWatchingTabPage";
            this.currentlyWatchingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.currentlyWatchingTabPage.Size = new System.Drawing.Size(917, 629);
            this.currentlyWatchingTabPage.TabIndex = 0;
            this.currentlyWatchingTabPage.Text = "Currently Watching";
            // 
            // onHoldTabPage
            // 
            this.onHoldTabPage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.onHoldTabPage.Controls.Add(this.onHoldList);
            this.onHoldTabPage.Location = new System.Drawing.Point(4, 29);
            this.onHoldTabPage.Name = "onHoldTabPage";
            this.onHoldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.onHoldTabPage.Size = new System.Drawing.Size(917, 629);
            this.onHoldTabPage.TabIndex = 1;
            this.onHoldTabPage.Text = "On Hold";
            // 
            // currentlyWatchingList
            // 
            this.currentlyWatchingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentlyWatchingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.currentlyWatchingList.Location = new System.Drawing.Point(0, 0);
            this.currentlyWatchingList.Name = "currentlyWatchingList";
            this.currentlyWatchingList.Size = new System.Drawing.Size(917, 629);
            this.currentlyWatchingList.TabIndex = 2;
            this.currentlyWatchingList.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(-1, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Anime";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(-1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 45);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(-1, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Manga";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // onHoldList
            // 
            this.onHoldList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onHoldList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.onHoldList.Location = new System.Drawing.Point(0, 0);
            this.onHoldList.Name = "onHoldList";
            this.onHoldList.Size = new System.Drawing.Size(917, 629);
            this.onHoldList.TabIndex = 3;
            this.onHoldList.UseCompatibleStateImageBehavior = false;
            // 
            // planToWatchTabPage
            // 
            this.planToWatchTabPage.Controls.Add(this.planToWatchList);
            this.planToWatchTabPage.Location = new System.Drawing.Point(4, 29);
            this.planToWatchTabPage.Name = "planToWatchTabPage";
            this.planToWatchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.planToWatchTabPage.Size = new System.Drawing.Size(917, 629);
            this.planToWatchTabPage.TabIndex = 2;
            this.planToWatchTabPage.Text = "Plan to Watch";
            this.planToWatchTabPage.UseVisualStyleBackColor = true;
            // 
            // completedTabPage
            // 
            this.completedTabPage.Controls.Add(this.completedList);
            this.completedTabPage.Location = new System.Drawing.Point(4, 29);
            this.completedTabPage.Name = "completedTabPage";
            this.completedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.completedTabPage.Size = new System.Drawing.Size(917, 629);
            this.completedTabPage.TabIndex = 3;
            this.completedTabPage.Text = "Completed";
            this.completedTabPage.UseVisualStyleBackColor = true;
            // 
            // droppedTabPage
            // 
            this.droppedTabPage.Controls.Add(this.droppedList);
            this.droppedTabPage.Location = new System.Drawing.Point(4, 29);
            this.droppedTabPage.Name = "droppedTabPage";
            this.droppedTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.droppedTabPage.Size = new System.Drawing.Size(917, 629);
            this.droppedTabPage.TabIndex = 4;
            this.droppedTabPage.Text = "Dropped";
            this.droppedTabPage.UseVisualStyleBackColor = true;
            // 
            // planToWatchList
            // 
            this.planToWatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planToWatchList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.planToWatchList.Location = new System.Drawing.Point(0, 0);
            this.planToWatchList.Name = "planToWatchList";
            this.planToWatchList.Size = new System.Drawing.Size(914, 629);
            this.planToWatchList.TabIndex = 4;
            this.planToWatchList.UseCompatibleStateImageBehavior = false;
            // 
            // completedList
            // 
            this.completedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.completedList.Location = new System.Drawing.Point(0, 0);
            this.completedList.Name = "completedList";
            this.completedList.Size = new System.Drawing.Size(917, 629);
            this.completedList.TabIndex = 4;
            this.completedList.UseCompatibleStateImageBehavior = false;
            // 
            // droppedList
            // 
            this.droppedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.droppedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.droppedList.Location = new System.Drawing.Point(0, 0);
            this.droppedList.Name = "droppedList";
            this.droppedList.Size = new System.Drawing.Size(917, 629);
            this.droppedList.TabIndex = 4;
            this.droppedList.UseCompatibleStateImageBehavior = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1097, 686);
            this.Controls.Add(this.TabController);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "MainView";
            this.Text = "Form1";
            this.TabController.ResumeLayout(false);
            this.currentlyWatchingTabPage.ResumeLayout(false);
            this.onHoldTabPage.ResumeLayout(false);
            this.planToWatchTabPage.ResumeLayout(false);
            this.completedTabPage.ResumeLayout(false);
            this.droppedTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.TabControl TabController;
        private System.Windows.Forms.TabPage currentlyWatchingTabPage;
        private System.Windows.Forms.ListView currentlyWatchingList;
        private System.Windows.Forms.TabPage onHoldTabPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView onHoldList;
        private System.Windows.Forms.TabPage planToWatchTabPage;
        private System.Windows.Forms.TabPage completedTabPage;
        private System.Windows.Forms.TabPage droppedTabPage;
        private System.Windows.Forms.ListView planToWatchList;
        private System.Windows.Forms.ListView completedList;
        private System.Windows.Forms.ListView droppedList;
    }
}

