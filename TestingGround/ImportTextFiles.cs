using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGround
{
	// Importing .txt content
	public class ImportTextFiles
	{
		string hostFolder = "Books";
		//string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		public string myPath = Environment.CurrentDirectory + "\\";
		public List<string> listOfTexts = new List<string>();
		string otherTextFiles;

		MakeAList makeList = new MakeAList();

		public ImportTextFiles()
		{
			ImportTexts();
		}

		public void ImportTexts()
		{
			myPath = myPath + hostFolder;

			int i = 0;
			foreach (var item in makeList.names)
			{

				if (File.Exists(@hostFolder + @"\" + makeList.names[i] + ".txt"))
				{
					string text = System.IO.File.ReadAllText(@hostFolder + @"\" + makeList.names[i] + ".txt");
					listOfTexts.Add(text);
				}
				i++;
			}
		}

		public void CreateBooksDir()
		{
			Directory.CreateDirectory(myPath);
		}
	}
}
