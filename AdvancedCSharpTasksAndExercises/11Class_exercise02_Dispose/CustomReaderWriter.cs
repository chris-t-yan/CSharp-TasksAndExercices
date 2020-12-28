using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace _11Class_exercise02_Dispose
{
    public class CustomReaderWriter : IDisposable
    {
        private string path;
        private StreamWriter _sw;
        private bool disposedValue = false;
       
        public CustomReaderWriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }

        public void WriteInFile(string text)
        {
            _sw.WriteLine(text);
        }
        public void Dispose()
        {
            _dispose(true);
        }

        private void _dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                path = "";
                disposedValue = true;
            }
        }


       
    }
}
