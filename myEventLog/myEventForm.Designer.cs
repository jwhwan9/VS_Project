namespace myEventLog
{
    partial class myEventForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlServer = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmdQuery = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ddlEventType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numItems = new System.Windows.Forms.NumericUpDown();
            this.dtMax = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlServer
            // 
            this.ddlServer.FormattingEnabled = true;
            this.ddlServer.Items.AddRange(new object[] {
            "./",
            "MyWinPC"});
            this.ddlServer.Location = new System.Drawing.Point(12, 48);
            this.ddlServer.Name = "ddlServer";
            this.ddlServer.Size = new System.Drawing.Size(121, 20);
            this.ddlServer.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(267, 49);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(238, 22);
            this.txtFilter.TabIndex = 1;
            // 
            // cmdQuery
            // 
            this.cmdQuery.Location = new System.Drawing.Point(523, 47);
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Size = new System.Drawing.Size(75, 23);
            this.cmdQuery.TabIndex = 2;
            this.cmdQuery.Text = "Search";
            this.cmdQuery.UseVisualStyleBackColor = true;
            this.cmdQuery.Click += new System.EventHandler(this.cmdQuery_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(604, 48);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 89);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1324, 641);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // ddlEventType
            // 
            this.ddlEventType.FormattingEnabled = true;
            this.ddlEventType.Items.AddRange(new object[] {
            "電子商務",
            "Application",
            "System",
            "Security"});
            this.ddlEventType.Location = new System.Drawing.Point(140, 47);
            this.ddlEventType.Name = "ddlEventType";
            this.ddlEventType.Size = new System.Drawing.Size(121, 20);
            this.ddlEventType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Count:";
            // 
            // numItems
            // 
            this.numItems.Location = new System.Drawing.Point(427, 22);
            this.numItems.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numItems.Name = "numItems";
            this.numItems.Size = new System.Drawing.Size(76, 22);
            this.numItems.TabIndex = 8;
            // 
            // dtMax
            // 
            this.dtMax.Location = new System.Drawing.Point(270, 22);
            this.dtMax.Name = "dtMax";
            this.dtMax.Size = new System.Drawing.Size(149, 22);
            this.dtMax.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "查詢最後時間:";
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(523, 18);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(156, 23);
            this.pgBar.TabIndex = 11;
            this.pgBar.UseWaitCursor = true;
            // 
            // myEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 742);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtMax);
            this.Controls.Add(this.numItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlEventType);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdQuery);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.ddlServer);
            this.Name = "myEventForm";
            this.Text = "myEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlServer;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button cmdQuery;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox ddlEventType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numItems;
        private System.Windows.Forms.DateTimePicker dtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgBar;
    }
}

