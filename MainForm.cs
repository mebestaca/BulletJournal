﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BulletJournal
{

    //test commit

    public partial class MainForm : Form
    {
        DBTools db;
        JournalTask.EntryType entryType;

        int taskId;
        string title;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            string cn = Properties.Settings.Default.DatabaseConnectionString;
            db = new DBTools(cn);

            RefreshGrid();

            dateTimePicker.Value = DateTime.Today;
        }


        private void btn_refresh_Click(object sender, EventArgs e)
        {

            RefreshGrid();
        }

        public void RefreshGrid()
        {
            Populate_Collection();
            Populate_dailyTask();
            Populate_futureLog();
            Populate_monthly();
            Populate_index();
        }

        private void btn_addDailyTask_Click(object sender, EventArgs e)
        {
            using (DailyDescription category = new DailyDescription(JournalTask.EntryMode.add))
            {
                category.OnDailyMainSave += this.OnSave;
                category.ShowDialog();
            }
        }

        private void btn_addCollection_Click(object sender, EventArgs e)
        {
            using (CollectionDescription category = new CollectionDescription(JournalTask.EntryMode.add))
            {
                category.OnCategorySaved += this.OnSave;
                category.ShowDialog();
            }
        }

        public void Populate_index()
        {
            string commandString = "select Daily.Entry as Entry, " + //daily task
                                   "sum(Daily.Count) as Count, " +
                                   "sum(Daily.Tasks) as Tasks, " +
                                   "sum(Daily.Events) as Events, " +
                                   "sum(Daily.Notes) as Notes, " +
                                   "sum(Daily.Closed) as Closed " +
                                   "from ( " +
                                   "select 'Daily Tasks' as Entry, " +
                                   "count(*) as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from dailymain as m " +
                                   "inner join dailydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from dailymain " +
                                   "where taskdate = @taskdate) " +
                                   "union all " +
                                   "select 'Daily Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "count(*) as Tasks, " +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from dailymain as m " +
                                   "inner join dailydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from dailymain " +
                                   "where taskdate = @taskdate " +
                                   "and d.tasktype = 0) " +
                                   "union all " +
                                   "select 'Daily Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "count(*) as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from dailymain as m " +
                                   "inner join dailydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from dailymain " +
                                   "where taskdate = @taskdate " +
                                   "and d.tasktype = 1) " +
                                   "union all " +
                                   "select 'Daily Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "0 as Events, " +
                                   "count(*) as Notes, " +
                                   "0 as Closed " +
                                   "from dailymain as m " +
                                   "inner join dailydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from dailymain " +
                                   "where taskdate = @taskdate " +
                                   "and d.tasktype = 2) " +
                                   "union all " +
                                   "select 'Daily Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "count(*) as Closed " +
                                   "from dailymain as m " +
                                   "inner join dailydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from dailymain " +
                                   "where taskdate = @taskdate " +
                                   "and d.tasktype = 3) " +
                                   ") as Daily " +
                                   "group by Daily.Entry " +
                                   "union all " + // monthly tasks
                                   "select Monthly.Entry as Entry, " +
                                   "sum(Monthly.Count) as Count, " +
                                   "sum(Monthly.Tasks) as Tasks, " +
                                   "sum(Monthly.Events) as Events, " +
                                   "sum(Monthly.Notes) as Notes, " +
                                   "sum(Monthly.Closed) as Closed " +
                                   "from ( " +
                                   "select 'Monthly Tasks' as Entry, " +
                                   "count(*) as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from monthlymain as m " +
                                   "inner join monthlydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from monthlymain " +
                                   "where taskdate >= @monthlytaskdate) " +
                                   "and taskdate <= @monthlytaskdateEnd " +
                                   "union all " +
                                   "select 'Monthly Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "count(*) as Tasks, " +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from monthlymain as m " +
                                   "inner join monthlydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from monthlymain " +
                                   "where taskdate >= @monthlytaskdate " +
                                   "and taskdate <= @monthlytaskdateEnd " +
                                   "and d.tasktype = 0) " +
                                   "union all " +
                                   "select 'Monthly Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "count(*) as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from monthlymain as m " +
                                   "inner join monthlydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from monthlymain " +
                                   "where taskdate >= @monthlytaskdate " +
                                   "and taskdate <= @monthlytaskdateEnd " +
                                   "and d.tasktype = 1) " +
                                   "union all " +
                                   "select 'Monthly Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "0 as Events, " +
                                   "count(*) as Notes, " +
                                   "0 as Closed " +
                                   "from monthlymain as m " +
                                   "inner join monthlydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from monthlymain " +
                                   "where taskdate >= @monthlytaskdate " +
                                   "and taskdate <= @monthlytaskdateEnd " +
                                   "and d.tasktype = 2) " +
                                   "union all " +
                                   "select 'Monthly Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "count(*) as Closed " +
                                   "from monthlymain as m " +
                                   "inner join monthlydetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from monthlymain " +
                                   "where taskdate >= @monthlytaskdate " +
                                   "and taskdate <= @monthlytaskdateEnd " +
                                   "and d.tasktype = 3) " +
                                   ") as Monthly " +
                                   "group by Monthly.Entry " +
                                   "union all " + //futurelog
                                   "select Future.Entry as Entry, " +
                                   "sum(Future.Count) as Count, " +
                                   "sum(Future.Tasks) as Tasks, " +
                                   "sum(Future.Events) as Events, " +
                                   "sum(Future.Notes) as Notes, " +
                                   "sum(Future.Closed) as Closed " +
                                   "from ( " +
                                   "select 'Future Tasks' as Entry, " +
                                   "count(*) as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from futuremain as m " +
                                   "inner join futuredetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from futuremain " +
                                   "where taskdate >= @futureTaskdate " +
                                   "and taskdate <= @futureTaskdateEnd) " +
                                   "union all " +
                                   "select 'Future Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "count(*) as Tasks, " +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from futuremain as m " +
                                   "inner join futuredetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from futuremain " +
                                   "where taskdate >= @futureTaskdate " +
                                   "and taskdate <= @futureTaskdateEnd " +
                                   "and d.tasktype = 0) " +
                                   "union all " +
                                   "select 'Future Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "count(*) as Events, " +
                                   "0 as Notes, " +
                                   "0 as Closed " +
                                   "from futuremain as m " +
                                   "inner join futuredetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from futuremain " +
                                   "where taskdate >= @futureTaskdate " +
                                   "and taskdate <= @futureTaskdateEnd " +
                                   "and d.tasktype = 1) " +
                                   "union all " +
                                   "select 'Future Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks, " +
                                   "0 as Events, " +
                                   "count(*) as Notes, " +
                                   "0 as Closed " +
                                   "from futuremain as m " +
                                   "inner join futuredetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from futuremain " +
                                   "where taskdate >= @futureTaskdate " +
                                   "and taskdate <= @futureTaskdateEnd " +
                                   "and d.tasktype = 2) " +
                                   "union all " +
                                   "select 'Future Tasks' as Entry, " +
                                   "0 as Count, " +
                                   "0 as Tasks," +
                                   "0 as Events, " +
                                   "0 as Notes, " +
                                   "count(*) as Closed " +
                                   "from futuremain as m " +
                                   "inner join futuredetail as d " +
                                   "on m.taskid = d.maintaskforeignkey " +
                                   "where m.taskdate in (select taskdate " +
                                   "from futuremain " +
                                   "where taskdate >= @futureTaskdate " +
                                   "and taskdate <= @futureTaskdateEnd " +
                                   "and d.tasktype = 3) " +
                                   ") as Future " +
                                   "group by Future.Entry "; 

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taskdate", SqlDbType.Date) { Value = dateTimePicker.Value },
                new SqlParameter("@monthlytaskdate", SqlDbType.Date) { Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, 1) },
                new SqlParameter("@monthlytaskdateEnd", SqlDbType.Date) { Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month,
                                        DateTime.DaysInMonth(dateTimePicker.Value.Year, dateTimePicker.Value.Month)) },
                new SqlParameter("@futureTaskdate", SqlDbType.Date) { Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, 1) },
                new SqlParameter("@futureTaskdateEnd", SqlDbType.Date) { Value = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, 1).AddMonths(6) }
            };

            dataGrid_index.DataSource = db.GenericQueryAction(commandString, parameters);
            dataGrid_index.Columns["Entry"].Width = 120;
            dataGrid_index.Columns["Count"].Width = 70;
            dataGrid_index.Columns["Tasks"].Width = 70;
            dataGrid_index.Columns["Events"].Width = 70;
            dataGrid_index.Columns["Notes"].Width = 70;
            dataGrid_index.Columns["Closed"].Width = 70;

        }

        public void Populate_dailyTask()
        {
            string command = "select " +
                                   "a.taskid, " +
                                   "format(a.taskdate, 'dd/MM/yyyy') as [Date], " +
                                   "a.description as Description, " +
                                   "count(b.taskid) as [Contents] " +
                                   "from dailymain as a " +
                                   "left join dailydetail as b " +
                                   "on a.taskid = b.maintaskforeignkey " +
                                   "where a.taskdate >= @taskdate " +
                                   "and (a.description like @filter " +
                                   "or format(a.taskdate, 'dd/MM/yyyy') like @filter) " +
                                   "group by a.taskid, format(a.taskdate, 'dd/MM/yyyy') ,a.description " +
                                   "order by format(a.taskdate, 'dd/MM/yyyy'), a.taskid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taskdate", SqlDbType.Date) { Value = dateTimePicker.Value },
                new SqlParameter("@filter", SqlDbType.NVarChar) { Value = '%' + txt_dailySearch.Text + '%' }
            };


            dataGrid_dailyTask.DataSource = db.GenericQueryAction(command, parameters);

            dataGrid_dailyTask.Columns[0].Visible = false;
            dataGrid_dailyTask.Columns[0].Width = 1;
            dataGrid_dailyTask.Columns["Date"].Width = 70;
            dataGrid_dailyTask.Columns["Description"].Width = 332;
            dataGrid_dailyTask.Columns["Contents"].Width = 70;
        }

        

        public void Populate_monthly()
        {

            string command = "select " +
                                   "a.taskid, " +
                                   "format(a.taskdate, 'yyyy MMMM') as [Date], " +
                                   "a.description as Description, " +
                                   "count(b.taskid) as [Contents] " +
                                   "from monthlymain as a " +
                                   "left join monthlydetail as b " +
                                   "on a.taskid = b.maintaskforeignkey " +
                                   "where a.taskdate >= @taskdate " +
                                   "and (a.description like @filter " +
                                   "or format(a.taskdate, 'yyyy MMMM') like @filter) " +
                                   "group by a.taskid, format(a.taskdate, 'yyyy MMMM') ,a.description " +
                                   "order by format(a.taskdate, 'yyyy MMMM'), a.taskid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taskdate", SqlDbType.Date) { Value = dateTimePicker.Value },
                new SqlParameter("@filter", SqlDbType.NVarChar) { Value = '%' + txt_monthlySearch.Text + '%' }
            };


            dataGrid_monthly.DataSource = db.GenericQueryAction(command, parameters);

            dataGrid_monthly.Columns[0].Visible = false;
            dataGrid_monthly.Columns[0].Width = 1;
            dataGrid_monthly.Columns["Date"].Width = 90;
            dataGrid_monthly.Columns["Description"].Width = 310;
            dataGrid_monthly.Columns["Contents"].Width = 70;
        }

        public void Populate_futureLog()
        {
            string command = "select " +
                                   "a.taskid, " +
                                   "format(a.taskdate, 'yyyy MMMM') as [Date], " +
                                   "a.description as Description, " +
                                   "count(b.taskid) as [Contents] " +
                                   "from futuremain as a " +
                                   "left join futuredetail as b " +
                                   "on a.taskid = b.maintaskforeignkey " +
                                   "where a.taskdate >= @taskdate " +
                                   "and (a.description like @filter " +
                                   "or format(a.taskdate, 'yyyy MMMM') like @filter) " +
                                   "group by a.taskid, format(a.taskdate, 'yyyy MMMM') ,a.description " +
                                   "order by format(a.taskdate, 'yyyy MMMM'), a.taskid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@taskdate", SqlDbType.Date) { Value = dateTimePicker.Value },
                new SqlParameter("@filter", SqlDbType.NVarChar) { Value = '%' + txt_futureSearch.Text + '%' }
            };


            dataGrid_futureLog.DataSource = db.GenericQueryAction(command, parameters);

            dataGrid_futureLog.Columns[0].Visible = false;
            dataGrid_futureLog.Columns[0].Width = 1;
            dataGrid_futureLog.Columns["Date"].Width = 90;
            dataGrid_futureLog.Columns["Description"].Width = 310;
            dataGrid_futureLog.Columns["Contents"].Width = 70;
        }

        public void Populate_Collection()
        {
            string commandString = "select " +
                                   "a.collectionid, " +
                                   "a.collectionname as Category, " +
                                   "count(b.collectionid) as [Contents] " +
                                   "from collectionmain as a " +
                                   "left join collectiondetail as b " +
                                   "on a.collectionid = b.maintaskforeignkey " +
                                   "where a.collectionname like @filter " +
                                   "group by a.collectionid, a.collectionname";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@filter", SqlDbType.NVarChar) { Value = '%' + txt_collectionSearch.Text + '%' }
            };


            dataGrid_collection.DataSource = db.GenericQueryAction(commandString, parameters);

            dataGrid_collection.Columns[0].Visible = false;
            dataGrid_collection.Columns[0].Width = 1;
            dataGrid_collection.Columns["Category"].Width = 400;
            dataGrid_collection.Columns["Contents"].Width = 70;
        }

        private void btn_addFutureLog_Click(object sender, EventArgs e)
        {
            using (FutureDescription monthlyDescription = new FutureDescription(JournalTask.EntryMode.add))
            {
                monthlyDescription.OnFutureMainSave += this.OnSave;
                monthlyDescription.ShowDialog();
            }
        }

        private void btn_addMonthlyTask_Click(object sender, EventArgs e)
        {
            using (MonthlyDescription monthlyDescription = new MonthlyDescription(JournalTask.EntryMode.add))
            {
                monthlyDescription.OnMonthlyMainSave += this.OnSave;
                monthlyDescription.ShowDialog();
            }

        }

        private void dataGrid_dailyTask_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            // right click
            if (e.Button == MouseButtons.Right)
            {
                title = dataGrid_dailyTask.SelectedRows[0].Cells[2].Value.ToString();

                taskId = JournalTask.ContextMenuHandler(dataGrid_dailyTask, contextMenuStrip1, e);
                entryType = JournalTask.EntryType.daily;

                
            }
        }

        private void dataGrid_collection_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Right Click
            if (e.Button == MouseButtons.Right)
            {
                // Store id
                taskId = JournalTask.ContextMenuHandler(dataGrid_collection, contextMenuStrip1, e);

                contextMenuStrip1.Items["migrate"].Visible = false;
                entryType = JournalTask.EntryType.collection;
            }
        }


        private void dataGrid_monthly_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            // right click
            if (e.Button == MouseButtons.Right)
            {
                title = dataGrid_monthly.SelectedRows[0].Cells[2].Value.ToString();

                taskId = JournalTask.ContextMenuHandler(dataGrid_monthly, contextMenuStrip1, e);
                entryType = JournalTask.EntryType.monthly;
                
            }
        }

        private void dataGrid_futureLog_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            // right clock
            if (e.Button == MouseButtons.Right)
            {
                title = dataGrid_futureLog.SelectedRows[0].Cells[2].Value.ToString();

                taskId = JournalTask.ContextMenuHandler(dataGrid_futureLog, contextMenuStrip1, e);
                entryType = JournalTask.EntryType.future;
                
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (entryType == JournalTask.EntryType.daily)
            {

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                string commandString = "delete from dailymain " +
                                       "where taskid = @taskId";

                db.GenericNonQueryAction(commandString, parameters);

                parameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                commandString = "delete from dailydetail " +
                                "where maintaskforeignkey = @taskId";

                db.GenericNonQueryAction(commandString, parameters);

                RefreshGrid();
            }
            if (entryType == JournalTask.EntryType.monthly)
            {

                SqlParameter[] mainParameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                string mainString = "delete from monthlymain " +
                                       "where taskid = @taskId";

                db.GenericNonQueryAction(mainString, mainParameters);

                SqlParameter[] detailParameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                string detailString = "delete from monthlydetail " +
                                "where maintaskforeignkey = @taskId";

                db.GenericNonQueryAction(detailString, detailParameters);

                RefreshGrid();
            }
            if (entryType == JournalTask.EntryType.future)
            {

                SqlParameter[] mainParameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                string mainString = "delete from futuremain " +
                                       "where taskid = @taskId";

                db.GenericNonQueryAction(mainString, mainParameters);

                SqlParameter[] detailParameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                string detailString = "delete from futuredetail " +
                                "where maintaskforeignkey = @taskId";

                db.GenericNonQueryAction(detailString, detailParameters);

                Populate_futureLog();
                Populate_index();
            }

            if (entryType == JournalTask.EntryType.collection)
            {
                string mainCommand = "delete from collectionmain " +
                                       "where collectionid = @taskId";

                SqlParameter[] mainparameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                db.GenericNonQueryAction(mainCommand, mainparameters);

                string detailCommand = "delete from collectiondetail " +
                                       "where maintaskforeignkey = @taskId";

                SqlParameter[] detailParameters = new SqlParameter[]
                {
                    new SqlParameter("@taskId", SqlDbType.Int) { Value = taskId }

                };

                db.GenericNonQueryAction(detailCommand, detailParameters);

                RefreshGrid();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (entryType == JournalTask.EntryType.daily)
            {
                using (DailyDescription dailyTask = new DailyDescription(JournalTask.EntryMode.edit, taskId))
                {
                    dailyTask.OnDailyMainSave += OnSave;
                    dailyTask.ShowDialog();
                }
            }
            
            if (entryType == JournalTask.EntryType.monthly)
            {
                using (MonthlyDescription monthlyDescription = new MonthlyDescription(JournalTask.EntryMode.edit, taskId))
                {
                    monthlyDescription.OnMonthlyMainSave += this.OnSave;
                    monthlyDescription.ShowDialog();
                }
            }

            if (entryType == JournalTask.EntryType.future)
            {
                using (FutureDescription futureDescription = new FutureDescription(JournalTask.EntryMode.edit, taskId))
                {
                    futureDescription.OnFutureMainSave += this.OnSave;
                    futureDescription.ShowDialog();
                }
            }

            if (entryType == JournalTask.EntryType.collection)
            {
                
                using (CollectionDescription collectionDescription = new CollectionDescription( JournalTask.EntryMode.edit, taskId))
                {
                    collectionDescription.OnCategorySaved += OnSave;
                    collectionDescription.ShowDialog();
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            JournalTask.currentDay = dateTimePicker;
            RefreshGrid();
        }

        private void OnSave()
        {
            RefreshGrid();
        }

        private void dailyTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (Migration migration = new Migration(entryType, JournalTask.EntryType.daily, taskId, _title:title))
            {
                migration.OnMigrated += OnSave;
                migration.ShowDialog();

            }
        }

        private void monthlyTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (Migration migration = new Migration(entryType, JournalTask.EntryType.monthly, taskId, _title:title))
            {
                migration.OnMigrated += OnSave;
                migration.ShowDialog();
            }
        }

        private void futureLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Migration migration = new Migration(entryType, JournalTask.EntryType.future, taskId, _title:title))
            {
                migration.OnMigrated += OnSave;
                migration.ShowDialog();
            }
        }

        private void dailyTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (DailyDescription dailyDescription = new DailyDescription(JournalTask.EntryMode.migrate_main, taskId, _entryType: entryType))
            {
                dailyDescription.OnDailyMainSave += OnSave;
                dailyDescription.ShowDialog();
            }
        }

        private void monthlyTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (MonthlyDescription dailyDescription = new MonthlyDescription(JournalTask.EntryMode.migrate_main, taskId, _entryType: entryType))
            {
                dailyDescription.OnMonthlyMainSave += OnSave;
                dailyDescription.ShowDialog();
            }
        }

        private void futureLogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FutureDescription dailyDescription = new FutureDescription(JournalTask.EntryMode.migrate_main, taskId, _entryType: entryType))
            {
                dailyDescription.OnFutureMainSave += OnSave;
                dailyDescription.ShowDialog();
            }
        }

        private void txt_collectionSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txt_futureSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txt_monthlySearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void txt_dailySearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dataGrid_collection_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Left Click


            int colId = (int)dataGrid_collection.SelectedRows[0].Cells[0].Value;
            string title = dataGrid_collection.SelectedRows[0].Cells[1].Value.ToString();
            using (CollectionContent content = new CollectionContent(colId, title))
            {
                content.OnRefreshGrid += this.OnSave;
                content.ShowDialog();
            }
            
        }

        private void dataGrid_futureLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // left click

            int colId = (int)dataGrid_futureLog.SelectedRows[0].Cells[0].Value;
            string title = dataGrid_futureLog.SelectedRows[0].Cells[2].Value.ToString();

            using (FutureContent content = new FutureContent(colId, title))
            {
                content.OnRefreshGrid += this.OnSave;
                content.ShowDialog();
            }
            
        }

        private void dataGrid_monthly_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // left click

            int colId = (int)dataGrid_monthly.SelectedRows[0].Cells[0].Value;
            string title = dataGrid_monthly.SelectedRows[0].Cells[2].Value.ToString();
            using (MonthlyContent content = new MonthlyContent(colId, title))
            {
                content.OnRefreshGrid += this.OnSave;
                content.ShowDialog();
            }
            
        }

        private void dataGrid_dailyTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Left Click

            int colId = (int)dataGrid_dailyTask.SelectedRows[0].Cells[0].Value;
            string title = dataGrid_dailyTask.SelectedRows[0].Cells[2].Value.ToString();

            using (DailyContent content = new DailyContent(colId, title))
            {
                content.OnRefreshGrid += this.OnSave;
                content.ShowDialog();
            }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                txt_dailySearch.Focus();
            if (tabControl1.SelectedIndex == 2)
                txt_monthlySearch.Focus();
            if (tabControl1.SelectedIndex == 3)
                txt_futureSearch.Focus();
            if (tabControl1.SelectedIndex == 4)
                txt_collectionSearch.Focus();
        }
    }
}