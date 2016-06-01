using System;
using System.IO;

namespace ReadZeroTestsFromFile.ProblemSolving.Input
{
    public class TextFileInputReader : IFileInputReader, IDisposable
    {
        private bool _disposed;

        private readonly StreamReader _fileInputReader;

        public string FilePath { get; set; }

        public TextFileInputReader(string filePath)
        {
            FilePath = filePath;
            _fileInputReader = new StreamReader(FilePath);
        }

        public string ReadNextInputPart()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(nameof(_fileInputReader));
            }

            return _fileInputReader.ReadLine();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _fileInputReader.Dispose();
            }

            _disposed = true;
        }
    }
}