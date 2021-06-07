using AForge.Imaging.Filters;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WebCam
{
    public partial class webCamForm : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public webCamForm()
        {
            InitializeComponent();
        }

        private void webCamForm_Load(object sender, EventArgs e)
        {
            ReloadNewDevices();
            LoadDefaultImage();
        }

        private void ReloadNewDevices()
        {
            cmbCamera.Items.Clear();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in filterInfoCollection)
            {
                cmbCamera.Items.Add(item.Name);
            }
            cmbCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void btnCameraStart_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                MessageBox.Show(string.Format("Camera:{0}  is already running", cmbCamera.SelectedItem));
                return;
            }
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmbCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            var bitmap = (Bitmap)eventArgs.Frame.Clone();
            var filter = new Mirror(false, true);
            filter.ApplyInPlace(bitmap);
            pbCamera.Image = bitmap;
        }

        private void webCamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!videoCaptureDevice.IsRunning)
            {
                MessageBox.Show("Camera is not running");
                return;
            }

            //videoCaptureDevice.Stop();
            videoCaptureDevice.SignalToStop();
            videoCaptureDevice.NewFrame -= VideoCaptureDevice_NewFrame;
            //videoCaptureDevice = null;
            //Thread.Sleep(1000);
            LoadDefaultImage();
        }

        private void LoadDefaultImage()
        {
            var bitMap = new Bitmap(@"C:\Users\Suman\source\repos\WebCam\WebCam\camera_btn.jpg");
            pbCamera.Image = bitMap;
        }
        private void Reload_Click(object sender, EventArgs e)
        {
            ReloadNewDevices();
        }
    }
}
