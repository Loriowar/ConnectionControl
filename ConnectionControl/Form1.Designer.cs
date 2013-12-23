namespace ConnectionControl
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
            this.simpleDataGridView = new System.Windows.Forms.DataGridView();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CloseSelectedConnection = new System.Windows.Forms.Button();
            this.StaticNumConLabel = new System.Windows.Forms.Label();
            this.NumConLabel = new System.Windows.Forms.Label();
            this.RefreshGroup = new System.Windows.Forms.GroupBox();
            this.StaticLabelForSec = new System.Windows.Forms.Label();
            this.StaticLabelForEvery = new System.Windows.Forms.Label();
            this.SecValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.AutoRefreshCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.simpleDataGridView)).BeginInit();
            this.RefreshGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleDataGridView
            // 
            this.simpleDataGridView.AllowUserToAddRows = false;
            this.simpleDataGridView.AllowUserToDeleteRows = false;
            this.simpleDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.simpleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simpleDataGridView.Location = new System.Drawing.Point(12, 12);
            this.simpleDataGridView.MultiSelect = false;
            this.simpleDataGridView.Name = "simpleDataGridView";
            this.simpleDataGridView.ReadOnly = true;
            this.simpleDataGridView.Size = new System.Drawing.Size(791, 438);
            this.simpleDataGridView.TabIndex = 0;
            this.simpleDataGridView.DataSourceChanged += new System.EventHandler(this.simpleDataGridView_DataSourceChanged);
            this.simpleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.simpleDataGridView_CellContentClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.Location = new System.Drawing.Point(6, 19);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(101, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.Text = "Refresh now";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CloseSelectedConnection
            // 
            this.CloseSelectedConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseSelectedConnection.Location = new System.Drawing.Point(809, 29);
            this.CloseSelectedConnection.Name = "CloseSelectedConnection";
            this.CloseSelectedConnection.Size = new System.Drawing.Size(101, 23);
            this.CloseSelectedConnection.TabIndex = 2;
            this.CloseSelectedConnection.Text = "Close connection";
            this.CloseSelectedConnection.UseVisualStyleBackColor = true;
            this.CloseSelectedConnection.Click += new System.EventHandler(this.CloseSelectedConnection_Click);
            // 
            // StaticNumConLabel
            // 
            this.StaticNumConLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticNumConLabel.AutoSize = true;
            this.StaticNumConLabel.Location = new System.Drawing.Point(809, 437);
            this.StaticNumConLabel.Name = "StaticNumConLabel";
            this.StaticNumConLabel.Size = new System.Drawing.Size(120, 13);
            this.StaticNumConLabel.TabIndex = 3;
            this.StaticNumConLabel.Text = "Number of connections:";
            this.StaticNumConLabel.Click += new System.EventHandler(this.StaticNumConLabel_Click);
            // 
            // NumConLabel
            // 
            this.NumConLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumConLabel.AutoSize = true;
            this.NumConLabel.Location = new System.Drawing.Point(935, 437);
            this.NumConLabel.Name = "NumConLabel";
            this.NumConLabel.Size = new System.Drawing.Size(13, 13);
            this.NumConLabel.TabIndex = 4;
            this.NumConLabel.Text = "0";
            this.NumConLabel.Click += new System.EventHandler(this.NumConLabel_Click);
            // 
            // RefreshGroup
            // 
            this.RefreshGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshGroup.Controls.Add(this.StaticLabelForSec);
            this.RefreshGroup.Controls.Add(this.StaticLabelForEvery);
            this.RefreshGroup.Controls.Add(this.SecValueUpDown);
            this.RefreshGroup.Controls.Add(this.AutoRefreshCheckBox);
            this.RefreshGroup.Controls.Add(this.RefreshButton);
            this.RefreshGroup.Location = new System.Drawing.Point(812, 71);
            this.RefreshGroup.Name = "RefreshGroup";
            this.RefreshGroup.Size = new System.Drawing.Size(148, 111);
            this.RefreshGroup.TabIndex = 5;
            this.RefreshGroup.TabStop = false;
            this.RefreshGroup.Text = "Refresh options";
            // 
            // StaticLabelForSec
            // 
            this.StaticLabelForSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticLabelForSec.AutoSize = true;
            this.StaticLabelForSec.Enabled = false;
            this.StaticLabelForSec.Location = new System.Drawing.Point(114, 73);
            this.StaticLabelForSec.Name = "StaticLabelForSec";
            this.StaticLabelForSec.Size = new System.Drawing.Size(24, 13);
            this.StaticLabelForSec.TabIndex = 5;
            this.StaticLabelForSec.Text = "sec";
            // 
            // StaticLabelForEvery
            // 
            this.StaticLabelForEvery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StaticLabelForEvery.AutoSize = true;
            this.StaticLabelForEvery.Enabled = false;
            this.StaticLabelForEvery.Location = new System.Drawing.Point(33, 74);
            this.StaticLabelForEvery.Name = "StaticLabelForEvery";
            this.StaticLabelForEvery.Size = new System.Drawing.Size(33, 13);
            this.StaticLabelForEvery.TabIndex = 4;
            this.StaticLabelForEvery.Text = "every";
            // 
            // SecValueUpDown
            // 
            this.SecValueUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecValueUpDown.Enabled = false;
            this.SecValueUpDown.Location = new System.Drawing.Point(72, 72);
            this.SecValueUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.SecValueUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.SecValueUpDown.Name = "SecValueUpDown";
            this.SecValueUpDown.Size = new System.Drawing.Size(35, 20);
            this.SecValueUpDown.TabIndex = 3;
            this.SecValueUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.SecValueUpDown.ValueChanged += new System.EventHandler(this.SecValueUpDown_ValueChanged);
            // 
            // AutoRefreshCheckBox
            // 
            this.AutoRefreshCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoRefreshCheckBox.AutoSize = true;
            this.AutoRefreshCheckBox.Location = new System.Drawing.Point(7, 49);
            this.AutoRefreshCheckBox.Name = "AutoRefreshCheckBox";
            this.AutoRefreshCheckBox.Size = new System.Drawing.Size(83, 17);
            this.AutoRefreshCheckBox.TabIndex = 2;
            this.AutoRefreshCheckBox.Text = "Auto refresh";
            this.AutoRefreshCheckBox.UseVisualStyleBackColor = true;
            this.AutoRefreshCheckBox.CheckedChanged += new System.EventHandler(this.AutoRefreshCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 462);
            this.Controls.Add(this.RefreshGroup);
            this.Controls.Add(this.NumConLabel);
            this.Controls.Add(this.StaticNumConLabel);
            this.Controls.Add(this.CloseSelectedConnection);
            this.Controls.Add(this.simpleDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simpleDataGridView)).EndInit();
            this.RefreshGroup.ResumeLayout(false);
            this.RefreshGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecValueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView simpleDataGridView;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseSelectedConnection;
        private System.Windows.Forms.Label StaticNumConLabel;
        private System.Windows.Forms.Label NumConLabel;
        private System.Windows.Forms.GroupBox RefreshGroup;
        private System.Windows.Forms.Label StaticLabelForSec;
        private System.Windows.Forms.Label StaticLabelForEvery;
        private System.Windows.Forms.NumericUpDown SecValueUpDown;
        private System.Windows.Forms.CheckBox AutoRefreshCheckBox;

    }
}

