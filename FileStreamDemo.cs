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
    }
}
