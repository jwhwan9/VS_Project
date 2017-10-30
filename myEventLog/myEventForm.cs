using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security;
using System.Threading;
using System.Management;

namespace myEventLog
{
    public partial class myEventForm : Form
    {
        static int MAX_EventCount = 100;
        static bool isExit = false;
        public myEventForm()
        {
            InitializeComponent();
            InitDateTimePicker();
            InitList();

            //this.dtMax.Format = DateTimePickerFormat.Time;
            //this.dtMax.ShowUpDown = true;
            numItems.Value = MAX_EventCount;
        }

        void InitDateTimePicker()
        {

            dtMax.Format = DateTimePickerFormat.Custom;
            dtMax.CustomFormat = "MM dd yyyy hh mm ss"; 
        }

        void InitList()
        {
            listView1.Columns.Add("No.", 50, HorizontalAlignment.Center);
            listView1.Columns.Add("Machine", 80, HorizontalAlignment.Center);
            listView1.Columns.Add("RecordNumber", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("TimeWritten", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("SourceName", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Message", 600, HorizontalAlignment.Left);

            ddlEventType.SelectedIndex = 0;
            ddlServer.SelectedIndex = 1;
        }

        void performSearch()
        {

            // Set cursor as hourglass
            //this.UseWaitCursor = true;
            //listView1.BeginUpdate();

            //gatherEvent(ddlServer.Text, txtFilter.Text.Trim(), ddlEventType.SelectedItem.ToString().Trim());
            /*
            try
            {
                gatherEvent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
             */
            //listView1.EndUpdate();
            // Set cursor as default arrow
            //this.UseWaitCursor = false;

        }

        void gatherEvent(string Machine_Name, string Keyword_Text, string Event_Type)
        {

            string machine = Machine_Name; //ddlServer.Text; 
            string keyword = Keyword_Text; //txtFilter.Text.Trim();
            string eventType = Event_Type; //ddlEventType.SelectedItem.ToString().Trim();

            //MessageBox.Show( machine);            
            EventLog aLog = new EventLog(eventType, machine);
            EventLogEntry entry;
            EventLogEntryCollection entries = aLog.Entries;

            int LastLogToShow = entries.Count;
            if (LastLogToShow <= 0)
            {
                //Console.WriteLine("No Event Logs in the Log :" + eventType);
            }
            else
            {

                // Progress Bar
                pgBar.Minimum = 0;
                pgBar.Maximum = (int)numItems.Value;

                for (int i = entries.Count - 1; i > 0 && listView1.Items.Count < numItems.Value; i--)
                {
                    if (isExit)
                    {
                        return;
                    }

                    entry = entries[i];

                    if (i == 0) break;

                    if (entry.Message.IndexOf(keyword) > 0 || txtFilter.Text == "")
                    {
                        /*
                        Console.WriteLine("[Index]\t" + entry.Index +
                                      "\n[EventID]\t" + entry.InstanceId +
                                      "\n[TimeWritten]\t" + entry.TimeWritten +
                                      "\n[MachineName]\t" + entry.MachineName +
                                      "\n[Source]\t" + entry.Source +
                                      "\n[UserName]\t" + entry.UserName +
                                      "\n[Message]\t" + entry.Message);

                        Console.WriteLine("-------------------------------------------------------------");
                         */
                        ListViewItem i1 = new ListViewItem("" + (listView1.Items.Count + 1));

                        // Machine
                        ListViewItem.ListViewSubItem sub_i0 = new ListViewItem.ListViewSubItem();
                        sub_i0.Text = machine;
                        i1.SubItems.Add(sub_i0);

                        // Record Number
                        ListViewItem.ListViewSubItem sub_i1 = new ListViewItem.ListViewSubItem();
                        sub_i1.Text = entry.Index.ToString();
                        i1.SubItems.Add(sub_i1);

                        // DateTime information
                        DateTime wkConditionDT = dtMax.Value;
                        DateTime wkEntryDT = entry.TimeWritten;

                        ListViewItem.ListViewSubItem sub_i2 = new ListViewItem.ListViewSubItem();
                        sub_i2.Text = entry.TimeWritten.ToString();
                        i1.SubItems.Add(sub_i2);

                        ListViewItem.ListViewSubItem sub_i3 = new ListViewItem.ListViewSubItem();
                        sub_i3.Text = entry.Source;
                        i1.SubItems.Add(sub_i3);

                        ListViewItem.ListViewSubItem sub_i4 = new ListViewItem.ListViewSubItem();
                        string sMsg = entry.Message;
                        sMsg = sMsg.Replace(@"中事件 ID '0' 的描述。本機電腦可能沒有所需的登錄資訊或訊息 DLL 檔案，因此無法顯示訊息，或者您可能沒有存取的使用權限。", "");
                        sub_i4.Text = sMsg.Replace(@"找不到來源", "");
                        i1.SubItems.Add(sub_i4);

                        if (DateTime.Compare(wkConditionDT, wkEntryDT) >= 0)
                        {
                            listView1.Items.Add(i1);
                        }

                        pgBar.Value = listView1.Items.Count;

                    }
                }
            }
            cmdQuery.Enabled = true;

        }

        private void cmdQuery_Click(object sender, EventArgs e)
        {
            cmdQuery.Enabled = false;

            Thread backgroundThread = new Thread(
        new ThreadStart(() =>
        {


            this.Invoke((MethodInvoker)delegate()
            {

                listView1.Items.Clear();
                gatherEvent(ddlServer.Text, txtFilter.Text.Trim(), ddlEventType.SelectedItem.ToString().Trim());
            });
            //performSearch();
        }
    ));
            backgroundThread.Start();



        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            isExit = true;
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // Use this since we are a WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Use this since we are a console app
                System.Environment.Exit(1);
            }
            Process.GetCurrentProcess().Kill();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            this.CopyListViewToClipboard(listView1);
        }

        public void CopyListViewToClipboard(ListView lv)
        {
            StringBuilder buffer = new StringBuilder();

            for (int i = 0; i < lv.Columns.Count; i++)
            {
                buffer.Append(lv.Columns[i].Text);
                buffer.Append("\t");
            }

            buffer.Append(System.Environment.NewLine);
            for (int i = 0; i < lv.Items.Count; i++)
            {
                for (int j = 0; j < lv.Columns.Count; j++)
                {
                    buffer.Append(lv.Items[i].SubItems[j].Text);
                    buffer.Append("\t");
                }

                buffer.Append(System.Environment.NewLine);
                buffer.Append("====================================================================");
                buffer.Append(System.Environment.NewLine);
            }

            Clipboard.SetText(buffer.ToString());
        }
    }
}
