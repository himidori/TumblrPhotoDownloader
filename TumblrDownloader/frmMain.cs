using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Ini;

namespace TumblrDownloader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private const string TUMBLR_API_URL = "https://api.tumblr.com/v2/blog/{0}/posts/photo?api_key={1}&offset={2}";
        private const int PICTURES_PER_PAGE = 20;
        private int toDownload;
        private int downloaded;
        private bool isDownloading;
        private Queue<string> downloadQueue = new Queue<string>();
        private List<WebClient> webClients = new List<WebClient>();
        private Thread downloadThread;
        private Thread parsingThread;
        IniFile ini = new IniFile(Path.Combine(Application.StartupPath, "settings.ini"));

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            folderTXT.Text = fbd.SelectedPath;
        }

        private string getPageSource(string url)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                Stream stream = req.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(stream);
                return reader.ReadToEnd();
            }
            catch { }

            return string.Empty;
        }


        private void StopDownload()
        {
            while (downloadThread.IsAlive)
            {
                downloadThread.Abort();
            }
            while (parsingThread.IsAlive)
            {
                parsingThread.Abort();
            }

            foreach(var client in webClients)
            {
                client.CancelAsync();
            }

            webClients.Clear();
            Invoke(new MethodInvoker(() => downloadProgress.Value = 0));
            UpdateStatus("download stopped");
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            if (!isDownloading)
            {
                if (string.IsNullOrEmpty(apiKeyTXT.Text))
                {
                    MessageBox.Show("ApiKey is empty");
                    return;
                }

                if (string.IsNullOrEmpty(tumblrUserTXT.Text))
                {
                    MessageBox.Show("User was not specified");
                    return;
                }

                if (string.IsNullOrEmpty(folderTXT.Text) || !Directory.Exists(folderTXT.Text))
                {
                    MessageBox.Show("Specified directory is invalid");
                    return;
                }
                apiKeyTXT.Enabled = false;
                tumblrUserTXT.Enabled = false;
                browseBTN.Enabled = false;
                startBTN.Text = "Stop";
                downloadThread = new Thread(DownloadStuff) { IsBackground = true };
                downloadThread.Start();
            }

            else
            {
                StopDownload();
                isDownloading = false;
                apiKeyTXT.Enabled = true;
                tumblrUserTXT.Enabled = true;
                browseBTN.Enabled = true;
                startBTN.Text = "Start";
            }
        }


        private void DownloadStuff()
        {
            isDownloading = true;
            downloaded = 0;
            toDownload = 0;
            UpdateStatus("download started");
            parsingThread = new Thread(ParsePage) { IsBackground = true };
            parsingThread.Start();

            while (parsingThread.IsAlive)
            {
                while (downloadQueue.Count > 0)
                {
                    string url = downloadQueue.Dequeue();
                    string fileName = url.Substring(url.LastIndexOf('/') + 1);
                    Uri uri = new Uri(url);
                    webClients.Add(new WebClient());
                    webClients.Last().DownloadFileCompleted += frmMain_DownloadFileCompleted;
                    webClients.Last().DownloadFileAsync(uri, folderTXT.Text + "\\" + fileName);
                }
            }

            bool Done = false;
            while (!Done)
            {
                Done = true;
                foreach (var client in webClients.ToList())
                {
                    if (client.IsBusy)
                    {
                        Done = false;
                        break;
                    }
                    else
                    {
                        webClients.Remove(client);
                    }
                }
            }

            isDownloading = false;
            Invoke(new MethodInvoker(() => startBTN.Text = "Start"));
            Invoke(new MethodInvoker(() => downloadProgress.Value = 100));
            UpdateStatus("download finished");
            Invoke(new MethodInvoker(() => apiKeyTXT.Enabled = true));
            Invoke(new MethodInvoker(() => tumblrUserTXT.Enabled = true));
            Invoke(new MethodInvoker(() => browseBTN.Enabled = true));
            downloadQueue.Clear();
        }

        void frmMain_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) return;

            downloaded++;
            UpdateProgress(downloaded, toDownload);
            UpdateStatus(string.Format("{0} / {1}", downloaded, toDownload));
        }

        private void UpdateProgress(int downloaded, int total)
        {
            Invoke(new MethodInvoker(() => downloadProgress.Value = (downloaded * 100) / total));
        }

        private void ParsePage()
        {
            UpdateStatus("parsing started");
            string username = tumblrUserTXT.Text;
            string apikey = apiKeyTXT.Text;
            string source = getPageSource(string.Format(TUMBLR_API_URL, username, apikey, 0));
            Match match = Regex.Match(source, "\"total_posts\":(\\d+)");
            int totalPosts = int.Parse(match.Groups[1].Value);
            UpdateStatus(string.Format("tumblr blog has total of {0} posts", totalPosts));
            int totalPages = totalPosts / PICTURES_PER_PAGE;

            for (int page = 0; page <= totalPages; page++)
            {
                UpdateStatus("parsing page " + (page + 1));
                string response = getPageSource(string.Format(TUMBLR_API_URL, username, apikey, (page * 20)));
                MatchCollection matches = Regex.Matches(response, "\"original_size\":{\"url\":\"([^,]+)\"");
                toDownload += matches.Count;
                
                foreach(Match m in matches)
                {
                    downloadQueue.Enqueue(m.Groups[1].Value.Replace(@"\/", "/"));
                }

            }

            UpdateStatus("parsing finished");
        }

        private void UpdateStatus(string status)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => statusLBL.Text = string.Format("status: {0}", status)));
            }
            else
            {
                statusLBL.Text = string.Format("status: {0}", status);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Application.StartupPath, "settings.ini")))
            {
                apiKeyTXT.Text = ini.IniReadValue("Settings", "ApiKey");
                folderTXT.Text = ini.IniReadValue("Settings", "DownloadFolder");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(apiKeyTXT.Text) && !string.IsNullOrEmpty(folderTXT.Text))
            {
                ini.IniWriteValue("Settings", "ApiKey", apiKeyTXT.Text);
                ini.IniWriteValue("Settings", "DownloadFolder", folderTXT.Text);
            }
        }
    }
}
