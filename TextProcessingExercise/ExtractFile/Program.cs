using System.IO.Enumeration;

namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath=Console.ReadLine();
            string fileName = string.Empty;
            string fileExtension=string.Empty;
            int lastSeperatorIndex = filePath.LastIndexOf('\\');
            int extensionIndex=filePath.LastIndexOf(".");

            if(lastSeperatorIndex != -1 &&
                extensionIndex!= -1 &&
                extensionIndex>lastSeperatorIndex) 
            {
              fileName=filePath.Substring(lastSeperatorIndex+1,
                  extensionIndex-lastSeperatorIndex-1);
                fileExtension=filePath.Substring(extensionIndex+1);
            }
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}