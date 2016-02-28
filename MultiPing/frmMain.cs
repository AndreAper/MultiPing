using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace MultiPing
{
    public partial class frmMain : Form
    {
        string strSourceFile;
        List<string> listIpAddress;
        List<PingReply> listReply;
        StringBuilder sbOutputData;
        PingOptions poCustomOption;

        void ReadFile() 
        {
            if (File.Exists(strSourceFile))
            {
                string[] lines = File.ReadAllLines(strSourceFile);
                toolStripStatusLabelSelectedFile.Text = "Selected File: " + strSourceFile;
                toolStripStatusLabelLines.Text = "Lines: " + lines.Length;

                listIpAddress = new List<string>();

                foreach (string s in lines)
                {
                    listIpAddress.Add(s);
                }

                btnPerformPing.Visible = true;
            }
        }

        async void PerformPing() 
        {
            btnPerformPing.Visible = false;
            dataGridView.Rows.Clear();
            listReply = new List<PingReply>();
            sbOutputData = new StringBuilder();
            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = listIpAddress.Count;

            for (int i = 0; i < listIpAddress.Count; i++)
            {
                toolStripStatusLabelChecked.Text = "Checked: " + i.ToString();

                try
                {
                    PingReply pr = await SendAsync(listIpAddress[i]);

                    listReply.Add(pr);
                    toolStripProgressBar.PerformStep();

                    dataGridView.Rows.Add(listIpAddress[i], pr.Address.ToString(), pr.Buffer.Length.ToString(), pr.RoundtripTime.ToString(), pr.Status.ToString());
                    sbOutputData.AppendLine(listIpAddress[i] + ";" + pr.Address + ";" + pr.Buffer.Length.ToString() + ";" + pr.RoundtripTime.ToString() + ";" + pr.Status.ToString());
                }
                catch (Exception ex)
                {
                    dataGridView.Rows.Add(listIpAddress[i], null, null, null, ex.InnerException.Message);
                    sbOutputData.AppendLine(listIpAddress[i] + ";;;;FAILED: " + ex.InnerException.Message);
                }
            }

            toolStripProgressBar.Value = 0;
            btnExportToFile.Visible = true;
            btnPerformPing.Visible = true;
        }

        async Task<PingReply> SendAsync(string hostOrIp) 
        {
            Ping p = new Ping();
            return await p.SendPingAsync(hostOrIp);
        }

        public frmMain()
        {
            InitializeComponent();

            if (Properties.Settings.Default.SourceFile != null)
            {
                strSourceFile = Properties.Settings.Default.SourceFile;
                ReadFile(); 
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strSourceFile = ofd.FileName;
                Properties.Settings.Default.SourceFile = strSourceFile;
                Properties.Settings.Default.Save();

                ReadFile();
            }

        }

        private void btnPerformPing_Click(object sender, EventArgs e)
        {
            if (strSourceFile.Length != 0)
            {
                PerformPing();
            }
            else
            {
                MessageBox.Show("No Source File selected!");
            }
        }

        private void btnExportToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        sw.Write(sbOutputData.ToString());
                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
