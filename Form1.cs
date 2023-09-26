using Aspose.Cells.Drawing;
using System;
using System.Windows.Forms;
using VirusTotalNet;

namespace SecOPs_security_suite
{
    public partial class Form1 : Form
    {


        private readonly VirusTotal virusTotal;

        public Form1()
        {
            InitializeComponent();


            // Initialize the VirusTotal API client
            VirusTotal virusTotal = new VirusTotal("720d9ff210ffff987fa962426fee12753766501b02ef4b21d30b5f10e3ac8a65");
            this.virusTotal = virusTotal;
            this.virusTotal.UseTLS = true;

            string computerName = Environment.MachineName;

            // Start a timer to update the date and time every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            //initialize webbrowser

            LoadLocalHtmlFile("file:///C:/Users/mawul/source/repos/SecOPs%20security%20suite/index.html");

        }

        private void LoadLocalHtmlFile(string filePath)
        {

            string url = new Uri(filePath).AbsoluteUri;
            webBrowser1.Navigate(url);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            // Update the label with the current date and time
            labelInfo.Text = "Computer Name: " + Environment.MachineName + "\n" +
                           "Date and Time: " + DateTime.Now.ToString();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void About_Click(object sender, EventArgs e)
        {
            // Display a message box about the application.
            MessageBox.Show("SecOPs Security Suite is a collectiton of Security tools for Organizations.", "About SecOPs", MessageBoxButtons.OK);
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Display a message box asking the user to confirm that they want to exit.
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Close the application.
                Application.Exit();
            }
        }

        private void UpdateSignatures_Click(object sender, EventArgs e)
        {

        }

        private void SendReport_Click(object sender, EventArgs e)
        {

        }

        private void Scandrives_Click(object sender, EventArgs e)
        {

        }

        private void Scanurl_Click(object sender, EventArgs e)
        {
            // Create a dialog box with a text box for the URL.
            var dialog = new DialogBox();
            dialog.Title = "Enter URL";
            dialog.Controls.Add(new System.Windows.Forms.TextBox { Text = "Enter URL here" });

            // Show the dialog box and get the URL.
            var url = dialog.ShowDialog();

            // If the user entered a URL, scan it.
            if (url != null)
            {
                // Create a VirusTotal API client.
                var client = new VirusTotalNetAPIClient("720d9ff210ffff987fa962426fee12753766501b02ef4b21d30b5f10e3ac8a65");

                // Get the scan results for the URL.
                var scanResults = client.ScanURL(url);

                // Display the scan results in WebBrowser1.
                webBrowser1.Navigate(scanResults.ToString());
            }
        }

        private void Scanfile_Click(object sender, EventArgs e)
        {

        }
    }

}
