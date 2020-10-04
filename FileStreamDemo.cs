using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewPrograms
{
    class FileStreamDemo
    {

        static async Task WriteToFileAsync(string filePath, string text)

        {

            if (string.IsNullOrEmpty(filePath))

                throw new ArgumentNullException("filePath");

            if (string.IsNullOrEmpty(text))

                throw new ArgumentNullException("text");

            byte[] buffer = Encoding.Unicode.GetBytes(text);

            Int32 offset = 0;

            Int32 sizeOfBuffer = 4096;

            FileStream fileStream = null;

            try

            {

                fileStream = new FileStream(filePath, FileMode.Append, FileAccess.Write,

                FileShare.None, bufferSize: sizeOfBuffer, useAsync: true);

                await fileStream.WriteAsync(buffer, offset, buffer.Length);

            }

            catch

            {

                //Write code here to handle exceptions.

            }

            finally

            {

                if (fileStream != null)

                    fileStream.Dispose();

            }

        }

        static async Task<string> ReadFromFileAsync(string filePath, int bufferSize)

        {

            if (bufferSize < 1024)
                throw new ArgumentNullException("bufferSize");

            if (string.IsNullOrEmpty(filePath))

                throw new ArgumentNullException("filePath");

            StringBuilder readBuffer = null;

            byte[] buffer = new byte[bufferSize];

            FileStream fileStream = null;

            try

            {

                readBuffer = new StringBuilder();

                fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read,

                FileShare.Read, bufferSize: bufferSize, useAsync: true);

                Int32 bytesRead = 0;

                while ((bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)

                {

                    readBuffer.Append(Encoding.Unicode.GetString(buffer, 0, bytesRead));

                }

            }

            catch

            {

                readBuffer = null;

                //Write code here to handle exceptions;

            }

            finally

            {

                if (fileStream != null)

                    fileStream.Dispose();

            }

            return readBuffer.ToString();

        }

        public void Count_the_number_of_lines_in_a_file()
        {
            string fileName = @"mytest.txt";
            int count;

            try
            {
                // Delete the file if it exists.
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                Console.Write("\n\n Count the number of lines in a file :\n");
                Console.Write("------------------------------------------\n");
                // Create the file.
                using (StreamWriter fileStr = File.CreateText(fileName))
                {
                    fileStr.WriteLine(" test line 1");
                    fileStr.WriteLine(" test line 2");
                    fileStr.WriteLine(" Test line 3");
                    fileStr.WriteLine(" test line 4");
                    fileStr.WriteLine(" test line 5");
                    fileStr.WriteLine(" Test line 6");
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    count = 0;
                    Console.WriteLine(" Here is the content of the file mytest.txt : ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine("");
                }
                Console.Write(" The number of lines in  the file {0} is : {1} \n\n", fileName, count);
            }
            catch (Exception MyExcep)
            {
                Console.WriteLine(MyExcep.ToString());
            }
        }
    }
}
