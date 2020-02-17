using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooTest
{
    class Test7
    {
        
        public void BeginTranction(string filePath, long fileLength)
        {
            TruncateFile(filePath, fileLength);
        }
        

        private static void TruncateFile(string pathOfFile, long lengthOfFile)
        {
            // check if the file exists before trancation begins
            if (!File.Exists(pathOfFile))
                throw new ArgumentException("No file found at specified path.", "pathOfFile");

            using (var fileStream = new FileStream(pathOfFile, FileMode.Open, FileAccess.Write))
            {
                if (fileStream.Length < lengthOfFile)
                    throw new ArgumentOutOfRangeException("length", "The specified length is greater than that of the file.");

                fileStream.SetLength(lengthOfFile);
            }
        }
    }
}
