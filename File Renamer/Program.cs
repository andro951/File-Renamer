using System;
using System.IO;

class Program {
	static void Main(string[] args) {
		// Specify the folder path where the files are located
		string rootFolderPath = @"C:\Users\Isaac\Documents\my games\Terraria\tModLoader\ModSources\VacuumBags\Items\Sprites";

		DirectoryInfo rootDirectory = new DirectoryInfo(rootFolderPath);
		List<FileInfo> files = rootDirectory.GetFiles().ToList();
		string findString = " - Copy.png";
		string replaceString = "_Hover.png";
		foreach (FileInfo file in files) {
			if (!file.Name.EndsWith(findString))
				continue;

			File.Move(file.FullName, file.FullName.Replace(findString, replaceString));
		}
	}
}