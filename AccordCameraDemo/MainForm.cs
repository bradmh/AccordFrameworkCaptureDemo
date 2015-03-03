using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Extensions.Imaging;
using Accord.Extensions.Vision;

namespace AccordCameraDemo
{
    public partial class MainForm : Form
    {
    	ImageStreamReader _reader;
    	
        public MainForm()
        {
            InitializeComponent();
            
            this.picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            this.picPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            
            this.picCamera.Paint += picCamera_Paint;
            
            _reader = new CameraCapture(cameraIdx: 0);
            _reader.Open();
            
            this.FormClosing += MainForm_FormClosing;
            Application.Idle += Application_Idle;
            this.btnCapture.Click += btnCapture_Click;
            this.btnSave.Click += btnSave_Click;
        }

		void picCamera_Paint(object sender, PaintEventArgs e)
		{
			PictureBox picBox = sender as PictureBox;
			
			var pW = picBox.Width / 5 * 3;
			var pH = picBox.Height;
			
			Rectangle portraitBorder = 
				new Rectangle((picBox.Width - pW) / 2, 0, pW, pH);
			
			using (var pen = new Pen(Color.Red, 2))
			{
				e.Graphics.DrawRectangle(pen, portraitBorder);
			}
		}
		
        Image<Bgr, byte> _frame = null;
		void Application_Idle(object sender, EventArgs e)
		{
			_frame = _reader.ReadAs<Bgr, byte>();
			
			if(_frame == null)
			{
				Application.Idle -= Application_Idle;
				return;
			}
			
			var imgCaputre = _frame.ToBitmap();
			this.picCamera.Image = imgCaputre;
			GC.Collect();
		}
			
		void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(_reader != null)
				_reader.Dispose();
		}

		void btnCapture_Click(object sender, EventArgs e)
		{
			if(_frame != null)
			{
				var imgCapture = _frame.ToBitmap();
				
				var pW = imgCapture.Width / 5 * 3;
				var pH = imgCapture.Height;
			
				Rectangle portraitBorder = 
					new Rectangle((imgCapture.Width - pW) / 2, 0, pW, pH);
			
				var imgPortrait = imgCapture.Clone(portraitBorder, imgCapture.PixelFormat);
				
				this.picPortrait.Image = imgPortrait;
			}
		}

		void btnSave_Click(object sender, EventArgs e)
		{
			using (var dlg = new SaveFileDialog()) 
			{
				dlg.FileName = "portrait";
				dlg.DefaultExt = ".jpg";
				dlg.Filter = "JPeg Image|*.jpg";
				
				if(dlg.ShowDialog() == DialogResult.OK)
				{
					var fileName = dlg.FileName;
					
					this.picPortrait.Image.Save(fileName, ImageFormat.Jpeg);
				}
			}
		}
    }
}
