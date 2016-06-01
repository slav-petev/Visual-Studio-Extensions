using System;
using System.IO;

namespace ConsoleApplication1.Input
{
    public class FileInputReader : IInputReader, IDisposable
    {
        private bool _disposed;

        private readonly StreamReader _reader =
            new StreamReader(@"../../Input/Input.txt");

        public string ReadLine()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("Reader is already disposed");
            }

            return _reader.ReadLine();
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
                _reader.Dispose();
            }

            _disposed = true;
        }
    }
}