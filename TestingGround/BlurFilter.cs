using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TestingGround
{
        // This fiter is not working yet, STILL WIP

	// Blur
	public class BlurFilter
	{
        public WriteableBitmap wBitmap;
        int drawlineX = 200;
        Random random = new Random();

        void CreateGraphics(int height, int width, Image Viewport)
        {
            wBitmap = BitmapFactory.New(width, height);


            Viewport.Source = wBitmap;

            // Background Color
            wBitmap.FillRectangle(0, 0, width, height, Colors.Gray);
            wBitmap.FillEllipseCentered(drawlineX, 200, 20, 20, Color.FromArgb(255, 255, 255, 255));
        }

        public void ScreenGraphics(WriteableBitmap blurBitmap, Image BlurPort, int width, int height)
        {
            WriteableBitmap tempBitmap = blurBitmap;
            blurBitmap = tempBitmap;
            BlurPort.Source = blurBitmap;

            tempBitmap.FillRectangle(0, 0, width, height, Colors.Green);
            tempBitmap.FillTriangle(ranPosition(), ranPosition(), ranPosition(), ranPosition(), ranPosition(), ranPosition(), Colors.Red);
            tempBitmap.FillRectangle(30, 30, ranPosition(), ranPosition(), Colors.Beige);

            BlurPort.Source = blurBitmap;
        }

        int ranPosition()
        {
            int position;

            position = random.Next(40, 255);

            return position;
        }
    
        int LocalRandomPosition() 
        {
          // create a local random position variable
        }

        bool RandomOrNot(int value) 
        {
           if(value < 100)
           {
              return false;
           }
           return true;
        } 
    }
}
