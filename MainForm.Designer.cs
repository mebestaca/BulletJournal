﻿namespace BulletJournal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_index = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGrid_index = new System.Windows.Forms.DataGridView();
            this.tab_Daily_Task = new System.Windows.Forms.TabPage();
            this.btn_addDailyTask = new System.Windows.Forms.Button();
            this.dataGrid_dailyTask = new System.Windows.Forms.DataGridView();
            this.tab_Monthly_Task = new System.Windows.Forms.TabPage();
            this.btn_addMonthlyTask = new System.Windows.Forms.Button();
            this.dataGrid_monthly = new System.Windows.Forms.DataGridView();
            this.tab_Future_Log = new System.Windows.Forms.TabPage();
            this.btn_addFutureLog = new System.Windows.Forms.Button();
            this.dataGrid_futureLog = new System.Windows.Forms.DataGridView();
            this.tab_Collection = new System.Windows.Forms.TabPage();
            this.btn_addCollection = new System.Windows.Forms.Button();
            this.dataGrid_collection = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.migrate = new System.Windows.Forms.ToolStripMenuItem();
            this.toExistingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.futureLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.futureLogToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tab_index.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_index)).BeginInit();
            this.tab_Daily_Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailyTask)).BeginInit();
            this.tab_Monthly_Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_monthly)).BeginInit();
            this.tab_Future_Log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_futureLog)).BeginInit();
            this.tab_Collection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_collection)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_index);
            this.tabControl1.Controls.Add(this.tab_Daily_Task);
            this.tabControl1.Controls.Add(this.tab_Monthly_Task);
            this.tabControl1.Controls.Add(this.tab_Future_Log);
            this.tabControl1.Controls.Add(this.tab_Collection);
            this.tabControl1.Location = new System.Drawing.Point(37, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tab_index
            // 
            this.tab_index.Controls.Add(this.label1);
            this.tab_index.Controls.Add(this.dateTimePicker);
            this.tab_index.Controls.Add(this.dataGrid_index);
            this.tab_index.Location = new System.Drawing.Point(4, 25);
            this.tab_index.Name = "tab_index";
            this.tab_index.Padding = new System.Windows.Forms.Padding(3);
            this.tab_index.Size = new System.Drawing.Size(735, 421);
            this.tab_index.TabIndex = 0;
            this.tab_index.Text = "Index";
            this.tab_index.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date Today:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(129, 383);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGrid_index
            // 
            this.dataGrid_index.AllowUserToAddRows = false;
            this.dataGrid_index.AllowUserToDeleteRows = false;
            this.dataGrid_index.AllowUserToOrderColumns = true;
            this.dataGrid_index.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_index.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_index.MultiSelect = false;
            this.dataGrid_index.Name = "dataGrid_index";
            this.dataGrid_index.ReadOnly = true;
            this.dataGrid_index.RowHeadersWidth = 51;
            this.dataGrid_index.RowTemplate.Height = 24;
            this.dataGrid_index.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_index.Size = new System.Drawing.Size(700, 350);
            this.dataGrid_index.TabIndex = 1;
            // 
            // tab_Daily_Task
            // 
            this.tab_Daily_Task.Controls.Add(this.btn_addDailyTask);
            this.tab_Daily_Task.Controls.Add(this.dataGrid_dailyTask);
            this.tab_Daily_Task.Location = new System.Drawing.Point(4, 25);
            this.tab_Daily_Task.Name = "tab_Daily_Task";
            this.tab_Daily_Task.Size = new System.Drawing.Size(735, 421);
            this.tab_Daily_Task.TabIndex = 3;
            this.tab_Daily_Task.Text = "Daily Task";
            this.tab_Daily_Task.UseVisualStyleBackColor = true;
            // 
            // btn_addDailyTask
            // 
            this.btn_addDailyTask.Location = new System.Drawing.Point(641, 371);
            this.btn_addDailyTask.Name = "btn_addDailyTask";
            this.btn_addDailyTask.Size = new System.Drawing.Size(75, 42);
            this.btn_addDailyTask.TabIndex = 0;
            this.btn_addDailyTask.Text = "Add";
            this.btn_addDailyTask.UseVisualStyleBackColor = true;
            this.btn_addDailyTask.Click += new System.EventHandler(this.btn_addDailyTask_Click);
            // 
            // dataGrid_dailyTask
            // 
            this.dataGrid_dailyTask.AllowUserToAddRows = false;
            this.dataGrid_dailyTask.AllowUserToDeleteRows = false;
            this.dataGrid_dailyTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_dailyTask.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_dailyTask.MultiSelect = false;
            this.dataGrid_dailyTask.Name = "dataGrid_dailyTask";
            this.dataGrid_dailyTask.ReadOnly = true;
            this.dataGrid_dailyTask.RowHeadersWidth = 51;
            this.dataGrid_dailyTask.RowTemplate.Height = 24;
            this.dataGrid_dailyTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_dailyTask.Size = new System.Drawing.Size(700, 350);
            this.dataGrid_dailyTask.TabIndex = 0;
            this.dataGrid_dailyTask.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_dailyTask_CellMouseUp);
            // 
            // tab_Monthly_Task
            // 
            this.tab_Monthly_Task.Controls.Add(this.btn_addMonthlyTask);
            this.tab_Monthly_Task.Controls.Add(this.dataGrid_monthly);
            this.tab_Monthly_Task.Location = new System.Drawing.Point(4, 25);
            this.tab_Monthly_Task.Name = "tab_Monthly_Task";
            this.tab_Monthly_Task.Size = new System.Drawing.Size(735, 421);
            this.tab_Monthly_Task.TabIndex = 2;
            this.tab_Monthly_Task.Text = "Monthly Task";
            this.tab_Monthly_Task.UseVisualStyleBackColor = true;
            // 
            // btn_addMonthlyTask
            // 
            this.btn_addMonthlyTask.Location = new System.Drawing.Point(641, 371);
            this.btn_addMonthlyTask.Name = "btn_addMonthlyTask";
            this.btn_addMonthlyTask.Size = new System.Drawing.Size(75, 42);
            this.btn_addMonthlyTask.TabIndex = 0;
            this.btn_addMonthlyTask.Text = "Add";
            this.btn_addMonthlyTask.UseVisualStyleBackColor = true;
            this.btn_addMonthlyTask.Click += new System.EventHandler(this.btn_addMonthlyTask_Click);
            // 
            // dataGrid_monthly
            // 
            this.dataGrid_monthly.AllowUserToAddRows = false;
            this.dataGrid_monthly.AllowUserToDeleteRows = false;
            this.dataGrid_monthly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_monthly.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_monthly.MultiSelect = false;
            this.dataGrid_monthly.Name = "dataGrid_monthly";
            this.dataGrid_monthly.ReadOnly = true;
            this.dataGrid_monthly.RowHeadersWidth = 51;
            this.dataGrid_monthly.RowTemplate.Height = 24;
            this.dataGrid_monthly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_monthly.Size = new System.Drawing.Size(700, 350);
            this.dataGrid_monthly.TabIndex = 0;
            this.dataGrid_monthly.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_monthly_CellMouseUp);
            // 
            // tab_Future_Log
            // 
            this.tab_Future_Log.Controls.Add(this.btn_addFutureLog);
            this.tab_Future_Log.Controls.Add(this.dataGrid_futureLog);
            this.tab_Future_Log.Location = new System.Drawing.Point(4, 25);
            this.tab_Future_Log.Name = "tab_Future_Log";
            this.tab_Future_Log.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Future_Log.Size = new System.Drawing.Size(735, 421);
            this.tab_Future_Log.TabIndex = 1;
            this.tab_Future_Log.Text = "Future Log";
            this.tab_Future_Log.UseVisualStyleBackColor = true;
            // 
            // btn_addFutureLog
            // 
            this.btn_addFutureLog.Location = new System.Drawing.Point(641, 371);
            this.btn_addFutureLog.Name = "btn_addFutureLog";
            this.btn_addFutureLog.Size = new System.Drawing.Size(75, 42);
            this.btn_addFutureLog.TabIndex = 0;
            this.btn_addFutureLog.Text = "Add";
            this.btn_addFutureLog.UseVisualStyleBackColor = true;
            this.btn_addFutureLog.Click += new System.EventHandler(this.btn_addFutureLog_Click);
            // 
            // dataGrid_futureLog
            // 
            this.dataGrid_futureLog.AllowUserToAddRows = false;
            this.dataGrid_futureLog.AllowUserToDeleteRows = false;
            this.dataGrid_futureLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_futureLog.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_futureLog.MultiSelect = false;
            this.dataGrid_futureLog.Name = "dataGrid_futureLog";
            this.dataGrid_futureLog.ReadOnly = true;
            this.dataGrid_futureLog.RowHeadersWidth = 51;
            this.dataGrid_futureLog.RowTemplate.Height = 24;
            this.dataGrid_futureLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_futureLog.Size = new System.Drawing.Size(700, 350);
            this.dataGrid_futureLog.TabIndex = 1;
            this.dataGrid_futureLog.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_futureLog_CellMouseUp);
            // 
            // tab_Collection
            // 
            this.tab_Collection.Controls.Add(this.btn_addCollection);
            this.tab_Collection.Controls.Add(this.dataGrid_collection);
            this.tab_Collection.Location = new System.Drawing.Point(4, 25);
            this.tab_Collection.Name = "tab_Collection";
            this.tab_Collection.Size = new System.Drawing.Size(735, 421);
            this.tab_Collection.TabIndex = 4;
            this.tab_Collection.Text = "Collection";
            this.tab_Collection.UseVisualStyleBackColor = true;
            // 
            // btn_addCollection
            // 
            this.btn_addCollection.Location = new System.Drawing.Point(641, 371);
            this.btn_addCollection.Name = "btn_addCollection";
            this.btn_addCollection.Size = new System.Drawing.Size(75, 42);
            this.btn_addCollection.TabIndex = 0;
            this.btn_addCollection.Text = "Add";
            this.btn_addCollection.UseVisualStyleBackColor = true;
            this.btn_addCollection.Click += new System.EventHandler(this.btn_addCollection_Click);
            // 
            // dataGrid_collection
            // 
            this.dataGrid_collection.AllowUserToAddRows = false;
            this.dataGrid_collection.AllowUserToDeleteRows = false;
            this.dataGrid_collection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_collection.Location = new System.Drawing.Point(16, 17);
            this.dataGrid_collection.MultiSelect = false;
            this.dataGrid_collection.Name = "dataGrid_collection";
            this.dataGrid_collection.ReadOnly = true;
            this.dataGrid_collection.RowHeadersWidth = 51;
            this.dataGrid_collection.RowTemplate.Height = 24;
            this.dataGrid_collection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_collection.Size = new System.Drawing.Size(700, 350);
            this.dataGrid_collection.TabIndex = 2;
            this.dataGrid_collection.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_collection_CellMouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_refresh,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(141, 26);
            this.btn_refresh.Text = "&Refresh";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.migrate});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // migrate
            // 
            this.migrate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toExistingToolStripMenuItem,
            this.asNewToolStripMenuItem});
            this.migrate.Name = "migrate";
            this.migrate.Size = new System.Drawing.Size(210, 24);
            this.migrate.Text = "Migrate";
            // 
            // toExistingToolStripMenuItem
            // 
            this.toExistingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyTaskToolStripMenuItem,
            this.monthlyTaskToolStripMenuItem,
            this.futureLogToolStripMenuItem});
            this.toExistingToolStripMenuItem.Name = "toExistingToolStripMenuItem";
            this.toExistingToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toExistingToolStripMenuItem.Text = "To Existing";
            // 
            // asNewToolStripMenuItem
            // 
            this.asNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyTaskToolStripMenuItem1,
            this.monthlyTaskToolStripMenuItem1,
            this.futureLogToolStripMenuItem1});
            this.asNewToolStripMenuItem.Name = "asNewToolStripMenuItem";
            this.asNewToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asNewToolStripMenuItem.Text = "As New";
            // 
            // dailyTaskToolStripMenuItem
            // 
            this.dailyTaskToolStripMenuItem.Name = "dailyTaskToolStripMenuItem";
            this.dailyTaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dailyTaskToolStripMenuItem.Text = "Daily Task";
            this.dailyTaskToolStripMenuItem.Click += new System.EventHandler(this.dailyTaskToolStripMenuItem_Click);
            // 
            // monthlyTaskToolStripMenuItem
            // 
            this.monthlyTaskToolStripMenuItem.Name = "monthlyTaskToolStripMenuItem";
            this.monthlyTaskToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.monthlyTaskToolStripMenuItem.Text = "Monthly Task";
            this.monthlyTaskToolStripMenuItem.Click += new System.EventHandler(this.monthlyTaskToolStripMenuItem_Click);
            // 
            // futureLogToolStripMenuItem
            // 
            this.futureLogToolStripMenuItem.Name = "futureLogToolStripMenuItem";
            this.futureLogToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.futureLogToolStripMenuItem.Text = "Future Log";
            this.futureLogToolStripMenuItem.Click += new System.EventHandler(this.futureLogToolStripMenuItem_Click);
            // 
            // dailyTaskToolStripMenuItem1
            // 
            this.dailyTaskToolStripMenuItem1.Name = "dailyTaskToolStripMenuItem1";
            this.dailyTaskToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.dailyTaskToolStripMenuItem1.Text = "Daily Task";
            // 
            // monthlyTaskToolStripMenuItem1
            // 
            this.monthlyTaskToolStripMenuItem1.Name = "monthlyTaskToolStripMenuItem1";
            this.monthlyTaskToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.monthlyTaskToolStripMenuItem1.Text = "Monthly Task";
            // 
            // futureLogToolStripMenuItem1
            // 
            this.futureLogToolStripMenuItem1.Name = "futureLogToolStripMenuItem1";
            this.futureLogToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.futureLogToolStripMenuItem1.Text = "Future Log";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Bullet Journal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_index.ResumeLayout(false);
            this.tab_index.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_index)).EndInit();
            this.tab_Daily_Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_dailyTask)).EndInit();
            this.tab_Monthly_Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_monthly)).EndInit();
            this.tab_Future_Log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_futureLog)).EndInit();
            this.tab_Collection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_collection)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_index;
        private System.Windows.Forms.TabPage tab_Future_Log;
        private System.Windows.Forms.TabPage tab_Monthly_Task;
        private System.Windows.Forms.TabPage tab_Daily_Task;
        private System.Windows.Forms.TabPage tab_Collection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGrid_monthly;
        private System.Windows.Forms.DataGridView dataGrid_dailyTask;
        private System.Windows.Forms.Button btn_addDailyTask;
        private System.Windows.Forms.Button btn_addMonthlyTask;
        private System.Windows.Forms.DataGridView dataGrid_index;
        private System.Windows.Forms.Button btn_addFutureLog;
        private System.Windows.Forms.DataGridView dataGrid_futureLog;
        private System.Windows.Forms.Button btn_addCollection;
        private System.Windows.Forms.DataGridView dataGrid_collection;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_refresh;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem migrate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toExistingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem futureLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monthlyTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem futureLogToolStripMenuItem1;
    }
}

