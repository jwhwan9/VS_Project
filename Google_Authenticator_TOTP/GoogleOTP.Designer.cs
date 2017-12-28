namespace Google_Authenticator_TOTP
{
    partial class GoogleOTP
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
            this.components = new System.ComponentModel.Container();
            this.txtIdentity = new System.Windows.Forms.TextBox();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.cmdOTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecretBase32 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecretHex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.txtHMAC = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTimeToGO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIdentity
            // 
            this.txtIdentity.Location = new System.Drawing.Point(84, 14);
            this.txtIdentity.Name = "txtIdentity";
            this.txtIdentity.Size = new System.Drawing.Size(183, 22);
            this.txtIdentity.TabIndex = 0;
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(84, 205);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(183, 22);
            this.txtOTP.TabIndex = 1;
            // 
            // cmdOTP
            // 
            this.cmdOTP.Location = new System.Drawing.Point(329, 12);
            this.cmdOTP.Name = "cmdOTP";
            this.cmdOTP.Size = new System.Drawing.Size(75, 23);
            this.cmdOTP.TabIndex = 2;
            this.cmdOTP.Text = "GenOTP";
            this.cmdOTP.UseVisualStyleBackColor = true;
            this.cmdOTP.Click += new System.EventHandler(this.cmdOTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secret Base32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "OTP";
            // 
            // txtSecretBase32
            // 
            this.txtSecretBase32.Location = new System.Drawing.Point(84, 60);
            this.txtSecretBase32.Name = "txtSecretBase32";
            this.txtSecretBase32.Size = new System.Drawing.Size(183, 22);
            this.txtSecretBase32.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Secret Hex";
            // 
            // txtSecretHex
            // 
            this.txtSecretHex.Location = new System.Drawing.Point(84, 92);
            this.txtSecretHex.Name = "txtSecretHex";
            this.txtSecretHex.Size = new System.Drawing.Size(183, 22);
            this.txtSecretHex.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Timestamp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "HMAC";
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Location = new System.Drawing.Point(84, 125);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(183, 22);
            this.txtTimestamp.TabIndex = 11;
            // 
            // txtHMAC
            // 
            this.txtHMAC.Location = new System.Drawing.Point(84, 255);
            this.txtHMAC.Name = "txtHMAC";
            this.txtHMAC.Size = new System.Drawing.Size(312, 22);
            this.txtHMAC.TabIndex = 12;
            // 
            // txtTimeToGO
            // 
            this.txtTimeToGO.AutoSize = true;
            this.txtTimeToGO.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTimeToGO.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTimeToGO.Location = new System.Drawing.Point(273, 205);
            this.txtTimeToGO.Name = "txtTimeToGO";
            this.txtTimeToGO.Size = new System.Drawing.Size(0, 24);
            this.txtTimeToGO.TabIndex = 13;
            // 
            // GoogleOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 375);
            this.Controls.Add(this.txtTimeToGO);
            this.Controls.Add(this.txtHMAC);
            this.Controls.Add(this.txtTimestamp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSecretHex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecretBase32);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.txtIdentity);
            this.Name = "GoogleOTP";
            this.Text = "Google Authenticator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdentity;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button cmdOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecretBase32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecretHex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.TextBox txtHMAC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtTimeToGO;
    }
}

