using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace WebInfoGather
{
    public partial class WebInfoGatherForm : Form
    {
        Dictionary<string, int> dictWebInfoLink;
        Dictionary<string, string> dictWebInfo;

        public WebInfoGatherForm()
        {
            InitializeComponent();
            InitRange();
        }

        private void InitRange()
        {

            this.webView.ScriptErrorsSuppressed = true;
            this.ddlRange.DisplayMember = "Text";
            this.ddlRange.ValueMember = "Value";
            List<Object> items = new List<Object>();
            items.Add(new { Text = "不限", Value = "" });
            items.Add(new { Text = "一小時內", Value = "&tbs=qdr:h" });
            items.Add(new { Text = "一天內", Value = "&tbs=qdr:d" });
            items.Add(new { Text = "一周內", Value = "&tbs=qdr:w" });
            items.Add(new { Text = "一個月內", Value = "&tbs=qdr:m" });
            items.Add(new { Text = "一年內", Value = "&tbs=qdr:y" });            

            this.ddlRange.DataSource = items;
            this.ddlRange.SelectedIndex = 3;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            
            // 此程式碼取出搜尋結果中關鍵的網頁原始碼，有需要的請自行對結果做字串處理 
            // 1. 將關鍵字送到Google做搜尋，取得搜尋結果網頁的原始碼 
            string url = @"https://www.google.com.tw/search?q=" + this.txtKeyword.Text + ddlRange.SelectedValue; // +"site:www.ptt.cc/bbs/&source=lnt&tbs=qdr:w";
            WebClient objWebClient = new WebClient();
            string strContext = System.Text.Encoding.Default.GetString(objWebClient.DownloadData(new Uri(url.Trim())));
            string myWebViewString = "";
            // 2. 從原始碼中取得搜尋出的網址與名稱 
            MatchCollection matches = Regex.Matches(strContext, @"<h3 class="+'"'+"r"+'"'+@">*(?<href>.+?)[\""'].+?></h3>");
            // MatchCollection matchesContent = Regex.Matches(strContext, "?<span class=\"st\">(*)</span>");

            int i = 0;
            foreach (Match m in matches)
            {
                string myTarget = m.Value.ToString();
                myTarget = myTarget.Replace("<h3 class=\"r\"><a href=\"/url?","");

                string myKeyword1 = "q=";
                string myKeyword2 = "&amp;";
                string myURL = myTarget.Substring(myTarget.IndexOf(myKeyword1) + myKeyword1.Length, myTarget.IndexOf(myKeyword2) - myKeyword1.Length);

                myKeyword2 = "\">";                
                myTarget = myTarget.Substring(myTarget.IndexOf(myKeyword2));
                myKeyword1 = "\">";
                myKeyword2 = @"</a>";
                string myText = myTarget.Substring(myTarget.IndexOf(myKeyword1) + myKeyword1.Length, myTarget.IndexOf(myKeyword2) - myKeyword1.Length);

                myTarget = myText + System.Environment.NewLine + myURL;
                this.txtResult.Text = this.txtResult.Text + myTarget + System.Environment.NewLine;

                myWebViewString = myWebViewString + "<a href=\"" + myURL + "\">" + myText + "</a><br>"; // +matchesContent[i].Value.ToString() + "<br>";
                i++;
            }
            this.webView.DocumentText = myWebViewString;
            
        }

        private void lblKey1_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey1.Text +" "+ this.txtKeyword.Text;
        }

        private void lblKey2_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey2.Text + " " + this.txtKeyword.Text;
        }


        private void lblKey3_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey3.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey21_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey21.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey22_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey22.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey23_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey23.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey24_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey24.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey25_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey25.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey31_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey31.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey32_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey32.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey33_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey33.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey34_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey34.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey35_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey35.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey36_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey36.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey37_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey37.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey38_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey38.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey4_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey4.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey5_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey5.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey6_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey6.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey7_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey7.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey26_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey26.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey27_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey27.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey28_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey28.Text + " " + this.txtKeyword.Text;
        }

        private void lblKey8_Click(object sender, EventArgs e)
        {
            this.txtKeyword.Text = this.lblKey8.Text + " " + this.txtKeyword.Text;
        }

        private void cmdSmart_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream("WebInfoKey.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string line;
                dictWebInfoLink = new Dictionary<string, int>();
                dictWebInfo = new Dictionary<string, string>();

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Trim() != "")
                    {
                        string[] strs = line.Split(':');
                        SearchKeyword(strs[0], int.Parse(strs[1]));
                        Thread.Sleep(800 + DateTime.Now.Millisecond);
                    }
                }
            }

                #region 根據權重，重新 Sorting
                 //進行排序
                var result = from pair in dictWebInfoLink
                             orderby pair.Value descending 
                             select pair;

                #region 根據 Sorting 產生 WebInfo 結果
                string myWebViewString = "";
                foreach (KeyValuePair<string, int> item in result)
                {                    
                    Console.WriteLine("{0}: {1}", item.Key, dictWebInfo[item.Key]);
                    myWebViewString = myWebViewString + "[" + dictWebInfoLink[item.Key] + "]" + dictWebInfo[item.Key] + "<br>"; 
                }
                                
                this.webView.DocumentText = myWebViewString;
                #endregion

                #endregion
            
        }

        private void SearchKeyword(string Keyword, int xFactor)
        {
            // 此程式碼取出搜尋結果中關鍵的網頁原始碼，有需要的請自行對結果做字串處理 
            // 1. 將關鍵字送到Google做搜尋，取得搜尋結果網頁的原始碼 
            string url = @"https://www.google.com.tw/search?q=" + Keyword + ddlRange.SelectedValue; // +"site:www.ptt.cc/bbs/&source=lnt&tbs=qdr:w";
            WebClient objWebClient = new WebClient();
            string strContext = System.Text.Encoding.Default.GetString(objWebClient.DownloadData(new Uri(url.Trim())));
            string myWebViewString = "";
            // 2. 從原始碼中取得搜尋出的網址與名稱 
            MatchCollection matches = Regex.Matches(strContext, @"<h3 class=" + '"' + "r" + '"' + @">*(?<href>.+?)[\""'].+?></h3>");
            // MatchCollection matchesContent = Regex.Matches(strContext, "?<span class=\"st\">(*)</span>");

            
            foreach (Match m in matches)
            {
                string myTarget = m.Value.ToString();
                myTarget = myTarget.Replace("<h3 class=\"r\"><a href=\"/url?", "");

                string myKeyword1 = "q=";
                string myKeyword2 = "&amp;";
                string myURL = myTarget.Substring(myTarget.IndexOf(myKeyword1) + myKeyword1.Length, myTarget.IndexOf(myKeyword2) - myKeyword1.Length);

                myKeyword2 = "\">";
                myTarget = myTarget.Substring(myTarget.IndexOf(myKeyword2));
                myKeyword1 = "\">";
                myKeyword2 = @"</a>";
                string myText = myTarget.Substring(myTarget.IndexOf(myKeyword1) + myKeyword1.Length, myTarget.IndexOf(myKeyword2) - myKeyword1.Length);

                // Console mode
                //myTarget = myText + System.Environment.NewLine + myURL;

                // Html mode
                myTarget = "<a href=\"" + myURL + "\">" + myText + "</a><br>";                


                #region  Check 是否為廣告
                int hitMyKeyCount = 0;
                string[] myKeyWords = Keyword.Split(' ');
                foreach (string myKey in myKeyWords)
                {
                    if (myTarget.Contains(myKey))
                    {
                        hitMyKeyCount++;
                    }
                }
                if (hitMyKeyCount == 0) continue;
                #endregion

                #region 將搜尋回的 Link 權重存回 Dictionary
                if (dictWebInfoLink.ContainsKey(myURL))
                {
                    dictWebInfoLink[myURL] = (int)dictWebInfoLink[myURL] + xFactor;
                }
                else
                {
                    // full info
                    dictWebInfo.Add(myURL, myTarget);
                    // to check exist or not
                    dictWebInfoLink.Add(myURL, xFactor);
                }
                #endregion

                
            }
        }

        private void webView_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = webView.Url.AbsoluteUri;
        }
        
    }
}
