using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

// Helpers for form filling
using ConnectionControl.FormHelper;
// Declare custom types
using ConnectionControl.CommonTypes;

using IpHlpApidotnet;

namespace ConnectionControl
{
    public partial class Form1 : Form
    {
        private CustomIPHlpApi _connection_params = new CustomIPHlpApi();
        private DataTable _table_content = new DataTable();

        private static System.Windows.Forms.Timer _refresh_table_view_timer = new System.Windows.Forms.Timer();

        static object TableRefreshLocker = new object();
        
        public Form1()
        {
            InitializeComponent();

            _connection_params.GetTcpConnections();
            _connection_params.RunRefreshHostName();
            RefreshTCPTableData();

            // Initialize timer and depend value
            //_table_view_timer_period = 1000;
            //_refresh_table_view_timer = new System.Timers.Timer(_table_view_timer_period);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleDataGridView.DataSource = null;
            simpleDataGridView.DataSource = _table_content;

            _refresh_table_view_timer.Interval = Convert.ToInt32(SecValueUpDown.Value) * 1000;
            _refresh_table_view_timer.Tick += new EventHandler(RefreshTableViewEvent);

            // Disable sotrting
            foreach (DataGridViewColumn column in simpleDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void simpleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshTCPTableView();
        }

        private void CloseSelectedConnection_Click(object sender, EventArgs e)
        {
            if (AutoRefreshCheckBox.CheckState == CheckState.Checked)
            {
                // Stop refresh timer for evade conflict
                _refresh_table_view_timer.Stop();
            }

            // Change button text and store previous value
            var old_button_text = CloseSelectedConnection.Text;
            CloseSelectedConnection.Text = "Wait...";

            // Lock button
            CloseSelectedConnection.Enabled = false;

            // TODO: this method of get selected row can not support sorting table
            var selected_row_content = _connection_params[simpleDataGridView.CurrentRow.Index];

            // Determine connection by local port
            TcpDisconnecter.Disconnecter.CloseLocalPort(selected_row_content.Local.Port);

            // Wait closing current connection
            System.Threading.Thread.Sleep(2000);

            // Immediate find close connections
            _connection_params.CheckForClosedConnections();
            // Refresh connection table content
            RefreshTCPTableView();
            
            //Return button text
            CloseSelectedConnection.Text = old_button_text;
            // Unlock button
            CloseSelectedConnection.Enabled = true;

            if (AutoRefreshCheckBox.CheckState == CheckState.Checked)
            {
                // Resume timer
                _refresh_table_view_timer.Start();
            }
        }

        private void StaticNumConLabel_Click(object sender, EventArgs e)
        {

        }

        private void NumConLabel_Click(object sender, EventArgs e)
        {

        }

        // Event after change table data. Call dependent actions inside
        private void simpleDataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            // Set connections number
            NumConLabel.Text = _connection_params.Count.ToString();
        }

        private void AutoRefreshCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRefreshCheckBox.CheckState == CheckState.Unchecked)
            {
                // Disable timer
                _refresh_table_view_timer.Stop();

                // Disable elements, related with refresh control
                StaticLabelForEvery.Enabled = false;
                SecValueUpDown.Enabled = false;
                StaticLabelForSec.Enabled = false;
            }
            else
            {
                // Set timer period
                //_refresh_table_view_timer.Interval = Convert.ToInt32(SecValueUpDown.Value)*1000;
                // Start timer
                _refresh_table_view_timer.Start();

                // Enable elements
                StaticLabelForEvery.Enabled = true;
                SecValueUpDown.Enabled = true;
                StaticLabelForSec.Enabled = true;
            }
        }

        private void SecValueUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Set new value for refresh timer
            _refresh_table_view_timer.Interval = Convert.ToInt32(SecValueUpDown.Value)*1000;
        }
        
        
        // Additional methods
        #region additional_methods

        private void RefreshTCPTableData()
        {
            _connection_params.RefreshTCP();
            if (_connection_params.Count > 0)
            {
                _table_content = TableMethods.GenerateDataSource(_connection_params.GetIPTableContent());
            }
        }

        private void RefreshTCPTableView()
        {
            // Save selected cell and view position for preaty refresh table content
            var old_selected_row_index = simpleDataGridView.CurrentRow.Index;
            var old_selected_column_index = simpleDataGridView.CurrentCell.ColumnIndex;
            var old_top_view_row = simpleDataGridView.FirstDisplayedScrollingRowIndex;

            lock (TableRefreshLocker)
            {
                RefreshTCPTableData();

                simpleDataGridView.DataSource = _table_content;
                if (simpleDataGridView.Rows.Count > old_selected_row_index)
                {
                    //simpleDataGridView.Rows[old_selected_row_index].Selected = true;
                    simpleDataGridView.CurrentCell = this.simpleDataGridView[old_selected_column_index, old_selected_row_index];

                    simpleDataGridView.FirstDisplayedScrollingRowIndex = old_top_view_row;
                }
                //BindingContext[simpleDataGridView.DataSource].EndCurrentEdit();
                //simpleDataGridView.Update();
                //simpleDataGridView.Refresh();
            }
        }

        // Action for Elapsed event
        private void RefreshTableViewEvent(object sender, EventArgs e)
        {
            RefreshTCPTableView();
        }

        #endregion
    }
}
