using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestingGround
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary
	
	//
	// This project will soon be closed and a new one will replace it. (this is too old, lets start fresh)
	//
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			CreateMultiDimensionalArray();
			CreateJaggedArray();

			MixedOperations();

            tabBlur.Background = Brushes.LightGreen;

            Debug.WriteLine("Random Number is: " + RandomNumberCreator.RandomNum(1, 500).ToString());

            anim = new SimpleAnimation();
        }

		private void Viewport_Loaded(object sender, RoutedEventArgs e)
		{
			width = (int)this.ViewPortContainer.ActualWidth;
			height = (int)this.ViewPortContainer.ActualHeight;
			wBitmap = BitmapFactory.New(width, height);
			

			Viewport.Source = wBitmap;

			// Background Color
			wBitmap.FillRectangle(0, 0, width, height, Colors.Gray);

			//CompositionTarget.Rendering += CompositionTarget_Rendering;

			//wBitmap.FillEllipseCentered(drawlineX, 200, 20, 20, 200, true);
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, 200, true);
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, 200, true);
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, 200, true);
			wBitmap.FillEllipseCentered(drawlineX, 200, 20, 20, Color.FromArgb(255, 255, 255, 255));
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, Color.FromArgb(40, 200, 40, 10));
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, Color.FromArgb(40, 200, 40, 10));
			//wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, Color.FromArgb(40, 200, 40, 10));



		}

		private void CompositionTarget_Rendering(object sender, EventArgs e)
		{
			wBitmap.Clear();
			
			wBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, 200, true);
			if(drawlineX > width)
			{
				drawlineX = 0;
			}
		}

		void MixedOperations()
		{
			int i = 0;
			foreach (var item in makeList.names)
			{
				comboBox.Items.Add(makeList.names[i]);
				i++;
			}

			i = 0;
			foreach (var item in makeList.names)
			{
				listBox.Items.Add(makeList.names[i]);
				i++;
			}

			comboBox.SelectedIndex = 0;

			if (!Directory.Exists(importTexts.myPath))
			{
				importTexts.CreateBooksDir();
			}

			for (int j = 0; j < 100; j++)
			{
				makeListConvert.Add(j);
			}
			int[] arrayList = ListToArrayConvert(makeListConvert);

			foreach (var item in arrayList)
			{
				Debug.WriteLine(item);
			}

			for (int ij = 0; ij < 100; ij++)
			{
				makeDictionary.Add(ij, ij.ToString() + "ABC");
			}

			foreach (var item in makeDictionary)
			{
				Debug.Write(item.Key.ToString() + " " + item.Value);
			}

			makeListConvert.Reverse();

			foreach (var item in makeListConvert)
			{
				Debug.WriteLine(item);
			}
			Debug.WriteLine("");

			// LINQ
			var elements = makeListConvert.SkipWhile((n, index) => n >= index);

			foreach (var item in elements)
			{
				Debug.WriteLine(item);
			}

			Debug.WriteLine("");

			foreach (var item in makeListConvert)
			{
				if (item.ToString().EndsWith("9"))
				{
					Debug.WriteLine(item);
				}
			}
			Debug.WriteLine("");
			makeListConvert.Clear();
			for (int u = 0; u < 50; u++)
			{
				makeListConvert.Add(random.Next(0, 3000));
			}
			foreach (var item in makeListConvert)
			{
				Debug.WriteLine(item.ToString());
			}

			// Rectangle in Debug Output
			rectConsl.CreateRectangle();
		}

		int[] ListToArrayConvert(List<int> list)
		{
			int[] listArray = list.ToArray();
			return listArray;
		}

		void CreateMultiDimensionalArray()
		{
			// set certain bools in array to true
			for (int ij = 0; ij < barrowedBooks.GetLength(0); ij++)
			{
				for (int j = 0; j < barrowedBooks.GetLength(1); j++)
				{
					if (ij == 0 && j == 3)
					{
						barrowedBooks[ij, j] = true;
					}

					if (ij == 2 && j == 8)
					{
						barrowedBooks[ij, j] = true;
					}
				}
			}

			// Multidimensional Array[,] Visualized
			for (int ij = 0; ij < barrowedBooks.GetLength(0); ij++)
			{
				for (int j = 0; j < barrowedBooks.GetLength(1); j++)
				{
					Debug.Write(barrowedBooks[ij, j] + " ");
				}
				Debug.WriteLine("");
			}
		}

		void CreateJaggedArray()
		{
			jaggedArrayStuff[0] = new bool[] { false, true, false, false, false, true };
			jaggedArrayStuff[1] = new bool[] { false, true };
			jaggedArrayStuff[2] = new bool[] { false, true, false, true };
			jaggedArrayStuff[3] = new bool[] { true, true, false, false, false, true };
			jaggedArrayStuff[4] = new bool[] { true, false, false, false, false };

			for (int jag = 0; jag < jaggedArrayStuff.Length; jag++)
			{
				for (int jagjag = 0; jagjag < jaggedArrayStuff[jag].Length; jagjag++)
				{
					Debug.Write(jaggedArrayStuff[jag][jagjag] + " ");
				}
				Debug.WriteLine("");
			}

			Debug.WriteLine("jagged array, third array count: " + jaggedArrayStuff[2].Length.ToString());
		}

		private void Viewport_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			// something is not right here

			WriteableBitmap tempBitmap = wBitmap;
			this.Title = "Testing Ground (Loading MotionBlur)";
			ImageFilter.AlterTransparency(tempBitmap, 70);
			this.Title = "Testing Ground";
			//wBitmap.Clear();
			wBitmap = tempBitmap;
			Viewport.Source = wBitmap;
			
			
			tempBitmap.FillEllipseCentered(drawlineX += 5, 200, 20, 20, Color.FromArgb(255, 255, 255, 255));
			

		}

		private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			
		}

		private void BlurPort_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
            //WriteableBitmap tempBitmap = blurBitmap;
            //blurBitmap = tempBitmap;
            //BlurPort.Source = blurBitmap;

            //tempBitmap.FillRectangle(0, 0, width, height, Colors.Green);
            //tempBitmap.FillTriangle(200, 50, 300, 300, 50, 200, Colors.Red);
            //tempBitmap.FillRectangle(123, 123, 350, 350, Colors.Beige);
            // Testing image effect

            //tempBitmap.AdjustContrast(50);
            //tempBitmap.AdjustBrightness(200);

            //width = (int)this.ViewPortContainer.ActualWidth;
            //height = (int)this.ViewPortContainer.ActualHeight;

            blurFilter.ScreenGraphics(blurBitmap, BlurPort, width, height);
        }

		private void BlurPort_Loaded(object sender, RoutedEventArgs e)
		{
            width = (int)this.ViewPortContainer.ActualWidth;
            height = (int)this.ViewPortContainer.ActualHeight;
            blurBitmap = BitmapFactory.New(width, height);

            BlurPort.Source = blurBitmap;
            Viewport.Source = blurBitmap;

            // Background Color
            blurBitmap.FillRectangle(0, 0, width, height, Colors.Gray);

            blurBitmap.FillEllipseCentered(drawlineX, 200, 20, 20, Color.FromArgb(255, 255, 255, 255));
            blurBitmap = BitmapFactory.New(width, height);
            BlurPort.Source = blurBitmap;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //anim.timer.Stop();
            Console.WriteLine(tabControl.SelectedItem.ToString());
            Console.WriteLine(tabControl.SelectedIndex.ToString());
            if (tabControl.SelectedIndex == 0)
            {
                tabList.Background = Brushes.LightCoral;
            }
            if (tabControl.SelectedIndex == 1)
            {
                tabDropDown.Background = Brushes.LightCoral;
            }
            if (tabControl.SelectedIndex == 2)
            {
                tabTreeListView.Background = Brushes.LightCoral;
            }
            if (tabControl.SelectedIndex == 3)
            {
                tabMotionBlur.Background = Brushes.LightCoral;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                DropDownLabel.Content = "Gospel of Matthew";
            }
            if (comboBox.SelectedIndex == 1)
            {
                DropDownLabel.Content = "Gospel of Mark";
            }
            if (comboBox.SelectedIndex == 2)
            {
                DropDownLabel.Content = "Gospel of Luke";
            }
            if (comboBox.SelectedIndex == 3)
            {
                DropDownLabel.Content = "Gospel of John";
            }

            if(comboBox.SelectedIndex > 3)
            {
                DropDownLabel.Content = "Not ready yet";
            }

            
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
            {
                if(anim.timerRuns == true)
                {
                    anim.StopAnimation();
                }
                else
                {
                    anim.StartAnimation();
                }
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			int i = 0;
			foreach(var item in makeList.names)
			{
				if (listBox.SelectedIndex == i)
				{
					if (File.Exists(@hostFolder + @"\" + makeList.names[i] + ".txt"))
					{
						richTextBox.Document.Blocks.Clear();
						richTextBox.Document.Blocks.Add(new Paragraph(new Run(importTexts.listOfTexts[i])));
						//MessageBox.Show("File exists");
						break;
					}
					else
					{
                        richTextBox.Document.Blocks.Clear();
                        richTextBox.Document.Blocks.Add(new Paragraph(new Run("Not avaliable at the moment")));
						//MessageBox.Show("Passage yet to be added");
						break;
					}
					//richTextBox.Document.Blocks.Clear();
					//richTextBox.Document.Blocks.Add(new Paragraph(new Run("Book by Matthew in NT. Chapter 1 to 28")));
				}
				else
				{
					richTextBox.Document.Blocks.Clear();
				}
				i++;
			}
		}

        MakeAList makeList = new MakeAList();
        ImportTextFiles importTexts = new ImportTextFiles();
        Random random = new Random();
        string hostFolder = "Books";
        RectangleConsole rectConsl = new RectangleConsole();
        SimpleAnimation anim;

        int height, width;
        WriteableBitmap wBitmap;
        WriteableBitmap blurBitmap;
        int drawlineX = 200;
        BlurFilter blurFilter = new BlurFilter();

        bool[,] barrowedBooks = new bool[3, 10]
        {
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false },
            { false, false, false, false, false, false, false, false, false, false }
        };

        bool[][] jaggedArrayStuff = new bool[5][];

        List<int> makeListConvert = new List<int>();

        Dictionary<int, string> makeDictionary = new Dictionary<int, string>();

    }
}
