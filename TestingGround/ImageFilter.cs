using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TestingGround
{	
	// Transparency
	public static class ImageFilter
	{
		int trix = 0;
		
		// More filter ideas waiting in line atp
                // change Transparency level
		public static WriteableBitmap AlterTransparency(BitmapSource image, Byte alpha)
		{

			//	BitmapSource bitmapSource =
			//	Imaging.CreateBitmapSourceFromHBitmap(
			//image.GetHbitmap(), IntPtr.Zero, Int32Rect.Empty,
			//System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
			//	System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = new System.Windows.Media.Imaging.WriteableBitmap(bitmapSource);

			WriteableBitmap original = new WriteableBitmap(image);

			WriteableBitmap transparentImage = BitmapFactory.New((int)image.Width, (int)image.Height);

			Color c = Colors.Black;
			Color v = Colors.Black;

			for (int i = 0; i < image.Width; i++)
			{
				for (int j = 0; j < image.Height; j++)
				{
					c = original.GetPixel(i, j);
					v = Color.FromArgb(alpha, c.R, c.G, c.B);
					transparentImage.SetPixel(i, j, v);
				}
			}

			return transparentImage;
		}
		
		void SomeOtherGroundToTest()
		{
			// yes
		}
		
		private void NoFuge(int numbersOnly)
		{
			// no more fuge
		
		}
	}
}
