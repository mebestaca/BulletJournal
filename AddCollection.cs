﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletJournal
{
    public partial class AddCollection : Form
    {
        DBTools db;

        MainForm main;

        public AddCollection()
        {
            InitializeComponent();
            db = new DBTools(Properties.Settings.Default.DatabaseConnectionString);
            cmb_taskType.SelectedIndex = 0;
        }

        public AddCollection(MainForm m)
        {
            InitializeComponent();
            db = new DBTools(Properties.Settings.Default.DatabaseConnectionString);
            main = m;
            cmb_taskType.SelectedIndex = 0;

        }

        private void ClearForm()
        {
            txt_taskDescription.Text = "";
            cmb_taskType.Text = "";
            chk_important.Checked = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = JournalTask.GetTask(cmb_taskType.Text);
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@desc", SqlDbType.NVarChar) { Value = txt_taskDescription.Text  },
                new SqlParameter("tasktype", SqlDbType.Int) { Value = JournalTask.GetTask(cmb_taskType.Text)},
                new SqlParameter("isImportant", SqlDbType.Bit) { Value = chk_important.Checked}
            };
            string command = "insert into collectiontable (taskdescription, tasktype, taskisimportant) " +
                             "values (@desc, @tasktype, @isImportant)";

            db.GenericNonQueryAction(command, parameters);
            main.Populate_collection();
            ClearForm();

        }
    }
}