namespace WebInfoGather
{
    partial class WebInfoGatherForm
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
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.webView = new System.Windows.Forms.WebBrowser();
            this.ddlRange = new System.Windows.Forms.ComboBox();
            this.lblKey1 = new System.Windows.Forms.Label();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.lblKey21 = new System.Windows.Forms.Label();
            this.lblKey22 = new System.Windows.Forms.Label();
            this.lblKey23 = new System.Windows.Forms.Label();
            this.lblKey24 = new System.Windows.Forms.Label();
            this.lblKey25 = new System.Windows.Forms.Label();
            this.lblKey3 = new System.Windows.Forms.Label();
            this.lblKey31 = new System.Windows.Forms.Label();
            this.lblKey32 = new System.Windows.Forms.Label();
            this.lblKey33 = new System.Windows.Forms.Label();
            this.lblKey34 = new System.Windows.Forms.Label();
            this.lblKey35 = new System.Windows.Forms.Label();
            this.lblKey36 = new System.Windows.Forms.Label();
            this.lblKey37 = new System.Windows.Forms.Label();
            this.lblKey38 = new System.Windows.Forms.Label();
            this.lblKey4 = new System.Windows.Forms.Label();
            this.lblKey5 = new System.Windows.Forms.Label();
            this.lblKey6 = new System.Windows.Forms.Label();
            this.lblKey7 = new System.Windows.Forms.Label();
            this.lblKey26 = new System.Windows.Forms.Label();
            this.lblKey27 = new System.Windows.Forms.Label();
            this.lblKey28 = new System.Windows.Forms.Label();
            this.lblKey8 = new System.Windows.Forms.Label();
            this.cmdSmart = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.progressBarSmart = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(533, 38);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(59, 23);
            this.cmdSearch.TabIndex = 0;
            this.cmdSearch.Text = "Search";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(21, 38);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(432, 22);
            this.txtKeyword.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(672, 1);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(18, 19);
            this.txtResult.TabIndex = 2;
            // 
            // webView
            // 
            this.webView.Location = new System.Drawing.Point(21, 161);
            this.webView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(656, 341);
            this.webView.TabIndex = 3;
            this.webView.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webView_DocumentCompleted);
            // 
            // ddlRange
            // 
            this.ddlRange.FormattingEnabled = true;
            this.ddlRange.Location = new System.Drawing.Point(459, 39);
            this.ddlRange.Name = "ddlRange";
            this.ddlRange.Size = new System.Drawing.Size(68, 20);
            this.ddlRange.TabIndex = 4;
            // 
            // lblKey1
            // 
            this.lblKey1.AutoSize = true;
            this.lblKey1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey1.Location = new System.Drawing.Point(282, 70);
            this.lblKey1.Name = "lblKey1";
            this.lblKey1.Size = new System.Drawing.Size(29, 12);
            this.lblKey1.TabIndex = 5;
            this.lblKey1.Text = "盜刷";
            this.lblKey1.Click += new System.EventHandler(this.lblKey1_Click);
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey2.Location = new System.Drawing.Point(317, 70);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(29, 12);
            this.lblKey2.TabIndex = 6;
            this.lblKey2.Text = "被駭";
            this.lblKey2.Click += new System.EventHandler(this.lblKey2_Click);
            // 
            // lblKey21
            // 
            this.lblKey21.AutoSize = true;
            this.lblKey21.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey21.Location = new System.Drawing.Point(282, 92);
            this.lblKey21.Name = "lblKey21";
            this.lblKey21.Size = new System.Drawing.Size(29, 12);
            this.lblKey21.TabIndex = 7;
            this.lblKey21.Text = "機票";
            this.lblKey21.Click += new System.EventHandler(this.lblKey21_Click);
            // 
            // lblKey22
            // 
            this.lblKey22.AutoSize = true;
            this.lblKey22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey22.Location = new System.Drawing.Point(317, 92);
            this.lblKey22.Name = "lblKey22";
            this.lblKey22.Size = new System.Drawing.Size(29, 12);
            this.lblKey22.TabIndex = 8;
            this.lblKey22.Text = "旅遊";
            this.lblKey22.Click += new System.EventHandler(this.lblKey22_Click);
            // 
            // lblKey23
            // 
            this.lblKey23.AutoSize = true;
            this.lblKey23.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey23.Location = new System.Drawing.Point(352, 92);
            this.lblKey23.Name = "lblKey23";
            this.lblKey23.Size = new System.Drawing.Size(29, 12);
            this.lblKey23.TabIndex = 9;
            this.lblKey23.Text = "訂房";
            this.lblKey23.Click += new System.EventHandler(this.lblKey23_Click);
            // 
            // lblKey24
            // 
            this.lblKey24.AutoSize = true;
            this.lblKey24.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey24.Location = new System.Drawing.Point(387, 92);
            this.lblKey24.Name = "lblKey24";
            this.lblKey24.Size = new System.Drawing.Size(29, 12);
            this.lblKey24.TabIndex = 10;
            this.lblKey24.Text = "飯店";
            this.lblKey24.Click += new System.EventHandler(this.lblKey24_Click);
            // 
            // lblKey25
            // 
            this.lblKey25.AutoSize = true;
            this.lblKey25.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey25.Location = new System.Drawing.Point(422, 92);
            this.lblKey25.Name = "lblKey25";
            this.lblKey25.Size = new System.Drawing.Size(29, 12);
            this.lblKey25.TabIndex = 11;
            this.lblKey25.Text = "酒店";
            this.lblKey25.Click += new System.EventHandler(this.lblKey25_Click);
            // 
            // lblKey3
            // 
            this.lblKey3.AutoSize = true;
            this.lblKey3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey3.Location = new System.Drawing.Point(352, 70);
            this.lblKey3.Name = "lblKey3";
            this.lblKey3.Size = new System.Drawing.Size(29, 12);
            this.lblKey3.TabIndex = 12;
            this.lblKey3.Text = "個資";
            this.lblKey3.Click += new System.EventHandler(this.lblKey3_Click);
            // 
            // lblKey31
            // 
            this.lblKey31.AutoSize = true;
            this.lblKey31.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey31.Location = new System.Drawing.Point(282, 112);
            this.lblKey31.Name = "lblKey31";
            this.lblKey31.Size = new System.Drawing.Size(29, 12);
            this.lblKey31.TabIndex = 13;
            this.lblKey31.Text = "網路";
            this.lblKey31.Click += new System.EventHandler(this.lblKey31_Click);
            // 
            // lblKey32
            // 
            this.lblKey32.AutoSize = true;
            this.lblKey32.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey32.Location = new System.Drawing.Point(317, 112);
            this.lblKey32.Name = "lblKey32";
            this.lblKey32.Size = new System.Drawing.Size(29, 12);
            this.lblKey32.TabIndex = 14;
            this.lblKey32.Text = "網購";
            this.lblKey32.Click += new System.EventHandler(this.lblKey32_Click);
            // 
            // lblKey33
            // 
            this.lblKey33.AutoSize = true;
            this.lblKey33.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey33.Location = new System.Drawing.Point(352, 112);
            this.lblKey33.Name = "lblKey33";
            this.lblKey33.Size = new System.Drawing.Size(29, 12);
            this.lblKey33.TabIndex = 15;
            this.lblKey33.Text = "易遊";
            this.lblKey33.Click += new System.EventHandler(this.lblKey33_Click);
            // 
            // lblKey34
            // 
            this.lblKey34.AutoSize = true;
            this.lblKey34.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey34.Location = new System.Drawing.Point(387, 112);
            this.lblKey34.Name = "lblKey34";
            this.lblKey34.Size = new System.Drawing.Size(29, 12);
            this.lblKey34.TabIndex = 16;
            this.lblKey34.Text = "易飛";
            this.lblKey34.Click += new System.EventHandler(this.lblKey34_Click);
            // 
            // lblKey35
            // 
            this.lblKey35.AutoSize = true;
            this.lblKey35.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey35.Location = new System.Drawing.Point(422, 112);
            this.lblKey35.Name = "lblKey35";
            this.lblKey35.Size = new System.Drawing.Size(29, 12);
            this.lblKey35.TabIndex = 17;
            this.lblKey35.Text = "雄獅";
            this.lblKey35.Click += new System.EventHandler(this.lblKey35_Click);
            // 
            // lblKey36
            // 
            this.lblKey36.AutoSize = true;
            this.lblKey36.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey36.Location = new System.Drawing.Point(457, 112);
            this.lblKey36.Name = "lblKey36";
            this.lblKey36.Size = new System.Drawing.Size(29, 12);
            this.lblKey36.TabIndex = 18;
            this.lblKey36.Text = "東南";
            this.lblKey36.Click += new System.EventHandler(this.lblKey36_Click);
            // 
            // lblKey37
            // 
            this.lblKey37.AutoSize = true;
            this.lblKey37.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey37.Location = new System.Drawing.Point(492, 112);
            this.lblKey37.Name = "lblKey37";
            this.lblKey37.Size = new System.Drawing.Size(29, 12);
            this.lblKey37.TabIndex = 19;
            this.lblKey37.Text = "可樂";
            this.lblKey37.Click += new System.EventHandler(this.lblKey37_Click);
            // 
            // lblKey38
            // 
            this.lblKey38.AutoSize = true;
            this.lblKey38.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey38.Location = new System.Drawing.Point(527, 112);
            this.lblKey38.Name = "lblKey38";
            this.lblKey38.Size = new System.Drawing.Size(29, 12);
            this.lblKey38.TabIndex = 20;
            this.lblKey38.Text = "康福";
            this.lblKey38.Click += new System.EventHandler(this.lblKey38_Click);
            // 
            // lblKey4
            // 
            this.lblKey4.AutoSize = true;
            this.lblKey4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey4.Location = new System.Drawing.Point(387, 70);
            this.lblKey4.Name = "lblKey4";
            this.lblKey4.Size = new System.Drawing.Size(29, 12);
            this.lblKey4.TabIndex = 21;
            this.lblKey4.Text = "外洩";
            this.lblKey4.Click += new System.EventHandler(this.lblKey4_Click);
            // 
            // lblKey5
            // 
            this.lblKey5.AutoSize = true;
            this.lblKey5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey5.Location = new System.Drawing.Point(422, 70);
            this.lblKey5.Name = "lblKey5";
            this.lblKey5.Size = new System.Drawing.Size(29, 12);
            this.lblKey5.TabIndex = 22;
            this.lblKey5.Text = "詐騙";
            this.lblKey5.Click += new System.EventHandler(this.lblKey5_Click);
            // 
            // lblKey6
            // 
            this.lblKey6.AutoSize = true;
            this.lblKey6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey6.Location = new System.Drawing.Point(457, 70);
            this.lblKey6.Name = "lblKey6";
            this.lblKey6.Size = new System.Drawing.Size(29, 12);
            this.lblKey6.TabIndex = 23;
            this.lblKey6.Text = "駭客";
            this.lblKey6.Click += new System.EventHandler(this.lblKey6_Click);
            // 
            // lblKey7
            // 
            this.lblKey7.AutoSize = true;
            this.lblKey7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey7.Location = new System.Drawing.Point(492, 70);
            this.lblKey7.Name = "lblKey7";
            this.lblKey7.Size = new System.Drawing.Size(29, 12);
            this.lblKey7.TabIndex = 24;
            this.lblKey7.Text = "入侵";
            this.lblKey7.Click += new System.EventHandler(this.lblKey7_Click);
            // 
            // lblKey26
            // 
            this.lblKey26.AutoSize = true;
            this.lblKey26.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey26.Location = new System.Drawing.Point(457, 92);
            this.lblKey26.Name = "lblKey26";
            this.lblKey26.Size = new System.Drawing.Size(29, 12);
            this.lblKey26.TabIndex = 25;
            this.lblKey26.Text = "訂票";
            this.lblKey26.Click += new System.EventHandler(this.lblKey26_Click);
            // 
            // lblKey27
            // 
            this.lblKey27.AutoSize = true;
            this.lblKey27.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey27.Location = new System.Drawing.Point(492, 92);
            this.lblKey27.Name = "lblKey27";
            this.lblKey27.Size = new System.Drawing.Size(28, 12);
            this.lblKey27.TabIndex = 26;
            this.lblKey27.Text = "OTA";
            this.lblKey27.Click += new System.EventHandler(this.lblKey27_Click);
            // 
            // lblKey28
            // 
            this.lblKey28.AutoSize = true;
            this.lblKey28.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey28.Location = new System.Drawing.Point(527, 92);
            this.lblKey28.Name = "lblKey28";
            this.lblKey28.Size = new System.Drawing.Size(41, 12);
            this.lblKey28.TabIndex = 27;
            this.lblKey28.Text = "信用卡";
            this.lblKey28.Click += new System.EventHandler(this.lblKey28_Click);
            // 
            // lblKey8
            // 
            this.lblKey8.AutoSize = true;
            this.lblKey8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKey8.Location = new System.Drawing.Point(527, 69);
            this.lblKey8.Name = "lblKey8";
            this.lblKey8.Size = new System.Drawing.Size(65, 12);
            this.lblKey8.TabIndex = 28;
            this.lblKey8.Text = "個資受害者";
            this.lblKey8.Click += new System.EventHandler(this.lblKey8_Click);
            // 
            // cmdSmart
            // 
            this.cmdSmart.Location = new System.Drawing.Point(599, 38);
            this.cmdSmart.Name = "cmdSmart";
            this.cmdSmart.Size = new System.Drawing.Size(62, 23);
            this.cmdSmart.TabIndex = 29;
            this.cmdSmart.Text = "Smart";
            this.cmdSmart.UseVisualStyleBackColor = true;
            this.cmdSmart.Click += new System.EventHandler(this.cmdSmart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(21, 133);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(656, 22);
            this.txtUrl.TabIndex = 30;
            // 
            // progressBarSmart
            // 
            this.progressBarSmart.Location = new System.Drawing.Point(533, 10);
            this.progressBarSmart.Name = "progressBarSmart";
            this.progressBarSmart.Size = new System.Drawing.Size(128, 23);
            this.progressBarSmart.TabIndex = 31;
            // 
            // WebInfoGatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 518);
            this.Controls.Add(this.progressBarSmart);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.cmdSmart);
            this.Controls.Add(this.lblKey8);
            this.Controls.Add(this.lblKey28);
            this.Controls.Add(this.lblKey27);
            this.Controls.Add(this.lblKey26);
            this.Controls.Add(this.lblKey7);
            this.Controls.Add(this.lblKey6);
            this.Controls.Add(this.lblKey5);
            this.Controls.Add(this.lblKey4);
            this.Controls.Add(this.lblKey38);
            this.Controls.Add(this.lblKey37);
            this.Controls.Add(this.lblKey36);
            this.Controls.Add(this.lblKey35);
            this.Controls.Add(this.lblKey34);
            this.Controls.Add(this.lblKey33);
            this.Controls.Add(this.lblKey32);
            this.Controls.Add(this.lblKey31);
            this.Controls.Add(this.lblKey3);
            this.Controls.Add(this.lblKey25);
            this.Controls.Add(this.lblKey24);
            this.Controls.Add(this.lblKey23);
            this.Controls.Add(this.lblKey22);
            this.Controls.Add(this.lblKey21);
            this.Controls.Add(this.lblKey2);
            this.Controls.Add(this.lblKey1);
            this.Controls.Add(this.ddlRange);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.cmdSearch);
            this.Name = "WebInfoGatherForm";
            this.Text = "WebInfoGatherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.WebBrowser webView;
        private System.Windows.Forms.ComboBox ddlRange;
        private System.Windows.Forms.Label lblKey1;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.Label lblKey21;
        private System.Windows.Forms.Label lblKey22;
        private System.Windows.Forms.Label lblKey23;
        private System.Windows.Forms.Label lblKey24;
        private System.Windows.Forms.Label lblKey25;
        private System.Windows.Forms.Label lblKey3;
        private System.Windows.Forms.Label lblKey31;
        private System.Windows.Forms.Label lblKey32;
        private System.Windows.Forms.Label lblKey33;
        private System.Windows.Forms.Label lblKey34;
        private System.Windows.Forms.Label lblKey35;
        private System.Windows.Forms.Label lblKey36;
        private System.Windows.Forms.Label lblKey37;
        private System.Windows.Forms.Label lblKey38;
        private System.Windows.Forms.Label lblKey4;
        private System.Windows.Forms.Label lblKey5;
        private System.Windows.Forms.Label lblKey6;
        private System.Windows.Forms.Label lblKey7;
        private System.Windows.Forms.Label lblKey26;
        private System.Windows.Forms.Label lblKey27;
        private System.Windows.Forms.Label lblKey28;
        private System.Windows.Forms.Label lblKey8;
        private System.Windows.Forms.Button cmdSmart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ProgressBar progressBarSmart;
    }
}

