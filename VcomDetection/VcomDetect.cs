using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;


namespace VcomDetection
{
    public partial class VcomDetect : Form
    {
        bool flag;
        public VcomDetect()
        {
            InitializeComponent();
        }

        public bool IsUsbDeviceConnected(string pid, string vid)
        {
            using (var searcher =
              new ManagementObjectSearcher(@"Select * From Win32_USBControllerDevice"))
            {
                using (var collection = searcher.Get())
                {
                    foreach (var device in collection)
                    {
                        var usbDevice = Convert.ToString(device);

                        if (usbDevice.Contains(pid) && usbDevice.Contains(vid))
                        {
                            usb_status.Image = Properties.Resources.connect;
                            connectBtn.Text = "Disconnect";
                            flag = true;
                            return true;
                        }
                        else
                        {
                            usb_status.Image = Properties.Resources.disconnect;
                        }

                    }
                }
            }
            return false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                string vidID, pidID;
                vidID = vid_textBox.Text;
                pidID = pid_textBox.Text;
                if (vidID == "" || pidID == "")
                {
                    MessageBox.Show("VID and PID cannot be left empty", "Message");
                }
                else
                {
                    IsUsbDeviceConnected(pidID, vidID);
                }
            }
            else
            {
                usb_status.Image = Properties.Resources.disconnect;
                connectBtn.Text = "Connect";
                flag = false;
            }            
        }
    }
}
