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
	/// </summary>
	public partial class MainWindow : Window
	{
		MakeAList makeList = new MakeAList();
		ImportTextFiles importTexts = new ImportTextFiles();
		Random random = new Random();

		bool[,] barrowedBooks = new bool[3, 10]
		{
			{ false, false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false, false },
			{ false, false, false, false, false, false, false, false, false, false }
		};

		string hostFolder = "Books";

		public MainWindow()
		{
			InitializeComponent();

			for (int ij = 0; ij < barrowedBooks.GetLength(0); ij++)
			{
				for (int j = 0; j < barrowedBooks.GetLength(1); j++)
				{
					if(ij == 0 && j == 3)
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

			

			int i = 0;
			foreach(var item in makeList.names)
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
						MessageBox.Show("Doesn't exist");
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
	}
}
