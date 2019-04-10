using System;

namespace DataCompression
{
    public class Context
    {
        private ICompressor _compressor;
        public Context(ICompressor compressor) 
        {
            _compressor = compressor;
        }
        public string Compress(string data) 
        {
            return _compressor.Compress(data);
        }
    }
}