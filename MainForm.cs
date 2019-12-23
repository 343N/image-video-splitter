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
using System.Media;
using System.Collections;

namespace Video_and_GIF_Splitter
{
	public partial class MainForm : Form
	{

		String filePath = "";
		int segmentsX, segmentsY;
		SegmentHandler SH = new SegmentHandler();
		public MainForm()
		{
			InitializeComponent();
			String dir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Pictures";
			openFileDialog1.InitialDirectory = dir;
			exportImages.InitialDirectory = dir;
			Console.WriteLine(dir);
			SH.segnx = (int)segmentsHoriz.Value;
			SH.segny = (int)segmentsVert.Value;
			SH.segsx = (int)segmentWidth.Value;
			SH.segsy = (int)segmentHeight.Value;
		}




		private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Console.WriteLine("Opening dialog...");
			ToolStripMenuItem menu = (ToolStripMenuItem)sender;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				filePath = openFileDialog1.FileName;

				Stream fileStream = openFileDialog1.OpenFile();
				Image img = Image.FromStream(fileStream);

				this.pictureBox1.Image = img;

				segmentWidth.Maximum = img.Width;
				segmentHeight.Maximum = img.Height;
				segmentWidth.Value = img.Width / segmentsHoriz.Value;
				segmentHeight.Value = img.Height / segmentsVert.Value;

				segmentWidth.Increment = (decimal)(img.Width * 0.01);
				segmentHeight.Increment = (decimal)(img.Height * 0.01);
			};


		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			Image curImg = pictureBox1.Image;
			base.OnPaint(e);
			//Console.WriteLine(DateTime);
			if (curImg != null)
			{
				int[] size = getPictureBoxScaledImgSize(pictureBox1);
				if (size != null)
				{
					int leftEdge = (pictureBox1.Width / 2) - (size[0] / 2);
					int topEdge = (pictureBox1.Height / 2) - (size[1] / 2);
					SH.basex = leftEdge;
					SH.basey = topEdge;
					SH.segScale = getPictureBoxImgScale(pictureBox1);
					//SegmentScaleLabel.Text = "Segment Scale: " + SH.segScale;
					SH.initSegments();
					SH.drawAllSegments(g);
					imageSizeReal.Text = "Real Image Size: " + curImg.Width + ", " + curImg.Height;
					String scaleLabelTxt = "Scaled Image Size: " + size[0] + ", " + size[1] + "";
					scaleLabelTxt += " (x" + Math.Round(SH.segScale, 3) + ")";
					imageSizeScaled.Text = scaleLabelTxt;

				}
			}

		}

		private int[] getPictureBoxScaledImgSize(PictureBox pb)
		{
			if (pb.Image == null) return null;
			Image img = pb.Image;
			if (img.Height == 0 || img.Width == 0 || pb.Height == 0 || pb.Width == 0) return null;
			int X = 0, Y = 0;
			float ar = (float)img.Width / img.Height;
			switch (getDominantAxis(pb.Width, pb.Height, ar))
			{
				case "H":
					X = pb.Width;
					Y = (int)(img.Height * ((float)pb.Width / (float)img.Width));
					break;
				case "W":
					X = (int)(img.Width * ((float)pb.Height / (float)img.Height));
					Y = pb.Height;
					break;
				default:
				case null:
					return null;
			}

			return new int[] { X, Y };

		}

		private decimal getPictureBoxImgScale(PictureBox pb)
		{
			if (pb == null) return 0;
			decimal scale = ((decimal)getPictureBoxScaledImgSize(pb)[0] / pb.Image.Width);
			return scale;
		}


		private String getDominantAxis(int X, int Y, float aspectratio)
		{
			if (aspectratio == 0) return null;
			int res = (int)Math.Round((decimal)(X / aspectratio), 0);
			return (res > Y) ? "W" : "H";
		}



		private void segmentsHoriz_ValueChanged(object sender, EventArgs e)
		{
			SH.segnx = (int)segmentsHoriz.Value;
			pictureBox1.Invalidate();
		}

		private void segmentsVert_ValueChanged(object sender, EventArgs e)
		{
			SH.segny = (int)segmentsVert.Value;
			pictureBox1.Invalidate();
		}


		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			SH.shouldDraw = checkBox1.Checked;
			pictureBox1.Invalidate();
		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null) return;
			ToolStripMenuItem menu = (ToolStripMenuItem)sender;
			exportImages.Filter = "PNG image|*.png|Jpg image|*.jpg|Bitmap image|*.bmp";
			exportImages.Title = "Export Images";
			exportImages.ShowDialog();


			if (exportImages.FileName != "")
			{
				checkBox1.Checked = false;
				pictureBox1.Invalidate();
				//Image img = pictureBox1.Image;
				Bitmap bmp = (Bitmap)pictureBox1.Image;
				ArrayList segments = SH.getSegmentsReal();
				int fileCount = 0;
				String fn = getFileName(exportImages.FileName);
				String fd = getFileDirectory(exportImages.FileName);
				String fext = getFileExtension(exportImages.FileName);
				foreach (Segment s in segments)
				{

					Bitmap clone = bmp.Clone(new Rectangle(s.x, s.y, s.sx, s.sy), bmp.PixelFormat);
					FileStream fs = new FileStream(fd + fn + fileCount + "." + fext, FileMode.Create);
					fileCount++;
					switch (exportImages.FilterIndex)
					{
						case 1:
							clone.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
							break;

						case 2:
							clone.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
							break;
						case 3:
							clone.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
							break;
					}

					fs.Dispose();
				}


			}
		}


		private void exportImages_FileOk(object sender, CancelEventArgs e)
		{
			Console.WriteLine("EXPORT START!");
			if (exportImages.FileName != "")
			{

				Console.WriteLine(exportImages.FileName);
			}
		}

		//private void formatFilename(String n)
		//{

		//}

		private String getFileName(String str)
		{
			String fn = getFullFileName(str);
			String ext = getFileExtension(fn);
			if (ext == null) return fn;
			return fn.Substring(0, fn.Length - ext.Length - 1);
		}

		private String getFullFileName(String fn)
		{
			String[] path = fn.Split('\\');
			String[] periods = fn.Split('.');

			return path[path.Length - 1];
		}

		private String getFileExtension(String fn)
		{
			String[] periods = fn.Split('.');
			String ext = periods[periods.Length - 1];
			if (periods.Length < 2 || ext.Length == 0)
			{
				return null;
			}
			return ext;
		}

		private string getFileDirectory(String f)
		{
			return f.Substring(0, f.LastIndexOf("\\") + 1);
		}

		private void segmentHeight_ValueChanged(object sender, EventArgs e)
		{
			SH.segsy = (int)segmentHeight.Value;
			pictureBox1.Invalidate();
		}

		private void segmentWidth_ValueChanged(object sender, EventArgs e)
		{
			SH.segsx = (int)segmentWidth.Value;
			pictureBox1.Invalidate();
		}

		private void autoSegmentSize_Click(object sender, EventArgs e)
		{
			Image img = pictureBox1.Image;
			segmentWidth.Value = (int)Math.Round((decimal)img.Width / SH.segnx);
			segmentHeight.Value = (int)Math.Round((decimal)img.Height / SH.segny);
		}

		private void autoSegment_Click(object sender, EventArgs e)
		{
			Image img = pictureBox1.Image;
			int[] scaledSize = getPictureBoxScaledImgSize(pictureBox1);
			if (img == null) return;
			segmentsHoriz.Value = (int)Math.Floor((decimal)img.Width / SH.segsx);
			segmentsVert.Value = (int)Math.Floor((decimal)img.Height / SH.segsy);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			//pictureBox1.Width = MainForm.ActiveForm.Width - panel1.Width;
		}

		private void SegmentScaleLabel_Click(object sender, EventArgs e)
		{

		}

		private void imageSizeScaled_Click(object sender, EventArgs e)
		{

		}

		private void imageSizeReal_Click(object sender, EventArgs e)
		{

		}

		private void transparentSlider_ValueChanged(object sender, EventArgs e)
		{
			pictureBox1.Invalidate();
		}


	}
}
