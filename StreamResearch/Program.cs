using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamResearch
{
	class Program
	{
		private static List<string> _fileList;


		static void Main(string[] args)
		{

			FileInfo fileInfo = new FileInfo("x");

			if (FileExists("1910000_A1"))
			{
				fileInfo = GetFile("1910000_A1");
			}


			var newPath = @"c:\temp\xyz.pdf";

			fileInfo.CopyTo(newPath);



			String path = @"C:\temp\MyTest.txt";
/*
			if (!File.Exists(path))
			{
				Console.WriteLine("File " + path + " does not exists!");

				// Ensure that the parent directory exists.
				Directory.CreateDirectory(@"C:\temp");
			}

			// Create a FileStream to write file.
			// (FileMode.Append: Open file to write to end of file,
			// if file does not exit, create it and write).
			using (FileStream writeFileStream = new FileStream(path, FileMode.Append))
			{
				string s = "\nHello every body!";

				// Convert string to bytes with UTF8 encoding.
				byte[] bytes = Encoding.UTF8.GetBytes(s);

				// Write bytes to file.
				writeFileStream.Write(bytes, 0, bytes.Length);
			}
			Console.WriteLine("Finish!");
*/
			Console.ReadLine();
		}


		public static bool FileExists(object message)
		{
			var homeDir = "Q:\\Dokumentation\\1910";

			var fileName = message.ToString();
			_fileList = Directory.GetFiles(homeDir, "*.pdf").ToList();

			return _fileList.Any(x => x.EndsWith(fileName + ".pdf"));
		}

		public static FileInfo GetFile(object message)
		{
			var path = _fileList.Where(x => x.Contains(message.ToString()));
			var newFile = new FileInfo(path.First());

			return newFile;
		}
	}
}
