using System;
using System.Collections.Generic;
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

		string hostFolder = "Books";

		public MainWindow()
		{
			InitializeComponent();
			

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
